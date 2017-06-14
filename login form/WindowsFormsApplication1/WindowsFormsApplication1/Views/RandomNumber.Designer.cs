namespace WindowsFormsApplication1
{
    partial class RandomNumber
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
            this.userNumber = new System.Windows.Forms.TextBox();
            this.login = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.randNumber = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.signIn = new System.Windows.Forms.Button();
            this.register = new System.Windows.Forms.Button();
            this.generateNumber = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // userNumber
            // 
            this.userNumber.Location = new System.Drawing.Point(273, 205);
            this.userNumber.Name = "userNumber";
            this.userNumber.Size = new System.Drawing.Size(151, 20);
            this.userNumber.TabIndex = 13;
            // 
            // login
            // 
            this.login.Location = new System.Drawing.Point(273, 104);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(151, 20);
            this.login.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(118, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 18);
            this.label3.TabIndex = 11;
            this.label3.Text = "Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(118, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 18);
            this.label2.TabIndex = 10;
            this.label2.Text = "Your number";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(193, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 29);
            this.label1.TabIndex = 9;
            this.label1.Text = "Welcome";
            // 
            // randNumber
            // 
            this.randNumber.Location = new System.Drawing.Point(273, 153);
            this.randNumber.Name = "randNumber";
            this.randNumber.ReadOnly = true;
            this.randNumber.Size = new System.Drawing.Size(151, 20);
            this.randNumber.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(118, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 18);
            this.label4.TabIndex = 14;
            this.label4.Text = "Random number";
            // 
            // signIn
            // 
            this.signIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signIn.Location = new System.Drawing.Point(310, 301);
            this.signIn.Name = "signIn";
            this.signIn.Size = new System.Drawing.Size(114, 30);
            this.signIn.TabIndex = 16;
            this.signIn.Text = "Sign In";
            this.signIn.UseVisualStyleBackColor = true;
            this.signIn.Click += new System.EventHandler(this.signIn_Click);
            // 
            // register
            // 
            this.register.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register.Location = new System.Drawing.Point(402, 12);
            this.register.Name = "register";
            this.register.Size = new System.Drawing.Size(114, 30);
            this.register.TabIndex = 20;
            this.register.Text = "Register";
            this.register.UseVisualStyleBackColor = true;
            this.register.Click += new System.EventHandler(this.register_Click);
            // 
            // generateNumber
            // 
            this.generateNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generateNumber.Location = new System.Drawing.Point(121, 301);
            this.generateNumber.Name = "generateNumber";
            this.generateNumber.Size = new System.Drawing.Size(114, 30);
            this.generateNumber.TabIndex = 21;
            this.generateNumber.Text = "Generate";
            this.generateNumber.UseVisualStyleBackColor = true;
            this.generateNumber.Click += new System.EventHandler(this.generateNumber_Click);
            // 
            // RandomNumber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 364);
            this.Controls.Add(this.generateNumber);
            this.Controls.Add(this.register);
            this.Controls.Add(this.signIn);
            this.Controls.Add(this.randNumber);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.userNumber);
            this.Controls.Add(this.login);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.KeyPreview = true;
            this.Name = "RandomNumber";
            this.Text = "By Dmytro Havryliak";
            this.Load += new System.EventHandler(this.RandomNumber_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox userNumber;
        private System.Windows.Forms.TextBox login;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox randNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button signIn;
        private System.Windows.Forms.Button register;
        private System.Windows.Forms.Button generateNumber;
    }
}