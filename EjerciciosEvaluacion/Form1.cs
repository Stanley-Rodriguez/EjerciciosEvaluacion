using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjerciciosEvaluacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Ejercicio #1
        private void BtnTMultiplicar_Click(object sender, EventArgs e)
        {
            LbxTMultiplicar.Items.Clear();

            int valorTxtBox = Convert.ToInt32(TxtVTMultiplicar.Text);
            int producto;

            string linea;

            //Este bucle es para el multiplicando y se repetira hasra que llegue al valor
            //de la tabla deseada
            for (int multiplicando = 1; multiplicando <= valorTxtBox; multiplicando++) 
            {
                //Este bucle es para el multiplicador que realizara la multiplicacion
                //por el multiplicando 12 veces y luego se agrega por linea al listbox
                for (int multiplicador = 1; multiplicador < 13; multiplicador++)
                {
                    producto = multiplicando * multiplicador;
                    linea = ""+ multiplicador + "  x  "+ multiplicando + "  =  "+ producto +"";
                    LbxTMultiplicar.Items.Add(linea);
                }
            }
        }

        //Ejercicio #2
        private void BtnSecuencia_Click(object sender, EventArgs e)
        {
            LbSecuencia.Items.Clear();
            
            //Este ejercicio es una serie Fibonacci para mostrar la cantidad
            //de números deseados de la serie
            int i = 0;
            int limiteFb = Convert.ToInt32(TxtVSecuencia.Text);
            
            int contenedor; 
            int valor1 = 0;
            int valor2 = 1;

            while (i < limiteFb)
            {
                LbSecuencia.Items.Add(valor1.ToString()); //Automaticamente agrega el 0 a la lista

                contenedor = valor1;                      //Almacena el valor alternado entre el valor1 y valor2
                valor1 = valor2;
                valor2 = contenedor + valor1;             //Almacena el valor de la suma que inicialmente es
                                                          //0 + 1 = 1 
                i++;
            }
        }

        //Ejercicio 3; Este ejercicio no funciona bien, incluso por mas que investigue por internet no
        //pude hacerlo. Tiene expresiones lambda, algo que no se manejar bien.
        private void BtnOrdenAleatorio_Click(object sender, EventArgs e)
        {
            LbxOrdenAleatorio.Items.Clear();

            List<int> serie = new List<int>();

            int valor = Convert.ToInt32(TxtVOrdenAleatorio.Text);
            int numero;

            Random random = new Random(); 

            for (int i = 1; i <= valor; i++)
            {
                //el metodo next de la clase random proporciona un valor
                //valor aleatorio entre dos numeros.
                numero = random.Next(1, valor);

                //si no existe en la lista declarada se agrega para que 
                //que no se repita
                if (!serie.Any(x => x == numero)) 
                {
                    serie.Add(numero);
                }
            }

            foreach (var item in serie)
            {
                LbxOrdenAleatorio.Items.Add(item);
            }

            //Mi problema con este ejercicio es que solo se agrega a la lista segun el numero de 
            //repeticiones indicada por la cantidad del texbox, y si hay repetidos no se va a agregar para 
            //luego ser mostrada. Eso hace que me falten varios numeros y tampoco se agregue el numero mas alto
        }

        //Ejercicio 4, en este ejercicio utilice un struct para realizar la operacion y obtener el valor
        //de las variables desde el struct. Traté de hacerlo con un bucle while, pero no pude resolverlo.
        private void BtnBilletes_Click(object sender, EventArgs e)
        {
            LbxBilletes.Items.Clear();

            Operacion.Cantidad = Convert.ToInt32(TxtVBilletes.Text);

            LbxBilletes.Items.Add("Cantidad x Billete");


            if (Operacion.Cantidad >= 2000)
            {
                Operacion.Calculo(Operacion.Cantidad, 2000);

                LbxBilletes.Items.Add(Operacion.Resultado);

                Operacion.Cantidad = Operacion.Cantidad -= Operacion.Producto;
            }
            if (Operacion.Cantidad >= 1000)
            {
                Operacion.Calculo(Operacion.Cantidad, 1000);

                LbxBilletes.Items.Add(Operacion.Resultado);

                Operacion.Cantidad = Operacion.Cantidad -= Operacion.Producto;
            }
            if (Operacion.Cantidad >= 500)
            {
                Operacion.Calculo(Operacion.Cantidad, 500);

                LbxBilletes.Items.Add(Operacion.Resultado);

                Operacion.Cantidad = Operacion.Cantidad -= Operacion.Producto;
            }
            if (Operacion.Cantidad >= 200)
            {
                Operacion.Calculo(Operacion.Cantidad, 200);

                LbxBilletes.Items.Add(Operacion.Resultado);

                Operacion.Cantidad = Operacion.Cantidad -= Operacion.Producto;
            }
            if (Operacion.Cantidad >= 100)
            {
                Operacion.Calculo(Operacion.Cantidad, 100);

                LbxBilletes.Items.Add(Operacion.Resultado);

                Operacion.Cantidad = Operacion.Cantidad -= Operacion.Producto;
            }
            if (Operacion.Cantidad >= 50)
            {
                Operacion.Calculo(Operacion.Cantidad, 50);

                LbxBilletes.Items.Add(Operacion.Resultado);

                Operacion.Cantidad = Operacion.Cantidad -= Operacion.Producto;
            }
            if (Operacion.Cantidad >= 25)
            {
                Operacion.Calculo(Operacion.Cantidad, 25);

                LbxBilletes.Items.Add(Operacion.Resultado);

                Operacion.Cantidad = Operacion.Cantidad -= Operacion.Producto;
            }
            if (Operacion.Cantidad >= 10)
            {
                Operacion.Calculo(Operacion.Cantidad, 10);

                LbxBilletes.Items.Add(Operacion.Resultado);

                Operacion.Cantidad = Operacion.Cantidad -= Operacion.Producto;
            }
            if (Operacion.Cantidad >= 5)
            {
                Operacion.Calculo(Operacion.Cantidad, 5);

                LbxBilletes.Items.Add(Operacion.Resultado);

                Operacion.Cantidad = Operacion.Cantidad -= Operacion.Producto;
            }
            if (Operacion.Cantidad >= 1)
            {
                Operacion.Calculo(Operacion.Cantidad, 1);

                LbxBilletes.Items.Add(Operacion.Resultado);

                Operacion.Cantidad = Operacion.Cantidad -= Operacion.Producto;
            }
        }

        struct Operacion
        {
            public static string Resultado;
            public static int Divisor;
            public static int Producto;
            public static int Cantidad;

            public static void Calculo(int cantidad,int dividendo)
            {
                Divisor = cantidad / dividendo;
                Producto = Divisor * dividendo;
                Resultado = "" + Divisor + " x " + dividendo + " = " + Producto + "";
            }
        }
    }
}
