using CarGallery.Domain.Abstractions;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarGallery.DataAccess.SqlServer
{
    public class ImagePathRepository : IImagePathRepository
    {
        DataClasses1DataContext context = new DataClasses1DataContext();
        public void AddData(ImagePath data)
        {
            context.ImagePaths.InsertOnSubmit(data);
            context.SubmitChanges();


        }

        public void DeleteData(ImagePath data)
        {
            throw new NotImplementedException();
        }

        public ObservableCollection<ImagePath> GetAllData()
        {
            var images = from ImagePaths in context.ImagePaths
                         select ImagePaths;
            return new ObservableCollection<ImagePath>(images);
        }

        public ImagePath GetData(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateData(ImagePath data)
        {
            throw new NotImplementedException();
        }
    }
}
