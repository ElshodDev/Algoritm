namespace MedianOfTwoSortedArrays
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] nums1 = { 1, 3 };
			int[] nums2 = { 2 };
			double result = FindMedianSortedArrays(nums1, nums2);
			Console.WriteLine(result); // Output: 2.0

			nums1 = new int[] { 1, 2 };
			nums2 = new int[] { 3, 4 };
			result = FindMedianSortedArrays(nums1, nums2);
			Console.WriteLine(result); // Output: 2.5

			nums1 = new int[] { 0, 0 };
			nums2 = new int[] { 0, 0 };
			result = FindMedianSortedArrays(nums1, nums2);
			Console.WriteLine(result); // Output: 0.0

			nums1 = new int[] { };
			nums2 = new int[] { 1 };
			result = FindMedianSortedArrays(nums1, nums2);
			Console.WriteLine(result); // Output: 1.0

			nums1 = new int[] { 2 };
			nums2 = new int[] { };
			result = FindMedianSortedArrays(nums1, nums2);
			Console.WriteLine(result); // Output: 2.0
		}

		public static double FindMedianSortedArrays(int[] nums1, int[] nums2)
		{
			if (nums1.Length > nums2.Length)
			{
				return FindMedianSortedArrays(nums2, nums1);
			}

			int x = nums1.Length;
			int y = nums2.Length;
			int low = 0;
			int high = x;

			while (low <= high)
			{
				int partitionX = (low + high) / 2;
				int partitionY = (x + y + 1) / 2 - partitionX;

				int maxX = (partitionX == 0) ? int.MinValue : nums1[partitionX - 1];
				int maxY = (partitionY == 0) ? int.MinValue : nums2[partitionY - 1];

				int minX = (partitionX == x) ? int.MaxValue : nums1[partitionX];
				int minY = (partitionY == y) ? int.MaxValue : nums2[partitionY];

				if (maxX <= minY && maxY <= minX)
				{
					if ((x + y) % 2 == 0)
					{
						return (Math.Max(maxX, maxY) + Math.Min(minX, minY)) / 2.0;
					}
					else
					{
						return Math.Max(maxX, maxY);
					}
				}
				else if (maxX > minY)
				{
					high = partitionX - 1;
				}
				else
				{
					low = partitionX + 1;
				}
			}
			throw new ArgumentException("Input arrays are not sorted or of invalid size.");
		}
	}
}
	