namespace UnknownSystem
{
    partial class Welcome
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
            label1 = new Label();
            registerB = new Button();
            databaseB = new Button();
            button1 = new Button();
            loginPanel1 = new LoginPanel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(640, 48);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // registerB
            // 
            registerB.Location = new Point(704, 16);
            registerB.Name = "registerB";
            registerB.Size = new Size(75, 23);
            registerB.TabIndex = 1;
            registerB.Text = "Register ";
            registerB.UseVisualStyleBackColor = true;
            registerB.Click += registerClick;
            // 
            // databaseB
            // 
            databaseB.Location = new Point(704, 56);
            databaseB.Name = "databaseB";
            databaseB.Size = new Size(75, 23);
            databaseB.TabIndex = 2;
            databaseB.Text = "Database";
            databaseB.UseVisualStyleBackColor = true;
            databaseB.Click += databaseClick;
            // 
            // button1
            // 
            button1.Location = new Point(40, 40);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 3;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = true;
            button1.Click += loginClick;
            // 
            // loginPanel1
            // 
            loginPanel1.BackColor = Color.Transparent;
            loginPanel1.Location = new Point(272, 120);
            loginPanel1.Name = "loginPanel1";
            loginPanel1.Size = new Size(243, 177);
            loginPanel1.TabIndex = 4;
            // 
            // Welcome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(loginPanel1);
            Controls.Add(button1);
            Controls.Add(databaseB);
            Controls.Add(registerB);
            Controls.Add(label1);
            Name = "Welcome";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            Load += Welcome_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button registerB;
        private Button databaseB;
        private Button button1;
        private LoginPanel loginPanel1;
    }
}