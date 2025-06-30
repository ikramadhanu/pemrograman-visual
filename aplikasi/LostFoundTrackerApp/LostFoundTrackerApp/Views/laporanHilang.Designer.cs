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
            dateTimePickerMissing = new DateTimePicker();
            label5 = new Label();
            textDesc = new TextBox();
            label2 = new Label();
            textName = new TextBox();
            label1 = new Label();
            textLoc = new TextBox();
            label3 = new Label();
            textAddress = new TextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // buttonSave
            // 
            buttonSave.BackColor = Color.FromArgb(255, 186, 46);
            buttonSave.BackgroundImageLayout = ImageLayout.None;
            buttonSave.Font = new Font("Audiowide", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonSave.Location = new Point(336, 363);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(323, 44);
            buttonSave.TabIndex = 21;
            buttonSave.Text = "BUAT LAPORAN";
            buttonSave.UseVisualStyleBackColor = false;
            buttonSave.Click += buttonSave_Click;
            // 
            // dateTimePickerMissing
            // 
            dateTimePickerMissing.Location = new Point(42, 261);
            dateTimePickerMissing.Name = "dateTimePickerMissing";
            dateTimePickerMissing.Size = new Size(250, 27);
            dateTimePickerMissing.TabIndex = 20;
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
            textDesc.TextChanged += textDesc_TextChanged;
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
            // textLoc
            // 
            textLoc.Location = new Point(42, 322);
            textLoc.Name = "textLoc";
            textLoc.Size = new Size(617, 27);
            textLoc.TabIndex = 23;
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
            // textAddress
            // 
            textAddress.Location = new Point(42, 133);
            textAddress.Name = "textAddress";
            textAddress.Size = new Size(617, 27);
            textAddress.TabIndex = 25;
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
            Controls.Add(textAddress);
            Controls.Add(label4);
            Controls.Add(textLoc);
            Controls.Add(label3);
            Controls.Add(buttonSave);
            Controls.Add(dateTimePickerMissing);
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
        private DateTimePicker dateTimePickerMissing;
        private Label label5;
        private TextBox textDesc;
        private Label label2;
        private TextBox textName;
        private Label label1;
        private TextBox textLoc;
        private Label label3;
        private TextBox textAddress;
        private Label label4;
    }
}
