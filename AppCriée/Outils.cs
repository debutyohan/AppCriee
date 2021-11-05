using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace AppCriée
{
    public  class Outils
    {
        public Outils() { }
        public static bool IsNumeric(String Test)
        {
            double X;
            try
            {
                X = double.Parse(Test);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool IsDate(String Test)
        {
            DateTime X;
            try
            {
                X = DateTime.Parse(Test);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static bool IsValidEmail(string strIn)
        {
            // Return true if strIn is in valid e-mail format.
            return Regex.IsMatch(strIn,
                   @"^(?("")("".+?""@)|(([0-9a-zA-Z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-zA-Z])@))" +
                   @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,6}))$");
        }
        public static string GeneratePassword(int Length)
        {
            return GeneratePassword(Length, "0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray());
        }
        public static string GeneratePassword(int Length, bool CaseSensitive)
        {
            if (CaseSensitive)
                return GeneratePassword(Length);
            else
                return GeneratePassword(Length, "0123456789abcdefghijklmnopqrstuvwxyz".ToCharArray());
        }
        public static string GeneratePassword(int Length, char[] Chars)
        {
            string Password = string.Empty;
            System.Random rnd = new System.Random();
            for (int i = 0; i < Length; i++)
                Password += Chars[rnd.Next(Chars.Length)];
            return Password;

        }
    }
}
