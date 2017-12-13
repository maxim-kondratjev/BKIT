namespace WindowsFormsApp1
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
            this.label_time = new System.Windows.Forms.Label();
            this.Button_fileLoad = new System.Windows.Forms.Button();
            this.button_findWord = new System.Windows.Forms.Button();
            this.textBox_wordToFind = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listBox = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox_maxDistance = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.labelTimeFind = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_time
            // 
            this.label_time.AutoSize = true;
            this.label_time.Location = new System.Drawing.Point(468, 359);
            this.label_time.Name = "label_time";
            this.label_time.Size = new System.Drawing.Size(0, 13);
            this.label_time.TabIndex = 0;
            // 
            // Button_fileLoad
            // 
            this.Button_fileLoad.Location = new System.Drawing.Point(15, 9);
            this.Button_fileLoad.Name = "Button_fileLoad";
            this.Button_fileLoad.Size = new System.Drawing.Size(149, 38);
            this.Button_fileLoad.TabIndex = 1;
            this.Button_fileLoad.Text = "Загрузить файл";
            this.Button_fileLoad.UseVisualStyleBackColor = true;
            this.Button_fileLoad.Click += new System.EventHandler(this.Button_fileLoad1);
            // 
            // button_findWord
            // 
            this.button_findWord.Location = new System.Drawing.Point(465, 9);
            this.button_findWord.Name = "button_findWord";
            this.button_findWord.Size = new System.Drawing.Size(199, 38);
            this.button_findWord.TabIndex = 2;
            this.button_findWord.Text = "Найти";
            this.button_findWord.UseVisualStyleBackColor = true;
            this.button_findWord.Click += new System.EventHandler(this.button_findWord_Click);
            // 
            // textBox_wordToFind
            // 
            this.textBox_wordToFind.Location = new System.Drawing.Point(307, 9);
            this.textBox_wordToFind.Name = "textBox_wordToFind";
            this.textBox_wordToFind.Size = new System.Drawing.Size(115, 20);
            this.textBox_wordToFind.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Текст:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(357, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Найденные слова:";
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.Location = new System.Drawing.Point(357, 118);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(307, 238);
            this.listBox.TabIndex = 6;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 118);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(339, 238);
            this.textBox1.TabIndex = 7;
            // 
            // textBox_maxDistance
            // 
            this.textBox_maxDistance.Location = new System.Drawing.Point(352, 36);
            this.textBox_maxDistance.Name = "textBox_maxDistance";
            this.textBox_maxDistance.Size = new System.Drawing.Size(70, 20);
            this.textBox_maxDistance.TabIndex = 8;
            this.textBox_maxDistance.Text = "1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(200, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Слово для поиска:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(200, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Максимальное расстояние:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(352, 63);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(70, 20);
            this.textBox2.TabIndex = 11;
            this.textBox2.Text = "1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(200, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Количество потоков:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(465, 53);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(196, 37);
            this.button1.TabIndex = 13;
            this.button1.Text = "Сохранить отчет";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(300, 375);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(158, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Затраченное время на поиск:";
            // 
            // labelTimeFind
            // 
            this.labelTimeFind.AutoSize = true;
            this.labelTimeFind.Location = new System.Drawing.Point(468, 375);
            this.labelTimeFind.Name = "labelTimeFind";
            this.labelTimeFind.Size = new System.Drawing.Size(0, 13);
            this.labelTimeFind.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(285, 359);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(173, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Затраченное время на загрузку:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 397);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.labelTimeFind);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_maxDistance);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_wordToFind);
            this.Controls.Add(this.button_findWord);
            this.Controls.Add(this.Button_fileLoad);
            this.Controls.Add(this.label_time);
            this.Name = "Form1";
            this.Text = "Вычисление расстояния Дамерау-Левенштейна";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_time;
        private System.Windows.Forms.Button Button_fileLoad;
        private System.Windows.Forms.Button button_findWord;
        private System.Windows.Forms.TextBox textBox_wordToFind;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox_maxDistance;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelTimeFind;
        private System.Windows.Forms.Label label7;
    }
}

