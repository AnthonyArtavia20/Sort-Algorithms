namespace SelectionSortA
{
    public class SelectionSortClass
    {
        public void SelectionSort(int[]array)
        {
            int indiceInicial = 0;
            while (indiceInicial != array.Length-1)
            {
                int valorMin = array[indiceInicial]; //Valor menor inicial  que siempre es el primero, este se va actualizando.
                int valorMinIndex = indiceInicial; //El número de indice donde está el valor mínimo.

                for (int i = indiceInicial; i < array.Length-1; i++)
                {
                    if (array[i] <= valorMin)
                    {
                        valorMin = array[i];
                        valorMinIndex = i;
                    }
                }

                if (array[indiceInicial] > valorMin)
                {
                    swapmethod(array, indiceInicial,valorMinIndex);
                }
                indiceInicial++;
            }
        }

        private void swapmethod(int[]array, int index1,int index2)
        {
            int indice_temporal = array[index1];
            array[index1] = array[index2];
            array[index2] = indice_temporal;
        }

        public void ImprimirLista(int[]array)
        {
            for (int i = 0; i < array.Length-1;i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}