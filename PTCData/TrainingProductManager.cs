using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTCData
{
    class TrainingProductManager
    {
        public List<TrainingProduct> Get()
        {
            List<TrainingProduct> ret = new List<TrainingProduct>();

            //TODO: Add your data access method here
            ret = CreateMockData();
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
                ProductName = "Buils your own Bootstrap Business Application Template",
                IntroductionDate = Convert.ToDateTime("1/29/2015"),
                Url = "http://bit.ly/1I8ZqZg",
                Price = Convert.ToDecimal(29.00)
            });

            ret.Add(new TrainingProduct()
            {
                ProductId = 3,
                ProductName = "Building Mobile Web Sites Using Web Forms, Bootsrap",
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
                ProductName = "The Many approaches to XML Processing in .NET Application",
                IntroductionDate = Convert.ToDateTime("7/22/2013"),
                Url = "http://bit.ly/1DBfUqd",
                Price = Convert.ToDecimal(29.00)
            });

            return ret;
        }
    }
}
