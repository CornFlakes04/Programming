namespace Act2
{
    partial class Form2
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
            txtF2Name = new TextBox();
            txtF2Age = new TextBox();
            txtF2Address = new TextBox();
            txtF2Email = new TextBox();
            txtF2User = new TextBox();
            txtF2Pass = new TextBox();
            btnF2Create = new Button();
            SuspendLayout();
            // 
            // txtF2Name
            // 
            txtF2Name.Location = new Point(115, 56);
            txtF2Name.Name = "txtF2Name";
            txtF2Name.PlaceholderText = "Name";
            txtF2Name.Size = new Size(206, 23);
            txtF2Name.TabIndex = 0;
            // 
            // txtF2Age
            // 
            txtF2Age.Location = new Point(115, 110);
            txtF2Age.Name = "txtF2Age";
            txtF2Age.PlaceholderText = "Age";
            txtF2Age.Size = new Size(206, 23);
            txtF2Age.TabIndex = 1;
            // 
            // txtF2Address
            // 
            txtF2Address.Location = new Point(115, 169);
            txtF2Address.Name = "txtF2Address";
            txtF2Address.PlaceholderText = "Address";
            txtF2Address.Size = new Size(206, 23);
            txtF2Address.TabIndex = 2;
            // 
            // txtF2Email
            // 
            txtF2Email.Location = new Point(377, 56);
            txtF2Email.Name = "txtF2Email";
            txtF2Email.PlaceholderText = "Email";
            txtF2Email.Size = new Size(206, 23);
            txtF2Email.TabIndex = 3;
            // 
            // txtF2User
            // 
            txtF2User.Location = new Point(377, 111);
            txtF2User.Name = "txtF2User";
            txtF2User.PlaceholderText = "Username";
            txtF2User.Size = new Size(206, 23);
            txtF2User.TabIndex = 4;
            // 
            // txtF2Pass
            // 
            txtF2Pass.Location = new Point(377, 153);
            txtF2Pass.Name = "txtF2Pass";
            txtF2Pass.PlaceholderText = "Password";
            txtF2Pass.Size = new Size(206, 23);
            txtF2Pass.TabIndex = 5;
            // 
            // btnF2Create
            // 
            btnF2Create.Location = new Point(447, 263);
            btnF2Create.Name = "btnF2Create";
            btnF2Create.Size = new Size(116, 42);
            btnF2Create.TabIndex = 6;
            btnF2Create.Text = "Submit";
            btnF2Create.UseVisualStyleBackColor = true;
            btnF2Create.Click += btnF2Create_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(621, 493);
            Controls.Add(btnF2Create);
            Controls.Add(txtF2Pass);
            Controls.Add(txtF2User);
            Controls.Add(txtF2Email);
            Controls.Add(txtF2Address);
            Controls.Add(txtF2Age);
            Controls.Add(txtF2Name);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtF2Name;
        private TextBox txtF2Age;
        private TextBox txtF2Address;
        private TextBox txtF2Email;
        private TextBox txtF2User;
        private TextBox txtF2Pass;
        private Button btnF2Create;
    }
}