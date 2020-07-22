namespace Password_Validator
{
    partial class Form1
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
            this.passwordPromptLabel = new System.Windows.Forms.Label();
            this.passwordPromptDescLabel = new System.Windows.Forms.Label();
            this.passwordInput = new System.Windows.Forms.TextBox();
            this.scanButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // passwordPromptLabel
            // 
            this.passwordPromptLabel.AutoSize = true;
            this.passwordPromptLabel.Location = new System.Drawing.Point(113, 18);
            this.passwordPromptLabel.Name = "passwordPromptLabel";
            this.passwordPromptLabel.Size = new System.Drawing.Size(134, 13);
            this.passwordPromptLabel.TabIndex = 0;
            this.passwordPromptLabel.Text = "Enter your password below";
            // 
            // passwordPromptDescLabel
            // 
            this.passwordPromptDescLabel.AutoSize = true;
            this.passwordPromptDescLabel.Location = new System.Drawing.Point(12, 41);
            this.passwordPromptDescLabel.Name = "passwordPromptDescLabel";
            this.passwordPromptDescLabel.Size = new System.Drawing.Size(342, 13);
            this.passwordPromptDescLabel.TabIndex = 1;
            this.passwordPromptDescLabel.Text = "A prompt will appear to let you know if your password is easily hackable";
            // 
            // passwordInput
            // 
            this.passwordInput.Location = new System.Drawing.Point(89, 76);
            this.passwordInput.Name = "passwordInput";
            this.passwordInput.Size = new System.Drawing.Size(177, 20);
            this.passwordInput.TabIndex = 2;
            // 
            // scanButton
            // 
            this.scanButton.Location = new System.Drawing.Point(139, 126);
            this.scanButton.Name = "scanButton";
            this.scanButton.Size = new System.Drawing.Size(75, 23);
            this.scanButton.TabIndex = 3;
            this.scanButton.Text = "Scan";
            this.scanButton.UseVisualStyleBackColor = true;
            this.scanButton.Click += new System.EventHandler(this.scanButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 174);
            this.Controls.Add(this.scanButton);
            this.Controls.Add(this.passwordInput);
            this.Controls.Add(this.passwordPromptDescLabel);
            this.Controls.Add(this.passwordPromptLabel);
            this.Name = "Form1";
            this.Text = "Password Validator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label passwordPromptLabel;
        private System.Windows.Forms.Label passwordPromptDescLabel;
        private System.Windows.Forms.TextBox passwordInput;
        private System.Windows.Forms.Button scanButton;
    }
}

