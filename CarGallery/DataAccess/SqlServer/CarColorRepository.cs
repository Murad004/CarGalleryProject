using CarGallery.Domain.Abstractions;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarGallery.DataAccess.SqlServer
{
    public class CarColorRepository : ICarColorRepository
    {
        public void AddData(CarColor data)
        {
            throw new NotImplementedException();
        }

        public void DeleteData(CarColor data)
        {
            throw new NotImplementedException();
        }

        public ObservableCollection<CarColor> GetAllData()
        {
            DataClasses1DataContext context = new DataClasses1DataContext();
            var carcolors = new ObservableCollection<CarColor>(context.CarColors);
            return carcolors;
        }

        public CarColor GetData(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateData(CarColor data)
        {
            throw new NotImplementedException();
        }
    }
}
