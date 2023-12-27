namespace LawyerAssistant
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            txttel = new MaskedTextBox();
            button1 = new Button();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            txtaddr = new TextBox();
            txtname = new TextBox();
            tabPage2 = new TabPage();
            txtphone2 = new MaskedTextBox();
            namebox = new ComboBox();
            button2 = new Button();
            label5 = new Label();
            label6 = new Label();
            label8 = new Label();
            txtadd2 = new TextBox();
            tabPage3 = new TabPage();
            txttel3 = new MaskedTextBox();
            namebox3 = new ComboBox();
            button3 = new Button();
            label9 = new Label();
            label10 = new Label();
            label12 = new Label();
            txtadd3 = new TextBox();
            pictureBox1 = new PictureBox();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tabControl1.Location = new Point(1, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(551, 442);
            tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(txttel);
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(txtaddr);
            tabPage1.Controls.Add(txtname);
            tabPage1.Location = new Point(4, 37);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(543, 401);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "ADD";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // txttel
            // 
            txttel.HidePromptOnLeave = true;
            txttel.Location = new Point(109, 206);
            txttel.Mask = "00000000000";
            txttel.Name = "txttel";
            txttel.Size = new Size(256, 34);
            txttel.TabIndex = 10;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 2;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.DarkRed;
            button1.Location = new Point(246, 266);
            button1.Name = "button1";
            button1.Size = new Size(117, 39);
            button1.TabIndex = 8;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.DarkRed;
            label4.Location = new Point(9, 212);
            label4.Name = "label4";
            label4.Size = new Size(67, 28);
            label4.TabIndex = 7;
            label4.Text = "Phone";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.DarkRed;
            label3.Location = new Point(6, 113);
            label3.Name = "label3";
            label3.Size = new Size(82, 28);
            label3.TabIndex = 6;
            label3.Text = "Address";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.DarkRed;
            label1.Location = new Point(9, 26);
            label1.Name = "label1";
            label1.Size = new Size(64, 28);
            label1.TabIndex = 4;
            label1.Text = "Name";
            // 
            // txtaddr
            // 
            txtaddr.Location = new Point(109, 110);
            txtaddr.Name = "txtaddr";
            txtaddr.Size = new Size(254, 34);
            txtaddr.TabIndex = 2;
            // 
            // txtname
            // 
            txtname.Location = new Point(109, 23);
            txtname.Name = "txtname";
            txtname.Size = new Size(254, 34);
            txtname.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(txtphone2);
            tabPage2.Controls.Add(namebox);
            tabPage2.Controls.Add(button2);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(label8);
            tabPage2.Controls.Add(txtadd2);
            tabPage2.Location = new Point(4, 37);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(543, 401);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "EDIT";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtphone2
            // 
            txtphone2.HidePromptOnLeave = true;
            txtphone2.Location = new Point(128, 195);
            txtphone2.Mask = "00000000000";
            txtphone2.Name = "txtphone2";
            txtphone2.Size = new Size(245, 34);
            txtphone2.TabIndex = 19;
            // 
            // namebox
            // 
            namebox.FormattingEnabled = true;
            namebox.Location = new Point(128, 23);
            namebox.Name = "namebox";
            namebox.Size = new Size(245, 36);
            namebox.TabIndex = 18;
            namebox.SelectedIndexChanged += namebox_SelectedIndexChanged;
            // 
            // button2
            // 
            button2.Location = new Point(279, 257);
            button2.Name = "button2";
            button2.Size = new Size(94, 38);
            button2.TabIndex = 17;
            button2.Text = "Update";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(22, 201);
            label5.Name = "label5";
            label5.Size = new Size(71, 28);
            label5.TabIndex = 16;
            label5.Text = "Phone:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(19, 114);
            label6.Name = "label6";
            label6.Size = new Size(86, 28);
            label6.TabIndex = 15;
            label6.Text = "Address:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(22, 29);
            label8.Name = "label8";
            label8.Size = new Size(68, 28);
            label8.TabIndex = 13;
            label8.Text = "Name:";
            // 
            // txtadd2
            // 
            txtadd2.Location = new Point(128, 108);
            txtadd2.Name = "txtadd2";
            txtadd2.Size = new Size(245, 34);
            txtadd2.TabIndex = 11;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(txttel3);
            tabPage3.Controls.Add(namebox3);
            tabPage3.Controls.Add(button3);
            tabPage3.Controls.Add(label9);
            tabPage3.Controls.Add(label10);
            tabPage3.Controls.Add(label12);
            tabPage3.Controls.Add(txtadd3);
            tabPage3.Location = new Point(4, 37);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(543, 401);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "DELETE";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // txttel3
            // 
            txttel3.HidePromptOnLeave = true;
            txttel3.Location = new Point(112, 200);
            txttel3.Mask = "00000000000";
            txttel3.Name = "txttel3";
            txttel3.Size = new Size(256, 34);
            txttel3.TabIndex = 20;
            // 
            // namebox3
            // 
            namebox3.FormattingEnabled = true;
            namebox3.Location = new Point(112, 28);
            namebox3.Name = "namebox3";
            namebox3.Size = new Size(254, 36);
            namebox3.TabIndex = 19;
            namebox3.SelectedIndexChanged += namebox3_SelectedIndexChanged;
            // 
            // button3
            // 
            button3.Location = new Point(272, 265);
            button3.Name = "button3";
            button3.Size = new Size(94, 46);
            button3.TabIndex = 17;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(15, 206);
            label9.Name = "label9";
            label9.Size = new Size(67, 28);
            label9.TabIndex = 16;
            label9.Text = "Phone";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(12, 113);
            label10.Name = "label10";
            label10.Size = new Size(82, 28);
            label10.TabIndex = 15;
            label10.Text = "Address";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(15, 27);
            label12.Name = "label12";
            label12.Size = new Size(64, 28);
            label12.TabIndex = 13;
            label12.Text = "Name";
            // 
            // txtadd3
            // 
            txtadd3.Location = new Point(112, 114);
            txtadd3.Name = "txtadd3";
            txtadd3.Size = new Size(254, 34);
            txtadd3.TabIndex = 11;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(592, 60);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(315, 362);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(920, 462);
            Controls.Add(pictureBox1);
            Controls.Add(tabControl1);
            MaximizeBox = false;
            Name = "Form3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "opponents";
            FormClosing += Form3_FormClosing;
            Load += Form3_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private Button button1;
        private Label label4;
        private Label label3;
        private Label label1;
        private TextBox txtaddr;
        private TextBox txtname;
        private TabPage tabPage2;
        private ComboBox namebox;
        private Button button2;
        private Label label5;
        private Label label6;
        private Label label8;
        private TextBox txtadd2;
        private TabPage tabPage3;
        private ComboBox namebox3;
        private Button button3;
        private Label label9;
        private Label label10;
        private Label label12;
        private TextBox txtadd3;
        private MaskedTextBox txttel;
        private MaskedTextBox txtphone2;
        private MaskedTextBox txttel3;
        private PictureBox pictureBox1;
    }
}