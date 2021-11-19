using System;
using System.Collections;
using System.Collections.Generic;

namespace Labb_4___Collection_generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee E1 = new Employee() { _ID = 101, _Name = "Anas", _Gender = "Male", _Salary = 20000 };
            Employee E2 = new Employee() { _ID = 102, _Name = "Hanna", _Gender = "Female", _Salary = 30000 };
            Employee E3 = new Employee() { _ID = 103, _Name = "Tobias", _Gender = "Male", _Salary = 40000 };
            Employee E4 = new Employee() { _ID = 104, _Name = "Sara", _Gender = "Female", _Salary = 40000 };
            Employee E5 = new Employee() { _ID = 105, _Name = "Anna", _Gender = "Female", _Salary = 50000 };


            Stack <Employee> MyStack = new Stack <Employee>();
            MyStack.Push(E1);
            MyStack.Push(E2);
            MyStack.Push(E3);
            MyStack.Push(E4);
            MyStack.Push(E5);



            foreach (Employee val in MyStack )
            {
                Console.WriteLine(val._ID + " - " + val._Name +" - "+ val._Gender+" - "+ val._Salary);
                Console.WriteLine("Items left int the Stack = {0}", MyStack.Count);
          
            }
            Console.WriteLine("------------------------------");

            Console.WriteLine("Retrive Using pop Method");



            Employee Emplo = MyStack.Pop();    
            Console.WriteLine(Emplo._ID + " - " + Emplo._Name + " - " + Emplo._Gender + " - " + Emplo._Salary);
            Console.WriteLine("Items left int the Stack = {0}", MyStack.Count);
                                   
            Employee Emplo1 = MyStack.Pop();
            Console.WriteLine(Emplo1._ID + " - " + Emplo1._Name + " - " + Emplo1._Gender + " - " + Emplo1._Salary);
            Console.WriteLine("Items left int the Stack = {0}", MyStack.Count);

            Employee Emplo2 = MyStack.Pop();
            Console.WriteLine(Emplo2._ID + " - " + Emplo2._Name + " - " + Emplo2._Gender + " - " + Emplo2._Salary);
            Console.WriteLine("Items left int the Stack = {0}", MyStack.Count);

            Employee Emplo3 = MyStack.Pop();
            Console.WriteLine(Emplo3._ID + " - " + Emplo3._Name + " - " + Emplo3._Gender + " - " + Emplo3._Salary);
            Console.WriteLine("Items left int the Stack = {0}", MyStack.Count);

            Employee Emplo4 = MyStack.Pop();
            Console.WriteLine(Emplo4._ID + " - " + Emplo4._Name + " - " + Emplo4._Gender + " - " + Emplo1._Salary);
            Console.WriteLine("Items left int the Stack = {0}", MyStack.Count);



            Console.WriteLine("------------------------------");

            MyStack.Push(E1);
            MyStack.Push(E2);
            MyStack.Push(E3);
            MyStack.Push(E4);
            MyStack.Push(E5);

            Console.WriteLine("Retrive Using Peek Method");

            
            Employee Emp = MyStack.Peek();
            Console.WriteLine(Emp._ID + " - " + Emp._Name + " - " + Emp._Gender + " - " + Emp._Salary);
            Console.WriteLine("Items left int the Stack = {0}", MyStack.Count);


            Employee Emp1 = MyStack.Peek();
            Console.WriteLine(Emp1._ID + " - " + Emp1._Name + " - " + Emp1._Gender + " - " + Emp1._Salary);
            Console.WriteLine("Items left int the Stack = {0}", MyStack.Count);

            Console.WriteLine("------------------------------");

            if (MyStack.Contains(E3))
            {
                Console.WriteLine("E3 is in stack");
            }
            else
            {
                Console.WriteLine("E3 is not in stack");
            }

            Console.WriteLine("------------------------------");

            List < Employee > MyList = new List<Employee>();
            MyList.Add(E1);
            MyList.Add(E2);
            MyList.Add(E3);
            MyList.Add(E4);
            MyList.Add(E5);

            if (MyList.Contains(E1))
            {
                Console.WriteLine("E1 object exists in the list");
            }
            else
            {
                Console.WriteLine("Object do not exists int he list");
            }
            Console.WriteLine("");

            Employee First = MyList.Find(y => y._Gender == "Male");

            Console.WriteLine(First._ID + " - " + First._Name + " - " + First._Gender + " - " + First._Salary);

            Console.WriteLine("");

            var Test = MyList.FindAll(c => c._Gender == "Male");
            foreach (var item in Test)
            {
                Console.WriteLine(item._ID + " - " + item._Name + " - " + item._Gender + " - " + item._Salary);
            }



            














        }

    }
}
