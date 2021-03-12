using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays_CS
{
    class Program
    {
        static void Main(string[] args)
        {

            //CREANDO LA VARIABLE PARA QUE RECIBA EL ARRAY (NO HACE FALTA ESPECIFICAR EL TIPO DE DATO)

            var valores = NuevoArray();

            //LLAMADA A LA SUBRUTINA
            IterarArrayFor(valores);

        }

        public static ushort[] NuevoArray()
        {

            //DECLARANDO EL ARRAY

            var valores = new ushort[3];  //SE DECLARA CON EL TIPO DE DATO QUE VA A GUARDAR

            //ASIGNANDO VALORES UNO POR UNO (MEDIANTE SUS INDICES):

            valores[0] = 5;

            valores[1] = 15;

            valores[2] = 25;

            return valores;
        }

        public static void IterarArrayFor(ushort[] valores) //RECIBE EL ARRAY PARA ITERARLO EN LA FUNCION
        {

            //ITERACION DEL VECTOR PARA MOSTRAR EL VALOR DE TODOS LOS ELEMENTOS

            for (int x = 0, loopTo = valores.Length - 1; x <= loopTo; x++)

                Console.WriteLine(valores[x]);

        }

        private static void ArrayDeclaracionAsignacionSimultanea()
        {

            //DECLARANDO EL ARRAY DE 3 ELEMENTOS Y ASIGNANDOLE VALORES

            var nombres = new string[] { "Mili", "Miracles", "Milagros" };

            //ITERACION SOBRE EL VECTOR PARA MOSTRAR EL VALOR DE SUS ELEMENTOS

            foreach (var nombre in nombres)

                Console.WriteLine(nombre);
        }

        private static float[,] NuevoArray2Dimensiones()
        {

            //DECLARA UN ARRAY DE 2 DIMENSIONES DE 3 X 2

            var matriz = new float[3,2];

            //ASIGNANDOLE VALORES 1 POR 1

            matriz[0, 0] = 1f;

            matriz[0, 1] = 2f;

            matriz[1, 0] = 3f;

            matriz[1, 1] = 4f;

            matriz[2, 0] = 5f;

            matriz[2, 1] = 6f;

            return matriz;
        }
    }
}
