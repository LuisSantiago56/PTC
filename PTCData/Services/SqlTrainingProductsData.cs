using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTCData.Services
{
    public class SqlTrainingProductsData : ITrainingProductsData
    {
        private readonly PTCContext db;

        public SqlTrainingProductsData()
        {
            db = new PTCContext();
        }

        public SqlTrainingProductsData(PTCContext db)
        {
            this.db = db;
        }

        public void Add(TrainingProduct product)
        {
            db.TrainingProducts.Add(product);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            var product = db.TrainingProducts.Find(id);
            db.TrainingProducts.Remove(product);
            db.SaveChanges();
        }

        public TrainingProduct Get(int id)
        {
            return db.TrainingProducts.FirstOrDefault(tp => tp.ProductId == id);
        }

        public IEnumerable<TrainingProduct> GetAll()
        {
            return from tp in db.TrainingProducts
                   orderby tp.ProductName
                   select tp;
        }

        public void Update(TrainingProduct product)
        {
            
            var entry = db.Entry(product);
            entry.State = EntityState.Modified;
            
    /*
            var r = Get(product.ProductId);
            r.ProductName = product.ProductName;
            r.Price = product.Price;
            r.IntroductionDate = product.IntroductionDate;
            r.Url = product.Url;
            */

            db.SaveChanges();
        }
    }
}
