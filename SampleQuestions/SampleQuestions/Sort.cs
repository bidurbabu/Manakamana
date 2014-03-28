using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleQuestions
{
   public class Sort
    {
        public static void printArray(int[] arr)
        {
            foreach(int i in arr)
            {
                Console.Write(" ");
                Console.Write(i);
            }
        }

        public void swap(int indexA,int indexB,int[] arr)
        {
            int temp = arr[indexA];
            arr[indexA] = arr[indexB];
            arr[indexB] = temp;
        }
        public int[] mergeTwoSortedArray(int[] arr1,int[] arr2)
        {
            int len1 = arr1.Length;
            int len2 = arr2.Length;
            int[] finalArray = new int[len1 + len2];
            int count = 0;
            int index1 = 0;
            int index2 = 0;
            while(index1<len1&&index2<len2)
            {
                if(arr1[index1]<arr2[index2])
                {
                    finalArray[count++] = arr1[index1++];
                }
                else
                {
                    finalArray[count++] = arr2[index2++];
                }
            }
            while(index1<len1)
            {
                finalArray[count++] = arr1[index1++];
            }
            while(index2<len2)
            {
                finalArray[count++]=arr2[index2++];
            }
            return finalArray;
        }
        public void mergSortSingleArrayWithPivotStartIndexAndEndIndex(int[] arr,int pivot,int start,int end)
        {
            int index1 = start;
            int index2 = pivot;
            int index = 0;
            int len = end - start+1;
            int[] tem = new int[len];
            while ((index1 < pivot) && (index2 <= end))
            {
                if (arr[index1] > arr[index2])
                {
                    tem[index++] = arr[index2++];
                }
                else
                {
                    tem[index++] = arr[index1++];
                }
            }
            while (index1 < pivot)
                tem[index++] = arr[index1++];
            while (index2 <= end)
                tem[index++] = arr[index2++];
            index = 0;
            while (index < len)
            {
                arr[start++] = tem[index++];
            }

        }
        public void mergeSortSingleArrayWithPivotSeparation(int[] arr, int pivot)
        {
            int len = arr.Length;
            mergSortSingleArrayWithPivotStartIndexAndEndIndex(arr, pivot, 0, len-1);  
        }
        public void selectionSort(int[] arr)
        {
            int maxIndex;
            for(int i=0;i<arr.Length;i++)
            {
                maxIndex = i;
               
                for(int j=i+1;j<arr.Length;j++)
                {
                    if(arr[j]>arr[maxIndex])
                    {
                        maxIndex = j;
                    }
                }
                //at this phase we have Maxium value in max
                //swap 
                swap(i, maxIndex, arr);
            }
        }
        public void insertionSort(int[] arr)
        {
            int len = arr.Length;
            for(int i=1;i<len;i++)
            {
                for(int j=i;j>=1;j--)
                {
                    if (arr[j - 1] > arr[j])
                    {
                        swap(j, j - 1, arr);
                    }
                    else
                        continue;
                }
            }
        }
        public void mergSort(int[] arr,int lowerIndex,int upperIndex)
        {

            if (lowerIndex == upperIndex) return;
            int index = (lowerIndex + upperIndex) / 2;
            mergSort(arr, lowerIndex, index);
            mergSort(arr, index + 1, upperIndex);
            mergSortSingleArrayWithPivotStartIndexAndEndIndex(arr, index+1,lowerIndex,upperIndex);
        }
        public void mergSort(int[] arr)
        {
            mergSort(arr, 0, arr.Length - 1);
        }
        public void quickSort(int[] arr)
        {
           quickSort(arr, 0, arr.Length - 1);
         
        }
   
     
        public void quickSort(int[] arr,int start,int end)
        {
            if (start >= end) return ;
            int upperIndex = partition(arr, start, end);
            quickSort(arr, start, upperIndex );
            quickSort(arr, upperIndex + 1, end);

        }

        private int partition(int[] arr, int start, int end)
        {
            int pivotValue = arr[end];
            int upperIndex = end - 1;
            int lowerIndex = start;
            while (upperIndex > lowerIndex)
            {
                while ((upperIndex > start) && (arr[upperIndex] > pivotValue)) { upperIndex--; }
                while ((lowerIndex < end) && (arr[lowerIndex] < pivotValue)) { lowerIndex++; }
                if (upperIndex > lowerIndex)
                {
                    swap(upperIndex--, lowerIndex++, arr);
                }
            }
            if (arr[lowerIndex] > arr[end])
            {
                swap(lowerIndex, end, arr);
            }
            return upperIndex;
        }
    }
}
