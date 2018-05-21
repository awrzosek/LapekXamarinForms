using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using Xamarin.Forms;

namespace Lapek.Services
{
    public abstract class ByteToImageService : IValueConverter
    {
        public ByteToImageService()
        {

        }

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            byte[] img = value as byte[];
            if (img == null)
                return null;
            return ImageSource.FromStream(() => new MemoryStream(img));
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
