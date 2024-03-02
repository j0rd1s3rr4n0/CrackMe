
namespace CrackMe
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.LBL_password = new System.Windows.Forms.Label();
            this.TB_password = new System.Windows.Forms.TextBox();
            this.BTN_Check = new System.Windows.Forms.Button();
            this.LBL_status = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LBL_password
            // 
            this.LBL_password.AutoSize = true;
            this.LBL_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.2F, System.Drawing.FontStyle.Bold);
            this.LBL_password.Location = new System.Drawing.Point(10, 33);
            this.LBL_password.Name = "LBL_password";
            this.LBL_password.Size = new System.Drawing.Size(132, 24);
            this.LBL_password.TabIndex = 0;
            this.LBL_password.Text = "PASSWORD:";
            // 
            // TB_password
            // 
            this.TB_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_password.Location = new System.Drawing.Point(148, 29);
            this.TB_password.MaxLength = 12;
            this.TB_password.Name = "TB_password";
            this.TB_password.PasswordChar = '*';
            this.TB_password.Size = new System.Drawing.Size(166, 30);
            this.TB_password.TabIndex = 1;
            this.TB_password.Text = "123456789012";
            this.TB_password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TB_password.UseSystemPasswordChar = true;
            this.TB_password.Click += new System.EventHandler(this.TB_password_TextChanged);
            // 
            // BTN_Check
            // 
            this.BTN_Check.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.8F);
            this.BTN_Check.Location = new System.Drawing.Point(327, 29);
            this.BTN_Check.Name = "BTN_Check";
            this.BTN_Check.Size = new System.Drawing.Size(144, 30);
            this.BTN_Check.TabIndex = 2;
            this.BTN_Check.Text = "CONNECT";
            this.BTN_Check.UseVisualStyleBackColor = true;
            this.BTN_Check.Click += new System.EventHandler(this.BTN_Check_Click);
            // 
            // LBL_status
            // 
            this.LBL_status.AutoSize = true;
            this.LBL_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_status.Location = new System.Drawing.Point(134, 99);
            this.LBL_status.Name = "LBL_status";
            this.LBL_status.Size = new System.Drawing.Size(211, 24);
            this.LBL_status.TabIndex = 3;
            this.LBL_status.Text = "WRONG PASSWORD";
            this.LBL_status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(509, 166);
            this.Controls.Add(this.LBL_status);
            this.Controls.Add(this.BTN_Check);
            this.Controls.Add(this.TB_password);
            this.Controls.Add(this.LBL_password);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CrackMeIfYouCan";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBL_password;
        private System.Windows.Forms.TextBox TB_password;
        private System.Windows.Forms.Button BTN_Check;
        private System.Windows.Forms.Label LBL_status;
    }
}

