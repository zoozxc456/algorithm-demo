namespace AlgorithmDemo.Sort;

public class QuickSortAlgorithm : ISortAlgorithm
{
    private int[] _nums = [];

    public int[] Sorted(int[] nums)
    {
        _nums = nums;
        QuickSort(_nums, 0, nums.Length - 1);
        return _nums;
    }

    private static void QuickSort(int[] nums, int left, int right)
    {
        if (left < right)
        {
            var pivotIndex = Partition(nums, left, right);

            QuickSort(nums, left, pivotIndex);
            QuickSort(nums, pivotIndex + 1, right);
        }
    }

    private static int Partition(int[] nums, int left, int right)
    {
        var pivot = nums[left];
        var swapCurrentIndex = left;

        for (var index = left + 1; index < right; index++)
        {
            if (IsLessThenPivot(nums[index], pivot))
            {
                Swap(nums, swapCurrentIndex + 1, index);
                swapCurrentIndex++;
            }
        }

        Swap(nums, swapCurrentIndex, left);

        return swapCurrentIndex;
    }

    private static bool IsLessThenPivot(int num, int pivot)
    {
        return num < pivot;
    }

    private static void Swap(int[] nums, int index1, int index2)
    {
        (nums[index1], nums[index2]) = (nums[index2], nums[index1]);
    }
}