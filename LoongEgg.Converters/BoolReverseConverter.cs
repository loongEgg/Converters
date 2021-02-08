using System;
using System.ComponentModel;
using System.Globalization;

namespace LoongEgg.Converters
{
    /// <summary>
    /// 翻转布尔值
    /// </summary>
    [Description("翻转布尔值")]
    public class BoolReverseConverter : BaseValueConverter<BoolReverseConverter>
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
            => !(bool)value;
    }
}
