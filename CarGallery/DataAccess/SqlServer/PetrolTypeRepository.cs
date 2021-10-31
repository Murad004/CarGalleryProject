using CarGallery.Domain.Abstractions;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarGallery.DataAccess.SqlServer
{
    public class PetrolTypeRepository : IPetrolTypeRepository
    {
        public void AddData(PetrolType data)
        {
            throw new NotImplementedException();
        }

        public void DeleteData(PetrolType data)
        {
            throw new NotImplementedException();
        }

        public ObservableCollection<PetrolType> GetAllData()
        {
            DataClasses1DataContext context = new DataClasses1DataContext();
            var petrols = new ObservableCollection<PetrolType>(context.PetrolTypes);
            return petrols;
        }

        public PetrolType GetData(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateData(PetrolType data)
        {
            throw new NotImplementedException();
        }
    }
}
