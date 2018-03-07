using System;
using System.Threading;
using System.Threading.Tasks;
using System.Diagnostics;
using static System.Console;

namespace WorkingWithTasks
{
    public static class Program
    {
        static void MethodA()
        {
            WriteLine("Starting Method A...");
            Thread.Sleep(3000); // simulate three seconds of work
            WriteLine("Finished Method A.");
        }

        static void MethodB()
        {
            WriteLine("Starting Method B...");
            Thread.Sleep(2000); // simulate two seconds of work
            WriteLine("Finished Method B.");
        }

        static void MethodC()
        {
            WriteLine("Starting Method C...");
            Thread.Sleep(1000); // simulate one second of work
            WriteLine("Finished Method C.");
        }

        public static void Main()
        {
            var timer = Stopwatch.StartNew();

            //WriteLine("Running methods synchronously on one thread.");
            //MethodA();
            //MethodB();
            //MethodC();

            WriteLine("Running methods synchronously on one thread.");
            Task taskA = new Task(MethodA);
            taskA.Start();
            Task taskB = Task.Factory.StartNew(MethodB);
            Task taskC = Task.Run(new Action(MethodC));

            Task[] tasks = { taskA, taskB, taskC };
            Task.WaitAll(tasks);

            WriteLine($"{timer.ElapsedMilliseconds:#,##0}ms elapsed.");

            WriteLine("Press ENTER to end.");
            ReadLine();
        }
    }
}