using System;
using System.Collections.Generic;
using System.Text;
namespace DiagramCode
{
    abstract class vehicle
    {
        string vehicle_Company_namre;
        car_ac ac = new car_ac();
        
        static void vehicle(int Vid) 
        {
            

            int id=Vid;
            System.Console.WriteLine("Vehicle id is ="+id);
        }
        int a;
        public abstract int A
        {
            get;
            set;
        }
        public abstract void run();
        public abstract void func();
        public void ApplyBrakes(string vehicleName)
        {
            Console.WriteLine(vehicleName + " apply brakes");
        }
        engine e1=new engine(1122);
        
    }
    class driver:vehicle
    {
        int d_id;
        string name;
        public drive()
        {
            System.Console.WriteLine(  "driving start");
        }




    }
    class car_ac
    {

        public car_ac()
        {


        }

    }
    class engine//compsition
    {
         static void engine(int eng_id)
         { id=eng_id;
         System.Console.WriteLine("Engine id is ="+id);


         }
         public override void run()
       {
           Console.WriteLine("engine start");
       }
       public override void brakes()
       {
           Console.WriteLine("engine stop");
       }


    }
     class car : vehicle
    {
       int a;
       public override int A
       {
           get
           {
               return a;
           }
           set
           {
               a = value;
           }
       }
       public override void run()
       {
           Console.WriteLine("car run");
       }
       public override void brakes()
       {
           Console.WriteLine("car stop");
       }
    }
    class Ship : vehicle
    {
       int a;
       public override int A
       {
           get
           {
               return a;
           }
           set
           {
               a = value;
           }
       }
       public override void run()
       {
           Console.WriteLine("Ship floats");
       }
       public override void func()
       {
           Console.WriteLine("Ship func");
       }
    }

    class Program
    {
        static void Main(string[] args)
        {


        }
        
    }
    
}