﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace Parsley.Core {

  /// <summary>
  /// Used as TypeConverter in a PropertyGrid to populate drop-down with
  /// a list of classes that are assignable to the property type.
  /// <remarks>When the property changes, the new type is instanciated and
  /// assigned to the property. The property should be assigned the 
  /// [RefreshProperties(RefreshProperties.All)] attribute in order to refresh on change.</remarks>
  /// </summary>
  public class ReflectionTypeConverter : ExpandableObjectConverter {
    private Type _type_of;


    public ReflectionTypeConverter(Type type_of) {
      _type_of = type_of;
    }

    public override object ConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value) {
      if (value.GetType() == typeof(string)) {
        string class_name = (string)value;
        Type t = Type.GetType(class_name);
        return System.Activator.CreateInstance(t);
      } else
        return base.ConvertFrom(context, culture, value);
    }


    public override bool GetStandardValuesSupported(System.ComponentModel.ITypeDescriptorContext context) {
      return true;
    }

    public override System.ComponentModel.TypeConverter.StandardValuesCollection GetStandardValues(System.ComponentModel.ITypeDescriptorContext context) {
      IEnumerable<Type> types = Core.TypeManager.AllDefaultConstructibleTypes(_type_of);
      return new StandardValuesCollection(types.ToArray());
    }

    public override bool CanConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Type sourceType) {
      if (sourceType == typeof(string))
        return true;
      else
        return base.CanConvertFrom(context, sourceType);
    }
  }
}
