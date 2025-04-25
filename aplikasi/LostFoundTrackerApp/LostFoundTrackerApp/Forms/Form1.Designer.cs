namespace LostFoundTrackerApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            closeLogin = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            checkBox1 = new CheckBox();
            button1 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)closeLogin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 186, 46);
            panel1.Controls.Add(closeLogin);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(856, 97);
            panel1.TabIndex = 0;
            // 
            // closeLogin
            // 
            closeLogin.Image = (Image)resources.GetObject("closeLogin.Image");
            closeLogin.Location = new Point(793, 33);
            closeLogin.Name = "closeLogin";
            closeLogin.Size = new Size(32, 31);
            closeLogin.SizeMode = PictureBoxSizeMode.Zoom;
            closeLogin.TabIndex = 2;
            closeLogin.TabStop = false;
            closeLogin.Click += closeLogin_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(100, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(173, 75);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(36, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(58, 75);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Audiowide", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(236, 110);
            label1.Name = "label1";
            label1.Size = new Size(392, 48);
            label1.TabIndex = 1;
            label1.Text = "Please Login First";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(236, 231);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(392, 27);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(236, 301);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(392, 27);
            textBox2.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Offside", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(236, 208);
            label2.Name = "label2";
            label2.Size = new Size(88, 20);
            label2.TabIndex = 4;
            label2.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Offside", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(236, 278);
            label3.Name = "label3";
            label3.Size = new Size(86, 20);
            label3.TabIndex = 5;
            label3.Text = "Password";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Offside", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBox1.Location = new Point(361, 345);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(132, 21);
            checkBox1.TabIndex = 7;
            checkBox1.Text = "Remember Me?";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 186, 46);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Audiowide", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(236, 384);
            button1.Name = "button1";
            button1.Size = new Size(392, 51);
            button1.TabIndex = 8;
            button1.Text = "LOGIN";
            button1.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(856, 484);
            Controls.Add(button1);
            Controls.Add(checkBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lost & Found Tracker";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)closeLogin).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label2;
        private Label label3;
        private CheckBox checkBox1;
        private Button button1;
        private PictureBox closeLogin;
    }
}
