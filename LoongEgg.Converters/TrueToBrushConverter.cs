using System;
using System.ComponentModel;
using System.Globalization;
using System.Windows.Media;

namespace LoongEgg.Converters
{
    /// <summary>
    /// bool to brush converter
    /// </summary>
    [Description("If [true] return (Brush)parameter, else return Brushes.Gray")]
    public class TrueToBrushConverter : BaseValueConverter<TrueToBrushConverter>
    {
        /// <summary>
        /// If [true] return (Brush)parameter, else return Brushes.Gray
        /// </summary>
        /// <param name="value"></param>
        /// <param name="targetType"></param>
        /// <param name="parameter">brush returned when value == true</param>
        /// <param name="culture"></param>
        /// <returns>[true]->(Brush)parameter; [false]->Brushes.Gray</returns>
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
            => (bool)value ? (Brush)parameter : Brushes.Gray;
    }
}
