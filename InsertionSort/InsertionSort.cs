namespace InsetionSortA
{
    public class InsetionSort : SomeMethods
    {
        public void InsertionSort(int[] array)
        {
            
            for (int i = 1; i < array.Length; i++)
            {
                int ValorActual = array[i];
                int j = i-1; //Para indicar el elemento anterior en la lista

                while (j >= 0 && array[j] > ValorActual)
                {
                    array[j + 1] = array[j];
                    j--;
                }
                array[j + 1] = ValorActual;
            }
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