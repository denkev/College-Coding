namespace frmStudentInfo
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            studentID = new RichTextBox();
            lastName = new RichTextBox();
            firstName = new RichTextBox();
            Submit = new Button();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            listID = new ListBox();
            listFirst = new ListBox();
            listLast = new ListBox();

            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(31, 26);
            label1.Name = "label1";
            label1.Size = new Size(100, 21);
            label1.TabIndex = 0;
            label1.Text = "Student ID*";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(271, 26);
            label2.Name = "label2";
            label2.Size = new Size(99, 21);
            label2.TabIndex = 1;
            label2.Text = "Last Name*";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(521, 26);
            label3.Name = "label3";
            label3.Size = new Size(101, 21);
            label3.TabIndex = 2;
            label3.Text = "First Name*";
            // 
            // studentID
            // 
            studentID.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            studentID.Location = new Point(31, 59);
            studentID.Name = "studentID";
            studentID.Size = new Size(214, 26);
            studentID.TabIndex = 3;
            studentID.Text = "";
            // 
            // lastName
            // 
            lastName.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lastName.Location = new Point(271, 59);
            lastName.Name = "lastName";
            lastName.Size = new Size(227, 26);
            lastName.TabIndex = 4;
            lastName.Text = "";
            // 
            // firstName
            // 
            firstName.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            firstName.Location = new Point(521, 59);
            firstName.Name = "firstName";
            firstName.Size = new Size(231, 26);
            firstName.TabIndex = 5;
            firstName.Text = "";
            // 
            // Submit
            // 
            Submit.FlatStyle = FlatStyle.Popup;
            Submit.Location = new Point(677, 107);
            Submit.Name = "Submit";
            Submit.Size = new Size(75, 23);
            Submit.TabIndex = 6;
            Submit.Text = "Submit";
            Submit.UseVisualStyleBackColor = true;
            Submit.Click += Submit_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(51, 174);
            label4.Name = "label4";
            label4.Size = new Size(124, 21);
            label4.TabIndex = 7;
            label4.Text = "Student ID List";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(297, 174);
            label5.Name = "label5";
            label5.Size = new Size(125, 21);
            label5.TabIndex = 8;
            label5.Text = "First Name List";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(548, 174);
            label6.Name = "label6";
            label6.Size = new Size(123, 21);
            label6.TabIndex = 9;
            label6.Text = "Last Name List";
            // 
            // listID
            // 
            listID.Location = new Point(51, 209);
            listID.Name = "listID";
            listID.Size = new Size(194, 211);
            listID.TabIndex = 10;
            listID.Text = "";
            // 
            // listFirst
            // 
            listFirst.Location = new Point(297, 209);
            listFirst.Name = "listFirst";
            listFirst.Size = new Size(194, 211);
            listFirst.TabIndex = 11;
            listFirst.Text = "";
            // 
            // listLast
            // 
            listLast.Location = new Point(548, 209);
            listLast.Name = "listLast";
            listLast.Size = new Size(194, 211);
            listLast.TabIndex = 12;
            listLast.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listLast);
            Controls.Add(listFirst);
            Controls.Add(listID);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(Submit);
            Controls.Add(firstName);
            Controls.Add(lastName);
            Controls.Add(studentID);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private RichTextBox studentID;
        private RichTextBox lastName;
        private RichTextBox firstName;
        private Button Submit;
        private Label label4;
        private Label label5;
        private Label label6;
        private ListBox listID;
        private ListBox listFirst;
        private ListBox listLast;
    }
}
