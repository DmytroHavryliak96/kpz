using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1.ValidateInput
{
    public static class ValidateUser
    {
        public static bool CheckNullOrEmpty(params string[] parameters) { 
            foreach(string str in parameters)
                if (String.IsNullOrEmpty(str))
                    return false;
            return true;
          
        }

        public static bool CheckLetters(params string[] parameters)
        {
            foreach (string str in parameters)
                if (!str.All(c => Char.IsLetter(c)))
                    return false;
            return true;
        }

        public static bool CkeckNumber(string number)
        {
            if (!number.All(c => Char.IsDigit(c)))
                return false;
            int num;
            if (!Int32.TryParse(number, out num))
                return false;
            
            return true; 
        }

        public static bool CheckLettersAndDigits(params string[] parameters)
        {
            foreach (string str in parameters)
                if (!str.All(c => Char.IsLetter(c) || Char.IsDigit(c)))
                    return false;
            return true;
        }

        public static bool CheckPhone(string phone)
        {
            if (phone.Length != 13 || !phone[0].Equals('+'))
                return false;
            for(int i = 1; i < phone.Length; i++)
            {
                if (!Char.IsDigit(phone[i]))
                    return false;
            }
            return true;
        }
    }
}
