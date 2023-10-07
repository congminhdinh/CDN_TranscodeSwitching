namespace Test
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.Digicom = new System.Windows.Forms.RadioButton();
            this.FFMpeg = new System.Windows.Forms.RadioButton();
            this.Ateme = new System.Windows.Forms.RadioButton();
            this.NoCDN = new System.Windows.Forms.RadioButton();
            this.CDN_CNetwork = new System.Windows.Forms.RadioButton();
            this.CDN_CVG = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(348, 194);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Digicom
            // 
            this.Digicom.AutoSize = true;
            this.Digicom.Location = new System.Drawing.Point(56, 24);
            this.Digicom.Name = "Digicom";
            this.Digicom.Size = new System.Drawing.Size(70, 19);
            this.Digicom.TabIndex = 7;
            this.Digicom.TabStop = true;
            this.Digicom.Text = "Digicom";
            this.Digicom.UseVisualStyleBackColor = true;
            // 
            // FFMpeg
            // 
            this.FFMpeg.AutoSize = true;
            this.FFMpeg.Location = new System.Drawing.Point(56, 67);
            this.FFMpeg.Name = "FFMpeg";
            this.FFMpeg.Size = new System.Drawing.Size(68, 19);
            this.FFMpeg.TabIndex = 8;
            this.FFMpeg.TabStop = true;
            this.FFMpeg.Text = "FFMpeg";
            this.FFMpeg.UseVisualStyleBackColor = true;
            // 
            // Ateme
            // 
            this.Ateme.AutoSize = true;
            this.Ateme.Location = new System.Drawing.Point(56, 110);
            this.Ateme.Name = "Ateme";
            this.Ateme.Size = new System.Drawing.Size(60, 19);
            this.Ateme.TabIndex = 9;
            this.Ateme.TabStop = true;
            this.Ateme.Text = "Ateme";
            this.Ateme.UseVisualStyleBackColor = true;
            // 
            // NoCDN
            // 
            this.NoCDN.AutoSize = true;
            this.NoCDN.Location = new System.Drawing.Point(38, 22);
            this.NoCDN.Name = "NoCDN";
            this.NoCDN.Size = new System.Drawing.Size(69, 19);
            this.NoCDN.TabIndex = 10;
            this.NoCDN.TabStop = true;
            this.NoCDN.Text = "No CDN";
            this.NoCDN.UseVisualStyleBackColor = true;
            // 
            // CDN_CNetwork
            // 
            this.CDN_CNetwork.AutoSize = true;
            this.CDN_CNetwork.Location = new System.Drawing.Point(38, 61);
            this.CDN_CNetwork.Name = "CDN_CNetwork";
            this.CDN_CNetwork.Size = new System.Drawing.Size(106, 19);
            this.CDN_CNetwork.TabIndex = 11;
            this.CDN_CNetwork.TabStop = true;
            this.CDN_CNetwork.Text = "CDN CNetwork";
            this.CDN_CNetwork.UseVisualStyleBackColor = true;
            // 
            // CDN_CVG
            // 
            this.CDN_CVG.AutoSize = true;
            this.CDN_CVG.Location = new System.Drawing.Point(38, 104);
            this.CDN_CVG.Name = "CDN_CVG";
            this.CDN_CVG.Size = new System.Drawing.Size(76, 19);
            this.CDN_CVG.TabIndex = 12;
            this.CDN_CVG.TabStop = true;
            this.CDN_CVG.Text = "CDN CVG";
            this.CDN_CVG.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Ateme);
            this.groupBox1.Controls.Add(this.Digicom);
            this.groupBox1.Controls.Add(this.FFMpeg);
            this.groupBox1.Location = new System.Drawing.Point(44, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 166);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.CDN_CVG);
            this.groupBox2.Controls.Add(this.NoCDN);
            this.groupBox2.Controls.Add(this.CDN_CNetwork);
            this.groupBox2.Location = new System.Drawing.Point(544, 63);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(180, 166);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Button button1;
        private RadioButton Digicom;
        private RadioButton FFMpeg;
        private RadioButton Ateme;
        private RadioButton NoCDN;
        private RadioButton CDN_CNetwork;
        private RadioButton CDN_CVG;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
    }
}