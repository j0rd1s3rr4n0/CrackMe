using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrackMe
{
    public partial class Form1 : Form
    {
        const string GENERALPASSWORD = "P@ssw0rd!IzY";
        bool first_time;
        public Form1()
        {
            InitializeComponent();
            LBL_status.Visible = false;
            first_time = true;
        }
        bool CheckPassword(string password)
        {
            return (password == GENERALPASSWORD);
        }

        private void BTN_Check_Click(object sender, EventArgs e)
        {
            if (CheckPassword(TB_password.Text.ToString()))
            {
                LBL_status.Visible = true;
                LBL_status.Text = "CORRECT!";
                
                Form2 form2 = new Form2(); // Crear una instancia de Form2
                this.Hide(); // Ocultar el formulario actual
                form2.ShowDialog(); // Mostrar Form2
                this.Show(); // Mostrar nuevamente el formulario actual después de que Form2 se cierre
            }
            else
            {
                LBL_status.Visible = true;
                LBL_status.Text = "WRONG PASSWORD!";
            }
        }

        private void TB_password_TextChanged(object sender, EventArgs e)
        {
            if (first_time){TB_password.Text = "";first_time = false;}
        }
    }
}
