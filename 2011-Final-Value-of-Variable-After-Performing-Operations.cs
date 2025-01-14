        public class Solution
        {
            public int FinalValueAfterOperations(string[] operations)
            {
                int x=0;
                foreach (string operation in operations)
                    x = operation[1] == '+' ? x+1 : x-1; 
                return x;
            }
        }