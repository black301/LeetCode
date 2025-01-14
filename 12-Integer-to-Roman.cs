 public class Solution
 {
     public string IntToRoman(int num)
     {
         int place = 1, temp;
         string result = \\;
         Dictionary<int, string> dic = new Dictionary<int, string>{
             {1,\I\},
             {5,\V\},
             {10,\X\},
             {50,\L\},
             {100,\C\},
             {500,\D\},
             {1000,\M\},
         };
         while (num > 0)
         {
             temp = num % 10;
             if (temp == 9 || temp == 4)
             {
                 result = dic[place] + dic[(temp + 1) * place] + result;
             }
             else
             {
                 if (dic.ContainsKey(temp * place))
                 {
                     result = dic[temp * place] + result;
                 }
                 else
                 {
                     if (temp == 2 || temp == 7) result = dic[place] + dic[place] + result;
                     if (temp == 3 || temp == 8) result = dic[place] + dic[place] + dic[place] + result;
                     if (temp == 7 || temp == 8) result = dic[place * 5] + result;
                     if (temp == 6) result = dic[place * 5]+dic[place] + result;
                 }
             }
             place = place * 10;
             num/=10;
         }
         return result;
     }
 }