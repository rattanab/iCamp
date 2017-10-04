namespace WindowsFormsApp3
{
    partial class Activity
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
            this.ActivityDetailsLabel = new System.Windows.Forms.Label();
            this.ActivityDetailsOutsideActivityChecklist = new System.Windows.Forms.CheckedListBox();
            this.ActivityDetailsGenerate = new System.Windows.Forms.Button();
            this.ActivityDetailsIndoorActivityChecklist = new System.Windows.Forms.CheckedListBox();
            this.SelectActivitiesTextBox = new System.Windows.Forms.TextBox();
            this.ActivityDetailsBack = new System.Windows.Forms.Button();
            this.ActivityDetailsSubmit = new System.Windows.Forms.Button();
            this.ActivityDetailsListBox = new System.Windows.Forms.ListBox();
            this.HomeDateAndTime = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // ActivityDetailsLabel
            // 
            this.ActivityDetailsLabel.AutoSize = true;
            this.ActivityDetailsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ActivityDetailsLabel.Location = new System.Drawing.Point(10, 10);
            this.ActivityDetailsLabel.Name = "ActivityDetailsLabel";
            this.ActivityDetailsLabel.Size = new System.Drawing.Size(166, 29);
            this.ActivityDetailsLabel.TabIndex = 0;
            this.ActivityDetailsLabel.Text = "Activity Details";
            // 
            // ActivityDetailsOutsideActivityChecklist
            // 
            this.ActivityDetailsOutsideActivityChecklist.FormattingEnabled = true;
            this.ActivityDetailsOutsideActivityChecklist.Items.AddRange(new object[] {
            "Archery",
            "Boxing",
            "Gaga Game",
            "Horse Riding",
            "Tennis",
            "Swimming",
            "Waterpark",
            "Soccer",
            "Adventure Park",
            "Flag Football",
            "Basketball",
            "Beach Volleyball"});
            this.ActivityDetailsOutsideActivityChecklist.Location = new System.Drawing.Point(15, 70);
            this.ActivityDetailsOutsideActivityChecklist.Name = "ActivityDetailsOutsideActivityChecklist";
            this.ActivityDetailsOutsideActivityChecklist.Size = new System.Drawing.Size(120, 184);
            this.ActivityDetailsOutsideActivityChecklist.TabIndex = 1;
            this.ActivityDetailsOutsideActivityChecklist.SelectedIndexChanged += new System.EventHandler(this.ActivityDetailsOutsideActivityChecklist_SelectedIndexChanged);
            // 
            // ActivityDetailsGenerate
            // 
            this.ActivityDetailsGenerate.Location = new System.Drawing.Point(5, 320);
            this.ActivityDetailsGenerate.Name = "ActivityDetailsGenerate";
            this.ActivityDetailsGenerate.Size = new System.Drawing.Size(120, 34);
            this.ActivityDetailsGenerate.TabIndex = 2;
            this.ActivityDetailsGenerate.Text = "Generate";
            this.ActivityDetailsGenerate.UseVisualStyleBackColor = true;
            this.ActivityDetailsGenerate.Click += new System.EventHandler(this.ActivityDetailsGenerate_Click);
            // 
            // ActivityDetailsIndoorActivityChecklist
            // 
            this.ActivityDetailsIndoorActivityChecklist.FormattingEnabled = true;
            this.ActivityDetailsIndoorActivityChecklist.Items.AddRange(new object[] {
            "Painting",
            "Fashion Design",
            "Sculpture",
            "Print-Making",
            "Weaving",
            "Creative Writing",
            "Puppetry"});
            this.ActivityDetailsIndoorActivityChecklist.Location = new System.Drawing.Point(137, 70);
            this.ActivityDetailsIndoorActivityChecklist.Name = "ActivityDetailsIndoorActivityChecklist";
            this.ActivityDetailsIndoorActivityChecklist.Size = new System.Drawing.Size(120, 109);
            this.ActivityDetailsIndoorActivityChecklist.TabIndex = 1;
            // 
            // SelectActivitiesTextBox
            // 
            this.SelectActivitiesTextBox.Location = new System.Drawing.Point(137, 44);
            this.SelectActivitiesTextBox.Name = "SelectActivitiesTextBox";
            this.SelectActivitiesTextBox.ReadOnly = true;
            this.SelectActivitiesTextBox.Size = new System.Drawing.Size(120, 20);
            this.SelectActivitiesTextBox.TabIndex = 3;
            this.SelectActivitiesTextBox.Text = "Select Activities";
            this.SelectActivitiesTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.SelectActivitiesTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // ActivityDetailsBack
            // 
            this.ActivityDetailsBack.Location = new System.Drawing.Point(130, 320);
            this.ActivityDetailsBack.Name = "ActivityDetailsBack";
            this.ActivityDetailsBack.Size = new System.Drawing.Size(120, 34);
            this.ActivityDetailsBack.TabIndex = 2;
            this.ActivityDetailsBack.Text = "Back";
            this.ActivityDetailsBack.UseVisualStyleBackColor = true;
            this.ActivityDetailsBack.Click += new System.EventHandler(this.ActivityDetailsBack_Click);
            // 
            // ActivityDetailsSubmit
            // 
            this.ActivityDetailsSubmit.Location = new System.Drawing.Point(255, 320);
            this.ActivityDetailsSubmit.Name = "ActivityDetailsSubmit";
            this.ActivityDetailsSubmit.Size = new System.Drawing.Size(120, 34);
            this.ActivityDetailsSubmit.TabIndex = 2;
            this.ActivityDetailsSubmit.Text = "Submit";
            this.ActivityDetailsSubmit.UseVisualStyleBackColor = true;
            // 
            // ActivityDetailsListBox
            // 
            this.ActivityDetailsListBox.FormattingEnabled = true;
            this.ActivityDetailsListBox.Location = new System.Drawing.Point(260, 70);
            this.ActivityDetailsListBox.Name = "ActivityDetailsListBox";
            this.ActivityDetailsListBox.Size = new System.Drawing.Size(120, 134);
            this.ActivityDetailsListBox.TabIndex = 6;
            // 
            // HomeDateAndTime
            // 
            this.HomeDateAndTime.Location = new System.Drawing.Point(200, 10);
            this.HomeDateAndTime.Name = "HomeDateAndTime";
            this.HomeDateAndTime.Size = new System.Drawing.Size(161, 20);
            this.HomeDateAndTime.TabIndex = 7;
            // 
            // Activity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.HomeDateAndTime);
            this.Controls.Add(this.ActivityDetailsListBox);
            this.Controls.Add(this.SelectActivitiesTextBox);
            this.Controls.Add(this.ActivityDetailsBack);
            this.Controls.Add(this.ActivityDetailsSubmit);
            this.Controls.Add(this.ActivityDetailsGenerate);
            this.Controls.Add(this.ActivityDetailsIndoorActivityChecklist);
            this.Controls.Add(this.ActivityDetailsOutsideActivityChecklist);
            this.Controls.Add(this.ActivityDetailsLabel);
            this.Name = "Activity";
            this.Text = "Activity Details";
            this.Load += new System.EventHandler(this.Activity_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ActivityDetailsLabel;
        private System.Windows.Forms.CheckedListBox ActivityDetailsOutsideActivityChecklist;
        private System.Windows.Forms.Button ActivityDetailsGenerate;
        private System.Windows.Forms.CheckedListBox ActivityDetailsIndoorActivityChecklist;
        private System.Windows.Forms.TextBox SelectActivitiesTextBox;
        private System.Windows.Forms.Button ActivityDetailsBack;
        private System.Windows.Forms.Button ActivityDetailsSubmit;
        private System.Windows.Forms.ListBox ActivityDetailsListBox;
        private System.Windows.Forms.DateTimePicker HomeDateAndTime;
    }
}