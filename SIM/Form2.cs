using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIM
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void LoadSerialPorts()
        {
            comboBox1.Items.Clear();  // Limpia el ComboBox
            string[] ports = SerialPort.GetPortNames(); // Obtiene los puertos disponibles

            if (ports.Length > 0)
            {
                comboBox1.Items.AddRange(ports); // Agrega los puertos al ComboBox
                comboBox1.SelectedIndex = 0; // Selecciona el primero por defecto
            }
            else
            {
                comboBox1.Items.Add("No hay puertos disponibles");
                comboBox1.SelectedIndex = 0;
            }
        }

        private void Btn_3_Click(object sender, EventArgs e)
        {
            LoadSerialPorts();  // Llamar a la función para actualizar los puertos
        }

        private void Btn_0_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Seguro que quieres salir?", "Confirmar salida",
                                          MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                //e.Cancel = true; // Cancela el cierre
            }
            else
            {
                Application.Exit(); // Cierra el programa si elige "Sí"
            }
        }
    }
}
