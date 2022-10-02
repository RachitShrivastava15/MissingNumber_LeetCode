namespace MisingNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = {3,0,1};
            int sum = nums.Length * (nums.Length + 1) / 2;
		
            for(int i = 0; i < nums.Length; i++) {
                sum -= nums[i];
            }
            Console.WriteLine(sum);
        }
    }
}