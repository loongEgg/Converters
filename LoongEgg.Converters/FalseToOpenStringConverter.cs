using System;
using System.ComponentModel;
using System.Globalization;

namespace LoongEgg.Converters
{
    [Description("false->Open, true->Close")]
    public class FalseToOpenStringConverter : BaseValueConverter<FalseToOpenStringConverter>
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
            => (bool)value ? "Close" : "Open";
    }
}
