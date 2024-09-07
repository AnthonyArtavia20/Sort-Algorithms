namespace QuickSortFolder
{
    public class QuickSort : SomeMethods
    {
        public void QuickSortAlgorithm(int[]array, int leftPointer, int rightPointer)
        {
            //Se crean 4 pointers ya que se necesitan las referencias iniciales(leftPointer y RightPointer), estos representan el max y el min de elementos en la lista
            //luego se crean Izq y Derec que son las que van a actualizarse en los bucles while.

            int Izq  = leftPointer;
            int Derec = rightPointer;

            //Calculamos el vivote que encontrará la mitad mde cada arreglo y subarreglo,
            int pivote = array[leftPointer+(rightPointer - leftPointer)/2];
            Console.WriteLine("El redondeo, cálculo del pivote es: " + pivote);

            //Creación del bucle principal que verifica que llegue hasta el tope de longitud.
            while ( Izq <= Derec)
            {
                while (array[Izq] < pivote) //Aquí verificamos que el pivote izquierda se vaya desplazando hasta el pivote
                {
                    Izq++;
                }

                while (array[Derec] > pivote) //Luego comparamos de derecha hasta el pivote.
                {
                    Derec--;
                }

                if (Izq <= Derec)
                {
                    SwapMethod(array,Izq,Derec);
                    Izq++;
                    Derec++;
                }
            }
            Console.WriteLine("LeftPointer= " + Izq);
            Console.WriteLine("RightPointer= " + Derec);

            //Llamadas recursivas encargadas de volver a repetir el proceso pero cada vez con las sublistas.
            if (leftPointer < Derec)
            {
                QuickSortAlgorithm(array,leftPointer,Derec);
            }
            if(rightPointer > Izq)
            {
                QuickSortAlgorithm(array,Izq,rightPointer);
            }
        }

        private static void SwapMethod(int[]array,int IndiceIzquierdo, int IndiceDerecho)
        {
            int temp = array[IndiceIzquierdo];
            array[IndiceIzquierdo] = array[IndiceDerecho];
            array[IndiceDerecho] = temp;
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