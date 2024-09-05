using SelectionSortA;

namespace Principal
{
    public class Program
    {
        public static void Main(string[] args)
        {

            SelectionSortClass selectionSort = new SelectionSortClass();

            int[] array = {56,5,87,6,23,2,9,3};

            selectionSort.SelectionSort(array);
            selectionSort.ImprimirLista(array);
        }
    }
}