using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibForClasses;
using RMP_PR11.Model;
using RMP_PR11.View;

namespace AddDataToDB
{
    class Program
    {
        static void Main(string[] args)
        {
            bool chek = true;
            AirlineEntities db = DBConnect.GetContext();
 /*           int[] ids = new int[db.Users.ToList().Count];
            string[] logins = new string[db.Users.ToList().Count];*/
            string name, surname, login, password, role;
           /* for (int i = 1; i <= ids.Length; i++)
            {
                ids[i - 1] = Convert.ToInt32(db.Users.ToList().Find(x => x.UserID == i).UserID);
                logins[i - 1] = db.Users.ToList().Find(x => x.UserID == i).Login;
            }*/

            Console.Write("Создание новой записи для пользователя\n");
            Console.Write("Введите имя пользователя: ");
            name = Convert.ToString(Console.ReadLine());
            Console.Write("Введите фамилию пользователя: ");
            surname = Convert.ToString(Console.ReadLine());
            Console.Write("Введите логин пользователя: ");
            login = Convert.ToString(Console.ReadLine());
            /*do
            {
                chek = true;
                for(int i = 0; i<logins.Length; i++)
                {
                    if(login == logins[i])
                    {
                        chek = false;
                        Console.Write("Такой логин уже существует! Придумайте другой логин: ");
                        login = Convert.ToString(Console.ReadLine());
                        Console.WriteLine();
                    } 
                }
                if (chek == true)
                {
                    break;
                }
            } while (true);*/
            Console.Write("Введите пароль пользователя: ");
            password = Convert.ToString(Console.ReadLine());
            DataHashing dataHashing = new DataHashing();
            string hash = dataHashing.PasswordHashing(password);
            Console.Write("Хешированный пароль пользователя: " + hash);
            Console.Write("\nВведите роль пользователя (U / A): ");
            role = Convert.ToString(Console.ReadLine());
            Console.WriteLine("\nУчетная запись добавлена ");
            Users user = new Users()
            {
                UserID = 1, //ids.Max()+1,
                Name = name,
                Surname = surname,
                Login = login,
                Password = hash,
                Role = role
            };
            db.Users.Add(user);
            db.SaveChanges();
            Console.ReadKey();
            
        }
    }
}
