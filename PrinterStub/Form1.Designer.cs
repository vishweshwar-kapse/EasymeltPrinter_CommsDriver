namespace PrinterStub
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
            this.txtMessagesFromSFS = new System.Windows.Forms.TextBox();
            this.btnClearText = new System.Windows.Forms.Button();
            this.btnStartListening = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtMessagesFromSFS
            // 
            this.txtMessagesFromSFS.Location = new System.Drawing.Point(22, 12);
            this.txtMessagesFromSFS.Multiline = true;
            this.txtMessagesFromSFS.Name = "txtMessagesFromSFS";
            this.txtMessagesFromSFS.Size = new System.Drawing.Size(419, 178);
            this.txtMessagesFromSFS.TabIndex = 0;
            // 
            // btnClearText
            // 
            this.btnClearText.Location = new System.Drawing.Point(366, 221);
            this.btnClearText.Name = "btnClearText";
            this.btnClearText.Size = new System.Drawing.Size(75, 23);
            this.btnClearText.TabIndex = 1;
            this.btnClearText.Text = "Clear";
            this.btnClearText.UseVisualStyleBackColor = true;
            // 
            // btnStartListening
            // 
            this.btnStartListening.Location = new System.Drawing.Point(216, 221);
            this.btnStartListening.Name = "btnStartListening";
            this.btnStartListening.Size = new System.Drawing.Size(131, 23);
            this.btnStartListening.TabIndex = 2;
            this.btnStartListening.Text = "Start Listening";
            this.btnStartListening.UseVisualStyleBackColor = true;
            this.btnStartListening.Click += new System.EventHandler(this.btnStartListening_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnStartListening);
            this.Controls.Add(this.btnClearText);
            this.Controls.Add(this.txtMessagesFromSFS);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMessagesFromSFS;
        private System.Windows.Forms.Button btnClearText;
        private System.Windows.Forms.Button btnStartListening;
    }
}

