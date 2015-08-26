using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arregloOrdenado
{
    class busquedaArreglo
    {
        int n,m,numBuscar;
        int[,]arreglo;
        public  busquedaArreglo(int fil,int col, int numBusqueda ,int[,] arreglo){
            this.arreglo = arreglo;
            this.n=fil;
            this.m=col;
            this.numBuscar=numBusqueda;

        }
        //public static int getN()
        //{
        //    return n;
        //} 

        

// primer valor es la fila

public bool buscarNumero ()
{
 
bool res=false;
int fila=0;
int columna=m;

while(res!=true || fila<n && columna > m){ 
if(numBuscar== arreglo[fila,columna-1]){
	res=true;
}
else{
	 if(numBuscar>arreglo[fila,columna-1]){
			fila++;
            if(numBuscar== arreglo[fila,columna-1]){
                res=true;
            }
			}
	else{	
            columna--;
             // se sobreentiende que debe ser menor           
            if (numBuscar == arreglo[fila, columna - 1])
            {
                res = true;
            }	
			}
		
		}

}//fin while

return res;

}
    }
}
