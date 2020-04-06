using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTCData
{
   public class TrainingProductManager
    {
        public List<KeyValuePair<string, string>> ValidationErrors { get; set; }

        public TrainingProductManager()
        {
            ValidationErrors = new List<KeyValuePair<string, string>>();
        }

        public bool Validate(TrainingProduct entity)
        {
            ValidationErrors.Clear();

            if(!string.IsNullOrEmpty(entity.ProductName))
            {
                if(entity.ProductName.ToLower() == entity.ProductName)
                {
                    ValidationErrors.Add(new KeyValuePair<string, string>("ProductName", "Product Name must not be all lower case."));
                }
            }

            return (ValidationErrors.Count == 0);
        }

        public bool Delete(TrainingProduct entity)
        {
            //TODO: Create DELETE code here

            return true;
        }

        public TrainingProduct Get(int productId)
        {
            List<TrainingProduct> list = new List<TrainingProduct>();
            TrainingProduct ret = new TrainingProduct();

            //TODO: Call your data acces method here
            list = CreateMockData();

            ret = list.Find(p => p.ProductId == productId);

            return ret;
        }

        public bool Update(TrainingProduct entity)
        {
            bool ret = false;

            ret = Validate(entity);
            if(ret)
            {
                //TODO: Create UPDATE code here
            }

            return ret;
        }

        public bool Insert(TrainingProduct entity)
        {
            bool ret = false;

            ret = Validate(entity);
            if(ret)
            {
                //TODO: Create Insert code here
            }

            return ret;
        }

        public List<TrainingProduct> Get(TrainingProduct entity)
        {
            List<TrainingProduct> ret = new List<TrainingProduct>();

            //TODO: Add your data access method here
            ret = CreateMockData();

            if(!string.IsNullOrEmpty(entity.ProductName))
            {
                ret = ret.FindAll(p => p.ProductName.ToLower().StartsWith(entity.ProductName, StringComparison.CurrentCultureIgnoreCase));
            }

            return ret;
        }
        private List<TrainingProduct> CreateMockData()
        {
            List<TrainingProduct> ret = new List<TrainingProduct>();

            ret.Add(new TrainingProduct()
            {
                ProductId = 1,
                ProductName = "Extending Bootstrap with CSS, JavaScript and JQuery",
                IntroductionDate = Convert.ToDateTime("6/11/2015"),
                Url = "http://bit.ly/lSNzc0i",
                Price = Convert.ToDecimal(29.00)
            });

            ret.Add(new TrainingProduct()
            {
                ProductId = 2,
                ProductName = "Buils your own Bootstrap Business Application Template in MVC",
                IntroductionDate = Convert.ToDateTime("1/29/2015"),
                Url = "http://bit.ly/1I8ZqZg",
                Price = Convert.ToDecimal(29.00)
            });

            ret.Add(new TrainingProduct()
            {
                ProductId = 3,
                ProductName = "Building Mobile Web Sites Using Web Forms, Bootsrap and HTML5",
                IntroductionDate = Convert.ToDateTime("8/28/2015"),
                Url = "http://bit.ly/1J2dcrj",
                Price = Convert.ToDecimal(29.00)
            });

            ret.Add(new TrainingProduct()
            {
                ProductId = 4,
                ProductName = "How to start and Run A Consulting Business",
                IntroductionDate = Convert.ToDateTime("9/12/2013"),
                Url = "http://bit.ly/1L8kOwd",
                Price = Convert.ToDecimal(29.00)
            });

            ret.Add(new TrainingProduct()
            {
                ProductId = 5,
                ProductName = "The Many approaches to XML Processing in .NET Applications",
                IntroductionDate = Convert.ToDateTime("7/22/2013"),
                Url = "http://bit.ly/1DBfUqd",
                Price = Convert.ToDecimal(29.00)
            });

            ret.Add(new TrainingProduct()
            {
                ProductId = 6,
                ProductName = "WPF for the Business Programmer",
                IntroductionDate = Convert.ToDateTime("6/12/2019"),
                Url = "http://bit.ly/1UF858z",
                Price = Convert.ToDecimal(29.00)
            });

            ret.Add(new TrainingProduct()
            {
                ProductId = 7,
                ProductName = "WPF for the Visual Basic Programmer - Part 1",
                IntroductionDate = Convert.ToDateTime("12/16/2014"),
                Url = "http://bit.ly/1uFxS7C",
                Price = Convert.ToDecimal(29.00)
            });

            ret.Add(new TrainingProduct()
            {
                ProductId = 8,
                ProductName = "WPF for the Visual Basic Programmer - Part 2",
                IntroductionDate = Convert.ToDateTime("2/18/2014"),
                Url = "http://bit.ly/1MjQ9NG",
                Price = Convert.ToDecimal(29.00)
            });

            return ret;
        }
    }
}
