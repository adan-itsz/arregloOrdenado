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
        int k=0, l=0;
        public void insertar(){
            dato= Convert.ToInt32(numericUpDown1.Value);
            if(k<fila){
                if(l<columna){
                    DataGridView1.Rows[k].Cells[l].Value=dato;
                    array[k,l]=dato;
                    k++;
                    dato=0;
                    numericUpDown1.Value=0;
                        if(l==columna){
                            l=0;
                            k++;
                        }
                }
            }
            
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            iniciarDGV();
            
        }
        public void iniciarDGV()
        {
            int fila = Convert.ToInt32(txtBoxFila.Text);
            int columna = Convert.ToInt32(txtBoxColumna.Text);
            int numeroBuscar = Convert.ToInt32(txtBoxNumBuscar.Text);

            int[,] array = new int[fila, columna];

            for (int i = 0; i < columna; i++)
            {
                dataGridView1.Columns.Add("", "");
            }
            for (int j = 0; j < fila - 1; j++)
            {
                dataGridView1.Rows.Add();
            }
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


    }
}
