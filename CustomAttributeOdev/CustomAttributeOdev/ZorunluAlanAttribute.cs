using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomAttributeOdev
{
    [AttributeUsage(AttributeTargets.Field, AllowMultiple =true, Inherited =true)]
    internal class ZorunluAlanAttribute : Attribute
    {
        public static DialogResult HataMesaji()
        {
            return MessageBox.Show("TÜM ALANLARI DOLDURMALISINIZ!");
        }

        public static DialogResult DogrulamaMesaji()
        {
            return MessageBox.Show("FORM BAŞARIYLA DOLDURULDU!");
        }
    }
}
