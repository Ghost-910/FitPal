namespace fitpal
{
    partial class DashboardForm
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
            lblUserInfo = new Label();
            lblLogo = new Label();
            pnlSidebar = new Panel();
            btnLogout = new Button();
            btnProgress = new Button();
            btnExercise = new Button();
            btnNutrition = new Button();
            btnCalories = new Button();
            btnBMI = new Button();
            btnOverview = new Button();
            pnlContent = new FlowLayoutPanel();
            pnlHeader.SuspendLayout();
            pnlSidebar.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(20, 28, 45);
            pnlHeader.Controls.Add(lblUserInfo);
            pnlHeader.Controls.Add(lblLogo);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1134, 55);
            pnlHeader.TabIndex = 0;
            // 
            // lblUserInfo
            // 
            lblUserInfo.AutoSize = true;
            lblUserInfo.ForeColor = Color.LightGray;
            lblUserInfo.Location = new Point(200, 20);
            lblUserInfo.Name = "lblUserInfo";
            lblUserInfo.Size = new Size(75, 20);
            lblUserInfo.TabIndex = 1;
            lblUserInfo.Text = "Welcome!";
            // 
            // lblLogo
            // 
            lblLogo.AutoSize = true;
            lblLogo.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLogo.ForeColor = Color.Teal;
            lblLogo.Location = new Point(14, 14);
            lblLogo.Name = "lblLogo";
            lblLogo.Size = new Size(106, 38);
            lblLogo.TabIndex = 0;
            lblLogo.Text = "FITPAL";
            // 
            // pnlSidebar
            // 
            pnlSidebar.BackColor = Color.FromArgb(20, 28, 45);
            pnlSidebar.Controls.Add(btnLogout);
            pnlSidebar.Controls.Add(btnProgress);
            pnlSidebar.Controls.Add(btnExercise);
            pnlSidebar.Controls.Add(btnNutrition);
            pnlSidebar.Controls.Add(btnCalories);
            pnlSidebar.Controls.Add(btnBMI);
            pnlSidebar.Controls.Add(btnOverview);
            pnlSidebar.Location = new Point(0, 55);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Size = new Size(190, 650);
            pnlSidebar.TabIndex = 1;
            // 
            // btnLogout
            // 
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.ForeColor = Color.Red;
            btnLogout.Location = new Point(0, 595);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(190, 52);
            btnLogout.TabIndex = 6;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click_1;
            // 
            // btnProgress
            // 
            btnProgress.FlatStyle = FlatStyle.Flat;
            btnProgress.ForeColor = Color.LightGray;
            btnProgress.Location = new Point(0, 320);
            btnProgress.Name = "btnProgress";
            btnProgress.Size = new Size(190, 52);
            btnProgress.TabIndex = 5;
            btnProgress.Text = "Progress";
            btnProgress.UseVisualStyleBackColor = true;
            btnProgress.Click += btnProgress_Click_1;
            // 
            // btnExercise
            // 
            btnExercise.FlatStyle = FlatStyle.Flat;
            btnExercise.ForeColor = Color.LightGray;
            btnExercise.Location = new Point(0, 260);
            btnExercise.Name = "btnExercise";
            btnExercise.Size = new Size(190, 52);
            btnExercise.TabIndex = 4;
            btnExercise.Text = "Exercise Plan";
            btnExercise.UseVisualStyleBackColor = true;
            btnExercise.Click += btnExercise_Click_1;
            // 
            // btnNutrition
            // 
            btnNutrition.FlatStyle = FlatStyle.Flat;
            btnNutrition.ForeColor = Color.LightGray;
            btnNutrition.Location = new Point(0, 200);
            btnNutrition.Name = "btnNutrition";
            btnNutrition.Size = new Size(190, 52);
            btnNutrition.TabIndex = 3;
            btnNutrition.Text = "Nutrition";
            btnNutrition.UseVisualStyleBackColor = true;
            btnNutrition.Click += btnNutrition_Click_1;
            // 
            // btnCalories
            // 
            btnCalories.FlatStyle = FlatStyle.Flat;
            btnCalories.ForeColor = Color.LightGray;
            btnCalories.Location = new Point(0, 140);
            btnCalories.Name = "btnCalories";
            btnCalories.Size = new Size(190, 52);
            btnCalories.TabIndex = 2;
            btnCalories.Text = "Calories";
            btnCalories.UseVisualStyleBackColor = true;
            btnCalories.Click += btnCalories_Click_1;
            // 
            // btnBMI
            // 
            btnBMI.FlatStyle = FlatStyle.Flat;
            btnBMI.ForeColor = Color.LightGray;
            btnBMI.Location = new Point(0, 80);
            btnBMI.Name = "btnBMI";
            btnBMI.Size = new Size(190, 52);
            btnBMI.TabIndex = 1;
            btnBMI.Text = "BMI";
            btnBMI.UseVisualStyleBackColor = true;
            btnBMI.Click += btnBMI_Click_1;
            // 
            // btnOverview
            // 
            btnOverview.FlatStyle = FlatStyle.Flat;
            btnOverview.ForeColor = Color.LightGray;
            btnOverview.Location = new Point(0, 20);
            btnOverview.Name = "btnOverview";
            btnOverview.Size = new Size(190, 52);
            btnOverview.TabIndex = 0;
            btnOverview.Text = "Overview";
            btnOverview.UseVisualStyleBackColor = true;
            btnOverview.Click += btnOverview_Click_1;
            // 
            // pnlContent
            // 
            pnlContent.AutoScroll = true;
            pnlContent.Location = new Point(190, 55);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(942, 650);
            pnlContent.TabIndex = 2;
            pnlContent.Paint += pnlContent_Paint;
            // 
            // DashboardForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 20, 35);
            ClientSize = new Size(1134, 703);
            Controls.Add(pnlContent);
            Controls.Add(pnlSidebar);
            Controls.Add(pnlHeader);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "DashboardForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FITPAL - Dashboard";
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlSidebar.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeader;
        private Label lblUserInfo;
        private Label lblLogo;
        private Panel pnlSidebar;
        private Button btnBMI;
        private Button btnOverview;
        private Button btnCalories;
        private Button btnExercise;
        private Button btnNutrition;
        private Button btnLogout;
        private Button btnProgress;
        private FlowLayoutPanel pnlContent;
    }
}