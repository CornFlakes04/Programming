using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Act2
{
    public partial class Form3 : Form
    {

        public int identifier;
        public int codeNum;
        public int passAcc;

        public static Form3 instance;
        public Form3()
        {
            InitializeComponent();
            instance = this;
        }

        public void AddDataToTable(string addNewName, string addNewAge, string addNewAdd, string addNewEmail, string addNewUser, string addNewPass)
        {
            tableF3Req.Rows.Add(addNewName, addNewAge, addNewAdd, addNewEmail, addNewUser, addNewPass);
        }

        private void btnF3Approve_Click(object sender, EventArgs e)
        {
            try
            {
                if (tableF3Req.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = tableF3Req.SelectedRows[0];
                    string newName = (string)selectedRow.Cells[0].Value;
                    string newAge = (string)selectedRow.Cells[1].Value;
                    string newAdd = (string)selectedRow.Cells[2].Value;
                    string newEmail = (string)selectedRow.Cells[3].Value;
                    string newUser = (string)selectedRow.Cells[4].Value;
                    string newPass = (string)selectedRow.Cells[5].Value;

                    if (Regex.IsMatch(newUser, @"^[a-zA-Z0-9]+$"))
                    {
                        tableF3App.Rows.Add(newName, newAge, newAdd, newEmail, newUser, newPass);

                        tableF3Req.Rows.RemoveAt(selectedRow.Index);
                        MessageBox.Show($"the account ({newName}) has been approved", "Approve Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        tableF3Req.Refresh();
                        tableF3App.Refresh();
                    }

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("Selection must not empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }

        }
        public void F3Credential(string user, string pass)
        {
            foreach (DataGridViewRow row in tableF3App.Rows)
            {
                string rowUsername = row.Cells["tableUser"].Value?.ToString();
                string rowPassword = row.Cells["tablePass"].Value?.ToString();

                if (rowUsername == user && rowPassword == pass)
                {
                    identifier = 1;
                    break;
                }
                else if (rowUsername != user && rowPassword == pass)
                {
                    identifier = 2;
                }
                else if (rowUsername == user && rowPassword != pass)
                {
                    identifier = 3;
                }
            }
        }

    }
}
