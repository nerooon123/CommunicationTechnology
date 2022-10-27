using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCheckLibrary
{
    public class CheckStringClass
    {
        public bool LoginCheck(string login)
        {
            string correctSymbols = "abcdefghijklmnopqrstuvwxyz0123456789-_.";
            login = login.ToLower();
            if (!login.All(x => correctSymbols.Contains(x)))
            {
                throw new Exception("Логин содержит недопустимые символы");
            }
            if (login == String.Empty)
            {
                throw new Exception("Вы не ввели логи");
            }
            if (login.EndsWith("."))
            {
                throw new Exception("Логин не может заканчиваться символом точка");
            }
            return true;
        }
    }
}
