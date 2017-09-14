using System;

namespace SortAlgorithms
{
    public class SortAlgorithms<T> where T : IComparable<T>
    {
        /*************************************** QuickSort ******************************************************/
        Random rand = new Random();
        public void SortQuick(T[] items)
        {
            QuickSortFunction(items, items.Length - 1, 0);
        }
        private void QuickSortFunction(T[] items, int right, int left)
        {
            if (left < right)
            {
                int pivotInfo = rand.Next(left, right);
                int pivot = partitionQuick(items, right, left, pivotInfo);

                QuickSortFunction(items, pivot - 1, left);
                QuickSortFunction(items, right, pivot + 1);
            }
        }
        
        private int partitionQuick(T[] items, int right, int left, int pivotIndex)
        {
            T valueOnIndex = items[pivotIndex];

            Swap(items, pivotIndex, right);

            int storeIndex = left;

            for (int count = left; count < right; count++)
            {
                if (items[count].CompareTo(valueOnIndex) < 0)
                {
                    Swap(items, count, storeIndex);
                    storeIndex += 1;
                }
            }

            Swap(items, storeIndex, right);
            return storeIndex;

        }
        /*************************************** Merge ******************************************************/
        public void SortMerge(T[] items)
        {
            if (items != null)
            {
                if (items.Length <= 1)
                {
                    return;
                }
                int leftLength = items.Length / 2;
                int rightLength = items.Length - leftLength;

                T[] left = new T[leftLength];
                T[] right = new T[rightLength];

                Array.Copy(items, 0, left, 0, leftLength);
                Array.Copy(items, leftLength, right, 0, rightLength);

                SortMerge(left);
                SortMerge(right);
                MergeSortInfo(items, left, right);
            }
        }

        private void MergeSortInfo(T[] items, T[] left, T[] right)
        {
            int indexLeft = 0;
            int indexRight = 0;
            int indexTarget = 0;
            int remainingItems = left.Length + right.Length;
            while (remainingItems > 0)
            {
                if (indexLeft >= left.Length)
                {
                    items[indexTarget] = right[indexRight++];
                }
                else if (indexRight >= right.Length)
                {
                    items[indexTarget] = left[indexLeft++];
                }
                else if (right[indexRight].CompareTo(left[indexLeft]) > 0)
                {
                    items[indexTarget] = left[indexLeft++];
                }
                else
                {
                    items[indexTarget] = right[indexRight++];
                }
                remainingItems--;
                indexTarget++;
            }

        }

        /*************************************** Bubble ******************************************************/
        public void SortBubble(T[] items)
        {
            if (items != null)
            {
                bool Swaped = true;
                do
                {
                    Swaped = false;
                    for (int count = 1; count < items.Length; count++)
                    {
                        if (items[count - 1].CompareTo(items[count]) > 0)
                        {
                            Swap(items, count - 1, count);
                            Swaped = true;
                        }
                    }

                } while (Swaped);
            }
        }
        /********************************************Insertion***********************************************/
     
        public void SortInsertion(T[] items)
        {
            int srtIndex = 1;
            while (srtIndex < items.Length)
            {
                if (items[srtIndex].CompareTo(items[srtIndex - 1]) < 0)
                {
                    int indextAt = findIndexAt(items, items[srtIndex]);
                    AssignValue(items, indextAt, srtIndex);
                }
                srtIndex++;
            }
        }
        private void AssignValue(T[] items, int indexAt, int srtIndex)
        {
            T temp = items[indexAt];
            items[indexAt] = items[srtIndex];
            for (int counter = srtIndex; counter > indexAt; counter--)
            {
                items[counter] = items[counter - 1];
            }
            items[indexAt + 1] = temp;
        }
        private int findIndexAt(T[] items, T value)
        {
            for (int counter = 0; counter < items.Length; counter++)
            {
                if (items[counter].CompareTo(value) > 0)
                {
                    return counter;
                }
            }
            throw new ArgumentException("The Inserted Value does not exists");
        }
        private int FindElementAt(T[] items, T value)
        {
            for (int counter = 0; counter < items.Length; counter++)
            {
                if (items[counter].CompareTo(value) > 0)
                {
                    return counter;
                }
            }
            throw new InvalidOperationException("The insertion index was not found");
        }
        private void Insert(T[] itemArray, int indexInsertingAt, int indexInsertingFrom)
        {
            T temp = itemArray[indexInsertingAt];

            // Step 2
            itemArray[indexInsertingAt] = itemArray[indexInsertingFrom];

            // Step 3
            for (int current = indexInsertingFrom; current > indexInsertingAt; current--)
            {
                itemArray[current] = itemArray[current - 1];
            }

            // Step 4
            itemArray[indexInsertingAt + 1] = temp;
        }
        /********************************** Selection **************************************************/
      
        public void SortSelection(T[] items)
        {
            int indexInfo = 0;
            while (indexInfo < items.Length)
            {
                int smallestInt = FindSmallestInt(items, indexInfo);
                var temp = items[indexInfo];
                items[indexInfo] = items[smallestInt];
                items[smallestInt] = temp;
                indexInfo++;
            }
        }
        private int FindSmallestInt(T[] items, int indextorganized)
        {
            int smallestInt = indextorganized;
            T ChoosenValue = items[indextorganized];
            for (int count = indextorganized; count < items.Length; count++)
            {
                if (items[count].CompareTo(ChoosenValue) < 0)
                {
                    smallestInt = count;
                    ChoosenValue = items[count];
                }
            }
            return smallestInt;
        }
       
        /********************************** End Selection ************************************************/
        private void Swap(T[] items, int left, int right)
        {
            if (left != right)
            {
                T temp = items[left];
                items[left] = items[right];
                items[right] = temp;
            }
        }
    }
}
