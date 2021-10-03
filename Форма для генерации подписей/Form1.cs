using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; // Для StreamWriter

namespace Форма_для_генерации_подписей
{
    public partial class Form1 : Form
    {

        public Form1() //Обрабатывается при запуске формы
        {

            InitializeComponent();
            PositionBox.SelectedIndexChanged += PositionBox_SelectedIndexChanged;
            PositionBox.SelectedItem = "Менеджер по продажам"; // Значение по умолчанию
            PositionBox.ForeColor = Color.Navy;

            CiteBox.SelectedIndexChanged += CiteBox_SelectedIndexChanged;
            CiteBox.SelectedItem = "Краснодар"; // Значение по умолчанию
            CiteBox.ForeColor = Color.Navy;

        }
        void Form1_KeyDown(object sender, KeyEventArgs e) //Закрываем Esc.
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e) // Серые буквы. Они же Placeholder плейсхолдер
        {
            FormFIO.AddPlaceholder("Микеланджело Буонарроти Леонардо"); 
            FormMobNomer.AddPlaceholder("88000000000");
            FormNomerVn.AddPlaceholder("20000");
        }
        
        public void Form1_MouseDowm(object sender, MouseEventArgs e) // Чтобы двигать форму нажатием. Нужно еще зайти в молнию и в поле MouseDowm выбрать Form1_MouseDowm
        {
            base.Capture = false;
            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref m);
        }

        private void Start_Click(object sender, EventArgs e) // Что происходит при нажатии кнопки Start
        {
            #region Вбираем
            string NUserFIO = FormFIO.Text.Trim(); // Вбираем ФИО Преобразуя поле в текс.Убираем пробелы
            string NUserMT = FormMobNomer.Text.Trim(); // Вбираем мобильный номер.Убираем пробелы
            string NUserNomerVn = FormNomerVn.Text.Trim(); // Вбираем внутрений номер.Убираем пробелы


            string NUserCity = CiteBox.SelectedItem.ToString(); // Вбираем город из выпадающего списка
            string NUserPosition = PositionBox.Text.Trim(); // Вбираем должность.Убираем пробелы 

            #endregion

            string[] NUserFIOParsing = NUserFIO.Split(' '); // Превращаем ФИО в массив по пробелу

            //Проверяем корректность заполнения
            if ( NUserFIO == "Микеланджело Буонарроти Леонардо" || NUserFIOParsing.Length < 2 || NUserPosition == "") // Если не указано Должность или ФИО не удалось распарсить
            {
                if (NUserPosition == "" && NUserFIO == "") // Сначала проверяем указаны ли оба параметра
                {
                    MessageBox.Show("Не указаны Должность и ФИО!", ""); // Нет должности и ФИО
                }
                else if (NUserFIO == "Микеланджело Буонарроти Леонардо") // Проверяем указано ли имя
                {
                    MessageBox.Show("ФИО не указано!", ""); // Не указано только ФИО
                }
                else if (NUserFIO != "" && NUserFIOParsing.Length < 2) //Если не удаеться разбить массив на 2 элемента
                {
                    MessageBox.Show("ФИО должно быть разделено пробелом", "Не корректно указано ФИО!"); // ФИО
                }
                else if (NUserPosition == "") // Проверяем указана ли должность
                {
                    MessageBox.Show("Не указана должность!", ""); // Не указана должность
                }
                
            } // Проверяем можно ли приступать к генерации. Заходим если Что-то не введено или введено одно поле
            else if (NUserMT != "" && NUserMT.Length != 11) // Проверяем корректность ввода телефона
            {
                MessageBox.Show("Телефон нужно указывать в формате: 88000000000", "Не корректно указан телефон!"); // Не указано только ФИО
            }
            else // Если все норм начинаем генерацию
            {
                if (NUserMT != "88000000000") // Если в мобильный номер записана только серый текст то не геним
                {
                    // Форматирование номера телефона
                    NUserMT = "+7" + NUserMT.Substring(1); // Заменяем первую 8 на +7
                    NUserMT = NUserMT.Insert(2, " "); // Делаем +7 800000000
                    NUserMT = NUserMT.Insert(6, " "); // Делаем +7 800 000000
                    NUserMT = NUserMT.Insert(10, "-"); //Делаем +7 800 000-0000
                    NUserMT = NUserMT.Insert(13, "-"); //Делаем +7 800 000-00-00
                } //Если указали телефон
                
                NUserFIO = NUserFIOParsing[0] + " " + NUserFIOParsing[1]; // Формируем название ака логин Фамилия потом имя

                string Place= Directory.GetCurrentDirectory() + @"\";// Ложим указатель на текущую деррикторию.Иначе нужно будет обьявлять в КАЖДОМ классе

                if (NUserCity == "Краснодар") // Если город нового сотрудника Краснодар
                {
                    
                    //Выпилил все кроме метода Custom, теперь все обращаються к нему

                        Krasnodar GenSigKras = new Krasnodar(); // Создаем ссылку на класс 
                        GenSigKras.Custom(NUserFIO, NUserNomerVn, NUserMT, Place, NUserPosition); // Вызываем метод из класса выше передавая ему данные
                       
                        string CopyPlace = @"\Почта\Краснодар"; // 

                        CopySignature a = new CopySignature(NUserFIO, CopyPlace); // Вызываем конструктор

                }
                if (NUserCity == "Астрахань") // Если город нового сотрудника Астрахань
                {
                        Astrakhan GenSigKras = new Astrakhan(); // Создаем ссылку на класс 
                        GenSigKras.Custom(NUserFIO, NUserNomerVn, NUserMT, Place, NUserPosition); // Вызываем метод из класса выше передавая ему данные
                        
                        string CopyPlace = @"\Астрахань\Общие документы\svalka\Почта"; // Новое место хранения
                        CopySignature a = new CopySignature(NUserFIO, CopyPlace); // Вызываем конструктор
                }
                if (NUserCity == "Сочи") // Если город нового сотрудника Сочи
                {
                    Sochi GenSigSoc = new Sochi(); // Создаем ссылку на класс 
                    GenSigSoc.Custom(NUserFIO, NUserNomerVn, NUserMT, Place, NUserPosition); // Вызываем метод из класса выше передавая ему данные

                    string CopyPlace = @"\Сочи\Общие документы\Почта\Сочи"; //Новое место
                    CopySignature a = new CopySignature(NUserFIO, CopyPlace); // Вызываем конструктор
                }
                if (NUserCity == "Таганрог")
                {

                    Taganrog GetSigTag = new Taganrog(); // Создаем ссылку на класс 
                        GetSigTag.Custom(NUserFIO, NUserNomerVn, NUserMT, Place, NUserPosition); // Вызываем метод из класса выше передавая ему данные
                    string CopyPlace = @"\tagn\подписи почт";
                    CopySignature a = new CopySignature(NUserFIO, CopyPlace); // Вызываем конструктор для копирования
                }
                if (NUserCity == "Армавир")
                {

                    Armavir GetSigArm = new Armavir();
                    GetSigArm.Custom(NUserFIO, NUserNomerVn, NUserMT, Place, NUserPosition);

                    string CopyPlace = @"\Подпись почты"; //Куда положить копию
                    CopySignature a = new CopySignature(NUserFIO, CopyPlace); // Вызываем конструктор
                }


                #region Очищаем форму
                FormFIO.AddPlaceholder("Микеланджело Буонарроти Леонардо"); // Очищаем от введенных данных сотрудников
                FormMobNomer.AddPlaceholder("88000000000");
                FormNomerVn.AddPlaceholder("20000");
                #endregion
            }
        }

        private void FormFIO_TextChanged(object sender, EventArgs e)
        {

        }

        private void PositionBox_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void CiteBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        

        private void CustomPositionBox_TextChanged(object sender, EventArgs e)
        {

        }
        private void QuestionBox_Click(object sender, EventArgs e) //Бокс вопросик
        {
            Instructions b = new Instructions();
        }

        private void ShrinkBox_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void ExitBox_Click(object sender, EventArgs e)
        {
            this.Close(); // Закрываем нажатием крестика
        }

        private void HylaBox_Click(object sender, EventArgs e) // Лягушачья кнопка
        {
            Hyla c = new Hyla();
        }
    }

}