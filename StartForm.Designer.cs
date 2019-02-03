namespace Marwa_DeskTop
{
    partial class StartForm
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
            this.btnAddUser = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.rdbtnEnglish = new System.Windows.Forms.RadioButton();
            this.rdbtnArbic = new System.Windows.Forms.RadioButton();
            this.btnShowUser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddUser
            // 
            this.btnAddUser.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAddUser.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddUser.Location = new System.Drawing.Point(157, 135);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(220, 142);
            this.btnAddUser.TabIndex = 0;
            this.btnAddUser.Text = "Add User";
            this.btnAddUser.UseVisualStyleBackColor = false;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLogin.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(439, 130);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(225, 147);
            this.btnLogin.TabIndex = 1;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // rdbtnEnglish
            // 
            this.rdbtnEnglish.AutoSize = true;
            this.rdbtnEnglish.Checked = true;
            this.rdbtnEnglish.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtnEnglish.Location = new System.Drawing.Point(277, 332);
            this.rdbtnEnglish.Name = "rdbtnEnglish";
            this.rdbtnEnglish.Size = new System.Drawing.Size(98, 27);
            this.rdbtnEnglish.TabIndex = 2;
            this.rdbtnEnglish.TabStop = true;
            this.rdbtnEnglish.Text = "English";
            this.rdbtnEnglish.UseVisualStyleBackColor = true;
            this.rdbtnEnglish.CheckedChanged += new System.EventHandler(this.rdbtnEnglish_CheckedChanged);
            // 
            // rdbtnArbic
            // 
            this.rdbtnArbic.AutoSize = true;
            this.rdbtnArbic.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtnArbic.Location = new System.Drawing.Point(423, 332);
            this.rdbtnArbic.Name = "rdbtnArbic";
            this.rdbtnArbic.Size = new System.Drawing.Size(79, 27);
            this.rdbtnArbic.TabIndex = 3;
            this.rdbtnArbic.Text = "عربي";
            this.rdbtnArbic.UseVisualStyleBackColor = true;
            this.rdbtnArbic.CheckedChanged += new System.EventHandler(this.rdbtnArbic_CheckedChanged);
            // 
            // btnShowUser
            // 
            this.btnShowUser.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnShowUser.Location = new System.Drawing.Point(119, 328);
            this.btnShowUser.Name = "btnShowUser";
            this.btnShowUser.Size = new System.Drawing.Size(100, 31);
            this.btnShowUser.TabIndex = 4;
            this.btnShowUser.Text = "Show User";
            this.btnShowUser.UseVisualStyleBackColor = false;
            this.btnShowUser.Click += new System.EventHandler(this.btnShowUser_Click);
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 450);
            this.Controls.Add(this.btnShowUser);
            this.Controls.Add(this.rdbtnArbic);
            this.Controls.Add(this.rdbtnEnglish);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnAddUser);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "StartForm";
            this.Padding = new System.Windows.Forms.Padding(17, 60, 17, 20);
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.RadioButton rdbtnEnglish;
        private System.Windows.Forms.RadioButton rdbtnArbic;
        private System.Windows.Forms.Button btnShowUser;
    }
}

