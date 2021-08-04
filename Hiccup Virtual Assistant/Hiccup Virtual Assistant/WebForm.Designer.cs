
namespace Hiccup_Virtual_Assistant
{
    partial class WebForm
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
            this.questionBrowser = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // questionBrowser
            // 
            this.questionBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.questionBrowser.Location = new System.Drawing.Point(0, 0);
            this.questionBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.questionBrowser.Name = "questionBrowser";
            this.questionBrowser.Size = new System.Drawing.Size(978, 826);
            this.questionBrowser.TabIndex = 0;
            this.questionBrowser.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.questionBrowser_DocumentCompleted);
            // 
            // WebForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 826);
            this.Controls.Add(this.questionBrowser);
            this.Name = "WebForm";
            this.Text = "WebForm";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.WebBrowser questionBrowser;
    }
}