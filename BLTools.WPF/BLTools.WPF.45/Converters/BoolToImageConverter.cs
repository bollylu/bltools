﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Media.Imaging;

namespace BLTools.WPF {
  public class BoolToImageConverter : IValueConverter {
    public string NullImage { get; set; }
    public string TrueImage { get; set; }
    public string FalseImage { get; set; }

    public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture) {
      if (!(value is bool?)) {
        return Binding.DoNothing;
      }

      if (((bool?)value) == null) {
        return new Uri(NullImage ?? "", UriKind.Relative);
      }

      if ((bool)value) {
        return new Uri(TrueImage ?? "", UriKind.Relative);
      } else {
        return new Uri(FalseImage ?? "", UriKind.Relative);
      }
    }

    public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture) {
      return Binding.DoNothing;
    }
  }
}
