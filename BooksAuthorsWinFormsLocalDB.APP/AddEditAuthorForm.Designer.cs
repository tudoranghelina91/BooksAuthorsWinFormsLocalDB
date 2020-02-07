namespace BooksAuthorsWinFormsLocalDB.APP
{
    partial class AddEditAuthorForm
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
            this.authorDateOfBirthLabel = new System.Windows.Forms.Label();
            this.authorLastNameLabel = new System.Windows.Forms.Label();
            this.authorFirstNameLabel = new System.Windows.Forms.Label();
            this.submitAuthorChangesBtn = new System.Windows.Forms.Button();
            this.authorDateOfBirthDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.authorLastNameTextBox = new System.Windows.Forms.TextBox();
            this.authorFirstNameTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // authorDateOfBirthLabel
            // 
            this.authorDateOfBirthLabel.AutoSize = true;
            this.authorDateOfBirthLabel.Location = new System.Drawing.Point(12, 122);
            this.authorDateOfBirthLabel.Name = "authorDateOfBirthLabel";
            this.authorDateOfBirthLabel.Size = new System.Drawing.Size(68, 13);
            this.authorDateOfBirthLabel.TabIndex = 13;
            this.authorDateOfBirthLabel.Text = "Date Of Birth";
            // 
            // authorLastNameLabel
            // 
            this.authorLastNameLabel.AutoSize = true;
            this.authorLastNameLabel.Location = new System.Drawing.Point(12, 66);
            this.authorLastNameLabel.Name = "authorLastNameLabel";
            this.authorLastNameLabel.Size = new System.Drawing.Size(58, 13);
            this.authorLastNameLabel.TabIndex = 12;
            this.authorLastNameLabel.Text = "Last Name";
            // 
            // authorFirstNameLabel
            // 
            this.authorFirstNameLabel.AutoSize = true;
            this.authorFirstNameLabel.Location = new System.Drawing.Point(12, 9);
            this.authorFirstNameLabel.Name = "authorFirstNameLabel";
            this.authorFirstNameLabel.Size = new System.Drawing.Size(57, 13);
            this.authorFirstNameLabel.TabIndex = 11;
            this.authorFirstNameLabel.Text = "First Name";
            // 
            // submitAuthorChangesBtn
            // 
            this.submitAuthorChangesBtn.Location = new System.Drawing.Point(63, 187);
            this.submitAuthorChangesBtn.Name = "submitAuthorChangesBtn";
            this.submitAuthorChangesBtn.Size = new System.Drawing.Size(75, 23);
            this.submitAuthorChangesBtn.TabIndex = 10;
            this.submitAuthorChangesBtn.Text = "Save Changes";
            this.submitAuthorChangesBtn.UseVisualStyleBackColor = true;
            this.submitAuthorChangesBtn.Click += new System.EventHandler(this.submitAuthorChangesBtn_Click);
            // 
            // authorDateOfBirthDateTimePicker
            // 
            this.authorDateOfBirthDateTimePicker.CustomFormat = "";
            this.authorDateOfBirthDateTimePicker.Location = new System.Drawing.Point(15, 138);
            this.authorDateOfBirthDateTimePicker.MaxDate = new System.DateTime(2019, 11, 6, 0, 0, 0, 0);
            this.authorDateOfBirthDateTimePicker.Name = "authorDateOfBirthDateTimePicker";
            this.authorDateOfBirthDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.authorDateOfBirthDateTimePicker.TabIndex = 9;
            this.authorDateOfBirthDateTimePicker.Value = new System.DateTime(2019, 11, 6, 0, 0, 0, 0);
            // 
            // authorLastNameTextBox
            // 
            this.authorLastNameTextBox.Location = new System.Drawing.Point(12, 82);
            this.authorLastNameTextBox.Name = "authorLastNameTextBox";
            this.authorLastNameTextBox.Size = new System.Drawing.Size(200, 20);
            this.authorLastNameTextBox.TabIndex = 8;
            this.authorLastNameTextBox.TextChanged += new System.EventHandler(this.authorLastNameTextBox_TextChanged);
            // 
            // authorFirstNameTextBox
            // 
            this.authorFirstNameTextBox.Location = new System.Drawing.Point(12, 25);
            this.authorFirstNameTextBox.Name = "authorFirstNameTextBox";
            this.authorFirstNameTextBox.Size = new System.Drawing.Size(200, 20);
            this.authorFirstNameTextBox.TabIndex = 7;
            this.authorFirstNameTextBox.TextChanged += new System.EventHandler(this.authorFirstNameTextBox_TextChanged);
            // 
            // AddAuthor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(231, 234);
            this.Controls.Add(this.authorDateOfBirthLabel);
            this.Controls.Add(this.authorLastNameLabel);
            this.Controls.Add(this.authorFirstNameLabel);
            this.Controls.Add(this.submitAuthorChangesBtn);
            this.Controls.Add(this.authorDateOfBirthDateTimePicker);
            this.Controls.Add(this.authorLastNameTextBox);
            this.Controls.Add(this.authorFirstNameTextBox);
            this.Name = "AddAuthor";
            this.Text = "AddAuthor";
            this.Load += new System.EventHandler(this.AddAuthor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label authorDateOfBirthLabel;
        private System.Windows.Forms.Label authorLastNameLabel;
        private System.Windows.Forms.Label authorFirstNameLabel;
        private System.Windows.Forms.Button submitAuthorChangesBtn;
        private System.Windows.Forms.DateTimePicker authorDateOfBirthDateTimePicker;
        private System.Windows.Forms.TextBox authorLastNameTextBox;
        private System.Windows.Forms.TextBox authorFirstNameTextBox;
    }
}