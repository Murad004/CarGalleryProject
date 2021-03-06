using CarGallery.Domain.Abstractions;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarGallery.DataAccess.SqlServer
{
    public class CarRepository : ICarRepository
    {
        DataClasses1DataContext context = new DataClasses1DataContext();
        public void AddData(Car data)
        {
            throw new NotImplementedException();
        }

        public void DeleteData(Car data)
        {
            throw new NotImplementedException();
        }

        public ObservableCollection<Car> GetAllData()
        {

            var cars = from Cars in context.Cars
                       select Cars;
            return new ObservableCollection<Car>(cars);
        }

        public Car GetData(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateData(Car data)
        {
            throw new NotImplementedException();
        }
    }
}
