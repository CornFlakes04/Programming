namespace Act2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            txtF1User = new TextBox();
            txtF1Pass = new TextBox();
            btnF1Login = new Button();
            linkLabel1 = new LinkLabel();
            linkLabel2 = new LinkLabel();
            checkBox1 = new CheckBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtF1User
            // 
            txtF1User.Location = new Point(322, 125);
            txtF1User.Name = "txtF1User";
            txtF1User.PlaceholderText = "Username";
            txtF1User.Size = new Size(217, 23);
            txtF1User.TabIndex = 0;
            txtF1User.TextChanged += txtF1User_TextChanged;
            // 
            // txtF1Pass
            // 
            txtF1Pass.Location = new Point(322, 174);
            txtF1Pass.Name = "txtF1Pass";
            txtF1Pass.PlaceholderText = "Password";
            txtF1Pass.Size = new Size(217, 23);
            txtF1Pass.TabIndex = 1;
            // 
            // btnF1Login
            // 
            btnF1Login.Location = new Point(371, 264);
            btnF1Login.Name = "btnF1Login";
            btnF1Login.Size = new Size(120, 33);
            btnF1Login.TabIndex = 2;
            btnF1Login.Text = "Login";
            btnF1Login.UseVisualStyleBackColor = true;
            btnF1Login.Click += btnF1Login_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(439, 223);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(100, 15);
            linkLabel1.TabIndex = 3;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Forgot password?";
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.Location = new Point(477, 323);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(89, 15);
            linkLabel2.TabIndex = 4;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Create Account";
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(322, 221);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(109, 19);
            checkBox1.TabIndex = 5;
            checkBox1.Text = "Remember me?";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-2, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(580, 349);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(578, 347);
            Controls.Add(txtF1User);
            Controls.Add(linkLabel2);
            Controls.Add(checkBox1);
            Controls.Add(btnF1Login);
            Controls.Add(txtF1Pass);
            Controls.Add(linkLabel1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtF1User;
        private TextBox txtF1Pass;
        private Button btnF1Login;
        private LinkLabel linkLabel1;
        private LinkLabel linkLabel2;
        private CheckBox checkBox1;
        private PictureBox pictureBox1;
    }
}