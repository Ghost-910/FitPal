namespace fitpal
{
    partial class LoginForm
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
            pnlHeader = new Panel();
            lblTitle = new Label();
            lblSubtitle = new Label();
            label3 = new Label();
            tabControl = new TabControl();
            tabPage1 = new TabPage();
            btnLogin = new Button();
            lblLoginError = new Label();
            txtLoginPass = new TextBox();
            lblLoginPass = new Label();
            txtLoginUser = new TextBox();
            lblLoginUser = new Label();
            tabPage2 = new TabPage();
            pnlRegScroll = new Panel();
            btnRegister = new Button();
            lblRegError = new Label();
            cmbRegGoal = new ComboBox();
            lblRegGoal = new Label();
            nudRegHeight = new NumericUpDown();
            lblRegHeight = new Label();
            nudRegWeight = new NumericUpDown();
            lblRegWeight = new Label();
            cmbRegGender = new ComboBox();
            lblRegGender = new Label();
            nudRegAge = new NumericUpDown();
            lblRegAge = new Label();
            txtRegName = new TextBox();
            lblRegName = new Label();
            txtRegPass = new TextBox();
            lblRegPass = new Label();
            txtRegUser = new TextBox();
            lblRegUser = new Label();
            pnlHeader.SuspendLayout();
            tabControl.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            pnlRegScroll.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudRegHeight).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudRegWeight).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudRegAge).BeginInit();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(517, 125);
            pnlHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.Teal;
            lblTitle.Location = new Point(20, 18);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(177, 62);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "FITPAL";
            lblTitle.Click += label1_Click;
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSubtitle.ForeColor = Color.LightGray;
            lblSubtitle.Location = new Point(22, 70);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(330, 23);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Your Personal Fitness and Nutrition Coach";
            lblSubtitle.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(0, 20);
            label3.TabIndex = 2;
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tabPage1);
            tabControl.Controls.Add(tabPage2);
            tabControl.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tabControl.ItemSize = new Size(215, 36);
            tabControl.Location = new Point(20, 120);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(462, 510);
            tabControl.TabIndex = 3;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.FromArgb(25, 32, 50);
            tabPage1.Controls.Add(btnLogin);
            tabPage1.Controls.Add(lblLoginError);
            tabPage1.Controls.Add(txtLoginPass);
            tabPage1.Controls.Add(lblLoginPass);
            tabPage1.Controls.Add(txtLoginUser);
            tabPage1.Controls.Add(lblLoginUser);
            tabPage1.Location = new Point(4, 40);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(454, 466);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Login";
            tabPage1.Click += tabPage1_Click;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Teal;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(30, 200);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(380, 44);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "LOGIN";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // lblLoginError
            // 
            lblLoginError.AutoSize = true;
            lblLoginError.ForeColor = Color.Red;
            lblLoginError.Location = new Point(30, 172);
            lblLoginError.Name = "lblLoginError";
            lblLoginError.Size = new Size(70, 23);
            lblLoginError.TabIndex = 4;
            lblLoginError.Text = "            ";
            // 
            // txtLoginPass
            // 
            txtLoginPass.BackColor = Color.FromArgb(35, 45, 65);
            txtLoginPass.Location = new Point(30, 132);
            txtLoginPass.Name = "txtLoginPass";
            txtLoginPass.Size = new Size(380, 30);
            txtLoginPass.TabIndex = 3;
            txtLoginPass.UseSystemPasswordChar = true;
            // 
            // lblLoginPass
            // 
            lblLoginPass.AutoSize = true;
            lblLoginPass.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLoginPass.ForeColor = Color.LightGray;
            lblLoginPass.Location = new Point(30, 110);
            lblLoginPass.Name = "lblLoginPass";
            lblLoginPass.Size = new Size(76, 20);
            lblLoginPass.TabIndex = 2;
            lblLoginPass.Text = "Password";
            // 
            // txtLoginUser
            // 
            txtLoginUser.BackColor = Color.FromArgb(35, 45, 65);
            txtLoginUser.ForeColor = Color.White;
            txtLoginUser.Location = new Point(30, 62);
            txtLoginUser.Name = "txtLoginUser";
            txtLoginUser.Size = new Size(380, 30);
            txtLoginUser.TabIndex = 1;
            // 
            // lblLoginUser
            // 
            lblLoginUser.AutoSize = true;
            lblLoginUser.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLoginUser.ForeColor = Color.LightGray;
            lblLoginUser.Location = new Point(30, 40);
            lblLoginUser.Name = "lblLoginUser";
            lblLoginUser.Size = new Size(80, 20);
            lblLoginUser.TabIndex = 0;
            lblLoginUser.Text = "Username";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(pnlRegScroll);
            tabPage2.Location = new Point(4, 40);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(454, 466);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Register";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // pnlRegScroll
            // 
            pnlRegScroll.AutoScroll = true;
            pnlRegScroll.BackColor = Color.FromArgb(25, 32, 50);
            pnlRegScroll.Controls.Add(btnRegister);
            pnlRegScroll.Controls.Add(lblRegError);
            pnlRegScroll.Controls.Add(cmbRegGoal);
            pnlRegScroll.Controls.Add(lblRegGoal);
            pnlRegScroll.Controls.Add(nudRegHeight);
            pnlRegScroll.Controls.Add(lblRegHeight);
            pnlRegScroll.Controls.Add(nudRegWeight);
            pnlRegScroll.Controls.Add(lblRegWeight);
            pnlRegScroll.Controls.Add(cmbRegGender);
            pnlRegScroll.Controls.Add(lblRegGender);
            pnlRegScroll.Controls.Add(nudRegAge);
            pnlRegScroll.Controls.Add(lblRegAge);
            pnlRegScroll.Controls.Add(txtRegName);
            pnlRegScroll.Controls.Add(lblRegName);
            pnlRegScroll.Controls.Add(txtRegPass);
            pnlRegScroll.Controls.Add(lblRegPass);
            pnlRegScroll.Controls.Add(txtRegUser);
            pnlRegScroll.Controls.Add(lblRegUser);
            pnlRegScroll.Dock = DockStyle.Fill;
            pnlRegScroll.Location = new Point(3, 3);
            pnlRegScroll.Name = "pnlRegScroll";
            pnlRegScroll.Size = new Size(448, 460);
            pnlRegScroll.TabIndex = 0;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.Teal;
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegister.Location = new Point(30, 576);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(380, 44);
            btnRegister.TabIndex = 17;
            btnRegister.Text = "CREATE ACCOUNT";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // lblRegError
            // 
            lblRegError.AutoSize = true;
            lblRegError.ForeColor = Color.Red;
            lblRegError.Location = new Point(30, 548);
            lblRegError.Name = "lblRegError";
            lblRegError.Size = new Size(60, 23);
            lblRegError.TabIndex = 16;
            lblRegError.Text = "          ";
            // 
            // cmbRegGoal
            // 
            cmbRegGoal.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRegGoal.FormattingEnabled = true;
            cmbRegGoal.Items.AddRange(new object[] { "Weight Loss", "Maintenance", "Muscle Gain" });
            cmbRegGoal.Location = new Point(30, 504);
            cmbRegGoal.Name = "cmbRegGoal";
            cmbRegGoal.Size = new Size(380, 31);
            cmbRegGoal.TabIndex = 15;
            // 
            // lblRegGoal
            // 
            lblRegGoal.AutoSize = true;
            lblRegGoal.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRegGoal.ForeColor = Color.LightGray;
            lblRegGoal.Location = new Point(30, 482);
            lblRegGoal.Name = "lblRegGoal";
            lblRegGoal.Size = new Size(105, 23);
            lblRegGoal.TabIndex = 14;
            lblRegGoal.Text = "Fitness Goal";
            // 
            // nudRegHeight
            // 
            nudRegHeight.Location = new Point(30, 438);
            nudRegHeight.Maximum = new decimal(new int[] { 250, 0, 0, 0 });
            nudRegHeight.Minimum = new decimal(new int[] { 100, 0, 0, 0 });
            nudRegHeight.Name = "nudRegHeight";
            nudRegHeight.Size = new Size(380, 30);
            nudRegHeight.TabIndex = 13;
            nudRegHeight.Value = new decimal(new int[] { 170, 0, 0, 0 });
            // 
            // lblRegHeight
            // 
            lblRegHeight.AutoSize = true;
            lblRegHeight.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRegHeight.ForeColor = Color.LightGray;
            lblRegHeight.Location = new Point(30, 416);
            lblRegHeight.Name = "lblRegHeight";
            lblRegHeight.Size = new Size(106, 23);
            lblRegHeight.TabIndex = 12;
            lblRegHeight.Text = "Height (cm)";
            // 
            // nudRegWeight
            // 
            nudRegWeight.DecimalPlaces = 1;
            nudRegWeight.Location = new Point(30, 372);
            nudRegWeight.Maximum = new decimal(new int[] { 300, 0, 0, 0 });
            nudRegWeight.Minimum = new decimal(new int[] { 30, 0, 0, 0 });
            nudRegWeight.Name = "nudRegWeight";
            nudRegWeight.Size = new Size(380, 30);
            nudRegWeight.TabIndex = 11;
            nudRegWeight.Value = new decimal(new int[] { 70, 0, 0, 0 });
            // 
            // lblRegWeight
            // 
            lblRegWeight.AutoSize = true;
            lblRegWeight.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRegWeight.ForeColor = Color.LightGray;
            lblRegWeight.Location = new Point(30, 350);
            lblRegWeight.Name = "lblRegWeight";
            lblRegWeight.Size = new Size(107, 23);
            lblRegWeight.TabIndex = 10;
            lblRegWeight.Text = "Weight (kg)";
            // 
            // cmbRegGender
            // 
            cmbRegGender.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRegGender.FormattingEnabled = true;
            cmbRegGender.Items.AddRange(new object[] { "Male", "Female" });
            cmbRegGender.Location = new Point(30, 306);
            cmbRegGender.Name = "cmbRegGender";
            cmbRegGender.Size = new Size(380, 31);
            cmbRegGender.TabIndex = 9;
            // 
            // lblRegGender
            // 
            lblRegGender.AutoSize = true;
            lblRegGender.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRegGender.ForeColor = Color.LightGray;
            lblRegGender.Location = new Point(30, 284);
            lblRegGender.Name = "lblRegGender";
            lblRegGender.Size = new Size(68, 23);
            lblRegGender.TabIndex = 8;
            lblRegGender.Text = "Gender";
            // 
            // nudRegAge
            // 
            nudRegAge.Location = new Point(30, 240);
            nudRegAge.Minimum = new decimal(new int[] { 10, 0, 0, 0 });
            nudRegAge.Name = "nudRegAge";
            nudRegAge.Size = new Size(380, 30);
            nudRegAge.TabIndex = 7;
            nudRegAge.Value = new decimal(new int[] { 25, 0, 0, 0 });
            // 
            // lblRegAge
            // 
            lblRegAge.AutoSize = true;
            lblRegAge.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRegAge.ForeColor = Color.LightGray;
            lblRegAge.Location = new Point(30, 218);
            lblRegAge.Name = "lblRegAge";
            lblRegAge.Size = new Size(42, 23);
            lblRegAge.TabIndex = 6;
            lblRegAge.Text = "Age";
            // 
            // txtRegName
            // 
            txtRegName.Location = new Point(30, 174);
            txtRegName.Name = "txtRegName";
            txtRegName.Size = new Size(380, 30);
            txtRegName.TabIndex = 5;
            // 
            // lblRegName
            // 
            lblRegName.AutoSize = true;
            lblRegName.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRegName.ForeColor = Color.LightGray;
            lblRegName.Location = new Point(30, 152);
            lblRegName.Name = "lblRegName";
            lblRegName.Size = new Size(91, 23);
            lblRegName.TabIndex = 4;
            lblRegName.Text = "Full Name";
            // 
            // txtRegPass
            // 
            txtRegPass.Location = new Point(30, 108);
            txtRegPass.Name = "txtRegPass";
            txtRegPass.Size = new Size(380, 30);
            txtRegPass.TabIndex = 3;
            txtRegPass.UseSystemPasswordChar = true;
            // 
            // lblRegPass
            // 
            lblRegPass.AutoSize = true;
            lblRegPass.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRegPass.ForeColor = Color.LightGray;
            lblRegPass.Location = new Point(30, 86);
            lblRegPass.Name = "lblRegPass";
            lblRegPass.Size = new Size(284, 23);
            lblRegPass.TabIndex = 2;
            lblRegPass.Text = "Password (Minimum 6 Characters)";
            // 
            // txtRegUser
            // 
            txtRegUser.Location = new Point(30, 42);
            txtRegUser.Name = "txtRegUser";
            txtRegUser.Size = new Size(380, 30);
            txtRegUser.TabIndex = 1;
            // 
            // lblRegUser
            // 
            lblRegUser.AutoSize = true;
            lblRegUser.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRegUser.ForeColor = Color.LightGray;
            lblRegUser.Location = new Point(30, 20);
            lblRegUser.Name = "lblRegUser";
            lblRegUser.Size = new Size(89, 23);
            lblRegUser.TabIndex = 0;
            lblRegUser.Text = "Username";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 20, 35);
            ClientSize = new Size(517, 683);
            Controls.Add(tabControl);
            Controls.Add(lblSubtitle);
            Controls.Add(label3);
            Controls.Add(pnlHeader);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FITPAL-Your Fitness Companion";
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            tabControl.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            pnlRegScroll.ResumeLayout(false);
            pnlRegScroll.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudRegHeight).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudRegWeight).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudRegAge).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlHeader;
        private Label lblTitle;
        private Label lblSubtitle;
        private Label label3;
        private TabControl tabControl;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TextBox txtLoginUser;
        private Label lblLoginUser;
        private Label lblLoginPass;
        private TextBox txtLoginPass;
        private Button btnLogin;
        private Label lblLoginError;
        private Panel pnlRegScroll;
        private Label lblRegUser;
        private TextBox txtRegUser;
        private TextBox txtRegPass;
        private Label lblRegPass;
        private NumericUpDown nudRegAge;
        private Label lblRegAge;
        private TextBox txtRegName;
        private Label lblRegName;
        private Label lblRegWeight;
        private ComboBox cmbRegGender;
        private Label lblRegGender;
        private NumericUpDown nudRegHeight;
        private Label lblRegHeight;
        private NumericUpDown nudRegWeight;
        private Button btnRegister;
        private Label lblRegError;
        private ComboBox cmbRegGoal;
        private Label lblRegGoal;
    }
}