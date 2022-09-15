using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;

namespace Reto2
{
    public class Validator_Simple
    {
        public bool IsCollapsable(int[] input)
        {
            if (input.Length <= 1) return true;

            var rst = new List<int[]>() { input };

            while (rst.Any())
            {
                rst = Collapse(rst);
                if (rst.Any(x => x.Length == 1)) return true;                
            }           
            return false;
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

        public List<int[]> Collapse(List<int[]> level)
        {
            return level.SelectMany(x => Collapse(x)).ToList();
        }

        public List<int[]> Collapse(int[] input)
        {
            var rst = new List<int[]>();
            for (var index = 0; index < input.Length - 1; index++)
            {
                var newInput = TryCollapse(index, input);
                if (newInput != null) rst.Add(newInput);
            }

            return rst;
        }

        public int[] TryCollapse(int index, int[] input)
        {
            var head = input[..index];
            var trail = input[(index + 2)..];
            if (input[index] == 0 && input[index + 1] == 1) return head.Concat(new int[] { 1 }).Concat(trail).ToArray();
            if (input[index] == 1 && input[index + 1] == 0) return head.Concat(new int[] { 0 }).Concat(trail).ToArray();

            return null;
        }
    }
}