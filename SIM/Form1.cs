using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIM
{
    public partial class Form1 : Form
    {
        private Timer timer;
        public Form1()
        {
            InitializeComponent();
            StartProgressBar();
        }
        private void StartProgressBar()
        {
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;
            progressBar1.Value = 0;

            timer = new Timer();
            timer.Interval = 100; // Tiempo de actualización en milisegundos
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < progressBar1.Maximum)
            {
                progressBar1.Value += 5; // Aumenta el progreso
            }
            else
            {
                timer.Stop();
                OpenNewForm();  // Llamamos a la función para abrir la nueva ventana
            }
        }
        private async void OpenNewForm()
        {
            await Task.Delay(1000);  // Espera 1 segundo
            this.Hide();  // Oculta Form1
            await Task.Delay(1000);  // Espera 1 segundo
            Form2 newForm = new Form2();
            newForm.Show();
        }
    }
}
