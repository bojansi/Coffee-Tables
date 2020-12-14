
namespace PresentationLayer
{
    partial class Login
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
            this.lbHeading = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbWaiterUser = new System.Windows.Forms.TextBox();
            this.tbWaiterPass = new System.Windows.Forms.TextBox();
            this.btnWaiterLogin = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // lbHeading
            // 
            this.lbHeading.Font = new System.Drawing.Font("Stencil", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHeading.Location = new System.Drawing.Point(2, 27);
            this.lbHeading.Margin = new System.Windows.Forms.Padding(0);
            this.lbHeading.Name = "lbHeading";
            this.lbHeading.Size = new System.Drawing.Size(381, 47);
            this.lbHeading.TabIndex = 4;
            this.lbHeading.Text = "PRIJAVA";
            this.lbHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(2, 112);
            this.label2.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(381, 30);
            this.label2.TabIndex = 5;
            this.label2.Text = "Username";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 205);
            this.label1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(381, 30);
            this.label1.TabIndex = 6;
            this.label1.Text = "Password";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbWaiterUser
            // 
            this.tbWaiterUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.tbWaiterUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbWaiterUser.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbWaiterUser.Location = new System.Drawing.Point(61, 143);
            this.tbWaiterUser.MaxLength = 20;
            this.tbWaiterUser.Multiline = true;
            this.tbWaiterUser.Name = "tbWaiterUser";
            this.tbWaiterUser.Size = new System.Drawing.Size(270, 30);
            this.tbWaiterUser.TabIndex = 7;
            this.tbWaiterUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbWaiterPass
            // 
            this.tbWaiterPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.tbWaiterPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbWaiterPass.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbWaiterPass.Location = new System.Drawing.Point(61, 236);
            this.tbWaiterPass.MaxLength = 20;
            this.tbWaiterPass.Multiline = true;
            this.tbWaiterPass.Name = "tbWaiterPass";
            this.tbWaiterPass.PasswordChar = '*';
            this.tbWaiterPass.Size = new System.Drawing.Size(270, 30);
            this.tbWaiterPass.TabIndex = 8;
            this.tbWaiterPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnWaiterLogin
            // 
            this.btnWaiterLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(205)))), ((int)(((byte)(99)))));
            this.btnWaiterLogin.FlatAppearance.BorderSize = 0;
            this.btnWaiterLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWaiterLogin.Font = new System.Drawing.Font("Stencil", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWaiterLogin.Location = new System.Drawing.Point(90, 322);
            this.btnWaiterLogin.Name = "btnWaiterLogin";
            this.btnWaiterLogin.Size = new System.Drawing.Size(206, 49);
            this.btnWaiterLogin.TabIndex = 9;
            this.btnWaiterLogin.Text = "PRIJAVI SE";
            this.btnWaiterLogin.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(205)))), ((int)(((byte)(99)))));
            this.panel1.Location = new System.Drawing.Point(29, 75);
            this.panel1.Margin = new System.Windows.Forms.Padding(20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(326, 5);
            this.panel1.TabIndex = 10;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(384, 411);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbHeading);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbWaiterUser);
            this.Controls.Add(this.tbWaiterPass);
            this.Controls.Add(this.btnWaiterLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbHeading;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbWaiterUser;
        private System.Windows.Forms.TextBox tbWaiterPass;
        private System.Windows.Forms.Button btnWaiterLogin;
        private System.Windows.Forms.Panel panel1;
    }
}