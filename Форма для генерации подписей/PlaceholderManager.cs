using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;// для работы this TextBox tb
using System.Drawing;

namespace Форма_для_генерации_подписей
{
    public static class PlaceholderManager //
    {
        public static void AddPlaceholder(this TextBox tb, string placeholderText)
        {
            tb.ForeColor = Color.Gray;
            tb.Text = placeholderText;
            tb.Enter += (s, e) => // Это называеться лямбда.
             {
                 if (tb.Text == placeholderText)
                 {
                     tb.Text = "";
                     tb.ForeColor = Color.Navy;
                 }
             }; // закрываем... лямбду?
            tb.Leave += (s, e) =>
            {
                if (tb.Text == "")
                {
                    tb.ForeColor = Color.Gray;

                    tb.Text = placeholderText;
                }
            };// закрываем... лямбду?
        }
    }
}
