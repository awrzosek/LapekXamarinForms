using Lapek.Models;
using Lapek.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lapek.ViewModels
{
    public class CategoriesViewModel
    {
        public List<CategoryModel> CategoriesList { get; set; }
        public CategoriesViewModel()
        {
            var categoriesServices = new CategoriesService();
            CategoriesList = categoriesServices.GetCategories();
        }

        private string baseUri = "http://lapekwebapi.azurewebsites.net/api/products/";

        public string NavigateToCategory(string name)
        {
            var Uri = baseUri + name;
            return Uri;
        }
    }
}
