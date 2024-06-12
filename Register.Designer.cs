namespace UnknownSystem
{
    partial class Register
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
            label2 = new Label();
            label3 = new Label();
            titleField = new TextBox();
            authorField = new TextBox();
            yearField = new TextBox();
            button1 = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            label4 = new Label();
            genreField = new ComboBox();
            button2 = new Button();
            button3 = new Button();
            bookIDfield = new TextBox();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Location = new Point(61, 13);
            label1.Name = "label1";
            label1.Size = new Size(29, 15);
            label1.TabIndex = 0;
            label1.Text = "Title";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Location = new Point(54, 55);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 1;
            label2.Text = "Author";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Location = new Point(61, 97);
            label3.Name = "label3";
            label3.Size = new Size(29, 15);
            label3.TabIndex = 2;
            label3.Text = "Year";
            // 
            // titleField
            // 
            titleField.Anchor = AnchorStyles.None;
            titleField.Location = new Point(178, 9);
            titleField.Name = "titleField";
            titleField.Size = new Size(100, 23);
            titleField.TabIndex = 3;
            // 
            // authorField
            // 
            authorField.Anchor = AnchorStyles.None;
            authorField.Location = new Point(178, 51);
            authorField.Name = "authorField";
            authorField.Size = new Size(100, 23);
            authorField.TabIndex = 4;
            // 
            // yearField
            // 
            yearField.Anchor = AnchorStyles.None;
            yearField.Location = new Point(178, 93);
            yearField.Name = "yearField";
            yearField.Size = new Size(100, 23);
            yearField.TabIndex = 5;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(312, 280);
            button1.Name = "button1";
            button1.Size = new Size(184, 64);
            button1.TabIndex = 6;
            button1.Text = "Register";
            button1.UseVisualStyleBackColor = true;
            button1.Click += regClick;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(titleField, 1, 0);
            tableLayoutPanel1.Controls.Add(authorField, 1, 1);
            tableLayoutPanel1.Controls.Add(label3, 0, 2);
            tableLayoutPanel1.Controls.Add(yearField, 1, 2);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(label4, 0, 3);
            tableLayoutPanel1.Controls.Add(genreField, 1, 3);
            tableLayoutPanel1.Location = new Point(248, 48);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Size = new Size(304, 168);
            tableLayoutPanel1.TabIndex = 7;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Location = new Point(57, 139);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 6;
            label4.Text = "label4";
            // 
            // genreField
            // 
            genreField.Anchor = AnchorStyles.None;
            genreField.FormattingEnabled = true;
            genreField.Items.AddRange(new object[] { "Drama", "Comedy", "Horror", "Fiction", "SciFi", "Fantasy", "Action", "Thriller", "Crime", "Educational", "Science", "Financial", "Philosophy" });
            genreField.Location = new Point(175, 135);
            genreField.Name = "genreField";
            genreField.Size = new Size(106, 23);
            genreField.TabIndex = 7;
            // 
            // button2
            // 
            button2.Location = new Point(0, 0);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 8;
            button2.Text = "Back";
            button2.UseVisualStyleBackColor = true;
            button2.Click += backButton;
            // 
            // button3
            // 
            button3.Location = new Point(528, 288);
            button3.Name = "button3";
            button3.Size = new Size(115, 48);
            button3.TabIndex = 9;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // bookIDfield
            // 
            bookIDfield.Location = new Point(88, 56);
            bookIDfield.Name = "bookIDfield";
            bookIDfield.Size = new Size(100, 23);
            bookIDfield.TabIndex = 10;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(bookIDfield);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(button1);
            Name = "Register";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Register";
            Load += Register_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox titleField;
        private TextBox authorField;
        private TextBox yearField;
        private Button button1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label4;
        private ComboBox genreField;
        private Button button2;
        private Button button3;
        private TextBox bookIDfield;
    }
}