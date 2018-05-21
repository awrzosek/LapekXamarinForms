using System;
using System.Collections.Generic;
using System.Text;

namespace Lapek.Services
{
    public class SearchService
    {
        public List<string> GetSuggestions()
        {
            var searchSuggestions = new List<string>
            {
                "Acer", "Apple", "Asus", "Dell", "HP", "Lenovo", "Msi", "Toshiba",
                "Intel Core i3", "Intel Core i5", "Intel Core i7", "Intel", "AMD",
                "Pentium", "Celeron", "Intel Core", "SSD", "HDD", "SATA", "M.2",
                "1366x768", "1920x1080", "1440x900", "28801800", "Intel HD Graphics",
                "Nvidia GeForce", "Intel Iris Pro", "Windows 10", "MacOS"
            };
            return searchSuggestions;
        }
    }
}
