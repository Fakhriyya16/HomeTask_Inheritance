
namespace Homework_Inheritance
{
    public class CustomMath
    {
        public int SumOfOddNumbers(int[] nums)
        {
            int sum = 0;
            for(int i = 0; i < nums.Length; i++)
            {
                if (nums[i] % 2 == 1)
                {
                    sum += nums[i];
                }
            }
            return sum;
        }

        public void OddOrEvenNumber(int n)
        {
            if(n%2 == 0)
            {
                Console.WriteLine("Even");
            }
            else
            {
                Console.WriteLine("Odd");
            }
        }

        public int SquareOfSumOfNumbers(int[] nums)
        {
            int sum = 0;
            for (int i = 0;i < nums.Length;i++)
            {
                if (nums[i] %2 == 0)
                {
                    sum += nums[i];
                }
            }
            int square = sum * sum;
            return square;
        }

        public int Multiplier(int n)
        {
            int multiplier = 1;
            for(int i = 1;i <= n; i++)
            {
                multiplier *= i;
            }
            return multiplier;
        }
    }
}
