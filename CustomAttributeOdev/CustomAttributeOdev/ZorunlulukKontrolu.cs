using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CustomAttributeOdev
{
    internal class ZorunlulukKontrolu
    {
        public static bool bilgileriDogrula(object obj)
        {
            Type objType = obj.GetType();
            FieldInfo[] fields = objType.GetFields();

            foreach(FieldInfo field in fields)
            {
                object zorunluAlanAttribute = field.GetCustomAttribute(typeof(ZorunluAlanAttribute));

                if(zorunluAlanAttribute != null)
                {
                    object fieldValue = field.GetValue(obj);
                    if (fieldValue == null || string.IsNullOrEmpty(fieldValue.ToString()))
                    {
                        ZorunluAlanAttribute.HataMesaji();
                        return false; // Zorunlu alan boş
                    }
                }

            }
            ZorunluAlanAttribute.DogrulamaMesaji();
            return true; // Tüm zorunlu alanlar dolu
        }
    }
}
