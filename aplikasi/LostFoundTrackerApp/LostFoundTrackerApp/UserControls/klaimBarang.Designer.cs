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
            dateTimeClaim = new DateTimePicker();
            label5 = new Label();
            textClaimContact = new TextBox();
            label4 = new Label();
            textClaimName = new TextBox();
            label3 = new Label();
            textDescBukti = new TextBox();
            label2 = new Label();
            textID = new TextBox();
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
            button1.Click += button1_Click;
            // 
            // dateTimeClaim
            // 
            dateTimeClaim.Location = new Point(42, 363);
            dateTimeClaim.Name = "dateTimeClaim";
            dateTimeClaim.Size = new Size(250, 27);
            dateTimeClaim.TabIndex = 20;
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
            // textClaimContact
            // 
            textClaimContact.Location = new Point(42, 289);
            textClaimContact.Name = "textClaimContact";
            textClaimContact.Size = new Size(617, 27);
            textClaimContact.TabIndex = 18;
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
            // textClaimName
            // 
            textClaimName.Location = new Point(42, 214);
            textClaimName.Name = "textClaimName";
            textClaimName.Size = new Size(617, 27);
            textClaimName.TabIndex = 16;
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
            // textDescBukti
            // 
            textDescBukti.Location = new Point(42, 142);
            textDescBukti.Name = "textDescBukti";
            textDescBukti.Size = new Size(617, 27);
            textDescBukti.TabIndex = 14;
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
            // textID
            // 
            textID.Location = new Point(42, 71);
            textID.Name = "textID";
            textID.Size = new Size(617, 27);
            textID.TabIndex = 12;
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
            Controls.Add(dateTimeClaim);
            Controls.Add(label5);
            Controls.Add(textClaimContact);
            Controls.Add(label4);
            Controls.Add(textClaimName);
            Controls.Add(label3);
            Controls.Add(textDescBukti);
            Controls.Add(label2);
            Controls.Add(textID);
            Controls.Add(label1);
            Name = "klaimBarang";
            Size = new Size(700, 446);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private DateTimePicker dateTimeClaim;
        private Label label5;
        private TextBox textClaimContact;
        private Label label4;
        private TextBox textClaimName;
        private Label label3;
        private TextBox textDescBukti;
        private Label label2;
        private TextBox textID;
        private Label label1;
    }
}
