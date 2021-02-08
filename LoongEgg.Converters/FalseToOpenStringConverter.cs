using System;
using System.Globalization;

namespace LoongEgg.Converters
{
    public class FalseToOpenStringConverter : BaseValueConverter<FalseToOpenStringConverter>
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
            => (bool)value ? "Close" : "Open";
    }
}
