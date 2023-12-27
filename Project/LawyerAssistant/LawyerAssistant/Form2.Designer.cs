namespace LawyerAssistant
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            txttel = new MaskedTextBox();
            txtid = new MaskedTextBox();
            button1 = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtaddr = new TextBox();
            txtname = new TextBox();
            tabPage2 = new TabPage();
            txtphone2 = new MaskedTextBox();
            txtid1 = new MaskedTextBox();
            namebox = new ComboBox();
            button2 = new Button();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            txtadd2 = new TextBox();
            tabPage3 = new TabPage();
            txttel3 = new MaskedTextBox();
            txtid3 = new MaskedTextBox();
            namebox3 = new ComboBox();
            button3 = new Button();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
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
            tabControl1.Location = new Point(0, 1);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(527, 482);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(txttel);
            tabPage1.Controls.Add(txtid);
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(txtaddr);
            tabPage1.Controls.Add(txtname);
            tabPage1.Location = new Point(4, 37);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(519, 441);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "ADD";
            tabPage1.UseVisualStyleBackColor = true;
            tabPage1.Click += tabPage1_Click;
            // 
            // txttel
            // 
            txttel.HidePromptOnLeave = true;
            txttel.Location = new Point(114, 260);
            txttel.Mask = "000000000000";
            txttel.Name = "txttel";
            txttel.Size = new Size(256, 34);
            txttel.TabIndex = 10;
            // 
            // txtid
            // 
            txtid.HidePromptOnLeave = true;
            txtid.Location = new Point(114, 112);
            txtid.Mask = "0000000000000000";
            txtid.Name = "txtid";
            txtid.Size = new Size(256, 34);
            txtid.TabIndex = 9;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.FlatAppearance.BorderSize = 2;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.DarkRed;
            button1.Location = new Point(245, 359);
            button1.Name = "button1";
            button1.Size = new Size(125, 41);
            button1.TabIndex = 8;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.DarkRed;
            label4.Location = new Point(6, 263);
            label4.Name = "label4";
            label4.Size = new Size(83, 31);
            label4.TabIndex = 7;
            label4.Text = "Phone:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.DarkRed;
            label3.Location = new Point(6, 186);
            label3.Name = "label3";
            label3.Size = new Size(102, 31);
            label3.TabIndex = 6;
            label3.Text = "Address:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.DarkRed;
            label2.Location = new Point(9, 104);
            label2.Name = "label2";
            label2.Size = new Size(41, 31);
            label2.TabIndex = 5;
            label2.Text = "ID:";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkRed;
            label1.Location = new Point(6, 23);
            label1.Name = "label1";
            label1.Size = new Size(80, 31);
            label1.TabIndex = 4;
            label1.Text = "Name:";
            // 
            // txtaddr
            // 
            txtaddr.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtaddr.Location = new Point(114, 179);
            txtaddr.Name = "txtaddr";
            txtaddr.Size = new Size(256, 38);
            txtaddr.TabIndex = 2;
            // 
            // txtname
            // 
            txtname.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtname.Location = new Point(114, 23);
            txtname.Name = "txtname";
            txtname.Size = new Size(256, 38);
            txtname.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(txtphone2);
            tabPage2.Controls.Add(txtid1);
            tabPage2.Controls.Add(namebox);
            tabPage2.Controls.Add(button2);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(label8);
            tabPage2.Controls.Add(txtadd2);
            tabPage2.Location = new Point(4, 37);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(519, 441);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "EDIT";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtphone2
            // 
            txtphone2.HidePromptOnLeave = true;
            txtphone2.Location = new Point(126, 264);
            txtphone2.Mask = "0000000000000000";
            txtphone2.Name = "txtphone2";
            txtphone2.Size = new Size(256, 34);
            txtphone2.TabIndex = 20;
            // 
            // txtid1
            // 
            txtid1.HidePromptOnLeave = true;
            txtid1.Location = new Point(127, 102);
            txtid1.Mask = "0000000000000000";
            txtid1.Name = "txtid1";
            txtid1.Size = new Size(256, 34);
            txtid1.TabIndex = 19;
            // 
            // namebox
            // 
            namebox.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            namebox.FormattingEnabled = true;
            namebox.Location = new Point(126, 16);
            namebox.Name = "namebox";
            namebox.Size = new Size(257, 39);
            namebox.TabIndex = 18;
            namebox.SelectedIndexChanged += namebox_SelectedIndexChanged;
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.FlatAppearance.BorderSize = 2;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.DarkRed;
            button2.Location = new Point(259, 339);
            button2.Name = "button2";
            button2.Size = new Size(124, 48);
            button2.TabIndex = 17;
            button2.Text = "Update";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.DarkRed;
            label5.Location = new Point(15, 267);
            label5.Name = "label5";
            label5.Size = new Size(83, 31);
            label5.TabIndex = 16;
            label5.Text = "Phone:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.DarkRed;
            label6.Location = new Point(12, 178);
            label6.Name = "label6";
            label6.Size = new Size(102, 31);
            label6.TabIndex = 15;
            label6.Text = "Address:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.DarkRed;
            label7.Location = new Point(15, 102);
            label7.Name = "label7";
            label7.Size = new Size(41, 31);
            label7.TabIndex = 14;
            label7.Text = "ID:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.DarkRed;
            label8.Location = new Point(16, 21);
            label8.Name = "label8";
            label8.Size = new Size(80, 31);
            label8.TabIndex = 13;
            label8.Text = "Name:";
            // 
            // txtadd2
            // 
            txtadd2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtadd2.Location = new Point(126, 181);
            txtadd2.Name = "txtadd2";
            txtadd2.Size = new Size(257, 38);
            txtadd2.TabIndex = 11;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(txttel3);
            tabPage3.Controls.Add(txtid3);
            tabPage3.Controls.Add(namebox3);
            tabPage3.Controls.Add(button3);
            tabPage3.Controls.Add(label9);
            tabPage3.Controls.Add(label10);
            tabPage3.Controls.Add(label11);
            tabPage3.Controls.Add(label12);
            tabPage3.Controls.Add(txtadd3);
            tabPage3.Location = new Point(4, 37);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(519, 441);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "DELETE";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // txttel3
            // 
            txttel3.HidePromptOnLeave = true;
            txttel3.Location = new Point(127, 288);
            txttel3.Mask = "0000000000000000";
            txttel3.Name = "txttel3";
            txttel3.Size = new Size(261, 34);
            txttel3.TabIndex = 21;
            // 
            // txtid3
            // 
            txtid3.HidePromptOnLeave = true;
            txtid3.Location = new Point(127, 113);
            txtid3.Mask = "0000000000000000";
            txtid3.Name = "txtid3";
            txtid3.Size = new Size(261, 34);
            txtid3.TabIndex = 20;
            // 
            // namebox3
            // 
            namebox3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            namebox3.FormattingEnabled = true;
            namebox3.Location = new Point(127, 27);
            namebox3.Name = "namebox3";
            namebox3.Size = new Size(261, 39);
            namebox3.TabIndex = 19;
            namebox3.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // button3
            // 
            button3.BackColor = Color.White;
            button3.FlatAppearance.BorderSize = 2;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = Color.DarkRed;
            button3.Location = new Point(271, 363);
            button3.Name = "button3";
            button3.Size = new Size(126, 41);
            button3.TabIndex = 17;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.DarkRed;
            label9.Location = new Point(12, 291);
            label9.Name = "label9";
            label9.Size = new Size(83, 31);
            label9.TabIndex = 16;
            label9.Text = "Phone:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = Color.DarkRed;
            label10.Location = new Point(6, 200);
            label10.Name = "label10";
            label10.Size = new Size(102, 31);
            label10.TabIndex = 15;
            label10.Text = "Address:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label11.ForeColor = Color.DarkRed;
            label11.Location = new Point(12, 113);
            label11.Name = "label11";
            label11.Size = new Size(41, 31);
            label11.TabIndex = 14;
            label11.Text = "ID:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label12.ForeColor = Color.DarkRed;
            label12.Location = new Point(12, 27);
            label12.Name = "label12";
            label12.Size = new Size(80, 31);
            label12.TabIndex = 13;
            label12.Text = "Name:";
            // 
            // txtadd3
            // 
            txtadd3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtadd3.Location = new Point(127, 193);
            txtadd3.Name = "txtadd3";
            txtadd3.Size = new Size(261, 38);
            txtadd3.TabIndex = 11;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(533, 88);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(297, 329);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 21;
            pictureBox1.TabStop = false;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(847, 514);
            Controls.Add(pictureBox1);
            Controls.Add(tabControl1);
            MaximizeBox = false;
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "clients";
            Activated += Form2_Activated;
            FormClosing += Form2_FormClosing;
            Load += Form2_Load;
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
        private Label label2;
        private Label label1;
        private TextBox txtaddr;
        private TextBox txtname;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private Button button2;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox txtadd2;
        private Button button3;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private TextBox txtadd3;
        private ComboBox namebox;
        private ComboBox namebox3;
        private MaskedTextBox txtid;
        private MaskedTextBox txtid1;
        private MaskedTextBox txtid3;
        private MaskedTextBox txttel;
        private MaskedTextBox txtphone2;
        private MaskedTextBox txttel3;
        private PictureBox pictureBox1;
    }
}