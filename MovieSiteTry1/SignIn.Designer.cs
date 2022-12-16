
namespace MovieSiteTry1
{
    partial class SignIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignIn));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.InUsername = new System.Windows.Forms.TextBox();
            this.InPassword = new System.Windows.Forms.TextBox();
            this.btnSignIn = new System.Windows.Forms.Button();
            this.transSignUp = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(366, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sign In";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(209, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(212, 254);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password";
            // 
            // InUsername
            // 
            this.InUsername.Location = new System.Drawing.Point(412, 168);
            this.InUsername.Name = "InUsername";
            this.InUsername.Size = new System.Drawing.Size(198, 20);
            this.InUsername.TabIndex = 3;
            // 
            // InPassword
            // 
            this.InPassword.Location = new System.Drawing.Point(412, 246);
            this.InPassword.Name = "InPassword";
            this.InPassword.Size = new System.Drawing.Size(198, 20);
            this.InPassword.TabIndex = 4;
            // 
            // btnSignIn
            // 
            this.btnSignIn.Location = new System.Drawing.Point(535, 334);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(75, 23);
            this.btnSignIn.TabIndex = 5;
            this.btnSignIn.Text = "SignIn";
            this.btnSignIn.UseVisualStyleBackColor = true;
            this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click);
            // 
            // transSignUp
            // 
            this.transSignUp.AutoSize = true;
            this.transSignUp.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.transSignUp.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transSignUp.ForeColor = System.Drawing.SystemColors.Highlight;
            this.transSignUp.Location = new System.Drawing.Point(342, 383);
            this.transSignUp.Name = "transSignUp";
            this.transSignUp.Size = new System.Drawing.Size(268, 14);
            this.transSignUp.TabIndex = 6;
            this.transSignUp.Text = "You don\'t have a account ? Sing Up from HERE!";
            this.transSignUp.Click += new System.EventHandler(this.transSignUp_Click);
            // 
            // SignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.transSignUp);
            this.Controls.Add(this.btnSignIn);
            this.Controls.Add(this.InPassword);
            this.Controls.Add(this.InUsername);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "SignIn";
            this.Text = "SignIn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox InUsername;
        private System.Windows.Forms.TextBox InPassword;
        private System.Windows.Forms.Button btnSignIn;
        private System.Windows.Forms.Label transSignUp;
    }
}