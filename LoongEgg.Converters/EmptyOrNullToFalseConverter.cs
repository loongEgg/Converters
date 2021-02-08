using System;
using System.ComponentModel;
using System.Globalization;

namespace LoongEgg.Converters
{
    /// <summary>
    /// 空或者null字符串转换成false
    /// </summary>
    [Description("空或者null字符串转换成false")]
    public class EmptyOrNullToFalseConverter : BaseValueConverter<EmptyOrNullToFalseConverter>
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
            => !string.IsNullOrEmpty((string)value);
    }
}
