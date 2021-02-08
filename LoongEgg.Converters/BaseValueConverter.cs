using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Markup;

namespace LoongEgg.Converters
{
    /// <summary>
    /// 可以直接在Xaml中使用的<see cref="IValueConverter"/>实现的基类
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class BaseValueConverter<T> : MarkupExtension, IValueConverter where T : MarkupExtension, IValueConverter, new()
    {
        public override object ProvideValue(IServiceProvider serviceProvider) => Converter;

        private static T Converter = new T();

        public abstract object Convert(object value, Type targetType, object parameter, CultureInfo culture);

        public virtual object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
 
    }
}
