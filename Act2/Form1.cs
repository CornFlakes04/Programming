using Microsoft.VisualBasic.ApplicationServices;
using System.ComponentModel.Design;
using System.DirectoryServices.ActiveDirectory;
using System.Windows.Forms;

namespace Act2
{
    public partial class Form1 : Form
    {
        Form3 form3 = new Form3();
        int LoginLimit = 3;
        public Form1()
        {
            InitializeComponent();
            AcceptButton = btnF1Login;
        }

        private void btnF1Login_Click(object sender, EventArgs e)
        {
            string Uname = txtF1User.Text;
            string Upass = txtF1Pass.Text;
            form3.F3Credential(Uname, Upass);

            while (LoginLimit > 0)
            {

                if (Uname == "admin" && Upass == "admin")
                {
                    form3.Show();
                    MessageBox.Show($"Hi {Uname}, Welcome to ANDROID CORP!", "Login Successful",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoginLimit = 3;
                    txtF1User.Text = "";
                    txtF1Pass.Text = "";
                    break; // Exit the loop on successful login
                }
                else if (form3.identifier == 1)
                {
                    MessageBox.Show($"Hi {Uname}, Welcome!", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoginLimit = 3;
                    txtF1User.Text = "";
                    txtF1Pass.Text = "";
                    break; // Exit the loop on successful login
                }
                else if (form3.identifier == 2 || form3.identifier == 3)
                {
                    LoginLimit--;

                    if (LoginLimit <= 0)
                    {
                        btnF1Login.Enabled = false; // Disable the login button after reaching the maximum login attempts.
                        MessageBox.Show("You have exceeded the maximum number of login attempts.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtF1User.Text = "";
                        txtF1Pass.Text = "";
                        break;
                    }
                    MessageBox.Show($"There has been an error with your credentials\n You have {LoginLimit} attempts left", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtF1User.Text = "";
                    txtF1Pass.Text = "";
                    return;
                }

                else
                {
                    LoginLimit--;

                    if (LoginLimit <= 0)
                    {
                        btnF1Login.Enabled = false; // Disable the login button after reaching the maximum login attempts.
                        MessageBox.Show("You have exceeded the maximum number of login attempts.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtF1User.Text = "";
                        txtF1Pass.Text = "";
                        break;
                    }
                    MessageBox.Show($"There has been an error with your credentials\n You have {LoginLimit} attempts left", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtF1User.Text = "";
                    txtF1Pass.Text = "";
                    return;
                }
            }


        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void txtF1User_TextChanged(object sender, EventArgs e)
        {

        }
    }
}