namespace Home_12_Form_
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
            registerLb = new Label();
            ConfirmButton = new Button();
            dateOfBirthDtp = new DateTimePicker();
            emailTb = new TextBox();
            dateOfBirthLb = new Label();
            passwordLb = new Label();
            emailLb = new Label();
            passwordTb = new TextBox();
            passwordCb = new CheckBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // registerLb
            // 
            registerLb.AutoSize = true;
            registerLb.Font = new Font("Showcard Gothic", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            registerLb.ForeColor = Color.Indigo;
            registerLb.Location = new Point(268, 26);
            registerLb.Name = "registerLb";
            registerLb.Size = new Size(201, 46);
            registerLb.TabIndex = 6;
            registerLb.Text = "REGISTER";
            // 
            // ConfirmButton
            // 
            ConfirmButton.BackColor = Color.Indigo;
            ConfirmButton.Cursor = Cursors.Hand;
            ConfirmButton.FlatAppearance.BorderSize = 0;
            ConfirmButton.FlatStyle = FlatStyle.Flat;
            ConfirmButton.Font = new Font("Showcard Gothic", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ConfirmButton.ForeColor = SystemColors.ControlLight;
            ConfirmButton.Location = new Point(250, 307);
            ConfirmButton.Name = "ConfirmButton";
            ConfirmButton.Size = new Size(234, 62);
            ConfirmButton.TabIndex = 1;
            ConfirmButton.Text = "CONFIRM";
            ConfirmButton.UseVisualStyleBackColor = false;
            ConfirmButton.Click += ConfirmButton_Click;
            // 
            // dateOfBirthDtp
            // 
            dateOfBirthDtp.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dateOfBirthDtp.Location = new Point(268, 227);
            dateOfBirthDtp.Name = "dateOfBirthDtp";
            dateOfBirthDtp.Size = new Size(292, 39);
            dateOfBirthDtp.TabIndex = 2;
            dateOfBirthDtp.Value = new DateTime(2025, 1, 8, 0, 0, 0, 0);
            // 
            // emailTb
            // 
            emailTb.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            emailTb.Location = new Point(268, 100);
            emailTb.Name = "emailTb";
            emailTb.PlaceholderText = "Enter your email here...";
            emailTb.Size = new Size(292, 35);
            emailTb.TabIndex = 3;
            // 
            // dateOfBirthLb
            // 
            dateOfBirthLb.AutoSize = true;
            dateOfBirthLb.Cursor = Cursors.Hand;
            dateOfBirthLb.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dateOfBirthLb.Location = new Point(55, 229);
            dateOfBirthLb.Name = "dateOfBirthLb";
            dateOfBirthLb.Size = new Size(170, 37);
            dateOfBirthLb.TabIndex = 4;
            dateOfBirthLb.Text = "Date Of Birth";
            // 
            // passwordLb
            // 
            passwordLb.AutoSize = true;
            passwordLb.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            passwordLb.Location = new Point(97, 163);
            passwordLb.Name = "passwordLb";
            passwordLb.Size = new Size(128, 37);
            passwordLb.TabIndex = 4;
            passwordLb.Text = "Password";
            // 
            // emailLb
            // 
            emailLb.AutoSize = true;
            emailLb.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            emailLb.Location = new Point(143, 97);
            emailLb.Name = "emailLb";
            emailLb.Size = new Size(82, 37);
            emailLb.TabIndex = 4;
            emailLb.Text = "Email";
            // 
            // passwordTb
            // 
            passwordTb.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            passwordTb.Location = new Point(268, 165);
            passwordTb.Name = "passwordTb";
            passwordTb.PasswordChar = '*';
            passwordTb.PlaceholderText = "Enter password here...";
            passwordTb.Size = new Size(292, 35);
            passwordTb.TabIndex = 3;
            // 
            // passwordCb
            // 
            passwordCb.AutoSize = true;
            passwordCb.Cursor = Cursors.Hand;
            passwordCb.Font = new Font("Segoe UI", 72F, FontStyle.Regular, GraphicsUnit.Point, 204);
            passwordCb.Location = new Point(566, 177);
            passwordCb.Name = "passwordCb";
            passwordCb.Size = new Size(15, 14);
            passwordCb.TabIndex = 7;
            passwordCb.UseVisualStyleBackColor = true;
            passwordCb.CheckedChanged += passwordCb_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(579, 174);
            label1.Name = "label1";
            label1.Size = new Size(122, 17);
            label1.TabIndex = 8;
            label1.Text = "<-- Show Password";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 255);
            ClientSize = new Size(713, 397);
            Controls.Add(label1);
            Controls.Add(passwordCb);
            Controls.Add(emailLb);
            Controls.Add(passwordLb);
            Controls.Add(dateOfBirthLb);
            Controls.Add(passwordTb);
            Controls.Add(emailTb);
            Controls.Add(dateOfBirthDtp);
            Controls.Add(ConfirmButton);
            Controls.Add(registerLb);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label registerLb;
        private Button ConfirmButton;
        private DateTimePicker dateOfBirthDtp;
        private TextBox emailTb;
        private Label dateOfBirthLb;
        private Label passwordLb;
        private Label emailLb;
        private TextBox passwordTb;
        private CheckBox passwordCb;
        private Label label1;
    }
}
