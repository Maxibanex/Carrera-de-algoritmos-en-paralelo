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

namespace Carrera_Algoritmos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


            // Configurar el NotifyIcon
            niErrorLetra = new NotifyIcon();
            niErrorLetra.Icon = SystemIcons.Error;
            niErrorLetra.Visible = true;

            // Manejar el evento KeyPress en el formulario
            this.KeyPress += txtNumBuscar_KeyPress;
        }

        private void gbInsercion_Enter(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            lblRamBinaria.Text = "";
            lblRamBurbuja.Text = "";
            lblRamInsercion.Text = "";
            lblRamQuicksort.Text = "";
            lblRamSecuencial.Text = "";
            lblRamApp.Text = "";

            lblTiempoBinaria.Text = "";
            lblTiempoBurbuja.Text = "";
            lblTiempoInsercion.Text = "";
            lblTiempoQuicksort.Text = "";
            lblTiempoSecuencial.Text = "";

            txtNumBuscar.Text = "";
            rtxtBinaria.Text = "";
            rtxtBurbuja.Text = "";
            rtxtInsercion.Text = "";
            rtxtQuicksort.Text = "";
            rtxtSecuencial.Text = "";

            pbBinaria.Value = pbBinaria.Minimum;
            pbBurbuja.Value = pbBurbuja.Minimum;
            pbInsercion.Value = pbInsercion.Minimum;
            pbQuicksort.Value = pbQuicksort.Minimum;
            pbSecuencial.Value = pbSecuencial.Minimum;

            txtNumBuscar.Focus();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {

            //variables para consumo
            long memoriaInicial = Process.GetCurrentProcess().PrivateMemorySize64; //variable de consumo inicial
            long usoDeMemoriaSecuencial = 0;
            long usoDeMemoriaBinaria = 0;
            long usoDeMemoriaBurbuja = 0;
            long usoDeMemoriaQuicksort = 0;
            long usoDeMemoriaInsercion = 0;



            //variables de tiempo
            Stopwatch tiempoSecuencial = new Stopwatch();
            Stopwatch tiempoBinaria = new Stopwatch();
            Stopwatch tiempoBurbuja = new Stopwatch();
            Stopwatch tiempoQuiksort = new Stopwatch();
            Stopwatch tiempoInsercion = new Stopwatch();


            int numNumerosAleatorios = 100000; // cantidad de números aleatorios
            int[] numerosAleatorios = new int[numNumerosAleatorios];
            int[] numerosAleatoriosOrden = new int[numNumerosAleatorios];
            int[] resBurbuja = new int[numNumerosAleatorios];
            int[] resQuicksort = new int[numNumerosAleatorios];
            int[] resInsercion = new int[numNumerosAleatorios];




            //int[] numerosorden = { 1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30};
            //int[] numerosnoorden = {1,5,7,3,4,6,2,8,9,10,12,13,15,20,21,17,18,11,22,27,29,30,28,19,24,14,26,16,23,25};


            // generar números aleatorios en paralelo
            Parallel.For(0, numNumerosAleatorios, i =>
            {
                Random random = new Random();
                numerosAleatorios[i] = random.Next(1, 3000001); // Números aleatorios entre 1 y 3000

                //QuickSort(numerosAleatoriosOrden, 0, numerosAleatoriosOrden.Length - 1);
            });


            //Declaracion de variables resultados
            Parallel.Invoke(

                () => Array.Copy(numerosAleatorios, numerosAleatoriosOrden, numerosAleatorios.Length),
                () => Array.Copy(numerosAleatorios, resQuicksort, numerosAleatorios.Length),
                () => Array.Copy(numerosAleatorios, resBurbuja, numerosAleatorios.Length),
                () => Array.Copy(numerosAleatorios, resInsercion, numerosAleatorios.Length)
            );


            Parallel.Invoke(
                () => QuickSort(numerosAleatoriosOrden, 0, numerosAleatoriosOrden.Length - 1)
            );




            if (txtNumBuscar.Text != "")
            {
                //declaracion de variable busqueda
                int numBuscar = int.Parse(txtNumBuscar.Text);

                int resSecuencial = 0; //variable busqueda Secuencial
                int resBinaria = 0; //variable busqueda Binaria

                //Ejecucion de algoritmos de busqueda y ordenamiento en parallelo

                Parallel.Invoke(
                    
                    () => 
                    {
                        long memoriaAntesSecuencial = Process.GetCurrentProcess().PrivateMemorySize64;
                        tiempoSecuencial.Start();
                        resSecuencial = BusquedaSecuencial(numerosAleatorios, numBuscar);
                        tiempoSecuencial.Stop();
                        long memoriaDespuesSecuencial = Process.GetCurrentProcess().PrivateMemorySize64;
                        usoDeMemoriaSecuencial = ((long)(memoriaDespuesSecuencial - memoriaAntesSecuencial));


                    },

                    () =>
                    {
                        long memoriaAntesBinaria = Process.GetCurrentProcess().PrivateMemorySize64;
                        tiempoBinaria.Start();
                        resBinaria = BusquedaBinaria(numerosAleatoriosOrden, numBuscar);
                        tiempoSecuencial.Stop();
                        long memoriaDespuesBinaria = Process.GetCurrentProcess().PrivateMemorySize64;
                        usoDeMemoriaBinaria = ((long)(memoriaDespuesBinaria - memoriaAntesBinaria));
                    },

                    () =>
                    {

                        long memoriaAntesBurbuja = Process.GetCurrentProcess().PrivateMemorySize64;
                        tiempoBurbuja.Start();
                        //Realizar busqueda
                        OrdenamientoBurbuja(resBurbuja);
                        tiempoBurbuja.Stop();

                        long memoriaDespuesBurbuja = Process.GetCurrentProcess().PrivateMemorySize64;
                        // Calcula el uso de memoria de QuickSort
                        usoDeMemoriaBurbuja = ((long)(memoriaDespuesBurbuja - memoriaAntesBurbuja));



                    },

                    () => {

                        long memoriaAntesQuiksort = Process.GetCurrentProcess().PrivateMemorySize64;

                        tiempoQuiksort.Start();
                        //Realizar busqueda
                        QuickSort(resQuicksort, 0, resQuicksort.Length - 1);
                        tiempoQuiksort.Stop();

                        long memoriaDespuesQuicksort = Process.GetCurrentProcess().PrivateMemorySize64;
                        // Calcula el uso de memoria de QuickSort
                        usoDeMemoriaQuicksort = ((long)(memoriaDespuesQuicksort - memoriaAntesQuiksort));

                        
                    },

                    () => {

                        long memoriaAntesInsercion = Process.GetCurrentProcess().PrivateMemorySize64;

                        tiempoInsercion.Start();
                        //Realizar busqueda
                        OrdenamientoPorInsercion(resInsercion);
                        tiempoInsercion.Stop();

                        long memoriaDespuesInsercion = Process.GetCurrentProcess().PrivateMemorySize64;
                        // Calcula el uso de memoria de QuickSort
                        usoDeMemoriaInsercion = ((long)(memoriaDespuesInsercion - memoriaAntesInsercion));

                    }
                    


                );


                //resultados


                //resultado Busqueda Secuencial
                if (resSecuencial != -1)
                {
                    rtxtSecuencial.Text = "El numero fue encontrado en la posición no. " + resSecuencial;
                }
                else
                {
                    rtxtSecuencial.Text = "El numero no existe en el arreglo";
                }
                lblTiempoSecuencial.Text = tiempoSecuencial.Elapsed.ToString();
                lblRamSecuencial.Text = usoDeMemoriaSecuencial.ToString() + " bytes";


                //resultado Busqueda Binaria
                if (resBinaria != -1)
                {
                    rtxtBinaria.Text = "El numero fue encontrado en la posición no. " + resBinaria;
                    //rtxtBinaria.Text = "El numero no existe en el arreglo";
                }
                else
                {
                    rtxtBinaria.Text = "El numero no existe en el arreglo";
                    //rtxtBinaria.Text = "El numero fue encontrado en la posición no. " + resBinaria;
                }
                lblTiempoBinaria.Text = tiempoBinaria.Elapsed.ToString();
                lblRamBinaria.Text = usoDeMemoriaBinaria.ToString() + " bytes";


                //resultado Quicksort
                string resBurbujaString = string.Join(" ", resBurbuja);
                rtxtBurbuja.Text = resBurbujaString;
                lblTiempoBurbuja.Text = tiempoBurbuja.Elapsed.ToString();
                lblRamBurbuja.Text = usoDeMemoriaBurbuja.ToString() + " bytes";


                //resultado Quicksort
                string resQuicksortString = string.Join(" ", resQuicksort);
                rtxtQuicksort.Text = resQuicksortString;
                lblTiempoQuicksort.Text = tiempoQuiksort.Elapsed.ToString();
                lblRamQuicksort.Text = usoDeMemoriaQuicksort.ToString() + " bytes";



                //resultado Quicksort
                string resInsercionString = string.Join(" ", resInsercion);
                rtxtInsercion.Text = resInsercionString;
                lblTiempoInsercion.Text = tiempoInsercion.Elapsed.ToString();
                lblRamInsercion.Text = usoDeMemoriaInsercion.ToString() + " bytes";







            }
            else
            {
                // Mostrar un mensaje con el NotifyIcon
                niErrorLetra.BalloonTipTitle = "Error";
                niErrorLetra.BalloonTipText = "Debe agregar un numero de busqueda primero";
                niErrorLetra.ShowBalloonTip(2000); // Muestra el mensaje durante 2 segundos
                txtNumBuscar.Focus();
            }


            long memoriaFinal = Process.GetCurrentProcess().PrivateMemorySize64; //memoria Final consumida
            long usoMemoria = 0;
            usoMemoria = ((long)((memoriaFinal - memoriaInicial) / (1024.0 * 1024.0)));

            lblRamApp.Text = usoMemoria.ToString() + " MB";

        }

        private void txtNumBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;

                // Mostrar un mensaje con el NotifyIcon
                niErrorLetra.BalloonTipTitle = "Error";
                niErrorLetra.BalloonTipText = "Solo puede agregar numeros";
                niErrorLetra.ShowBalloonTip(2000); // Muestra el mensaje durante 2 segundos
            }

        }


        private void MuestraResultados()
        {

        }



        //Busqueda Secuencial
        private static int BusquedaSecuencial(int[] busqArray, int numero)
        {
            for (int i=0; i<busqArray.Length; i++)
            {
                if (busqArray[i] == numero)
                {
                    return i; //se encontro el valor por lo que se devuelve el numero
                }
            }
            return -1; // El valor no se encontro.
        }

        

        //búsqueda binaria
        private static int BusquedaBinaria(int[] arreglo, int elemento)
        {
            int izquierda = 0;
            int derecha = arreglo.Length - 1;

            while (izquierda <= derecha)
            {
                int medio = izquierda + (derecha - izquierda) / 2;

                // Si el elemento medio es igual al elemento que buscamos, lo hemos encontrado
                if (arreglo[medio] == elemento)
                    return medio;

                // Si el elemento que buscamos es menor que el elemento medio,
                // restringimos la búsqueda a la mitad izquierda del arreglo
                if (elemento < arreglo[medio])
                    derecha = medio - 1;

                // Si el elemento que buscamos es mayor que el elemento medio,
                // restringimos la búsqueda a la mitad derecha del arreglo
                else
                    izquierda = medio + 1;
            }

            // Si llegamos aquí, el elemento no se encuentra en el arreglo
            return -1;
        }



        // Ordenamiento Burbuja
        private static void OrdenamientoBurbuja(int[] arr)
        {
            int n = arr.Length;
            bool intercambio;

            do
            {
                intercambio = false;
                for (int i = 1; i < n; i++)
                {
                    if (arr[i - 1] > arr[i])
                    {
                        // Intercambia los elementos si están en el orden incorrecto
                        int temp = arr[i - 1];
                        arr[i - 1] = arr[i];
                        arr[i] = temp;
                        intercambio = true;
                    }
                }
            } while (intercambio);
        }



        // Método Quiksort
        private static void QuickSort(int[] arreglo, int low, int high)
        {
            if (low < high)
            {
                // Encuentra el índice de partición, arr[p] se coloca en su posición correcta
                int partitionIndex = PartirQuiksort(arreglo, low, high);

                // Ordena los elementos antes y después de la partición
                QuickSort(arreglo, low, partitionIndex - 1);
                QuickSort(arreglo, partitionIndex + 1, high);

                
            }
        }

        // Método auxiliar para realizar la partición del arreglo
        private static int PartirQuiksort(int[] arreglo, int low, int high)
        {
            // Elije el pivote (usualmente el último elemento en este caso)
            int pivot = arreglo[high];

            // Índice del elemento más pequeño
            int i = (low - 1);

            for (int j = low; j <= high - 1; j++)
            {
                // Si el elemento actual es menor o igual al pivote
                if (arreglo[j] <= pivot)
                {
                    // Incrementa el índice del elemento más pequeño
                    i++;

                    // Intercambia arr[i] y arr[j]
                    int temp = arreglo[i];
                    arreglo[i] = arreglo[j];
                    arreglo[j] = temp;
                }
            }

            // Intercambia arr[i+1] y arr[high] (o el pivote)
            int temp2 = arreglo[i + 1];
            arreglo[i + 1] = arreglo[high];
            arreglo[high] = temp2;

            return (i + 1);
        }


        //Metodo inserción
        private static void OrdenamientoPorInsercion(int[] arr)
        {
            int n = arr.Length;
            for (int i = 1; i < n; i++)
            {
                int valorActual = arr[i];
                int j = i - 1;

                // Mover los elementos del arreglo que son mayores que el valor actual
                // a una posición adelante de su posición actual
                while (j >= 0 && arr[j] > valorActual)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }

                // Colocar el valor actual en su posición correcta en el arreglo
                arr[j + 1] = valorActual;
            }
        }




    }
}
