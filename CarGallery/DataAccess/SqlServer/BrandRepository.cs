using CarGallery.Domain.Abstractions;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarGallery.DataAccess.SqlServer
{
    public class BrandRepository : IBrandRepository
    {
        DataClasses1DataContext context = new DataClasses1DataContext();
        public void AddData(Brand data)
        {
            throw new NotImplementedException();
        }

        public void DeleteData(Brand data)
        {
            throw new NotImplementedException();
        }

        public ObservableCollection<Brand> GetAllData()
        {
            DataClasses1DataContext context = new DataClasses1DataContext();
            var brands = new ObservableCollection<Brand>(context.Brands);
            return brands;
        }

        public Brand GetData(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateData(Brand data)
        {
            throw new NotImplementedException();
        }
    }
}
