using CarGallery.DataAccess.SqlServer;
using CarGallery.Domain.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarGallery.Domain.ViewModels
{
    public class FilterUCViewModel:BaseViewModel
    {

        public BrandRepository brandRepository = new BrandRepository();
        public BanTypeRepository banTypeRepository = new BanTypeRepository();
        public PetrolTypeRepository petrolTypeRepository = new PetrolTypeRepository();
        public CarColorRepository carColorRepository = new CarColorRepository();

        public FilterUCViewModel(FilterUC filterUC)
        {
            filterUC.BrandComboBox.ItemsSource = brandRepository.GetAllData().Select(b=>b.Name);
            filterUC.BanTypeComboBox.ItemsSource = banTypeRepository.GetAllData().Select(b => b.Name); ;
            filterUC.ColorComboBox.ItemsSource = carColorRepository.GetAllData().Select(b => b.Name); ;
            filterUC.PetrolComboBox.ItemsSource = petrolTypeRepository.GetAllData().Select(b => b.Name); ;
        }
    }
}
