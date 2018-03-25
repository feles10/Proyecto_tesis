using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form3 : Form
    {
        Form1 menu = new Form1();
        public Form3()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e) // metodo para regresar al menu
        {
            menu.Visible = true;
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            String center; // indica donde se centrara la imagen
            String size; // indica el tamaño de la imagen
            Decimal zoom; // indica el zoom de la imagen
            center = textBox1.Text;
            size = comboBox1.Text;
            zoom = numericUpDown1.Value;

            WebClient wc = new WebClient();// se inicia un cliente web para la busqueda de la imagen mediante la API
            Uri URL = new Uri("https://maps.googleapis.com/maps/api/staticmap?size="+size+"&zoom="+zoom+"&center="+center+"&style=feature:road.local%7Celement:geometry%7Ccolor:0x00ff00&style=feature:landscape%7Celement:geometry.fill%7Ccolor:0x000000&style=element:labels%7Cinvert_lightness:true&style=feature:road.arterial%7Celement:labels%7Cinvert_lightness:false&key=AIzaSyDCsgfsT-i7t499iMrzrPXapC3NyQyZce4");  // se reliza la busqueda la imagen con los parametros suministrados por el usuario
            wc.DownloadFileAsync(URL, "C:\\Users\\Felix\\AppData\\Local\\Temp\\map.png");// se procede a descargar la imagen
            Thread.Sleep(1000);
            Process.Start(@"C:\Users\Felix\AppData\Local\Temp\map.png");// se muestra la imagen como previsualizacion
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Renderizado render = new Renderizado();

            render.render("C:\\Users\\Felix\\AppData\\Local\\Temp\\map.png");// se procede a realizar la renderizacion enviandole la ruta de la imagen al metodo
        }
    }
}
