public class Solution
{
    public bool CanBeValid(string s, string locked)
    {
        if (s.Length % 2 != 0)
            return false;
        Stack<int> stack = new Stack<int>();
        Stack<int> newstack = new Stack<int>();

        for (int i = 0; i < s.Length; i++)
        {
            if (locked[i] == '0')
            {
                newstack.Push(i);
            }
            else if (s[i] == '(')
            {
                stack.Push(i);
            }
            else if (s[i] == ')')
            {
                if (stack.Count > 0)
                {
                    stack.Pop();
                }
                else if (newstack.Count > 0)
                {
                    newstack.Pop();
                }
                else
                {
                    return false;
                }
            }
        }
        while(stack.Count()!=0 && newstack.Count != 0 && stack.Peek()<newstack.Peek())
        {
            stack.Pop();
            newstack.Pop();
        }
        if (stack.Count() > 0) return false;
        if (newstack.Count() %2!=0) return false;
        return true;
    }
}