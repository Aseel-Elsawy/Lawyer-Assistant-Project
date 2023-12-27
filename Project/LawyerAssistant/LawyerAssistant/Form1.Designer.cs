namespace LawyerAssistant
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            label3 = new Label();
            mangpass = new TextBox();
            label2 = new Label();
            label1 = new Label();
            button1 = new Button();
            nametxt = new TextBox();
            passwordtxt = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(495, 112);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(280, 300);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.DarkRed;
            label3.Location = new Point(66, 117);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(180, 28);
            label3.TabIndex = 19;
            label3.Text = "Manager Password:";
            // 
            // mangpass
            // 
            mangpass.Location = new Point(272, 112);
            mangpass.Margin = new Padding(4);
            mangpass.Name = "mangpass";
            mangpass.PasswordChar = '*';
            mangpass.Size = new Size(170, 34);
            mangpass.TabIndex = 18;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.DarkRed;
            label2.Location = new Point(66, 275);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(97, 28);
            label2.TabIndex = 17;
            label2.Text = "Password:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.DarkRed;
            label1.Location = new Point(66, 195);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(68, 28);
            label1.TabIndex = 16;
            label1.Text = "Name:";
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 2;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.DarkRed;
            button1.Location = new Point(315, 371);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(129, 41);
            button1.TabIndex = 15;
            button1.Text = "Add user";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // nametxt
            // 
            nametxt.Location = new Point(272, 192);
            nametxt.Margin = new Padding(4);
            nametxt.Name = "nametxt";
            nametxt.Size = new Size(170, 34);
            nametxt.TabIndex = 14;
            // 
            // passwordtxt
            // 
            passwordtxt.Location = new Point(272, 269);
            passwordtxt.Margin = new Padding(4);
            passwordtxt.Name = "passwordtxt";
            passwordtxt.Size = new Size(170, 34);
            passwordtxt.TabIndex = 13;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(868, 480);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            Controls.Add(mangpass);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(nametxt);
            Controls.Add(passwordtxt);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add user";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label3;
        private TextBox mangpass;
        private Label label2;
        private Label label1;
        private Button button1;
        private TextBox nametxt;
        private TextBox passwordtxt;
    }
}