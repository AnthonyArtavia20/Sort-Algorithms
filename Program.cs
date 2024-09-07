using SelectionSortA;
using InsetionSortA;
using BubbleSortFolder;

namespace Principal
{
    public class Program
    {
        public static void Main(string[] args)
        {

            //SelectionSortClass selectionSort = new SelectionSortClass();

            int[] array = {56,5,87,6,2,100,4,0,9,3};
//
            //selectionSort.SelectionSort(array);
            //selectionSort.ImprimirLista(array);

            InsetionSort insetionSort = new InsetionSort();
            BubbleSortAlgorithm bubbleSorting = new BubbleSortAlgorithm();

            bubbleSorting.BubbleSort(array);
            insetionSort.ImprimirLista(array);
        }
    }
}