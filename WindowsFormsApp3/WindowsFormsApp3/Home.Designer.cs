namespace WindowsFormsApp3
{
    partial class Home
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
            this.HomRegister = new System.Windows.Forms.Button();
            this.HomeActivities = new System.Windows.Forms.Button();
            this.HomeRegisterActivities = new System.Windows.Forms.Button();
            this.HomeExit = new System.Windows.Forms.Button();
            this.HomeSessionBox = new System.Windows.Forms.ComboBox();
            this.HomeLabel = new System.Windows.Forms.Label();
            this.HomeDateAndTime = new System.Windows.Forms.DateTimePicker();
            this.StartSession = new System.Windows.Forms.Button();
            this.LogInButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // HomRegister
            // 
            this.HomRegister.Location = new System.Drawing.Point(10, 50);
            this.HomRegister.Name = "HomRegister";
            this.HomRegister.Size = new System.Drawing.Size(161, 72);
            this.HomRegister.TabIndex = 0;
            this.HomRegister.Text = "Register";
            this.HomRegister.UseVisualStyleBackColor = true;
            this.HomRegister.Click += new System.EventHandler(this.HomRegister_Click);
            // 
            // HomeActivities
            // 
            this.HomeActivities.Location = new System.Drawing.Point(10, 150);
            this.HomeActivities.Name = "HomeActivities";
            this.HomeActivities.Size = new System.Drawing.Size(161, 72);
            this.HomeActivities.TabIndex = 0;
            this.HomeActivities.Text = "Activities";
            this.HomeActivities.UseVisualStyleBackColor = true;
            this.HomeActivities.Click += new System.EventHandler(this.HomeActivities_Click);
            // 
            // HomeRegisterActivities
            // 
            this.HomeRegisterActivities.Location = new System.Drawing.Point(10, 250);
            this.HomeRegisterActivities.Name = "HomeRegisterActivities";
            this.HomeRegisterActivities.Size = new System.Drawing.Size(161, 72);
            this.HomeRegisterActivities.TabIndex = 0;
            this.HomeRegisterActivities.Text = "Register Activities";
            this.HomeRegisterActivities.UseVisualStyleBackColor = true;
            this.HomeRegisterActivities.Click += new System.EventHandler(this.HomeRegisterActivities_Click);
            // 
            // HomeExit
            // 
            this.HomeExit.Location = new System.Drawing.Point(200, 250);
            this.HomeExit.Name = "HomeExit";
            this.HomeExit.Size = new System.Drawing.Size(161, 72);
            this.HomeExit.TabIndex = 0;
            this.HomeExit.Text = "Exit";
            this.HomeExit.UseVisualStyleBackColor = true;
            this.HomeExit.Click += new System.EventHandler(this.HomeExit_Click);
            // 
            // HomeSessionBox
            // 
            this.HomeSessionBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeSessionBox.FormattingEnabled = true;
            this.HomeSessionBox.Items.AddRange(new object[] {
            "New Session"});
            this.HomeSessionBox.Location = new System.Drawing.Point(200, 50);
            this.HomeSessionBox.Name = "HomeSessionBox";
            this.HomeSessionBox.Size = new System.Drawing.Size(161, 33);
            this.HomeSessionBox.TabIndex = 2;
            this.HomeSessionBox.Text = "Session";
            this.HomeSessionBox.SelectedIndexChanged += new System.EventHandler(this.HomeSessionBox_SelectedIndexChanged);
            // 
            // HomeLabel
            // 
            this.HomeLabel.AutoSize = true;
            this.HomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeLabel.Location = new System.Drawing.Point(10, 10);
            this.HomeLabel.Name = "HomeLabel";
            this.HomeLabel.Size = new System.Drawing.Size(106, 37);
            this.HomeLabel.TabIndex = 3;
            this.HomeLabel.Text = "Home";
            this.HomeLabel.Click += new System.EventHandler(this.HomeLabel_Click);
            // 
            // HomeDateAndTime
            // 
            this.HomeDateAndTime.Location = new System.Drawing.Point(200, 10);
            this.HomeDateAndTime.Name = "HomeDateAndTime";
            this.HomeDateAndTime.Size = new System.Drawing.Size(161, 20);
            this.HomeDateAndTime.TabIndex = 4;
            // 
            // StartSession
            // 
            this.StartSession.Location = new System.Drawing.Point(200, 89);
            this.StartSession.Name = "StartSession";
            this.StartSession.Size = new System.Drawing.Size(161, 31);
            this.StartSession.TabIndex = 0;
            this.StartSession.Text = "Start Session";
            this.StartSession.UseVisualStyleBackColor = true;
            this.StartSession.Click += new System.EventHandler(this.HomeExit_Click);
            // 
            // LogInButton
            // 
            this.LogInButton.Location = new System.Drawing.Point(10, 329);
            this.LogInButton.Name = "LogInButton";
            this.LogInButton.Size = new System.Drawing.Size(350, 30);
            this.LogInButton.TabIndex = 5;
            this.LogInButton.Text = "Log In";
            this.LogInButton.UseVisualStyleBackColor = true;
            this.LogInButton.Click += new System.EventHandler(this.LogInButton_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.LogInButton);
            this.Controls.Add(this.HomeDateAndTime);
            this.Controls.Add(this.HomeLabel);
            this.Controls.Add(this.HomeSessionBox);
            this.Controls.Add(this.StartSession);
            this.Controls.Add(this.HomeExit);
            this.Controls.Add(this.HomeRegisterActivities);
            this.Controls.Add(this.HomeActivities);
            this.Controls.Add(this.HomRegister);
            this.Name = "Home";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button HomRegister;
        private System.Windows.Forms.Button HomeActivities;
        private System.Windows.Forms.Button HomeRegisterActivities;
        private System.Windows.Forms.Button HomeExit;
        private System.Windows.Forms.ComboBox HomeSessionBox;
        private System.Windows.Forms.Label HomeLabel;
        private System.Windows.Forms.DateTimePicker HomeDateAndTime;
        private System.Windows.Forms.Button StartSession;
        private System.Windows.Forms.Button LogInButton;
    }
}

