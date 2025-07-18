namespace AlgorithmDemo.Sort;

public class MergeSortAlgorithm : ISortAlgorithm
{
    public int[] Sorted(int[] nums) => MergeSort(nums, 0, nums.Length - 1);

    private static int[] MergeSort(int[] num, int left, int right)
    {
        if (right - left < 1) return [num[left]];
        
        var mid = (left + right) / 2;
        var leftNumbers = MergeSort(num, left, mid);
        var rightNumbers = MergeSort(num, mid + 1, right);

        var tempNumbers = new int[right - left + 1];
        int leftPos = 0,
            rightPos = 0,
            tempPos = 0;

        while (leftPos != leftNumbers.Length || rightPos != rightNumbers.Length)
        {
            if (leftPos == leftNumbers.Length) tempNumbers[tempPos++] = rightNumbers[rightPos++];
            else if (rightPos == rightNumbers.Length) tempNumbers[tempPos++] = leftNumbers[leftPos++];
            else
            {
                if (leftNumbers[leftPos] < rightNumbers[rightPos]) tempNumbers[tempPos++] = leftNumbers[leftPos++];
                else tempNumbers[tempPos++] = rightNumbers[rightPos++];
            }
        }

        return tempNumbers;
    }
}