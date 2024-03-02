
namespace CrackMe
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.LBL_flag_random = new System.Windows.Forms.Label();
            this.link_label = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // LBL_flag_random
            // 
            this.LBL_flag_random.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LBL_flag_random.AutoSize = true;
            this.LBL_flag_random.Font = new System.Drawing.Font("Segoe UI Semibold", 30.8F, System.Drawing.FontStyle.Bold);
            this.LBL_flag_random.Location = new System.Drawing.Point(121, 140);
            this.LBL_flag_random.Name = "LBL_flag_random";
            this.LBL_flag_random.Size = new System.Drawing.Size(560, 70);
            this.LBL_flag_random.TabIndex = 0;
            this.LBL_flag_random.Text = "flag{this_is_not_a_flag}";
            this.LBL_flag_random.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LBL_flag_random.Click += new System.EventHandler(this.LBL_flag_random_Click);
            // 
            // link_label
            // 
            this.link_label.AutoSize = true;
            this.link_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.link_label.Location = new System.Drawing.Point(306, 262);
            this.link_label.Name = "link_label";
            this.link_label.Size = new System.Drawing.Size(143, 29);
            this.link_label.TabIndex = 1;
            this.link_label.TabStop = true;
            this.link_label.Text = "Join to CTF";
            this.link_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.link_label.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_label_LinkClicked);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.link_label);
            this.Controls.Add(this.LBL_flag_random);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.Text = "Copy The Flag!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBL_flag_random;
        private System.Windows.Forms.LinkLabel link_label;
    }
}