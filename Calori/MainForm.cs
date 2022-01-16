using Calori.Data;
using Calori.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calori
{
    public partial class MainForm : Form
    {
        AppDbContext db = new AppDbContext();
        public MainForm()
        {
            InitializeComponent();
            LoadData();
        }
        private void LoadData()
        {
            cboUserEmail.Items.Clear();
            List<string> emailextansion = new List<string>()
            {
                "gmail.com",
                "yahoo.com",
                "hotmail.com",
                "outlook.com"
            };
            cboUserEmail.DataSource = emailextansion.ToList();
        }

        private void lnklSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegistrationScreenForm registrationScreenForm = new RegistrationScreenForm(db);
            registrationScreenForm.ShowDialog();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            string mailBeforeAt = txtEmail.Text.Trim();
            var mailAfterAt=cboUserEmail.SelectedItem.ToString();
            string username = mailBeforeAt+"@"+mailAfterAt;

            User user = db.Users.FirstOrDefault(x => x.Email == username && x.Password == txtPassword.Text.Trim());
            if (user == null)
            {
                MessageBox.Show("Username or password is incorrect");
            }
            else
            {
                MealMainForm mealMainForm = new MealMainForm(db, user);
                mealMainForm.ShowDialog();
                txtEmail.Clear();
                txtPassword.Clear();
                this.Close();
            }
        }
    }
}
