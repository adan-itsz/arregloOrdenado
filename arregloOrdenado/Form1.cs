using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace arregloOrdenado
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
   
        private void Form1_Load(object sender, EventArgs e)
        {
            
             
        }
        int fila=0;
        int columna = 0;
        int numeroBuscar = 0;
        int[,] array;
       
        private void button2_Click(object sender, EventArgs e)
        {
            iniciarDGV();
            
        }
        public void iniciarDGV()
        {
            try
            {
                fila = Convert.ToInt32(txtBoxFila.Text) ;
                columna = Convert.ToInt32(txtBoxColumna.Text) ;
               



                for (int i = 0; i < columna; i++)
                {
                    dataGridView1.Columns.Add("", "");
                }
                for (int j = 0; j < fila - 1; j++)
                {
                    dataGridView1.Rows.Add();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("error");
            }
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            llenarDGV();
        }
        public void llenarDGV() 
        {
            try
            {
                Random rand = new Random();
                array = new int[fila, columna];
                int aux = 0;
                int aux2 = 0;
                int aux3 = 0;
                for (int i = 0; i < fila; )
                {
                    for (int j = 0; j < columna; )
                    {
                        if (i == 0)
                        {
                            if (j == 0)
                            {
                                aux = rand.Next(1, 100 + i);
                                dataGridView1[j, i].Value = aux;
                                array[j, i] = aux;
                                //MessageBox.Show("fgf");
                                j++;
                            }
                            else
                            {
                                aux = rand.Next(1, 400 + i + j);
                                if (aux > Convert.ToInt32(dataGridView1[j - 1, i].Value.ToString()))
                                {
                                    dataGridView1[j, i].Value = aux;
                                    array[j, i] = aux;
                                   // MessageBox.Show("fgf");
                                    j++;
                                }
                            }

                        }
                        else
                        {

                            if (j == 0)
                            {
                                aux2 = rand.Next(0, 800 + i + j);
                                if (aux2 > Convert.ToInt32(dataGridView1[j, i - 1].Value.ToString()))
                                {
                                    dataGridView1[j, i].Value = aux2;
                                    array[j, i] = aux2;
                                    //MessageBox.Show("fgf");
                                    j++;
                                }
                            }
                            else
                            {
                                aux3 = rand.Next(1, 1000 + i + j);
                                if (aux3 > Convert.ToInt32(dataGridView1[j, i - 1].Value.ToString())
                                    && aux3 > Convert.ToInt32(dataGridView1[j - 1, i].Value.ToString()))
                                {
                                    dataGridView1[j, i].Value = aux3;
                                    array[j, i] = aux3;
                                  //  MessageBox.Show("fgf");
                                    j++;

                                }
                            }

                        }
                    }
                    i++;
                } // cierra ultimo for
            }
            catch (Exception e)
            {
                MessageBox.Show("error");
            }
        
        }
       
        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            buscar();
        }
        public void buscar()
        {
            try
         {
               numeroBuscar = Convert.ToInt32(txtBoxBuscar.Text);
               busquedaArreglo bus = new busquedaArreglo(fila, columna, numeroBuscar, array);
               bool busqueda = bus.buscarNumero();
               if (busqueda)
                {
                    MessageBox.Show("El numero " + numeroBuscar + " si se encuentra en el arreglo");
               }
                else
                {
                   MessageBox.Show("El numero " + numeroBuscar + "no fue encontrado en el arreglo");
                }
        }
        catch (Exception)
        {
           MessageBox.Show("error");
       }
        }

    }
}
