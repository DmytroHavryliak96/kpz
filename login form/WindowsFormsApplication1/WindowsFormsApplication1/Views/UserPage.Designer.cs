namespace WindowsFormsApplication1
{
    partial class UserPage
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.credentials = new System.Windows.Forms.Label();
            this.signOut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(167, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Welcome, User";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(182, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "You are logged in as";
            // 
            // credentials
            // 
            this.credentials.AutoSize = true;
            this.credentials.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.credentials.Location = new System.Drawing.Point(137, 178);
            this.credentials.Name = "credentials";
            this.credentials.Size = new System.Drawing.Size(233, 18);
            this.credentials.TabIndex = 4;
            this.credentials.Text = "Firstname Lastname, DefaultUser ";
            this.credentials.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // signOut
            // 
            this.signOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signOut.Location = new System.Drawing.Point(393, 12);
            this.signOut.Name = "signOut";
            this.signOut.Size = new System.Drawing.Size(114, 30);
            this.signOut.TabIndex = 17;
            this.signOut.Text = "Sign out";
            this.signOut.UseVisualStyleBackColor = true;
            this.signOut.Click += new System.EventHandler(this.signOut_Click);
            // 
            // UserPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 364);
            this.Controls.Add(this.signOut);
            this.Controls.Add(this.credentials);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UserPage";
            this.Text = "WelcomeWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label credentials;
        private System.Windows.Forms.Button signOut;
    }
}