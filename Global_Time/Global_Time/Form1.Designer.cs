namespace Global_Time
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "Afghanistan Standard Time",
            "Alaskan Standard Time",
            "Arab Standard Time",
            "Arabian Standard Time",
            "Arabic Standard Time",
            "Argentina Standard Time",
            "Atlantic Standard Time",
            "AUS Central Standard Time",
            "AUS Eastern Standard Time",
            "Azerbaijan Standard Time",
            "Azores Standard Time",
            "Canada Central Standard Time",
            "Cape Verde Standard Time",
            "Caucasus Standard Time",
            "Cen. Australia Standard Time",
            "Central America Standard Time",
            "Central Asia Standard Time",
            "Central Brazilian Standard Time",
            "Central Europe Standard Time",
            "Central European Standard Time",
            "Central Pacific Standard Time",
            "Central Standard Time",
            "Central Standard Time (Mexico)",
            "China Standard Time",
            "Dateline Standard Time",
            "E. Africa Standard Time",
            "E. Australia Standard Time",
            "E. Europe Standard Time",
            "E. South America Standard Time",
            "Eastern Standard Time",
            "Egypt Standard Time",
            "Ekaterinburg Standard Time",
            "Fiji Standard Time",
            "FLE Standard Time",
            "Georgian Standard Time",
            "GMT Standard Time",
            "Greenland Standard Time",
            "Greenwich Standard Time",
            "GTB Standard Time",
            "Hawaiian Standard Time",
            "India Standard Time",
            "Iran Standard Time",
            "Israel Standard Time",
            "Jordan Standard Time",
            "Korea Standard Time",
            "Mauritius Standard Time",
            "Mid-Atlantic Standard Time",
            "Middle East Standard Time",
            "Montevideo Standard Time",
            "Morocco Standard Time",
            "Mountain Standard Time",
            "Mountain Standard Time (Mexico)",
            "Myanmar Standard Time",
            "N. Central Asia Standard Time",
            "Namibia Standard Time",
            "Nepal Standard Time",
            "New Zealand Standard Time",
            "Newfoundland Standard Time",
            "North Asia East Standard Time",
            "North Asia Standard Time",
            "Pacific SA Standard Time",
            "Pacific Standard Time",
            "Pacific Standard Time (Mexico)",
            "Pakistan Standard Time",
            "Romance Standard Time",
            "Russian Standard Time",
            "SA Eastern Standard Time",
            "SA Pacific Standard Time",
            "SA Western Standard Time",
            "Samoa Standard Time",
            "SE Asia Standard Time",
            "Singapore Standard Time",
            "South Africa Standard Time",
            "Sri Lanka Standard Time",
            "Taipei Standard Time",
            "Tasmania Standard Time",
            "Tokyo Standard Time",
            "Tonga Standard Time",
            "US Eastern Standard Time",
            "US Mountain Standard Time",
            "Venezuela Standard Time",
            "Vladivostok Standard Time",
            "W. Australia Standard Time",
            "W. Central Africa Standard Time",
            "W. Europe Standard Time",
            "West Asia Standard Time",
            "West Pacific Standard Time",
            "Yakutsk Standard Time"});
            this.listBox1.Location = new System.Drawing.Point(453, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(227, 498);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(160, 163);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Конвертировать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(312, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Конечное время";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Начальное время";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 86);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(172, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(275, 86);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(172, 20);
            this.textBox2.TabIndex = 5;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1:00:00",
            "2:00:00",
            "3:00:00",
            "4:00:00",
            "5:00:00",
            "6:00:00",
            "7:00:00",
            "8:00:00",
            "9:00:00",
            "10:00:00",
            "11:00:00",
            "12:00:00",
            "13:00:00",
            "14:00:00",
            "15:00:00",
            "16:00:00",
            "17:00:00",
            "18:00:00",
            "19:00:00",
            "20:00:00",
            "21:00:00",
            "22:00:00",
            "23:00:00",
            "0:00:00"});
            this.comboBox1.Location = new System.Drawing.Point(12, 290);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Items.AddRange(new object[] {
            "Челябинск",
            "Москва"});
            this.listBox2.Location = new System.Drawing.Point(275, 281);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(120, 95);
            this.listBox2.TabIndex = 7;
            this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(222, 458);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 517);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button button2;
    }
}

