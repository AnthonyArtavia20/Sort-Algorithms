namespace BubbleSortFolder
{
    public class BubbleSortAlgorithm : SomeMethods
    {
        public void BubbleSort(int[]array) // Creamos el método para implementar BubbleSort
        {
            //Creación de los índices para ir agrupando o haciendo la "Burbuja" que se dezplaza hasta la derecha.
            int IndiceDerecha = 1;
            int IndiceIzquierda = IndiceDerecha-1;

            while (IndiceDerecha < array.Length-1) //El límite de búsqueda se limita al tamaño de la lista.
            {
                while (array[IndiceIzquierda] <= array[IndiceDerecha] && IndiceDerecha < array.Length-1) //Comprobamos que siempre el de la izquierda sea menor al de la derecha.
                {
                    //Simplemente nos seguimos desplazando a la derecha
                    IndiceDerecha++;
                    IndiceIzquierda++;
                }

                if (array[IndiceIzquierda] > array[IndiceDerecha]) //Si fuese el caso que es al contrario, entonces  hacemos swap
                {
                    SwapMethod(array,IndiceIzquierda, IndiceDerecha);
                }
            }

            bool ordenada = true; //Bandera que nos ayudará a salir del bucle de ordenamiento.

            for (int i = 0; i < array.Length-1; i++) //Cada vez que se llega al final de la lista en el while principal, es necesario
            {//compropar desde el prinicio de la array hasta el final en caso de que ya esté ordenada, esto ayuda a determinar si salir del bucle ded ordenamiento
                //o no.
                if (array[i] > array[i + 1])
                {
                    ordenada = false; //Si no está ordenada
                    break;//salimos del bucle
                }
            }

            if (!ordenada) //Como no está ordenada, entones:
            {
                BubbleSort(array); //Hacemos llamada recursiva con la lista parcialmente ordenada. Y así hasta que la lista se ordene por completo
                //es decir, hasta que una vez que se recorra la lista y la bandera ordenada sea true.
            }
        }

        public void SwapMethod(int[]array, int IndiceIzquierdo, int IndiceDerecho) //Método encargado de intercambiar dos elementos cuando el izquiedo
        { //es menor al de la derecha.
            int IndiceTemporal = array[IndiceIzquierdo];
            array[IndiceIzquierdo] = array[IndiceDerecho];
            array[IndiceDerecho] = IndiceTemporal;
        }

        public void ImprimirLista(int[]array) //Método para imprimir la lista.
        {
            for (int i = 0; i < array.Length-1;i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}