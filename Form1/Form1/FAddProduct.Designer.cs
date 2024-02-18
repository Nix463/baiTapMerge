namespace Form1
{
    partial class FAddProduct
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
            dgvDang = new DataGridView();
            lblName = new Label();
            txtName = new TextBox();
            lblCondition = new Label();
            lblPhone = new Label();
            txtPhone = new TextBox();
            lblEmail = new Label();
            txtEmail = new TextBox();
            cbbCondition = new ComboBox();
            lblDay = new Label();
            dtpDay = new DateTimePicker();
            btnPost = new Button();
            lbldescribe = new Label();
            txtDescibe = new TextBox();
            btnFix = new Button();
            btnDelete = new Button();
            openFileDialog1 = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)dgvDang).BeginInit();
            SuspendLayout();
            // 
            // dgvDang
            // 
            dgvDang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDang.Location = new Point(627, 12);
            dgvDang.Name = "dgvDang";
            dgvDang.RowHeadersWidth = 62;
            dgvDang.Size = new Size(718, 426);
            dgvDang.TabIndex = 0;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(30, 93);
            lblName.Name = "lblName";
            lblName.Size = new Size(59, 25);
            lblName.TabIndex = 1;
            lblName.Text = "Name";
            // 
            // txtName
            // 
            txtName.Location = new Point(188, 87);
            txtName.Name = "txtName";
            txtName.Size = new Size(185, 31);
            txtName.TabIndex = 2;
            // 
            // lblCondition
            // 
            lblCondition.AutoSize = true;
            lblCondition.Location = new Point(30, 175);
            lblCondition.Name = "lblCondition";
            lblCondition.Size = new Size(90, 25);
            lblCondition.TabIndex = 1;
            lblCondition.Text = "Condition";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Location = new Point(30, 451);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(132, 25);
            lblPhone.TabIndex = 1;
            lblPhone.Text = "Phone Number";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(188, 445);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(150, 31);
            txtPhone.TabIndex = 2;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(30, 383);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(54, 25);
            lblEmail.TabIndex = 1;
            lblEmail.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(188, 380);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(304, 31);
            txtEmail.TabIndex = 2;
            // 
            // cbbCondition
            // 
            cbbCondition.FormattingEnabled = true;
            cbbCondition.Items.AddRange(new object[] { "Moi", "Cu" });
            cbbCondition.Location = new Point(188, 167);
            cbbCondition.Name = "cbbCondition";
            cbbCondition.Size = new Size(96, 33);
            cbbCondition.TabIndex = 3;
            // 
            // lblDay
            // 
            lblDay.AutoSize = true;
            lblDay.Location = new Point(30, 308);
            lblDay.Name = "lblDay";
            lblDay.Size = new Size(49, 25);
            lblDay.TabIndex = 4;
            lblDay.Text = "Date";
            // 
            // dtpDay
            // 
            dtpDay.Location = new Point(188, 302);
            dtpDay.Name = "dtpDay";
            dtpDay.Size = new Size(185, 31);
            dtpDay.TabIndex = 5;
            // 
            // btnPost
            // 
            btnPost.Location = new Point(655, 477);
            btnPost.Name = "btnPost";
            btnPost.Size = new Size(112, 34);
            btnPost.TabIndex = 6;
            btnPost.Text = "Add";
            btnPost.UseVisualStyleBackColor = true;
            btnPost.Click += btnPost_Click_1;
            // 
            // lbldescribe
            // 
            lbldescribe.AutoSize = true;
            lbldescribe.Location = new Point(30, 243);
            lbldescribe.Name = "lbldescribe";
            lbldescribe.Size = new Size(80, 25);
            lbldescribe.TabIndex = 7;
            lbldescribe.Text = "Describe";
            // 
            // txtDescibe
            // 
            txtDescibe.Location = new Point(188, 237);
            txtDescibe.Name = "txtDescibe";
            txtDescibe.Size = new Size(185, 31);
            txtDescibe.TabIndex = 8;
            // 
            // btnFix
            // 
            btnFix.Location = new Point(807, 477);
            btnFix.Name = "btnFix";
            btnFix.Size = new Size(112, 34);
            btnFix.TabIndex = 6;
            btnFix.Text = "Edit";
            btnFix.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(968, 477);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(112, 34);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "Reset";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // FAddProduct
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1357, 609);
            Controls.Add(txtDescibe);
            Controls.Add(lbldescribe);
            Controls.Add(btnDelete);
            Controls.Add(btnFix);
            Controls.Add(btnPost);
            Controls.Add(dtpDay);
            Controls.Add(lblDay);
            Controls.Add(cbbCondition);
            Controls.Add(txtEmail);
            Controls.Add(txtPhone);
            Controls.Add(txtName);
            Controls.Add(lblEmail);
            Controls.Add(lblPhone);
            Controls.Add(lblCondition);
            Controls.Add(lblName);
            Controls.Add(dgvDang);
            Name = "FAddProduct";
            Text = "FDangDo";
            Load += FAddProduct_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDang).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvDang;
        private Label lblName;
        private TextBox txtName;
        private Label lblCondition;
        private Label lblPhone;
        private TextBox txtPhone;
        private Label lblEmail;
        private TextBox txtEmail;
        private ComboBox cbbCondition;
        private Label lblDay;
        private DateTimePicker dtpDay;
        private Button btnPost;
        private Label lbldescribe;
        private TextBox txtDescibe;
        private Button btnFix;
        private Button btnDelete;
        private OpenFileDialog openFileDialog1;
    }
}
