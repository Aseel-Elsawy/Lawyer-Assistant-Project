namespace LawyerAssistant
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            dataGridView1 = new DataGridView();
            client = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            caeNo = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            dataGridView2 = new DataGridView();
            Column2 = new DataGridViewTextBoxColumn();
            date = new DataGridViewTextBoxColumn();
            court = new DataGridViewTextBoxColumn();
            clientbox = new ComboBox();
            casenobx = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { client, dataGridViewTextBoxColumn1, caeNo, Column1 });
            dataGridView1.Location = new Point(128, 71);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(781, 214);
            dataGridView1.TabIndex = 0;
            // 
            // client
            // 
            client.HeaderText = "client name";
            client.MinimumWidth = 6;
            client.Name = "client";
            client.Width = 125;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "subject";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.Width = 125;
            // 
            // caeNo
            // 
            caeNo.HeaderText = "auhtorization number";
            caeNo.MinimumWidth = 6;
            caeNo.Name = "caeNo";
            caeNo.Width = 125;
            // 
            // Column1
            // 
            Column1.HeaderText = "cort name";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 125;
            // 
            // dataGridView2
            // 
            dataGridView2.BackgroundColor = Color.White;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { Column2, date, court });
            dataGridView2.Location = new Point(128, 317);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.RowTemplate.Height = 29;
            dataGridView2.Size = new Size(781, 227);
            dataGridView2.TabIndex = 1;
            // 
            // Column2
            // 
            Column2.HeaderText = "date";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 125;
            // 
            // date
            // 
            date.HeaderText = "decisions";
            date.MinimumWidth = 6;
            date.Name = "date";
            date.Width = 125;
            // 
            // court
            // 
            court.HeaderText = "demands";
            court.MinimumWidth = 6;
            court.Name = "court";
            court.Width = 125;
            // 
            // clientbox
            // 
            clientbox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            clientbox.FormattingEnabled = true;
            clientbox.Location = new Point(257, 12);
            clientbox.Name = "clientbox";
            clientbox.Size = new Size(259, 36);
            clientbox.TabIndex = 2;
            clientbox.SelectedIndexChanged += clientbox_SelectedIndexChanged;
            // 
            // casenobx
            // 
            casenobx.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            casenobx.FormattingEnabled = true;
            casenobx.Location = new Point(703, 12);
            casenobx.Name = "casenobx";
            casenobx.Size = new Size(206, 36);
            casenobx.TabIndex = 3;
            casenobx.SelectedIndexChanged += casenobx_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkRed;
            label1.Location = new Point(128, 12);
            label1.Name = "label1";
            label1.Size = new Size(123, 28);
            label1.TabIndex = 4;
            label1.Text = "Client Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.DarkRed;
            label2.Location = new Point(600, 15);
            label2.Name = "label2";
            label2.Size = new Size(88, 28);
            label2.TabIndex = 5;
            label2.Text = "Case No:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.DarkRed;
            label3.Location = new Point(12, 123);
            label3.Name = "label3";
            label3.Size = new Size(87, 38);
            label3.TabIndex = 6;
            label3.Text = "Cases";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.DarkRed;
            label4.Location = new Point(3, 394);
            label4.Name = "label4";
            label4.Size = new Size(122, 38);
            label4.TabIndex = 7;
            label4.Text = "Sessions";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(935, 89);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(302, 438);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1318, 571);
            Controls.Add(pictureBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(casenobx);
            Controls.Add(clientbox);
            Controls.Add(dataGridView2);
            Controls.Add(dataGridView1);
            MaximizeBox = false;
            Name = "Form5";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form5";
            FormClosing += Form5_FormClosing;
            Load += Form5_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private ComboBox clientbox;
        private ComboBox casenobx;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private DataGridViewTextBoxColumn client;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn caeNo;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn date;
        private DataGridViewTextBoxColumn court;
        private PictureBox pictureBox1;
    }
}