namespace Reto2
{
    public class Validator_On
    {
        public bool IsCollapsable(int[] input)
        {
            if (input.Length <= 1) return true;

            else
                return (input[^1] != input[^2]);
        }

        public int CountCollapsableSubarrays(int[] input)
        {
            int rst = input.Length;
            for (var index = 0; index < input.Length - 1; index++)
            {
                if (IsCollapsable(input[index..(index + 2)])) rst += index + 1;
            }

            return rst;
        }
    }
}
