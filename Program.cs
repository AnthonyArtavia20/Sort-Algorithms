using SelectionSortA;
using InsetionSortA;

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

            insetionSort.InsertionSort(array);
            insetionSort.ImprimirLista(array);
        }
    }
}