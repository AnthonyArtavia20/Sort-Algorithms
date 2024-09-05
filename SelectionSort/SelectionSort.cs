namespace SelectionSortA
{
    public class SelectionSortClass : SomeMethods //Implementamos una interfaz simple para prácticar.
    {
        public void SelectionSort(int[]array) //Creamos un método encargado del SelectionSort
        {
            int indiceInicial = 0; //Indice inicial para buscar por índices por la lista.
            while (indiceInicial != array.Length-1) //Este bucle se encarga de revisar cuantas veces sean según la cantidad de elementos en la array.
            {
                int valorMin = array[indiceInicial]; //Valor menor inicial  que siempre es el primero, este se va actualizando.
                int valorMinIndex = indiceInicial; //El número de indice donde está el valor mínimo.

                for (int i = indiceInicial; i < array.Length-1; i++) //Encargado de buscar el valor mínimo y actualizarlo.
                {
                    if (array[i] <= valorMin) //Comparación constante para encontrar el mínimo de todas los elementos.
                    {
                        valorMin = array[i];
                        valorMinIndex = i;
                    }
                }

                if (array[indiceInicial] > valorMin) //Cuando termine de buscar el mínimo, comparamos el actual con ese 
                { //mínimo, si el actual es mayor, entonces hacemos "Swap" y nos movemos al siguiente elemento a comparar.
                    swapmethod(array, indiceInicial,valorMinIndex);
                }
                indiceInicial++; //Cuando se hizo el "Swap" nos movemos al siguiente elemento a comparar en la lista ya que el actual ya está ordenado.
            }
        }

        private void swapmethod(int[]array, int index1,int index2) //Encargado de intercambiar los elementos por medio de una variable temporal.
        {
            int indice_temporal = array[index1]; //Copiamos el valor del indice 1 para poder guardarlo.
            array[index1] = array[index2]; //Igualamos el primero y lo intercambiamos por el segundo
            array[index2] = indice_temporal; //Como el primero se destruyó, entonces igualamos el temporal que tiene el valor del primero al segundo-
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