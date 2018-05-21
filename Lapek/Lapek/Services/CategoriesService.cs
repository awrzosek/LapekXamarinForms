using Lapek.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lapek.Services
{
    public class CategoriesService
    {
        public List<CategoryModel> GetCategories()
        {
            var categoriesList = new List<CategoryModel>
            {
                new CategoryModel{ Name = "acer", Source = "acer.png" },
                new CategoryModel{ Name = "asus", Source = "asus.png" },
                new CategoryModel{ Name = "apple", Source = "apple.png" },
                new CategoryModel{ Name = "dell", Source = "dell.png" },
                new CategoryModel{ Name = "hp", Source = "hp.png" },
                new CategoryModel{ Name = "lenovo", Source = "lenovo.png" },
                new CategoryModel{ Name = "msi", Source = "msi.png" },
                new CategoryModel{ Name = "sony", Source = "sony.png" },
                new CategoryModel{ Name = "toshiba", Source = "toshiba.png" }
            };
            return categoriesList;
        }
    }
}
