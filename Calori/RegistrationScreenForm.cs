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
    public partial class RegistrationScreenForm : Form
    {
        private readonly AppDbContext db;
        bool passwordIsTrue = false;
        public RegistrationScreenForm(AppDbContext db)
        {
            InitializeComponent();
            this.db = db;
            LoadData();

        }

        private void LoadData()
        {
            cboGender.Items.Clear();
            cboEmail.Items.Clear();
            cboGender.DataSource = Enum.GetNames(typeof(Gender)).ToArray();
            List<string> emailextansion = new List<string>()
            {
                "gmail.com",
                "yahoo.com",
                "hotmail.com",
                "outlook.com"

            };
            cboEmail.DataSource = emailextansion.ToList();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            User user = new User();

            #region Name
            if (string.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("The name field cannot be left blank.");
                return;
            }
            else
            {
                user.Name = txtName.Text.Trim();
            }
            #endregion
            #region Surname
            if (string.IsNullOrEmpty(txtSurname.Text))
            {
                MessageBox.Show("The surname field cannot be left blank.");
                return;
            }
            else
            {
                user.Surname = txtSurname.Text.Trim();
            }
            #endregion
            #region Gender
            if (cboGender.SelectedIndex == -1)
            {
                return;
            }
            else
            {
                user.Gender = (Gender)cboGender.SelectedIndex;
            }
            #endregion
            #region Email
            var mailEnding = cboEmail.SelectedItem;
            if (string.IsNullOrEmpty(txtEmail.Text))
            {
                MessageBox.Show("The e-mail field cannot be left blank.");
                return;
            }
            else
            {
                char[] email = txtEmail.Text.Trim().ToArray();
                if (char.IsNumber(email[0]))
                {
                    MessageBox.Show("Mail cannot start with number!");
                    return;
                }
                else
                {
                    foreach (char letter in email)
                    {

                        if (!char.IsLetter(letter) && !char.IsNumber(letter) && char.IsPunctuation(letter))
                        {
                            if (letter != '.' || letter != '_' || letter != '-')
                            {
                                MessageBox.Show("Do not use special characters!");
                                return;
                            }
                        }
                        if (char.IsLetter(letter))
                        {
                            if (((int)letter > 64 && (int)letter < 91) || ((int)letter > 96 && (int)letter < 123))
                            {
                                user.Email = txtEmail.Text.Trim()+"@"+mailEnding.ToString();
                            }
                        }
                    }
                }



            }
            #endregion
            #region Password
            if (string.IsNullOrEmpty(txtPassword.Text) || string.IsNullOrEmpty(txtConfirmPasword.Text))
            {
                MessageBox.Show("The password fields cannot be left blank.");
                return;
            }
            if (passwordIsTrue == true)
            {
                user.Password = txtPassword.Text.Trim();
            }


            #endregion
            #region Birthday
            if (dtpDateofBirth.Value > DateTime.Now)
            {
                MessageBox.Show("Birthday can not be exceed today ");
                return;
            }
            user.BirthDate = dtpDateofBirth.Value;

            #endregion
            #region Weight and Height
            user.Weight = nudWeight.Value;
            user.Height = nudHeight.Value;
            #endregion

            foreach (var i in db.Users)
            {
                if (i.Email == user.Email)
                {
                    MessageBox.Show("User registered.");
                    return;
                }
            }

            db.Users.Add(user);
            db.SaveChanges();
            MessageBox.Show("Registration Succesful");
            ClearRegistrationScreen();
            Close();
        }

        private void ClearRegistrationScreen()
        {
            txtName.Clear();
            txtPassword.Clear();
            txtEmail.Clear();
            txtConfirmPasword.Clear();

            lblPassLen.ForeColor = Color.LightSteelBlue;
            lblPassLow.ForeColor = Color.LightSteelBlue;
            lblPassNum.ForeColor = Color.LightSteelBlue;
            lblPassSpec.ForeColor = Color.LightSteelBlue;
            lblPassUp.ForeColor = Color.LightSteelBlue;
            lblPassCont.Visible = false;
            dtpDateofBirth.Value = DateTime.Now;
            nudHeight.Value = 0;
            nudWeight.Value = 0;
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            lblPassLen.ForeColor = Color.LightSteelBlue;
            lblPassLow.ForeColor = Color.LightSteelBlue;
            lblPassNum.ForeColor = Color.LightSteelBlue;
            lblPassSpec.ForeColor = Color.LightSteelBlue;
            lblPassUp.ForeColor = Color.LightSteelBlue;

            txtPassword.PasswordChar = '*';
            string password = txtPassword.Text.Trim();
            string numbers = "0123456789";
            string upperCase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string lowerCase = "abcdefghijklmnopqrstuvwxyz";
            string specialCharacters = "!'£^#+$%&/*?\\-_|@~¨´,;.:`";
            if (password.Length < 6)
            {
                lblPassLen.ForeColor = Color.Red;
            }
            else
            {
                lblPassLen.ForeColor = Color.Green;
            }
            foreach (var item in password.Distinct())
            {
                if (lowerCase.Contains(item))
                {
                    lblPassLow.ForeColor = Color.Green;
                }
                else if (upperCase.Contains(item))
                {
                    lblPassUp.ForeColor = Color.Green;

                }
                else if (numbers.Contains(item))
                {
                    lblPassNum.ForeColor = Color.Green;
                }
                else if (specialCharacters.Contains(item))
                {
                    lblPassSpec.ForeColor = Color.Green;
                }
                else
                {
                    lblPassLen.ForeColor = Color.Red;
                    lblPassLow.ForeColor = Color.Red;
                    lblPassNum.ForeColor = Color.Red;
                    lblPassSpec.ForeColor = Color.Red;
                    lblPassUp.ForeColor = Color.Red;
                }

            }


        }

        private void txtConfirmPasword_TextChanged(object sender, EventArgs e)
        {
            txtConfirmPasword.PasswordChar = '*';
            string passwordCheck = txtConfirmPasword.Text.Trim();
            if (txtPassword.Text != passwordCheck)
            {
                lblPassCont.ForeColor = Color.Red;
                lblPassCont.Text = "Your password is not matched";
                lblPassCont.Visible = true;
                passwordIsTrue = false;


            }
            else
            {
                lblPassCont.ForeColor = Color.Green;
                lblPassCont.Text = "Your password  is matched";
                lblPassCont.Visible = true;
                passwordIsTrue = true;
            }
        }
    }
}
