namespace UnknownSystem
{
    partial class RegisterPanel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            passwordField = new TextBox();
            usernameField = new TextBox();
            label2 = new Label();
            label1 = new Label();
            register = new Button();
            SuspendLayout();
            // 
            // passwordField
            // 
            passwordField.Location = new Point(111, 69);
            passwordField.Name = "passwordField";
            passwordField.Size = new Size(100, 23);
            passwordField.TabIndex = 8;
            // 
            // usernameField
            // 
            usernameField.Location = new Point(111, 29);
            usernameField.Name = "usernameField";
            usernameField.Size = new Size(100, 23);
            usernameField.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 69);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 6;
            label2.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 37);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 5;
            label1.Text = "Username";
            // 
            // register
            // 
            register.Location = new Point(160, 120);
            register.Name = "register";
            register.Size = new Size(75, 23);
            register.TabIndex = 9;
            register.Text = "Register";
            register.UseVisualStyleBackColor = true;
            register.Click += this.registerClick;
            // 
            // RegisterPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(register);
            Controls.Add(passwordField);
            Controls.Add(usernameField);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "RegisterPanel";
            Size = new Size(243, 177);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox passwordField;
        private TextBox usernameField;
        private Label label2;
        private Label label1;
        private Button register;
    }
}
