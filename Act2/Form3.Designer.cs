namespace Act2
{
    partial class Form3
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            tableF3Req = new DataGridView();
            clmF3Name = new DataGridViewTextBoxColumn();
            clmF3Age = new DataGridViewTextBoxColumn();
            clmF3Address = new DataGridViewTextBoxColumn();
            clmF3Email = new DataGridViewTextBoxColumn();
            clmF3User = new DataGridViewTextBoxColumn();
            clmF3Pass = new DataGridViewTextBoxColumn();
            btnF3Approve = new Button();
            tableF3App = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            tableUser = new DataGridViewTextBoxColumn();
            tablePass = new DataGridViewTextBoxColumn();
            tabControl1 = new TabControl();
            tabPage2 = new TabPage();
            tabPage1 = new TabPage();
            ((System.ComponentModel.ISupportInitialize)tableF3Req).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tableF3App).BeginInit();
            tabControl1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage1.SuspendLayout();
            SuspendLayout();
            // 
            // tableF3Req
            // 
            tableF3Req.AllowUserToAddRows = false;
            tableF3Req.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            tableF3Req.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            tableF3Req.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableF3Req.Columns.AddRange(new DataGridViewColumn[] { clmF3Name, clmF3Age, clmF3Address, clmF3Email, clmF3User, clmF3Pass });
            tableF3Req.Location = new Point(0, 0);
            tableF3Req.Name = "tableF3Req";
            tableF3Req.ReadOnly = true;
            tableF3Req.RowTemplate.Height = 25;
            tableF3Req.Size = new Size(665, 315);
            tableF3Req.TabIndex = 0;
            // 
            // clmF3Name
            // 
            clmF3Name.HeaderText = "Name";
            clmF3Name.Name = "clmF3Name";
            clmF3Name.ReadOnly = true;
            // 
            // clmF3Age
            // 
            clmF3Age.HeaderText = "Age";
            clmF3Age.Name = "clmF3Age";
            clmF3Age.ReadOnly = true;
            // 
            // clmF3Address
            // 
            clmF3Address.HeaderText = "Address";
            clmF3Address.Name = "clmF3Address";
            clmF3Address.ReadOnly = true;
            // 
            // clmF3Email
            // 
            clmF3Email.HeaderText = "Email";
            clmF3Email.Name = "clmF3Email";
            clmF3Email.ReadOnly = true;
            // 
            // clmF3User
            // 
            clmF3User.HeaderText = "Username";
            clmF3User.Name = "clmF3User";
            clmF3User.ReadOnly = true;
            // 
            // clmF3Pass
            // 
            clmF3Pass.HeaderText = "Password";
            clmF3Pass.Name = "clmF3Pass";
            clmF3Pass.ReadOnly = true;
            // 
            // btnF3Approve
            // 
            btnF3Approve.Location = new Point(565, 321);
            btnF3Approve.Name = "btnF3Approve";
            btnF3Approve.Size = new Size(90, 35);
            btnF3Approve.TabIndex = 1;
            btnF3Approve.Text = "Approve";
            btnF3Approve.UseVisualStyleBackColor = true;
            btnF3Approve.Click += btnF3Approve_Click;
            // 
            // tableF3App
            // 
            tableF3App.AllowUserToAddRows = false;
            tableF3App.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            tableF3App.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            tableF3App.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableF3App.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, tableUser, tablePass });
            tableF3App.Location = new Point(0, 0);
            tableF3App.Name = "tableF3App";
            tableF3App.ReadOnly = true;
            tableF3App.RowTemplate.Height = 25;
            tableF3App.Size = new Size(665, 315);
            tableF3App.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Name";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Age";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "Address";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "Email";
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // tableUser
            // 
            tableUser.HeaderText = "Username";
            tableUser.Name = "tableUser";
            tableUser.ReadOnly = true;
            // 
            // tablePass
            // 
            tablePass.HeaderText = "Password";
            tablePass.Name = "tablePass";
            tablePass.ReadOnly = true;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Location = new Point(-2, -3);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(673, 399);
            tabControl1.TabIndex = 5;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = SystemColors.ControlDark;
            tabPage2.Controls.Add(tableF3Req);
            tabPage2.Controls.Add(btnF3Approve);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(665, 371);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Approved Users";
            // 
            // tabPage1
            // 
            tabPage1.BackColor = SystemColors.ControlDark;
            tabPage1.Controls.Add(tableF3App);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(665, 371);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Pending Users";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(669, 431);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form3";
            Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)tableF3Req).EndInit();
            ((System.ComponentModel.ISupportInitialize)tableF3App).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView tableF3Req;
        private DataGridViewTextBoxColumn clmF3Name;
        private DataGridViewTextBoxColumn clmF3Age;
        private DataGridViewTextBoxColumn clmF3Address;
        private DataGridViewTextBoxColumn clmF3Email;
        private DataGridViewTextBoxColumn clmF3User;
        private DataGridViewTextBoxColumn clmF3Pass;
        private Button btnF3Approve;
        private DataGridView tableF3App;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn tableUser;
        private DataGridViewTextBoxColumn tablePass;
        private TabControl tabControl1;
        private TabPage tabPage2;
        private TabPage tabPage1;
    }
}