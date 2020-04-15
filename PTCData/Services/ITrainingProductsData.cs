using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTCData.Services
{
    public interface ITrainingProductsData
    {
        IEnumerable<TrainingProduct> GetAll();
        TrainingProduct Get(int id);

        void Update(TrainingProduct product);

        void Add(TrainingProduct product);

        void Delete(int id);
    }
}
