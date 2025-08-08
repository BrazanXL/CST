// -------------------------------------------------
// Universidad de la Costa (CUC) - 2025
// Licencia: Creative Commons BY-NC-SA 4.0
// No comercial | Requiere atribución | Compartir igual
// -------------------------------------------------

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIM
{
    public partial class Form2 : Form
    {
        SerialPort serialPort;
        List<float> datosX = new List<float>();
        int maxPuntos = 100;
        public Form2()
        {
            InitializeComponent();

           pictureBox1.Paint += pictureBox1_Paint; // Asigna el evento de dibujo
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

        private void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                if (serialPort == null || !serialPort.IsOpen)
                    return;

                string data = serialPort.ReadExisting(); // No bloquea
                string[] partes = data.Split('\n'); // Separar por líneas si el ESP32 las envía así

                foreach (string parte in partes)
                {
                    if (float.TryParse(parte.Trim(), out float valorX))
                    {
                        Invoke(new Action(() =>
                        {
                            if (datosX.Count >= maxPuntos)
                                datosX.RemoveAt(0);

                            datosX.Add(valorX);
                            pictureBox1.Invalidate();
                        }));
                    }
                }
            }
            catch { /* Ignorar errores de cierre */ }
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

        private void Btn_1_Click(object sender, EventArgs e)
        {

        }

        private void Btn_2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.Clear(Color.White);
            Pen ejePen = new Pen(Color.Gray, 1);
            g.DrawLine(ejePen, 10, pictureBox1.Height / 2, pictureBox1.Width - 10, pictureBox1.Height / 2); // Eje X

            if (datosX.Count < 2) return;

            float maxValor = 50;
            float factorEscala = (pictureBox1.Height / 2) / maxValor;
            Pen dataPen = new Pen(Color.Blue, 2);

            for (int i = 1; i < datosX.Count; i++)
            {
                float x1 = (i - 1) * (pictureBox1.Width / (float)maxPuntos);
                float y1 = (pictureBox1.Height / 2) - (datosX[i - 1] * factorEscala);
                float x2 = i * (pictureBox1.Width / (float)maxPuntos);
                float y2 = (pictureBox1.Height / 2) - (datosX[i] * factorEscala);
                g.DrawLine(dataPen, x1, y1, x2, y2);
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            string[] puertos = SerialPort.GetPortNames(); // Obtener puertos disponibles
            comboBox1.Items.AddRange(puertos); // Agregar al ComboBox
            if (puertos.Length > 0)
                comboBox1.SelectedIndex = 0; // Seleccionar el primer puerto disponible
        }

        private async void Btn_4_ClickAsync(object sender, EventArgs e)
        {
            if (serialPort != null && serialPort.IsOpen) serialPort.Close();

            if (comboBox1.SelectedItem != null)
            {
                string puertoSeleccionado = comboBox1.SelectedItem.ToString();
                serialPort = new SerialPort(puertoSeleccionado, 9600);
                serialPort.DataReceived += SerialPort_DataReceived;

                try
                {
                    serialPort.Open();
                    MessageBox.Show("Conectado a " + puertoSeleccionado);

                    // 🔹 Esperar 2 segundos y luego enviar el comando para leer datos 🔹
                    await Task.Delay(2000);
                    serialPort.Write("R");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void Btn_5_Click(object sender, EventArgs e)
        {
            if (serialPort != null)
            {
                if (serialPort.IsOpen)
                {
                    serialPort.DataReceived -= SerialPort_DataReceived; // Desactiva evento
                    serialPort.Close();
                    MessageBox.Show("Conexión cerrada");
                }
                else
                {
                    MessageBox.Show("Conecte un puerto primero", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Conecte un puerto primero", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
