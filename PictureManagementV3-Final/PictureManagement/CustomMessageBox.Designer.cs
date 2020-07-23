namespace PictureManagement
{
    partial class CustomMessageBox
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
            this.messagePanel = new System.Windows.Forms.Panel();
            this.displayMessage = new System.Windows.Forms.Label();
            this.okButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.messagePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // messagePanel
            // 
            this.messagePanel.BackColor = System.Drawing.Color.White;
            this.messagePanel.Controls.Add(this.displayMessage);
            this.messagePanel.Location = new System.Drawing.Point(-10, 0);
            this.messagePanel.Name = "messagePanel";
            this.messagePanel.Size = new System.Drawing.Size(328, 85);
            this.messagePanel.TabIndex = 2;
            // 
            // displayMessage
            // 
            this.displayMessage.AutoSize = true;
            this.displayMessage.Location = new System.Drawing.Point(22, 9);
            this.displayMessage.MaximumSize = new System.Drawing.Size(300, 75);
            this.displayMessage.MinimumSize = new System.Drawing.Size(300, 75);
            this.displayMessage.Name = "displayMessage";
            this.displayMessage.Size = new System.Drawing.Size(300, 75);
            this.displayMessage.TabIndex = 2;
            this.displayMessage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(261, 155);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(100, 35);
            this.okButton.TabIndex = 0;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            this.okButton.KeyDown += new System.Windows.Forms.KeyEventHandler(this.okButton_onKeyDown);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(188, 100);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 32);
            this.button1.TabIndex = 3;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.okButton_Click);
            this.button1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.okButton_onKeyDown);
            // 
            // CustomMessageBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(310, 148);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.messagePanel);
            this.Controls.Add(this.okButton);
            this.KeyPreview = true;
            this.Name = "CustomMessageBox";
            this.Text = "CustomMessageBox";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.onKeyDown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.onMouseDown);
            this.messagePanel.ResumeLayout(false);
            this.messagePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel messagePanel;
        private System.Windows.Forms.Label displayMessage;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button button1;
    }
}