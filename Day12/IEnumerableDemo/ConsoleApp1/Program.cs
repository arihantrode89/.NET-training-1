using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UserInfo[] users = new UserInfo[3]
            {
                new UserInfo(1,"Arihant","Rode"),
                new UserInfo(2,"Ayushya","Tripathi"),
                new UserInfo(3,"Chirag","Bedi")
            };

            Users obj = new Users(users);

            foreach (var item in obj)
            {
                Console.WriteLine($"Id:{item.Id}\nName:{item.Name}\nLocation:{item.Location}");
                Console.WriteLine("".PadLeft(30, '-'));

            }
        }
    }

    public class UserInfo
    { 
        public UserInfo(int id,string name,string location)
        {
            this.Id = id;
            this.Name = name;
            this.Location = location;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }

    }

    public class Users : IEnumerable
    {
        private UserInfo[] _users;

        public Users(UserInfo[] uarr)
        {
            _users = new UserInfo[uarr.Length];
            for(int i = 0; i < uarr.Length; i++)
            {
                _users[i] = uarr[i];
            }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator) GetEnumerator();
        }
        public UserEnum GetEnumerator()
        {
            return new UserEnum(_users);
        }
    }

    public class UserEnum : IEnumerator
    {
        int currentIndex = -1;
        public UserInfo[] users;

        public UserEnum(UserInfo[] list)
        {
            users = list;
        }
        object IEnumerator.Current
        {
            get 
            { 
                return Current;
            }
            
        }

        public UserInfo Current
        {
            get
            {
                try
                {
                    return users[currentIndex];
                }
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }
        }


        public bool MoveNext()
        {
            currentIndex++;
            return (currentIndex < users.Length);
        }

        public void Reset()
        {
            currentIndex=-1;
        }
    }

}
