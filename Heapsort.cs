#region Heapsort
namespace HeapSort
{
    public class HeapSort
    {
        public void Sort(int[] inputArray)
        {
            int sizeOfHeap = inputArray.Length;
            int lastNonleaf = sizeOfHeap / 2 - 1; //you can find the last non leaf with total/2-1.
            for (int i = lastNonleaf; i >= 0; i--)//heapifies all non leafs in sequence
            {
                Heapify(inputArray, sizeOfHeap, i);
            }
            for (int i = sizeOfHeap - 1; i > 0; i--)//move max value to end of heap stack and calls reduced heapify
            {
                (inputArray[0], inputArray[i]) = (inputArray[i], inputArray[0]);  //swaps max value and index value
                Heapify(inputArray, i, 0);
            }
        }
        void Heapify(int[] inputArray, int sizeOfHeap, int nodeIndex)
        {
            int largestValue = nodeIndex; //sets largest value to index to start
            int leftIndex = (2 * nodeIndex + 1); //left child index is equal to 2n+1
            int rightIndex = (2 * nodeIndex + 2); //right child index is equal to 2n+2
            if (leftIndex < sizeOfHeap && inputArray[leftIndex] > inputArray[largestValue]) { largestValue = leftIndex; };
            if (rightIndex < sizeOfHeap && inputArray[rightIndex] > inputArray[largestValue]) { largestValue = rightIndex; };
            if (largestValue != nodeIndex)
            {
                (inputArray[nodeIndex], inputArray[largestValue]) = (inputArray[largestValue], inputArray[nodeIndex]);  //swaps values
                Heapify(inputArray, sizeOfHeap, largestValue);  //if there was a swap, it runs again                                                    
            }
        }

    }
}
#endregion Heapsort