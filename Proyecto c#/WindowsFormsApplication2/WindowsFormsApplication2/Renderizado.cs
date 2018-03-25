using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public class Renderizado
    {
        public static int ancho = 0; // ancho de la imagen medido en pixeles
        public static int alto = 0; // ancho de la imagen medido en pixeles
        public static int[,] arr_r; // matriz del tamaño de la imagen para guardar los valores del color rojo en cada pixel
        public static int[,] arr_g; // matriz del tamaño de la imagen para guardar los valores del color verde en cada pixel
        public static int[,] arr_b; // matriz del tamaño de la imagen para guardar los valores del color azul en cada pixel
        Bitmap imagen;

        public void render(String route) //metodo para calcular el tamaño de la imagen
        {
            imagen = new Bitmap(System.Drawing.Bitmap.FromFile(route));  // se crea un mapa de bits a partir de la imagen
            ancho = imagen.Width; // se asignan las dimensiones de la imagen y matrices
            alto = imagen.Height;
            arr_r = new int[ancho, alto];
            arr_g = new int[ancho, alto];
            arr_b = new int[ancho, alto];

            try
            {
                
                for (int i = 0; i < ancho; i++)
                {
                   
                    for (int j = 0; j < alto; j++)
                    {
                        arr_r[i, j] = imagen.GetPixel(i, j).R;
                        arr_g[i, j] = imagen.GetPixel(i, j).G;
                        arr_b[i, j] = imagen.GetPixel(i, j).B;//guarda el numero representativo de color del pixel en el arreglo      
                             
                    }//for1

                   
                }//for2

                MessageBox.Show("Imagen procesada"); // se utiliza para alertar que la matriz ya esta realizada

            }//try
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
            }//catch
        }
    }
}
