using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Act2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnF2Create_Click(object sender, EventArgs e)
        {
            string f2Name, f2Age, f2Address, f2Email, f2User, f2Pass;
            f2Name = txtF2Name.Text;
            f2Age = txtF2Age.Text;
            f2Address = txtF2Address.Text;
            f2Email = txtF2Email.Text;
            f2User = txtF2User.Text;
            f2Pass = txtF2Pass.Text;
            Form3 form3 = Application.OpenForms["Form3"] as Form3;

            if (f2User.Contains("admin"))
            {
                MessageBox.Show("Username must not contains 'admin'.");
                txtF2Name.Text = "";
                txtF2Age.Text = "";
                txtF2Address.Text = "";
                txtF2Email.Text = "";
                txtF2User.Text = "";
                txtF2Pass.Text = "";
                return;
            }
            else
            {
                if (form3 != null)
                {
                    form3.AddDataToTable(f2Name, f2Age, f2Address, f2Email, f2User, f2Pass);
                    MessageBox.Show($"Hi {f2Name}, Your account has been created,\nand currently waiting for approval", "Account created", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtF2Name.Text = "";
                    txtF2Age.Text = "";
                    txtF2Address.Text = "";
                    txtF2Email.Text = "";
                    txtF2User.Text = "";
                    txtF2Pass.Text = "";
                }
            }
        }
    }
}
