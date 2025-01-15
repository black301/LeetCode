public class Solution
{
    public int MinOperations(int n)
    {
        string bin1 = Convert.ToString(n,2);
        char[]bin=bin1.ToCharArray();
        bool carry = false,Isone=false;
        int counter = 0;
        for (int i = bin.Length - 1; i >= 0; i--)
        {
            if (Isone && bin[i] == '1')
            {
                carry = true;
                if (i != 0 && bin[i - 1] == '0'){
                    bin[i - 1] = '1';
                    Isone = false;
                    carry = false;
                } 
            }
            else if (Isone && bin[i] == '0')
            {
                Isone = false;
                carry = false;
            }
            else if (bin[i] == '1') {
                Isone = true;
                counter++;
            } 
        }
        if(carry) counter++;
        return counter;
    }
}