using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
namespace Delegate_EventDemo
{
    
    internal class Program:Form
    {
        public delegate void Delegate();

        public event Delegate add;
        public Program()
        {
           
            //creating buttom
            Button btn = new Button();
            btn.Text = "Click";
            btn.Parent = this;
            btn.Location = new Point(100, 100);

            //assigning the click event with inbuilt delegate i.e EventHandler()
            btn.Click += new EventHandler(onclick);
            add += new Delegate(Initialize);
            add();

        }

        public void Initialize()
        {
            Console.WriteLine("Initializing");
        }
        public void onclick(Object sender,EventArgs e)
        {

            MessageBox.Show("Button Clicked");
            Console.WriteLine("Button Clicked");
        }

        static void Main(string[] args)
        {
            Application.Run(new Program());
        }
    }
}
