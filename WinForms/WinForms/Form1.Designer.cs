namespace WinForms
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.Result = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chooseBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.summBox1 = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.Result2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.chooseBox2 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.summBox2 = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.list2 = new System.Windows.Forms.Label();
            this.list1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(314, 202);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.Result);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.chooseBox1);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.summBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(306, 176);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Процентная";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(117, 95);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Рассчитать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Result
            // 
            this.Result.AutoSize = true;
            this.Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Result.Location = new System.Drawing.Point(157, 138);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(0, 16);
            this.Result.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(9, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Конечная стоимость:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(137, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Размер скидки";
            // 
            // chooseBox1
            // 
            this.chooseBox1.FormattingEnabled = true;
            this.chooseBox1.Items.AddRange(new object[] {
            "5% - Бронзовая",
            "20% - Серебряная",
            "50% - Золотая"});
            this.chooseBox1.Location = new System.Drawing.Point(10, 54);
            this.chooseBox1.Name = "chooseBox1";
            this.chooseBox1.Size = new System.Drawing.Size(121, 21);
            this.chooseBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(137, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Стоимость товара";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // summBox1
            // 
            this.summBox1.BackColor = System.Drawing.SystemColors.Window;
            this.summBox1.Location = new System.Drawing.Point(10, 11);
            this.summBox1.Name = "summBox1";
            this.summBox1.Size = new System.Drawing.Size(121, 20);
            this.summBox1.TabIndex = 0;
            this.summBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.summBox1_KeyPress);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.Result2);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.chooseBox2);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.summBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(306, 176);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Сертификатная";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(117, 95);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "Рассчитать";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Result2
            // 
            this.Result2.AutoSize = true;
            this.Result2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Result2.Location = new System.Drawing.Point(157, 138);
            this.Result2.Name = "Result2";
            this.Result2.Size = new System.Drawing.Size(0, 16);
            this.Result2.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(9, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Конечная стоимость:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(137, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Размер скидки";
            // 
            // chooseBox2
            // 
            this.chooseBox2.FormattingEnabled = true;
            this.chooseBox2.Items.AddRange(new object[] {
            "1000 д.е - Базовый",
            "2000 д.е - Постоянный",
            "5000 д.е - Элитный"});
            this.chooseBox2.Location = new System.Drawing.Point(10, 54);
            this.chooseBox2.Name = "chooseBox2";
            this.chooseBox2.Size = new System.Drawing.Size(121, 21);
            this.chooseBox2.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(137, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 16);
            this.label7.TabIndex = 8;
            this.label7.Text = "Стоимость товара";
            // 
            // summBox2
            // 
            this.summBox2.Location = new System.Drawing.Point(10, 11);
            this.summBox2.Name = "summBox2";
            this.summBox2.Size = new System.Drawing.Size(121, 20);
            this.summBox2.TabIndex = 7;
            this.summBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.summBox2_KeyPress);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.list2);
            this.tabPage3.Controls.Add(this.list1);
            this.tabPage3.Controls.Add(this.button3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(306, 176);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Список";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // list2
            // 
            this.list2.AutoSize = true;
            this.list2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.list2.Location = new System.Drawing.Point(112, 91);
            this.list2.Name = "list2";
            this.list2.Size = new System.Drawing.Size(0, 16);
            this.list2.TabIndex = 2;
            // 
            // list1
            // 
            this.list1.AutoSize = true;
            this.list1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.list1.Location = new System.Drawing.Point(72, 59);
            this.list1.Name = "list1";
            this.list1.Size = new System.Drawing.Size(160, 16);
            this.list1.TabIndex = 1;
            this.list1.Text = "Скидка (через пробел):";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(78, 19);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(149, 23);
            this.button3.TabIndex = 0;
            this.button3.Text = "Вывести все значения";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 202);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Система скидок";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label Result;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox chooseBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox summBox1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label Result2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox chooseBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox summBox2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label list2;
        private System.Windows.Forms.Label list1;
        private System.Windows.Forms.Button button3;
    }
}

