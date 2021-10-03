using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; // Для StreamWriter

namespace Форма_для_генерации_подписей
{
    class Sochi //Колемаскин Данил Олегович
    {
       
        public void Custom(string NUserFIO, string NUserNomerVn, string NUserMT, string Place, string NUserPosition)
        {
            StreamWriter streamwriter = new StreamWriter(Place + NUserFIO + ".html");

            streamwriter.WriteLine("<html>");
            streamwriter.WriteLine("  <head>");
            streamwriter.WriteLine("");
            streamwriter.WriteLine("    <meta http-equiv=\"content-type\" content=\"text/html; charset=UTF-8\">");
            streamwriter.WriteLine("    <title></title>");
            streamwriter.WriteLine("  </head>");
            streamwriter.WriteLine("  <body text=\"#000000\" bgcolor=\"#FFFFFF\">");
            streamwriter.WriteLine("    <p style=\"color: rgb(0, 0, 0); font-family: &quot;Times New");
            streamwriter.WriteLine("      Roman&quot;; font-size: medium; font-style: normal;");
            streamwriter.WriteLine("      font-variant-ligatures: normal; font-variant-caps: normal;");
            streamwriter.WriteLine("      font-weight: 400; letter-spacing: normal; orphans: 2; text-align:");
            streamwriter.WriteLine("      start; text-indent: 0px; text-transform: none; white-space:");
            streamwriter.WriteLine("      normal; widows: 2; word-spacing: 0px; -webkit-text-stroke-width:");
            streamwriter.WriteLine("      0px; background-color: rgb(255, 255, 255); text-decoration-style:");
            streamwriter.WriteLine("      initial; text-decoration-color: initial;\"><font size=\"-2\"");
            streamwriter.WriteLine("        face=\"Arial\"><font color=\"#30b149\"><b>		" + NUserFIO + "		</b></font><br>\t\t\t<!-- Имя и Фамилия -->"); // Указываю фио
            streamwriter.WriteLine("        <font color=\"#333333\">" + NUserPosition + ",<br>" + "\t\t\t\t\t\t\t\t<!--Должность -->");
            streamwriter.WriteLine("          2ГИС.Юг<br>");
            streamwriter.WriteLine("          <br>");
            if (NUserMT != "88000000000")                                                                         // Указываем мобильный. Если тру
                streamwriter.WriteLine("          " + NUserMT + "\t\t\t\t\t\t\t\t\t\t\t<!-- Лич.Телефон -->");
            streamwriter.WriteLine("</font></font><font size=\"-2\" face=\"Arial\"><font color=\"#333333\"><span style=\"color: rgb(51, 51, 51);");
            streamwriter.WriteLine("            font-family: Arial; font-size: x-small; font-style: normal;");
            streamwriter.WriteLine("            font-variant-ligatures: normal; font-variant-caps: normal;");
            streamwriter.WriteLine("            font-weight: 400; letter-spacing: normal; orphans: 2;");
            streamwriter.WriteLine("            text-align: start; text-indent: 0px; text-transform: none;");
            streamwriter.WriteLine("            white-space: normal; widows: 2; word-spacing: 0px;");
            streamwriter.WriteLine("            -webkit-text-stroke-width: 0px; background-color: rgb(255,");
            streamwriter.WriteLine("            255, 255); text-decoration-style: initial;");
            streamwriter.WriteLine("            text-decoration-color: initial; display: inline !important;");
            streamwriter.WriteLine("            float: none;\"><br>");
            if (NUserNomerVn == "20000")
                streamwriter.WriteLine($"            +7-800-25-023-25" + "<br>" + "\t\t\t\t\t\t\t\t\t\t<!-- Внутр.Номер в формате доб._______-->");
            else
                streamwriter.WriteLine($"            +7-800-25-023-25 доб. " + NUserNomerVn + "<br>" + "\t\t\t\t\t\t\t\t\t<!-- Город + Внутр.Номер-->");

            streamwriter.WriteLine("          </span></font></font></p>");
            streamwriter.WriteLine("    <p style=\"color: rgb(0, 0, 0); font - family: &quot; Times New");
            streamwriter.WriteLine("      Roman&quot;; font-size: medium; font-style: normal;");
            streamwriter.WriteLine("      font-variant-ligatures: normal; font-variant-caps: normal;");
            streamwriter.WriteLine("      font-weight: 400; letter-spacing: normal; orphans: 2; text-align:");
            streamwriter.WriteLine("      start; text-indent: 0px; text-transform: none; white-space:");
            streamwriter.WriteLine("      normal; widows: 2; word-spacing: 0px; -webkit-text-stroke-width:");
            streamwriter.WriteLine("      0px; background-color: rgb(255, 255, 255); text-decoration-style:");
            streamwriter.WriteLine("      initial; text-decoration-color: initial;\"><font size=\"-1\"><font");
            streamwriter.WriteLine("          size=\"-2\" face=\"Arial\" color=\"#333333\">354033, Сочи,<br>");
            streamwriter.WriteLine("          Пластунская, 80, 6 офис, 3 этаж</font><br>");
            streamwriter.WriteLine("      </font></p>");
            streamwriter.WriteLine("    <p><font size=\"-1\"><span><font size=\"-2\" face=\"Arial\"><a");
            streamwriter.WriteLine("              href=\"http://info.2gis.ru/krasnodar/\"><span");
            streamwriter.WriteLine("                class=\"auto-style3\">info.2gis.ru/krasnodar</span></a><br>");
            streamwriter.WriteLine("          </font></span></font></p>");
            streamwriter.WriteLine("    <img moz-do-not-send=\"false\"");
            streamwriter.WriteLine("src=\"data:image/png;filename=2.png;base64,iVBORw0KGgoAAAANSUhEUgAAAGMAAAAvCAYAAAD3oXSCAAAACXBIWXMAAAsTAAALEwEAmpwYAAAAIGNIUk0AAHolAACAgwAA");

            streamwriter.WriteLine("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");

            streamwriter.WriteLine("VUp5tyWsGv/j8gI41+D8F8CwmSEESYjTEYYYTLCZIQRJuMngv8eAAAOiV9d0Q9yAAAAAElFTkSuQmCC\"");
            streamwriter.WriteLine("      alt=\"\" width=\"99\" height=\"47\">");
            streamwriter.WriteLine("  </body>");
            streamwriter.WriteLine("</html>");

            streamwriter.Close();
        }
    }
}
