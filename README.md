# Converters
## Abstract
Common instances of IValueConverter for WPF, can be used directly in xaml as MarkupExtension.
Make great benefit for MVVM program.

## 摘要
可以直接在WPF的Xaml文件中使用的值转换器的实现

## How TO
The demo below show how to flip the content of a buttton between Open and Close, as the [Value](named Sender.IsOpen here) which the DependencyProperty [Content] is binding to switch between false or true.
### 1.Refrence to this library in your xaml
```xml
xmlns:cvt="clr-namespace:LoongEgg.Converters;assembly=LoongEgg.Converters"
```
### 2.Using the converter you need easily and directly
```xml
<Button
                    Width="120"
                    HorizontalAlignment="Left"
                    Command="{Binding SenderOpenOrCloseCommand}"
                    Content="{Binding Sender.IsOpen, Converter={cvt:FalseToOpenStringConverter}, FallbackValue=打开/关闭}" />          
```
