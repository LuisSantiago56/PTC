using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTCCommon
{
    public class ViewModelBase
    {
        public ViewModelBase()
        {
            Init();
        }

        public string EventCommander { get; set; }
        public bool IsValid { get; set; }
        public string Mode { get; set; }
        public List<KeyValuePair<string, string>> ValidationErrors { get; set; }
        public string EventArgument { get; set; }
        public bool IsDetailAreaVisible { get; set; }
        public bool IsListAreaVisible { get; set; }
        public bool IsSearchAreaVisible { get; set; }

        protected virtual void ListMode()
        {
            IsValid = true;

            IsListAreaVisible = true;
            IsSearchAreaVisible = true;
            IsDetailAreaVisible = false;

            Mode = "List";
        }

        protected virtual void Init()
        {
            EventCommander = "List";
            EventArgument = string.Empty;
            ListMode();
        }

        protected virtual void Get()
        {

        }

        protected virtual void ResetSearch()
        {

        }

        protected virtual void AddMode()
        {
            IsListAreaVisible = false;
            IsSearchAreaVisible = false;
            IsDetailAreaVisible = true;

            Mode = "Add";
        }

        protected virtual void EditMode()
        {
            IsListAreaVisible = false;
            IsSearchAreaVisible = false;
            IsDetailAreaVisible = true;

            Mode = "Edit";
        }

        protected virtual void Add()
        {
            AddMode();
        }

        protected virtual void Edit()
        {
            EditMode();
        }

        protected virtual void Delete()
        {
            ListMode();
        }

        protected virtual void Save()
        {
            if (ValidationErrors.Count > 0)
            {
                IsValid = false;
            }

            if (!IsValid)
            {
                if (Mode == "Add")
                {
                    AddMode();
                }
                else
                {
                    EditMode();
                }
            }
        }

        public virtual void HandleRequest()
        {
            switch (EventCommander.ToLower())
            {
                case "list":
                    Get();
                    break;
                case "search":
                    Get();
                    break;
                case "resetsearch":
                    ResetSearch();
                    Get();
                    break;
                case "add":
                    Add();
                    break;
                case "save":
                    Save();
                    if (IsValid)
                    {
                        Get();
                    }
                    break;
                case "edit":
                    IsValid = true;
                    Edit();
                    break;
                case "delete":
                    ResetSearch();
                    Delete();
                    break;
                case "cancel":
                    ListMode();
                    Get();
                    break;
                default:
                    break;
            }
        }

    }
}
