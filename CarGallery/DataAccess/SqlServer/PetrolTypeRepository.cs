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
        DataClasses1DataContext context = new DataClasses1DataContext();
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
            var petrols = from PetrolTypes in context.PetrolTypes
                          select PetrolTypes;
            return new ObservableCollection<PetrolType>(petrols);
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
