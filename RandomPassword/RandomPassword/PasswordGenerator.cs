using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomPassword
{
    public class PasswordGenerator
    {

        public static string[] GeneratePasword(int length, int count, bool includeSymbols)
        {
            List<String> passwordList = new List<string>();
            Random rnd = new Random();
            int n;
            

            for (int i = 0; i < count; i++)
            {
                string password = "";

                if (includeSymbols == false)
                {
                    for (int p = 0; p < length; p++)
                    {
                        int decideChar = rnd.Next(3);

                        if (decideChar == 0)
                        {
                            n = rnd.Next(65, 91); // Generate capital letter
                        }
                        else if (decideChar == 1)
                        {
                            n = rnd.Next(97, 123); // Generate lowercase letter
                        }
                        else
                        {
                            n = rnd.Next(48, 58); // Generate a number
                        }
                        // Convert integer to character
                        password += (char)n;
                    }
                }
                else
                {
                    for (int p = 0; p < length; p++)
                    {
                        int decideChar = rnd.Next(4);

                        if (decideChar == 0)
                        {
                            n = rnd.Next(65, 91); // Generate capital letter
                        }
                        else if (decideChar == 1)
                        {
                            n = rnd.Next(97, 123); // Generate lowercase letter
                        }
                        else if (decideChar == 3)
                        {
                            n = rnd.Next(48, 58); // Generate a number
                        }
                        else
                        {
                            n = rnd.Next(33, 48); // Generate a symbol
                        }
                        // Convert integer to character
                        password += (char)n;
                    }
                }

                passwordList.Add(password);
            }
            return passwordList.ToArray();
        }
    }
}
