using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form4 : Form
    {
        Form1 menu = new Form1(); 

        public Form4()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e) //metodo para volver al menu
        {
            
            menu.Visible=true;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e) // metodo para seleccionar una imagen seleccionada por el usuario
        {
            using (OpenFileDialog dlg = new OpenFileDialog()) // se abre una ventana de exploracion de archivos
            {
                dlg.Title = "Open Image";
                dlg.Filter = "Image Files (*.bmp;*.jpg;*.jpeg,*.png)|*.BMP;*.JPG;*.JPEG;*.PNG"; // solo imagenes con esta extension se pueden ver

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    textBox1.Text = dlg.FileName.ToString(); // se llena el campo de texto con la dirreccion de la imagen
                    Process.Start(@textBox1.Text);// se muestra la  imagen como previsualizacion
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Renderizado render = new Renderizado();

            render.render(textBox1.Text); //se procede al renderizado enviadole la ruta de la imagen al metodo
        }
    }
}
