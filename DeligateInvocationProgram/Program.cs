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

        void Fuction1() { }
        
        void Function2 (string data) { }

        int Function3(int x)
        {
            return x;
        }

        bool Function4( string name, string city)
        {
            return true;

        }
        static void FunctionsAsAnArguments(Action obj, Action<string> obj2, Func<int, int> obj3, Func<string, string, bool> obj4, Func<int, double,double> obj6, Action<int> obj7 )
        {

            //Invoke Delegate objects
            double _calculation = obj6.Invoke(7, 8.1);
            obj2.Invoke("Datta");
            obj7.Invoke(22);
            obj.Invoke();

            int intparamter = obj3.Invoke(10);
            bool details = obj4.Invoke("Omkar", "Hubli");
            Console.WriteLine(_calculation);
            Console.WriteLine(intparamter);
            Console.WriteLine(details);
        }

        static void Main(string[] args)
        {
            Program _program = new Program();
            Func<int, double, double> calcualtePtr = new Func<int,  double, double>(Program.Calculate);
            Action<int> updatePtr = new Action<int>(_program.Update);
            Action<string> deletePtr = new Action<string>(_program.Delete);
            Action objFunction1 = new Action(_program.Fuction1);
            Action<string> objFunction2 = new Action<string>(_program.Function2);
            Func<int, int> objFunction3 = new Func<int, int>(_program.Function3);
            Func<string, string, bool> objFunction4 = new Func<string, string, bool>(_program.Function4);
            Func<string, string, bool> detailsPtr = new Func<string, string, bool>(_program.Function4);


            FunctionsAsAnArguments(objFunction1, objFunction2, objFunction3,detailsPtr,calcualtePtr,updatePtr);
            Console.ReadKey();


        }
    }
}
