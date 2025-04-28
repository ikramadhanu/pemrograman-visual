namespace LostFoundTrackerApp.UserControls
{
    partial class inputBarang
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
            label1 = new Label();
            textName = new TextBox();
            textDesc = new TextBox();
            label2 = new Label();
            textLocation = new TextBox();
            label3 = new Label();
            textFounder = new TextBox();
            label4 = new Label();
            label5 = new Label();
            dateTimePickerFound = new DateTimePicker();
            buttonSave = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Audiowide", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(31, 23);
            label1.Name = "label1";
            label1.Size = new Size(126, 26);
            label1.TabIndex = 0;
            label1.Text = "Nama Item";
            // 
            // textName
            // 
            textName.Location = new Point(31, 55);
            textName.Name = "textName";
            textName.Size = new Size(617, 27);
            textName.TabIndex = 1;
            // 
            // textDesc
            // 
            textDesc.Location = new Point(31, 126);
            textDesc.Name = "textDesc";
            textDesc.Size = new Size(617, 27);
            textDesc.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Audiowide", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(31, 94);
            label2.Name = "label2";
            label2.Size = new Size(168, 26);
            label2.TabIndex = 2;
            label2.Text = "Deskripsi Item";
            // 
            // textLocation
            // 
            textLocation.Location = new Point(31, 198);
            textLocation.Name = "textLocation";
            textLocation.Size = new Size(617, 27);
            textLocation.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Audiowide", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(31, 166);
            label3.Name = "label3";
            label3.Size = new Size(206, 26);
            label3.TabIndex = 4;
            label3.Text = "Lokasi Penemuan";
            // 
            // textFounder
            // 
            textFounder.Location = new Point(31, 273);
            textFounder.Name = "textFounder";
            textFounder.Size = new Size(617, 27);
            textFounder.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Audiowide", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(31, 241);
            label4.Name = "label4";
            label4.Size = new Size(166, 26);
            label4.TabIndex = 6;
            label4.Text = "Nama Penemu";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Audiowide", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(31, 318);
            label5.Name = "label5";
            label5.Size = new Size(220, 26);
            label5.TabIndex = 8;
            label5.Text = "Tanggal Penemuan";
            // 
            // dateTimePickerFound
            // 
            dateTimePickerFound.Location = new Point(31, 347);
            dateTimePickerFound.Name = "dateTimePickerFound";
            dateTimePickerFound.Size = new Size(250, 27);
            dateTimePickerFound.TabIndex = 9;
            // 
            // buttonSave
            // 
            buttonSave.BackColor = Color.FromArgb(255, 186, 46);
            buttonSave.BackgroundImageLayout = ImageLayout.None;
            buttonSave.Font = new Font("Audiowide", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonSave.Location = new Point(515, 347);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(133, 44);
            buttonSave.TabIndex = 10;
            buttonSave.Text = "SAVE";
            buttonSave.UseVisualStyleBackColor = false;
            buttonSave.Click += buttonSave_Click;
            // 
            // inputBarang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(buttonSave);
            Controls.Add(dateTimePickerFound);
            Controls.Add(label5);
            Controls.Add(textFounder);
            Controls.Add(label4);
            Controls.Add(textLocation);
            Controls.Add(label3);
            Controls.Add(textDesc);
            Controls.Add(label2);
            Controls.Add(textName);
            Controls.Add(label1);
            Name = "inputBarang";
            Size = new Size(700, 446);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textName;
        private TextBox textDesc;
        private Label label2;
        private TextBox textLocation;
        private Label label3;
        private TextBox textFounder;
        private Label label4;
        private Label label5;
        private DateTimePicker dateTimePickerFound;
        private Button buttonSave;
    }
}
