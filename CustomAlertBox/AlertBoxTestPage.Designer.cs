namespace CustomAlertBox
{
    partial class AlertBoxTestPage
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
            this.btnSuccessAlert = new System.Windows.Forms.Button();
            this.btnErrorAlert = new System.Windows.Forms.Button();
            this.btnWarningAlert = new System.Windows.Forms.Button();
            this.btnInfoAlert = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSuccessAlert
            // 
            this.btnSuccessAlert.Location = new System.Drawing.Point(64, 57);
            this.btnSuccessAlert.Name = "btnSuccessAlert";
            this.btnSuccessAlert.Size = new System.Drawing.Size(172, 62);
            this.btnSuccessAlert.TabIndex = 0;
            this.btnSuccessAlert.Text = "Success";
            this.btnSuccessAlert.UseVisualStyleBackColor = true;
            this.btnSuccessAlert.Click += new System.EventHandler(this.btnSuccessAlert_Click);
            // 
            // btnErrorAlert
            // 
            this.btnErrorAlert.Location = new System.Drawing.Point(64, 125);
            this.btnErrorAlert.Name = "btnErrorAlert";
            this.btnErrorAlert.Size = new System.Drawing.Size(172, 62);
            this.btnErrorAlert.TabIndex = 0;
            this.btnErrorAlert.Text = "Error";
            this.btnErrorAlert.UseVisualStyleBackColor = true;
            this.btnErrorAlert.Click += new System.EventHandler(this.btnErrorAlert_Click);
            // 
            // btnWarningAlert
            // 
            this.btnWarningAlert.Location = new System.Drawing.Point(64, 193);
            this.btnWarningAlert.Name = "btnWarningAlert";
            this.btnWarningAlert.Size = new System.Drawing.Size(172, 62);
            this.btnWarningAlert.TabIndex = 0;
            this.btnWarningAlert.Text = "Warning";
            this.btnWarningAlert.UseVisualStyleBackColor = true;
            this.btnWarningAlert.Click += new System.EventHandler(this.btnWarningAlert_Click);
            // 
            // btnInfoAlert
            // 
            this.btnInfoAlert.Location = new System.Drawing.Point(64, 261);
            this.btnInfoAlert.Name = "btnInfoAlert";
            this.btnInfoAlert.Size = new System.Drawing.Size(172, 62);
            this.btnInfoAlert.TabIndex = 0;
            this.btnInfoAlert.Text = "Info";
            this.btnInfoAlert.UseVisualStyleBackColor = true;
            this.btnInfoAlert.Click += new System.EventHandler(this.btnInfoAlert_Click);
            // 
            // AlertBoxTestPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 382);
            this.Controls.Add(this.btnInfoAlert);
            this.Controls.Add(this.btnWarningAlert);
            this.Controls.Add(this.btnErrorAlert);
            this.Controls.Add(this.btnSuccessAlert);
            this.Name = "AlertBoxTestPage";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSuccessAlert;
        private System.Windows.Forms.Button btnErrorAlert;
        private System.Windows.Forms.Button btnWarningAlert;
        private System.Windows.Forms.Button btnInfoAlert;
    }
}

