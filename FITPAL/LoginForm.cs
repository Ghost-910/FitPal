using fitpal.Models;
using fitpal.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace fitpal
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            lblLoginError.Text = "";
            string user = txtLoginUser.Text.Trim();
            string pass = txtLoginPass.Text;

            if (string.IsNullOrEmpty(user) || string.IsNullOrEmpty(pass))
            {
                lblLoginError.Text = "Please fill all fields.";
                return;
            }

            var fitnessUser = UserRepository.Instance.Login(user, pass);
            if (fitnessUser == null)
            {
                lblLoginError.Text = "Invalid username or password.";
                return;
            }

            var dashboard = new DashboardForm(fitnessUser);
            dashboard.Show();
            this.Hide();
            dashboard.FormClosed += (ss, ee) => { this.Show(); };
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            lblRegError.Text = "";
            try
            {
                FitnessGoal goal = (FitnessGoal)cmbRegGoal.SelectedIndex;

                var newUser = new FitnessUser(
                    txtRegUser.Text.Trim(),
                    txtRegPass.Text,
                    txtRegName.Text.Trim(),
                    (int)nudRegAge.Value,
                    cmbRegGender.SelectedItem.ToString(),
                    (double)nudRegWeight.Value,
                    (double)nudRegHeight.Value,
                    goal
                 );

                bool success = UserRepository.Instance.Register(newUser);
                if (!success)
                {
                    lblRegError.Text = "Username already exists.";
                    return;
                }

                MessageBox.Show("Accound created! You can now log in.",
                    "FITPAL", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                lblRegError.Text = ex.Message;
            }
        }
    }
}
