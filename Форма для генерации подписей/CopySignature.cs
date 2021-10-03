using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; // Для StreamWriter

namespace Форма_для_генерации_подписей
{
    class CopySignature
    {
       public CopySignature(string NUserFIO, string CopyPlace)
        {
            string desctopPath = Directory.GetCurrentDirectory()+@"\"; // Ложим указатель на текущую деррикторию. Кароче там где запущено ок да?

            // Создать ссылки на расположение
            string sourceFile = System.IO.Path.Combine(desctopPath, NUserFIO + ".html"); // Место где лежит подпись + ее название
            string destFile = System.IO.Path.Combine(CopyPlace, NUserFIO + ".html"); // Место куда деть + ее название

            File.Copy(sourceFile, destFile, true); // Запускаем это дело

        }
    }
}
