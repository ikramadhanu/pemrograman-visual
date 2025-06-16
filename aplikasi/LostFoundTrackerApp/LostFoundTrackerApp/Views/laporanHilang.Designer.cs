namespace LostFoundTrackerApp.Views
{
    partial class laporanHilang
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
            buttonSave = new Button();
            dateTimePickerFound = new DateTimePicker();
            label5 = new Label();
            textDesc = new TextBox();
            label2 = new Label();
            textName = new TextBox();
            label1 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            textBox2 = new TextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // buttonSave
            // 
            buttonSave.BackColor = Color.FromArgb(255, 186, 46);
            buttonSave.BackgroundImageLayout = ImageLayout.None;
            buttonSave.Font = new Font("Audiowide", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonSave.Location = new Point(526, 363);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(133, 44);
            buttonSave.TabIndex = 21;
            buttonSave.Text = "SAVE";
            buttonSave.UseVisualStyleBackColor = false;
            // 
            // dateTimePickerFound
            // 
            dateTimePickerFound.Location = new Point(42, 261);
            dateTimePickerFound.Name = "dateTimePickerFound";
            dateTimePickerFound.Size = new Size(250, 27);
            dateTimePickerFound.TabIndex = 20;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Audiowide", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(42, 223);
            label5.Name = "label5";
            label5.Size = new Size(228, 26);
            label5.TabIndex = 19;
            label5.Text = "Tanggal Kehilangan";
            // 
            // textDesc
            // 
            textDesc.Location = new Point(42, 194);
            textDesc.Name = "textDesc";
            textDesc.Size = new Size(617, 27);
            textDesc.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Audiowide", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(42, 162);
            label2.Name = "label2";
            label2.Size = new Size(168, 26);
            label2.TabIndex = 13;
            label2.Text = "Deskripsi Item";
            // 
            // textName
            // 
            textName.Location = new Point(42, 71);
            textName.Name = "textName";
            textName.Size = new Size(617, 27);
            textName.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Audiowide", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(42, 39);
            label1.Name = "label1";
            label1.Size = new Size(99, 26);
            label1.TabIndex = 11;
            label1.Text = "Pelapor";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(42, 322);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(617, 27);
            textBox1.TabIndex = 23;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Audiowide", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(42, 290);
            label3.Name = "label3";
            label3.Size = new Size(223, 26);
            label3.TabIndex = 22;
            label3.Text = "Tempat Kehilangan";
            label3.Click += label3_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(42, 133);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(617, 27);
            textBox2.TabIndex = 25;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Audiowide", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(42, 101);
            label4.Name = "label4";
            label4.Size = new Size(183, 26);
            label4.TabIndex = 24;
            label4.Text = "Alamat Pelapor";
            // 
            // laporanHilang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(textBox2);
            Controls.Add(label4);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(buttonSave);
            Controls.Add(dateTimePickerFound);
            Controls.Add(label5);
            Controls.Add(textDesc);
            Controls.Add(label2);
            Controls.Add(textName);
            Controls.Add(label1);
            Name = "laporanHilang";
            Size = new Size(700, 446);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonSave;
        private DateTimePicker dateTimePickerFound;
        private Label label5;
        private TextBox textDesc;
        private Label label2;
        private TextBox textName;
        private Label label1;
        private TextBox textBox1;
        private Label label3;
        private TextBox textBox2;
        private Label label4;
    }
}
