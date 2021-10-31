using CarGallery.DataAccess.SqlServer;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarGallery.Domain.ViewModels
{
    public class MainViewModel:BaseViewModel
    {
        public CarRepository repository = new CarRepository();

        public ObservableCollection<Car> Cars { get; set; }
        

        public MainViewModel(MainWindow mainWindow)
        {
            Cars = new ObservableCollection<Car>(repository.GetAllData().GroupBy(c=>new { c.Brand_Id, c.Brand.Name,c.ImagePath_Id,c.ImagePath.Path}).Select(c=>c.First()).Distinct());
            
        }
    }
}
