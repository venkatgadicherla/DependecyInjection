using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependecyInjection
{
    public interface IMathOperation

    {
        void Add(int a,int b);
        void Display();
    }
    public class UseOperation : IMathOperation
    {
        public void Add(int a, int b)
        {
            Console.WriteLine(a + b);
        }

        public void Display()
        {
            Console.WriteLine("This is done ru sure");
        }
      
    }

    public class UseOperation2 : IMathOperation
    {
        public void Add(int a, int b)
        {
            Console.WriteLine(a + b);
        }

        public void Display()
        {
            Console.WriteLine("This is  very well done");
        }
    }
    public class DipInd
    {
        private IMathOperation obj;
        public DipInd(IMathOperation pobj)
        {
            obj = pobj;
        }
        public void printdata()
        {
            obj.Display();
           
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // The code provided will print ‘Hello World’ to the console.
            // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.
            DipInd inj = new DipInd( new UseOperation());
            inj.printdata();
            DipInd inj_1 = new DipInd(new UseOperation2());
            inj_1.printdata();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}
