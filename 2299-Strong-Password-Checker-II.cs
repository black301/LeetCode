using System.Text.RegularExpressions;

        public class Solution
        {
            public bool StrongPasswordCheckerII(string password)
            {
                Regex reg = new(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[!@#$%^&*()\-+])(?!.*(.)\1)[A-Za-z\d!@#$%^&*()\-+]{8,}$");
                return reg.IsMatch(password);
            }
        }