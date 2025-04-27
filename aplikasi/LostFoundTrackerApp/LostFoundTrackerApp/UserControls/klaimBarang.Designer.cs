namespace LostFoundTrackerApp.UserControls
{
    partial class klaimBarang
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            dateTimePicker1 = new DateTimePicker();
            label5 = new Label();
            textBox4 = new TextBox();
            label4 = new Label();
            textBox3 = new TextBox();
            label3 = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 186, 46);
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.Font = new Font("Audiowide", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(526, 363);
            button1.Name = "button1";
            button1.Size = new Size(133, 44);
            button1.TabIndex = 21;
            button1.Text = "SAVE";
            button1.UseVisualStyleBackColor = false;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(42, 363);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 20;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Audiowide", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(42, 334);
            label5.Name = "label5";
            label5.Size = new Size(163, 26);
            label5.TabIndex = 19;
            label5.Text = "Tanggal Klaim";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(42, 289);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(617, 27);
            textBox4.TabIndex = 18;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Audiowide", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(42, 257);
            label4.Name = "label4";
            label4.Size = new Size(250, 26);
            label4.TabIndex = 17;
            label4.Text = "Info Kontak Penglaim";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(42, 214);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(617, 27);
            textBox3.TabIndex = 16;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Audiowide", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(42, 182);
            label3.Name = "label3";
            label3.Size = new Size(177, 26);
            label3.TabIndex = 15;
            label3.Text = "Nama Penglaim";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(42, 142);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(617, 27);
            textBox2.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Audiowide", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(42, 110);
            label2.Name = "label2";
            label2.Size = new Size(252, 26);
            label2.TabIndex = 13;
            label2.Text = "Deskripsi Pembuktian";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(42, 71);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(617, 27);
            textBox1.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Audiowide", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(42, 39);
            label1.Name = "label1";
            label1.Size = new Size(88, 26);
            label1.TabIndex = 11;
            label1.Text = "ID Item";
            // 
            // klaimBarang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button1);
            Controls.Add(dateTimePicker1);
            Controls.Add(label5);
            Controls.Add(textBox4);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "klaimBarang";
            Size = new Size(700, 446);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private DateTimePicker dateTimePicker1;
        private Label label5;
        private TextBox textBox4;
        private Label label4;
        private TextBox textBox3;
        private Label label3;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox1;
        private Label label1;
    }
}
