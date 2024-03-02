using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrackMe
{
    public partial class Form2 : Form
    {
        const string URL = "https://";
        private Timer timer;
        private Random random;
        private List<string> flagTexts;
        public Form2()
        {
            InitializeComponent();

            // Inicializa el temporizador
            timer = new Timer();
            timer.Interval = 2000; // Intervalo de 2 segundos
            timer.Tick += Timer_Tick;

            // Inicializa el generador de números aleatorios
            random = new Random();

            // Rellena la lista de textos aleatorios
            FillFlagTexts();

            // Inicia el temporizador
            timer.Start();
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            // Obtén un texto aleatorio de la lista
            int index = random.Next(flagTexts.Count);
            string randomText = flagTexts[index];

            // Asigna el texto aleatorio al Label
            LBL_flag_random.Text = "flag{" + randomText+ "}";
        }
        private void FillFlagTexts()
        {
            flagTexts = new List<string>();

            // Genera 99 cadenas de texto aleatorias en hexadecimal
            for (int i = 0; i < 5; i++)
            {
                byte[] buffer = new byte[4];
                random.NextBytes(buffer);
                string hexString = BitConverter.ToString(buffer).Replace("-", "");
                flagTexts.Add(hexString);
            }

            // Agrega el texto final deseado como el número 100
            flagTexts.Add("yes_you_can_crack_it");
        }

        private void LBL_flag_random_Click(object sender, EventArgs e)
        {

        }

        private void link_label_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(URL);
        }
    }
}
