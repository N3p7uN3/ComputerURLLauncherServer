namespace UrlLauncherServer
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
            this.txtCmd = new System.Windows.Forms.TextBox();
            this.chkStartup = new System.Windows.Forms.CheckBox();
            this.txtArguments = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtCmd
            // 
            this.txtCmd.Location = new System.Drawing.Point(12, 12);
            this.txtCmd.Name = "txtCmd";
            this.txtCmd.Size = new System.Drawing.Size(268, 20);
            this.txtCmd.TabIndex = 0;
            this.txtCmd.Text = "C:\\Program Files (x86)\\Mozilla Firefox\\firefox.exe";
            this.txtCmd.TextChanged += new System.EventHandler(this.txtCmd_TextChanged);
            // 
            // chkStartup
            // 
            this.chkStartup.AutoSize = true;
            this.chkStartup.Location = new System.Drawing.Point(12, 79);
            this.chkStartup.Name = "chkStartup";
            this.chkStartup.Size = new System.Drawing.Size(98, 17);
            this.chkStartup.TabIndex = 1;
            this.chkStartup.Text = "Start on startup";
            this.chkStartup.UseVisualStyleBackColor = true;
            this.chkStartup.CheckedChanged += new System.EventHandler(this.chkStartup_CheckedChanged);
            // 
            // txtArguments
            // 
            this.txtArguments.Location = new System.Drawing.Point(13, 39);
            this.txtArguments.Name = "txtArguments";
            this.txtArguments.Size = new System.Drawing.Size(100, 20);
            this.txtArguments.TabIndex = 2;
            this.txtArguments.Text = "%u";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 108);
            this.Controls.Add(this.txtArguments);
            this.Controls.Add(this.chkStartup);
            this.Controls.Add(this.txtCmd);
            this.Name = "Form1";
            this.Text = "URL Launcher Server";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCmd;
        private System.Windows.Forms.CheckBox chkStartup;
        private System.Windows.Forms.TextBox txtArguments;
    }
}

