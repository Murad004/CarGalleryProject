using CarGallery.Domain.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CarGallery.Domain.Views
{
    /// <summary>
    /// Interaction logic for FilterUC.xaml
    /// </summary>
    public partial class FilterUC : UserControl
    {
        public FilterUC()
        {
            InitializeComponent();
            DataContext = new FilterUCViewModel(this);
        }

    }
}
