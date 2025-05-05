namespace DijitalSaat
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            timer1 = new System.Windows.Forms.Timer(components);
            label3 = new Label();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            panel1 = new Panel();
            listBox1 = new ListBox();
            comboBox1 = new ComboBox();
            label4 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Consolas", 27.8490562F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.ForeColor = Color.White;
            label3.Location = new Point(65, 27);
            label3.Name = "label3";
            label3.Size = new Size(66, 48);
            label3.TabIndex = 5;
            label3.Text = "00";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Consolas", 27.8490562F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.White;
            label1.Location = new Point(208, 27);
            label1.Name = "label1";
            label1.Size = new Size(89, 48);
            label1.TabIndex = 0;
            label1.Text = ":00";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Consolas", 27.8490562F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.ForeColor = Color.White;
            label2.Location = new Point(126, 27);
            label2.Name = "label2";
            label2.Size = new Size(89, 48);
            label2.TabIndex = 5;
            label2.Text = ":00";
            // 
            // button1
            // 
            button1.BackColor = Color.DodgerBlue;
            button1.ForeColor = Color.White;
            button1.Location = new Point(165, 155);
            button1.Name = "button1";
            button1.Size = new Size(85, 38);
            button1.TabIndex = 1;
            button1.Text = "Başlat";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.DodgerBlue;
            button2.ForeColor = Color.White;
            button2.Location = new Point(256, 155);
            button2.Name = "button2";
            button2.Size = new Size(85, 38);
            button2.TabIndex = 2;
            button2.Text = "Durdur";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.DodgerBlue;
            button3.ForeColor = Color.White;
            button3.Location = new Point(347, 155);
            button3.Name = "button3";
            button3.Size = new Size(85, 38);
            button3.TabIndex = 3;
            button3.Text = "Kaydet";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Yellow;
            button4.ForeColor = Color.Black;
            button4.Location = new Point(438, 155);
            button4.Name = "button4";
            button4.Size = new Size(85, 38);
            button4.TabIndex = 4;
            button4.Text = "Reset";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources._360_F_337086574_uXbsZ1Hp8ct74pDsH7zauxXSMo9kNlX7;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(165, 50);
            panel1.Name = "panel1";
            panel1.Size = new Size(358, 98);
            panel1.TabIndex = 7;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 22;
            listBox1.Location = new Point(43, 210);
            listBox1.Name = "listBox1";
            listBox1.ScrollAlwaysVisible = true;
            listBox1.Size = new Size(478, 158);
            listBox1.TabIndex = 8;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "ders", "mola" });
            comboBox1.Location = new Point(43, 75);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(116, 30);
            comboBox1.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(43, 50);
            label4.Name = "label4";
            label4.Size = new Size(100, 22);
            label4.TabIndex = 10;
            label4.Text = "Ders/Mola";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(567, 392);
            Controls.Add(label4);
            Controls.Add(comboBox1);
            Controls.Add(listBox1);
            Controls.Add(panel1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Font = new Font("Consolas", 12.2264156F, FontStyle.Bold, GraphicsUnit.Point, 162);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Dijital Saat";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label label2;
        private Label label3;
        private Panel panel1;
        private ListBox listBox1;
        private ComboBox comboBox1;
        private Label label4;
    }
}
