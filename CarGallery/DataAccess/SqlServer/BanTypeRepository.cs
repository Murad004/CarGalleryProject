using CarGallery.Domain.Abstractions;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarGallery.DataAccess.SqlServer
{
    public class BanTypeRepository : IBanTypeRepository
    {
        DataClasses1DataContext context = new DataClasses1DataContext();
        public void AddData(BanType data)
        {
            throw new NotImplementedException();
        }

        public void DeleteData(BanType data)
        {
            throw new NotImplementedException();
        }

        public ObservableCollection<BanType> GetAllData()
        {

            var bantypes = from BanTypes in context.BanTypes
                           select BanTypes;
            return new ObservableCollection<BanType>(bantypes);
        }

        public BanType GetData(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateData(BanType data)
        {
            throw new NotImplementedException();
        }
    }
}
