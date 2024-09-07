using SelectionSortA;
using InsetionSortA;
using BubbleSortFolder;
using QuickSortFolder;

namespace Principal
{
    public class Program
    {
        public static void Main(string[] args)
        {
            SelectionSortClass selectionSort = new SelectionSortClass();
            InsetionSort insertionSort = new InsetionSort();
            BubbleSortAlgorithm bubbleSorting = new BubbleSortAlgorithm();
            QuickSort quickSort= new QuickSort();


            int[] array = {56,5,87,6,2,100,4,0,9,3};

            //selectionSort.SelectionSort(array);
            //selectionSort.ImprimirLista(array);

            //insertionSort.InsertionSort(array);
            //insertionSort.ImprimirLista(array);

            //bubbleSorting.BubbleSort(array);
            //bubbleSorting.ImprimirLista(array);

            quickSort.QuickSortAlgorithm(array,0,1);
            quickSort.ImprimirLista(array);

        }
    }
}