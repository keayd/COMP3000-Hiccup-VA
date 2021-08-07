
namespace Hiccup_Virtual_Assistant
{
    partial class SettingsForm
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
            this.components = new System.ComponentModel.Container();
            this.voiceSelectorList = new System.Windows.Forms.ComboBox();
            this.voiceSpeedBar = new System.Windows.Forms.TrackBar();
            this.speedGroupBox = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.voiceVolumeBar = new System.Windows.Forms.TrackBar();
            this.installedVoiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.installedVoiceBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.voiceSpeedBar)).BeginInit();
            this.speedGroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.voiceVolumeBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.installedVoiceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.installedVoiceBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // voiceSelectorList
            // 
            this.voiceSelectorList.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.voiceSelectorList.FormattingEnabled = true;
            this.voiceSelectorList.Location = new System.Drawing.Point(48, 54);
            this.voiceSelectorList.Name = "voiceSelectorList";
            this.voiceSelectorList.Size = new System.Drawing.Size(608, 57);
            this.voiceSelectorList.TabIndex = 0;
            this.voiceSelectorList.Text = "Select Voice";
            this.voiceSelectorList.SelectedIndexChanged += new System.EventHandler(this.voiceSelectorList_SelectedIndexChanged);
            // 
            // voiceSpeedBar
            // 
            this.voiceSpeedBar.Location = new System.Drawing.Point(6, 31);
            this.voiceSpeedBar.Minimum = -10;
            this.voiceSpeedBar.Name = "voiceSpeedBar";
            this.voiceSpeedBar.Size = new System.Drawing.Size(571, 69);
            this.voiceSpeedBar.TabIndex = 1;
            this.voiceSpeedBar.Scroll += new System.EventHandler(this.voiceSpeedBar_Scroll);
            // 
            // speedGroupBox
            // 
            this.speedGroupBox.Controls.Add(this.label3);
            this.speedGroupBox.Controls.Add(this.label2);
            this.speedGroupBox.Controls.Add(this.label1);
            this.speedGroupBox.Controls.Add(this.voiceSpeedBar);
            this.speedGroupBox.Location = new System.Drawing.Point(48, 189);
            this.speedGroupBox.Name = "speedGroupBox";
            this.speedGroupBox.Size = new System.Drawing.Size(583, 106);
            this.speedGroupBox.TabIndex = 2;
            this.speedGroupBox.TabStop = false;
            this.speedGroupBox.Text = "Voice Speed";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(526, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Fast";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(261, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Normal";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Slow";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.voiceVolumeBar);
            this.groupBox1.Location = new System.Drawing.Point(48, 337);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(583, 106);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Volume";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(526, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "High";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(261, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Medium";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "Low";
            // 
            // voiceVolumeBar
            // 
            this.voiceVolumeBar.Location = new System.Drawing.Point(6, 31);
            this.voiceVolumeBar.Maximum = 100;
            this.voiceVolumeBar.Name = "voiceVolumeBar";
            this.voiceVolumeBar.Size = new System.Drawing.Size(571, 69);
            this.voiceVolumeBar.TabIndex = 1;
            this.voiceVolumeBar.Value = 50;
            this.voiceVolumeBar.Scroll += new System.EventHandler(this.voiceVolumeBar_Scroll);
            // 
            // installedVoiceBindingSource
            // 
            this.installedVoiceBindingSource.DataSource = typeof(System.Speech.Synthesis.InstalledVoice);
            // 
            // installedVoiceBindingSource1
            // 
            this.installedVoiceBindingSource1.DataSource = typeof(System.Speech.Synthesis.InstalledVoice);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(699, 601);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.speedGroupBox);
            this.Controls.Add(this.voiceSelectorList);
            this.Name = "SettingsForm";
            this.Text = "Settings";
            ((System.ComponentModel.ISupportInitialize)(this.voiceSpeedBar)).EndInit();
            this.speedGroupBox.ResumeLayout(false);
            this.speedGroupBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.voiceVolumeBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.installedVoiceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.installedVoiceBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ComboBox voiceSelectorList;
        public System.Windows.Forms.TrackBar voiceSpeedBar;
        private System.Windows.Forms.GroupBox speedGroupBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TrackBar voiceVolumeBar;
        private System.Windows.Forms.BindingSource installedVoiceBindingSource;
        private System.Windows.Forms.BindingSource installedVoiceBindingSource1;
    }
}