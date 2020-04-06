using PTCCommon;
using System;
using System.Collections.Generic;

namespace PTCData
{
    public class TrainingProductViewModel : ViewModelBase
    {
        public TrainingProductViewModel() : base()
        {

        }
        
        public List<TrainingProduct> Products { get; set; }
        public TrainingProduct SearchEntity { get; set; }
        public TrainingProduct Entity { get; set; }

        protected override void Init()
        {
            Products = new List<TrainingProduct>();
            SearchEntity = new TrainingProduct();
            Entity = new TrainingProduct();
            ValidationErrors = new List<KeyValuePair<string, string>>();

            base.Init();
        }

        protected override void Save()
        {
            TrainingProductManager mgr = new TrainingProductManager();

            if (Mode == "Add")
            {
                //Add data to database here
                mgr.Insert(Entity);
            }
            else
            {
                mgr.Update(Entity);
            }

            ValidationErrors = mgr.ValidationErrors;
            base.Save();
        }

        protected override void Add()
        {
            IsValid = true;

            Entity = new TrainingProduct();
            Entity.IntroductionDate = DateTime.Now;
            Entity.Url = "http://";
            Entity.Price = 0;

            base.Add();
        }

        protected override void Edit()
        {
            TrainingProductManager mgr = new TrainingProductManager();

            Entity = mgr.Get(Convert.ToInt32(EventArgument));

            base.Edit();
        }

        protected override void Delete()
        {
            TrainingProductManager mgr = new TrainingProductManager();
            Entity = new TrainingProduct();
            Entity.ProductId = Convert.ToInt32(EventArgument);

            mgr.Delete(Entity);
            Get();

            base.Delete();
        }

        protected override void ResetSearch()
        {
            SearchEntity = new TrainingProduct();

            base.ResetSearch();
        }

        protected override void Get()
        {
            TrainingProductManager mgr = new TrainingProductManager();

            Products = mgr.Get(SearchEntity);

            base.Get();
        }

        public override void HandleRequest()
        {
            switch (EventCommander.ToLower())
            {
                case "paul":
                    break;
                default:
                    break;
            }

            base.HandleRequest();
        }
    }
}
