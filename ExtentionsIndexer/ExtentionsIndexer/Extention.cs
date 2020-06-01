using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace ExtentionsIndexer
{
    public static class Extention
    {
        public static bool IsEmail(this string str)
        {
            try
            {
                MailAddress email = new MailAddress(str);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static int HasChar(this string str,char letter)
        {
            int result = 0;
            foreach (char item in str)
            {
                if (item == letter)
                    result++;
            }
            return result;
        }

        public static int GetPower(this int num,int pow)
        {
            //return Math.Pow(num, pow);
            int result = 1;
            for (int i = 0; i < pow; i++)
            {
                result *= num;
            }
            return result;
        }
    }
}
