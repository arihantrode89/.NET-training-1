using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventRevisionDemo
{
    public class Button
    {
        public delegate void EventHandler();
        public event EventHandler OnClick;

        public void Click()
        {
            OnClick();
        }
    }
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Button btn = new Button();
            //btn.OnClick += new Button.EventHandler(button_click);
            btn.OnClick += button_click;
            btn.Click();
           
        }
        public static void button_click()
        {
            Console.WriteLine("Button clicked");
        }
    }
}
