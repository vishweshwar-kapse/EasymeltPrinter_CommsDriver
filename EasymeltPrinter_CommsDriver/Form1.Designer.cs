namespace EasymeltPrinter_CommsDriver
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
            this.btnSaveConfig = new System.Windows.Forms.Button();
            this.grdKeyValuePairs = new System.Windows.Forms.DataGridView();
            this.cbFilenames = new System.Windows.Forms.ComboBox();
            this.btnAddFilename = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIpAddress = new System.Windows.Forms.TextBox();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.btnSendData = new System.Windows.Forms.Button();
            this.txtMessageLog = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtMessageContent = new System.Windows.Forms.TextBox();
            this.btnSendCommand = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdKeyValuePairs)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSaveConfig
            // 
            this.btnSaveConfig.Location = new System.Drawing.Point(48, 415);
            this.btnSaveConfig.Margin = new System.Windows.Forms.Padding(4);
            this.btnSaveConfig.Name = "btnSaveConfig";
            this.btnSaveConfig.Size = new System.Drawing.Size(195, 86);
            this.btnSaveConfig.TabIndex = 4;
            this.btnSaveConfig.Text = "Save Config to File";
            this.btnSaveConfig.UseVisualStyleBackColor = true;
            this.btnSaveConfig.Click += new System.EventHandler(this.btnSaveConfig_Click);
            // 
            // grdKeyValuePairs
            // 
            this.grdKeyValuePairs.AllowDrop = true;
            this.grdKeyValuePairs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdKeyValuePairs.Location = new System.Drawing.Point(129, 65);
            this.grdKeyValuePairs.Margin = new System.Windows.Forms.Padding(4);
            this.grdKeyValuePairs.Name = "grdKeyValuePairs";
            this.grdKeyValuePairs.Size = new System.Drawing.Size(321, 182);
            this.grdKeyValuePairs.TabIndex = 3;
            // 
            // cbFilenames
            // 
            this.cbFilenames.FormattingEnabled = true;
            this.cbFilenames.Location = new System.Drawing.Point(192, 17);
            this.cbFilenames.Margin = new System.Windows.Forms.Padding(4);
            this.cbFilenames.Name = "cbFilenames";
            this.cbFilenames.Size = new System.Drawing.Size(160, 24);
            this.cbFilenames.TabIndex = 0;
            this.cbFilenames.TextChanged += new System.EventHandler(this.cbFilenames_TextChanged);
            // 
            // btnAddFilename
            // 
            this.btnAddFilename.Location = new System.Drawing.Point(372, 15);
            this.btnAddFilename.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddFilename.Name = "btnAddFilename";
            this.btnAddFilename.Size = new System.Drawing.Size(139, 28);
            this.btnAddFilename.TabIndex = 2;
            this.btnAddFilename.Text = "Add Filename";
            this.btnAddFilename.UseVisualStyleBackColor = true;
            this.btnAddFilename.Click += new System.EventHandler(this.btnAddFilename_Click);
            // 
            // label3
            // 
            this.label3.AllowDrop = true;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 21);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Txb Filenames";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Printer IP address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 71);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Port Number";
            // 
            // txtIpAddress
            // 
            this.txtIpAddress.Location = new System.Drawing.Point(196, 28);
            this.txtIpAddress.Margin = new System.Windows.Forms.Padding(4);
            this.txtIpAddress.Name = "txtIpAddress";
            this.txtIpAddress.Size = new System.Drawing.Size(196, 22);
            this.txtIpAddress.TabIndex = 12;
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(196, 71);
            this.txtPort.Margin = new System.Windows.Forms.Padding(4);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(196, 22);
            this.txtPort.TabIndex = 13;
            // 
            // btnSendData
            // 
            this.btnSendData.Location = new System.Drawing.Point(315, 415);
            this.btnSendData.Margin = new System.Windows.Forms.Padding(4);
            this.btnSendData.Name = "btnSendData";
            this.btnSendData.Size = new System.Drawing.Size(195, 86);
            this.btnSendData.TabIndex = 15;
            this.btnSendData.Text = "Send Data To Printer";
            this.btnSendData.UseVisualStyleBackColor = true;
            this.btnSendData.Click += new System.EventHandler(this.btnSendData_Click);
            // 
            // txtMessageLog
            // 
            this.txtMessageLog.Location = new System.Drawing.Point(129, 307);
            this.txtMessageLog.Multiline = true;
            this.txtMessageLog.Name = "txtMessageLog";
            this.txtMessageLog.Size = new System.Drawing.Size(321, 89);
            this.txtMessageLog.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 287);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 17);
            this.label4.TabIndex = 17;
            this.label4.Text = "Messages to printer";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(25, 120);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(612, 541);
            this.tabControl1.TabIndex = 18;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.grdKeyValuePairs);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.btnSendData);
            this.tabPage1.Controls.Add(this.txtMessageLog);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.btnAddFilename);
            this.tabPage1.Controls.Add(this.btnSaveConfig);
            this.tabPage1.Controls.Add(this.cbFilenames);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(604, 512);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnSendCommand);
            this.tabPage2.Controls.Add(this.txtMessageContent);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(604, 512);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtMessageContent
            // 
            this.txtMessageContent.Location = new System.Drawing.Point(36, 61);
            this.txtMessageContent.Name = "txtMessageContent";
            this.txtMessageContent.Size = new System.Drawing.Size(442, 22);
            this.txtMessageContent.TabIndex = 0;
            // 
            // btnSendCommand
            // 
            this.btnSendCommand.Location = new System.Drawing.Point(147, 116);
            this.btnSendCommand.Name = "btnSendCommand";
            this.btnSendCommand.Size = new System.Drawing.Size(205, 23);
            this.btnSendCommand.TabIndex = 1;
            this.btnSendCommand.Text = "Send Command To Printer";
            this.btnSendCommand.UseVisualStyleBackColor = true;
            this.btnSendCommand.Click += new System.EventHandler(this.btnSendCommand_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1269, 682);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.txtIpAddress);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.grdKeyValuePairs)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView grdKeyValuePairs;
        private System.Windows.Forms.ComboBox cbFilenames;
        private System.Windows.Forms.Button btnAddFilename;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSaveConfig;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIpAddress;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Button btnSendData;
        private System.Windows.Forms.TextBox txtMessageLog;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnSendCommand;
        private System.Windows.Forms.TextBox txtMessageContent;
    }
}

