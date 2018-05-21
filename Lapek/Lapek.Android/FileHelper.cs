using System;
using System.IO;
using Lapek.Droid;
using Xamarin.Forms;

[assembly: Dependency(typeof(FileHelper))]
namespace Lapek.Droid
{
    public class FileHelper : IFileHelper
    {
        public string GetLocalFilePath(string fileName)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            return Path.Combine(path, fileName);
        }
    }
}