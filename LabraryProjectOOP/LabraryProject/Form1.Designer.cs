namespace LabraryProject
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
            this.MainTitleLabrary = new System.Windows.Forms.Label();
            this.EmployeEentryLabel = new System.Windows.Forms.Label();
            this.PasswordEmpoleeEntryLabel = new System.Windows.Forms.Label();
            this.UserNameEmploeeLabel = new System.Windows.Forms.Label();
            this.ButtonEmployeeForPassWordAndUserName = new System.Windows.Forms.Button();
            this.PasswordEmpolyee = new System.Windows.Forms.TextBox();
            this.UserNameEmpolyee = new System.Windows.Forms.TextBox();
            this.LabelUserNameEnter = new System.Windows.Forms.Label();
            this.LabelPasswordUser = new System.Windows.Forms.Label();
            this.LabelUserEntry = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // MainTitleLabrary
            // 
            this.MainTitleLabrary.AutoSize = true;
            this.MainTitleLabrary.BackColor = System.Drawing.SystemColors.Control;
            this.MainTitleLabrary.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.MainTitleLabrary.Location = new System.Drawing.Point(339, 27);
            this.MainTitleLabrary.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.MainTitleLabrary.Name = "MainTitleLabrary";
            this.MainTitleLabrary.Size = new System.Drawing.Size(111, 24);
            this.MainTitleLabrary.TabIndex = 0;
            this.MainTitleLabrary.Text = "LABRARY";
            this.MainTitleLabrary.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // EmployeEentryLabel
            // 
            this.EmployeEentryLabel.AutoSize = true;
            this.EmployeEentryLabel.Location = new System.Drawing.Point(339, 102);
            this.EmployeEentryLabel.Name = "EmployeEentryLabel";
            this.EmployeEentryLabel.Size = new System.Drawing.Size(99, 25);
            this.EmployeEentryLabel.TabIndex = 3;
            this.EmployeEentryLabel.Text = "Enter User";
            // 
            // PasswordEmpoleeEntryLabel
            // 
            this.PasswordEmpoleeEntryLabel.AutoSize = true;
            this.PasswordEmpoleeEntryLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PasswordEmpoleeEntryLabel.Location = new System.Drawing.Point(106, 289);
            this.PasswordEmpoleeEntryLabel.Name = "PasswordEmpoleeEntryLabel";
            this.PasswordEmpoleeEntryLabel.Size = new System.Drawing.Size(91, 25);
            this.PasswordEmpoleeEntryLabel.TabIndex = 4;
            this.PasswordEmpoleeEntryLabel.Text = "Password";
            // 
            // UserNameEmploeeLabel
            // 
            this.UserNameEmploeeLabel.AutoSize = true;
            this.UserNameEmploeeLabel.Location = new System.Drawing.Point(106, 196);
            this.UserNameEmploeeLabel.Name = "UserNameEmploeeLabel";
            this.UserNameEmploeeLabel.Size = new System.Drawing.Size(100, 25);
            this.UserNameEmploeeLabel.TabIndex = 5;
            this.UserNameEmploeeLabel.Text = "UserName";
            // 
            // ButtonEmployeeForPassWordAndUserName
            // 
            this.ButtonEmployeeForPassWordAndUserName.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ButtonEmployeeForPassWordAndUserName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonEmployeeForPassWordAndUserName.Location = new System.Drawing.Point(317, 407);
            this.ButtonEmployeeForPassWordAndUserName.Name = "ButtonEmployeeForPassWordAndUserName";
            this.ButtonEmployeeForPassWordAndUserName.Size = new System.Drawing.Size(92, 36);
            this.ButtonEmployeeForPassWordAndUserName.TabIndex = 6;
            this.ButtonEmployeeForPassWordAndUserName.Text = "Log in ";
            this.ButtonEmployeeForPassWordAndUserName.UseVisualStyleBackColor = false;
            this.ButtonEmployeeForPassWordAndUserName.Click += new System.EventHandler(this.ButtonEmployeeForPassWordAndUserName_Click_1);
            // 
            // PasswordEmpolyee
            // 
            this.PasswordEmpolyee.Location = new System.Drawing.Point(231, 281);
            this.PasswordEmpolyee.Name = "PasswordEmpolyee";
            this.PasswordEmpolyee.Size = new System.Drawing.Size(251, 33);
            this.PasswordEmpolyee.TabIndex = 7;
            this.PasswordEmpolyee.TextChanged += new System.EventHandler(this.TextBoxForPasswordEmpolyee_TextChanged_1);
            // 
            // UserNameEmpolyee
            // 
            this.UserNameEmpolyee.Location = new System.Drawing.Point(231, 196);
            this.UserNameEmpolyee.Name = "UserNameEmpolyee";
            this.UserNameEmpolyee.Size = new System.Drawing.Size(251, 33);
            this.UserNameEmpolyee.TabIndex = 8;
            this.UserNameEmpolyee.TextChanged += new System.EventHandler(this.UserNameEmpolyee_TextChanged);
            // 
            // LabelUserNameEnter
            // 
            this.LabelUserNameEnter.AutoSize = true;
            this.LabelUserNameEnter.Location = new System.Drawing.Point(30, 131);
            this.LabelUserNameEnter.Name = "LabelUserNameEnter";
            this.LabelUserNameEnter.Size = new System.Drawing.Size(0, 25);
            this.LabelUserNameEnter.TabIndex = 11;
            
            // 
            // LabelPasswordUser
            // 
            this.LabelPasswordUser.AutoSize = true;
            this.LabelPasswordUser.Location = new System.Drawing.Point(30, 231);
            this.LabelPasswordUser.Name = "LabelPasswordUser";
            this.LabelPasswordUser.Size = new System.Drawing.Size(0, 25);
            this.LabelPasswordUser.TabIndex = 12;
            this.LabelPasswordUser.Click += new System.EventHandler(this.LabelPasswordUser_Click);
            // 
            // LabelUserEntry
            // 
            this.LabelUserEntry.AutoSize = true;
            this.LabelUserEntry.Location = new System.Drawing.Point(162, 75);
            this.LabelUserEntry.Name = "LabelUserEntry";
            this.LabelUserEntry.Size = new System.Drawing.Size(0, 25);
            this.LabelUserEntry.TabIndex = 13;
            
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 527);
            this.Controls.Add(this.LabelUserEntry);
            this.Controls.Add(this.LabelPasswordUser);
            this.Controls.Add(this.LabelUserNameEnter);
            this.Controls.Add(this.UserNameEmpolyee);
            this.Controls.Add(this.PasswordEmpolyee);
            this.Controls.Add(this.ButtonEmployeeForPassWordAndUserName);
            this.Controls.Add(this.UserNameEmploeeLabel);
            this.Controls.Add(this.PasswordEmpoleeEntryLabel);
            this.Controls.Add(this.EmployeEentryLabel);
            this.Controls.Add(this.MainTitleLabrary);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "Welcom To Labrary";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label MainTitleLabrary;
        private Label EmployeEentryLabel;
        private Label PasswordEmpoleeEntryLabel;
        private Label UserNameEmploeeLabel;
        private Button ButtonEmployeeForPassWordAndUserName;
        private TextBox PasswordEmpolyee;
        private TextBox UserNameEmpolyee;
        private Label LabelUserNameEnter;
        private Label LabelPasswordUser;
        private Label LabelUserEntry;
    }
}