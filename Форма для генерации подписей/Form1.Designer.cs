
namespace Форма_для_генерации_подписей
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Start = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.FormFIO = new System.Windows.Forms.TextBox();
            this.FormMobNomer = new System.Windows.Forms.TextBox();
            this.FormNomerVn = new System.Windows.Forms.TextBox();
            this.PositionBox = new System.Windows.Forms.ComboBox();
            this.CiteBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CustomPositionBox = new System.Windows.Forms.TextBox();
            this.QuestionBox = new System.Windows.Forms.PictureBox();
            this.ExitBox = new System.Windows.Forms.PictureBox();
            this.ShrinkBox = new System.Windows.Forms.PictureBox();
            this.HylaBox = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.QuestionBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShrinkBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HylaBox)).BeginInit();
            this.SuspendLayout();
            // 
            // Start
            // 
            this.Start.BackColor = System.Drawing.Color.Transparent;
            this.Start.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Start.BackgroundImage")));
            this.Start.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Start.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Start.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkViolet;
            this.Start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Start.Location = new System.Drawing.Point(211, 197);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(86, 39);
            this.Start.TabIndex = 0;
            this.Start.UseVisualStyleBackColor = false;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.GreenYellow;
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ФИО";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.GreenYellow;
            this.label2.Location = new System.Drawing.Point(12, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Мобильный телефон";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.GreenYellow;
            this.label3.Location = new System.Drawing.Point(12, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Внутрений номер";
            // 
            // FormFIO
            // 
            this.FormFIO.BackColor = System.Drawing.Color.Chartreuse;
            this.FormFIO.Location = new System.Drawing.Point(156, 25);
            this.FormFIO.Name = "FormFIO";
            this.FormFIO.Size = new System.Drawing.Size(197, 20);
            this.FormFIO.TabIndex = 4;
            this.FormFIO.TextChanged += new System.EventHandler(this.FormFIO_TextChanged);
            // 
            // FormMobNomer
            // 
            this.FormMobNomer.BackColor = System.Drawing.Color.Chartreuse;
            this.FormMobNomer.Location = new System.Drawing.Point(156, 57);
            this.FormMobNomer.Name = "FormMobNomer";
            this.FormMobNomer.Size = new System.Drawing.Size(197, 20);
            this.FormMobNomer.TabIndex = 5;
            // 
            // FormNomerVn
            // 
            this.FormNomerVn.BackColor = System.Drawing.Color.Chartreuse;
            this.FormNomerVn.Location = new System.Drawing.Point(156, 87);
            this.FormNomerVn.Name = "FormNomerVn";
            this.FormNomerVn.Size = new System.Drawing.Size(197, 20);
            this.FormNomerVn.TabIndex = 6;
            // 
            // PositionBox
            // 
            this.PositionBox.BackColor = System.Drawing.Color.Chartreuse;
            this.PositionBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PositionBox.ForeColor = System.Drawing.Color.DarkBlue;
            this.PositionBox.FormattingEnabled = true;
            this.PositionBox.ImeMode = System.Windows.Forms.ImeMode.On;
            this.PositionBox.Items.AddRange(new object[] {
            "Менеджер по продажам",
            "Специалист по сбору информации",
            "Руководитель группы продаж"});
            this.PositionBox.Location = new System.Drawing.Point(156, 119);
            this.PositionBox.Name = "PositionBox";
            this.PositionBox.Size = new System.Drawing.Size(197, 21);
            this.PositionBox.TabIndex = 9;
            this.PositionBox.SelectedIndexChanged += new System.EventHandler(this.PositionBox_SelectedIndexChanged);
            // 
            // CiteBox
            // 
            this.CiteBox.BackColor = System.Drawing.Color.Chartreuse;
            this.CiteBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CiteBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CiteBox.ForeColor = System.Drawing.Color.Black;
            this.CiteBox.FormattingEnabled = true;
            this.CiteBox.ImeMode = System.Windows.Forms.ImeMode.On;
            this.CiteBox.Items.AddRange(new object[] {
            "Краснодар",
            "Астрахань",
            "Сочи",
            "Таганрог",
            "Армавир"});
            this.CiteBox.Location = new System.Drawing.Point(156, 149);
            this.CiteBox.Name = "CiteBox";
            this.CiteBox.Size = new System.Drawing.Size(197, 21);
            this.CiteBox.TabIndex = 10;
            this.CiteBox.SelectedIndexChanged += new System.EventHandler(this.CiteBox_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.YellowGreen;
            this.label5.Location = new System.Drawing.Point(12, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Город";
            // 
            // CustomPositionBox
            // 
            this.CustomPositionBox.BackColor = System.Drawing.Color.Chartreuse;
            this.CustomPositionBox.Location = new System.Drawing.Point(156, 120);
            this.CustomPositionBox.Name = "CustomPositionBox";
            this.CustomPositionBox.Size = new System.Drawing.Size(197, 20);
            this.CustomPositionBox.TabIndex = 14;
            this.CustomPositionBox.TextChanged += new System.EventHandler(this.CustomPositionBox_TextChanged);
            // 
            // QuestionBox
            // 
            this.QuestionBox.BackColor = System.Drawing.Color.Transparent;
            this.QuestionBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("QuestionBox.BackgroundImage")));
            this.QuestionBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.QuestionBox.Location = new System.Drawing.Point(639, 51);
            this.QuestionBox.Name = "QuestionBox";
            this.QuestionBox.Size = new System.Drawing.Size(59, 43);
            this.QuestionBox.TabIndex = 16;
            this.QuestionBox.TabStop = false;
            this.QuestionBox.Click += new System.EventHandler(this.QuestionBox_Click);
            // 
            // ExitBox
            // 
            this.ExitBox.BackColor = System.Drawing.Color.Transparent;
            this.ExitBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ExitBox.BackgroundImage")));
            this.ExitBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ExitBox.Location = new System.Drawing.Point(643, -5);
            this.ExitBox.Name = "ExitBox";
            this.ExitBox.Size = new System.Drawing.Size(55, 53);
            this.ExitBox.TabIndex = 17;
            this.ExitBox.TabStop = false;
            this.ExitBox.Click += new System.EventHandler(this.ExitBox_Click);
            // 
            // ShrinkBox
            // 
            this.ShrinkBox.BackColor = System.Drawing.Color.Transparent;
            this.ShrinkBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ShrinkBox.BackgroundImage")));
            this.ShrinkBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ShrinkBox.Location = new System.Drawing.Point(591, -2);
            this.ShrinkBox.Name = "ShrinkBox";
            this.ShrinkBox.Size = new System.Drawing.Size(51, 50);
            this.ShrinkBox.TabIndex = 18;
            this.ShrinkBox.TabStop = false;
            this.ShrinkBox.Click += new System.EventHandler(this.ShrinkBox_Click);
            // 
            // HylaBox
            // 
            this.HylaBox.BackColor = System.Drawing.Color.Transparent;
            this.HylaBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("HylaBox.BackgroundImage")));
            this.HylaBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.HylaBox.Location = new System.Drawing.Point(665, 277);
            this.HylaBox.Name = "HylaBox";
            this.HylaBox.Size = new System.Drawing.Size(33, 26);
            this.HylaBox.TabIndex = 19;
            this.HylaBox.TabStop = false;
            this.HylaBox.Click += new System.EventHandler(this.HylaBox_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.GreenYellow;
            this.label4.Location = new System.Drawing.Point(12, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Должность Выб/Указать";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(697, 306);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.HylaBox);
            this.Controls.Add(this.ShrinkBox);
            this.Controls.Add(this.ExitBox);
            this.Controls.Add(this.QuestionBox);
            this.Controls.Add(this.PositionBox);
            this.Controls.Add(this.CustomPositionBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CiteBox);
            this.Controls.Add(this.FormNomerVn);
            this.Controls.Add(this.FormMobNomer);
            this.Controls.Add(this.FormFIO);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Start);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDowm);
            ((System.ComponentModel.ISupportInitialize)(this.QuestionBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShrinkBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HylaBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox FormFIO;
        private System.Windows.Forms.TextBox FormMobNomer;
        private System.Windows.Forms.TextBox FormNomerVn;
        private System.Windows.Forms.ComboBox PositionBox;
        private System.Windows.Forms.ComboBox CiteBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.TextBox CustomPositionBox;
        private System.Windows.Forms.PictureBox QuestionBox;
        private System.Windows.Forms.PictureBox ExitBox;
        private System.Windows.Forms.PictureBox ShrinkBox;
        private System.Windows.Forms.PictureBox HylaBox;
        private System.Windows.Forms.Label label4;
    }
}

