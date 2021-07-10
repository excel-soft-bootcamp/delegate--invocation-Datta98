using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeligateInvocationProgram
{
    class Program
    {
        static double Calculate(int x, double y) { return x + y; }

        void Update(int newNumber) { System.Console.WriteLine(newNumber); }

        void Delete(string key) { }

        void obj() { }
        
        void obj2 (string data) { }

        int obj3(int x)
        {
            return x;
        }

        bool obj4( string name, string city)
        {
            return true;

        }
        static void FunctionsAsAnArguments(Action obj, Action<string> obj2, Func<int, int> obj3, Func<string, string, bool> obj4)
        {

            //Invoke Delegate objects


        }

        static void Main(string[] args)
        {
            Program _program = new Program();
            Func<int, double, double> calcualtePtr = new Func<int,  double, double>(Program.Calculate);
            Action<int> updatePtr = new Action<int>(_program.Update);
            Action<string> deletePtr = new Action<string>(_program.Delete);


            FunctionsAsAnArguments(_program.obj, _program.obj2, _program.obj3, _program.obj4);



        }
    }
}
