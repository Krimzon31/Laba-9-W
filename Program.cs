using System;
using System.Collections.Generic;

namespace Laba_9_W
{
    public class Array_Class<T>
    {
        List<T> list = new List<T> { };

        public Array_Class()
        {
        }
        public void AddElem(T item) // Добавление элементов
        {
            list.Add(item);
        }
        public void DeleteElem(T item) // удаление элемента
        {
            list.Remove(item);
        }
        public T GetElem(int index) // получение элемента
        {
            return list[index];
        }
        public int GetLength() // получение длинны
        {
            return list.Count;
        }
    }

    public class Login : Array_Class<string>
    {
      
    }

    public class Password<T> : Array_Class<T>
    {
       
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Login login = new Login();
            login.AddElem("Arnold");
            login.AddElem("Edward");
            Console.WriteLine(String.Format("{0} {1}", login.GetElem(0), login.GetElem(1)));

            Password<string> password = new Password<string>();
            password.AddElem("1q2w3e4r5t6y7u8i9o0p");

            Console.ReadLine();
        }
    }
}
