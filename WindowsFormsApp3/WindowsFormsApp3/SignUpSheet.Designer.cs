namespace WindowsFormsApp3
{
    partial class SignUpSheet
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
            this.HomeDateAndTime = new System.Windows.Forms.DateTimePicker();
            this.SignUpHeader = new System.Windows.Forms.Label();
            this.SignUpBack = new System.Windows.Forms.Button();
            this.SignUpSubmit = new System.Windows.Forms.Button();
            this.ActivityListBox = new System.Windows.Forms.ListBox();
            this.SignUpUpdate = new System.Windows.Forms.Button();
            this.CamperListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // HomeDateAndTime
            // 
            this.HomeDateAndTime.Location = new System.Drawing.Point(200, 10);
            this.HomeDateAndTime.Name = "HomeDateAndTime";
            this.HomeDateAndTime.Size = new System.Drawing.Size(161, 20);
            this.HomeDateAndTime.TabIndex = 5;
            // 
            // SignUpHeader
            // 
            this.SignUpHeader.AutoSize = true;
            this.SignUpHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUpHeader.Location = new System.Drawing.Point(10, 10);
            this.SignUpHeader.Name = "SignUpHeader";
            this.SignUpHeader.Size = new System.Drawing.Size(99, 29);
            this.SignUpHeader.TabIndex = 6;
            this.SignUpHeader.Text = "Sign Up";
            // 
            // SignUpBack
            // 
            this.SignUpBack.Location = new System.Drawing.Point(130, 320);
            this.SignUpBack.Name = "SignUpBack";
            this.SignUpBack.Size = new System.Drawing.Size(120, 34);
            this.SignUpBack.TabIndex = 7;
            this.SignUpBack.Text = "Back";
            this.SignUpBack.UseVisualStyleBackColor = true;
            this.SignUpBack.Click += new System.EventHandler(this.ActivityDetailsBack_Click);
            // 
            // SignUpSubmit
            // 
            this.SignUpSubmit.Location = new System.Drawing.Point(255, 320);
            this.SignUpSubmit.Name = "SignUpSubmit";
            this.SignUpSubmit.Size = new System.Drawing.Size(120, 34);
            this.SignUpSubmit.TabIndex = 8;
            this.SignUpSubmit.Text = "Submit";
            this.SignUpSubmit.UseVisualStyleBackColor = true;
            // 
            // ActivityListBox
            // 
            this.ActivityListBox.FormattingEnabled = true;
            this.ActivityListBox.Location = new System.Drawing.Point(5, 79);
            this.ActivityListBox.Name = "ActivityListBox";
            this.ActivityListBox.Size = new System.Drawing.Size(156, 225);
            this.ActivityListBox.TabIndex = 9;
            // 
            // SignUpUpdate
            // 
            this.SignUpUpdate.Location = new System.Drawing.Point(5, 320);
            this.SignUpUpdate.Name = "SignUpUpdate";
            this.SignUpUpdate.Size = new System.Drawing.Size(120, 34);
            this.SignUpUpdate.TabIndex = 10;
            this.SignUpUpdate.Text = "Update";
            this.SignUpUpdate.UseVisualStyleBackColor = true;
            // 
            // CamperListBox
            // 
            this.CamperListBox.FormattingEnabled = true;
            this.CamperListBox.Location = new System.Drawing.Point(219, 79);
            this.CamperListBox.Name = "CamperListBox";
            this.CamperListBox.Size = new System.Drawing.Size(156, 225);
            this.CamperListBox.TabIndex = 9;
            // 
            // SignUpSheet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.SignUpUpdate);
            this.Controls.Add(this.CamperListBox);
            this.Controls.Add(this.ActivityListBox);
            this.Controls.Add(this.SignUpSubmit);
            this.Controls.Add(this.SignUpBack);
            this.Controls.Add(this.SignUpHeader);
            this.Controls.Add(this.HomeDateAndTime);
            this.Name = "SignUpSheet";
            this.Text = "SignUpSheet";
            this.Load += new System.EventHandler(this.SignUpSheet_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker HomeDateAndTime;
        private System.Windows.Forms.Label SignUpHeader;
        private System.Windows.Forms.Button SignUpBack;
        private System.Windows.Forms.Button SignUpSubmit;
        private System.Windows.Forms.ListBox ActivityListBox;
        private System.Windows.Forms.Button SignUpUpdate;
        private System.Windows.Forms.ListBox CamperListBox;
    }
}