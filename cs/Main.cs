using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace cs {
    public class MainDriver {
        public static void Main(string [] args) {
            //PrimitiveDataTypes.DataTypesMain(args);
            //Nullable.NullableMain(args);
            //NS.NamespaceMain(args);
            //StructVsClass.StructVsClassMain(args);
            //DataStructures.DataStructuresMain(args);
            //MultiDimensionalArrays.MultiDimensionalArraysMain(args);
            //ControlStructures.ControlStructuresMain(args);
            //Linq.LinqMain(args);
            //Linq2.Linq2Main(args);
            //Params.ParamsMain(args);
            //Delegates.DelegatesMain(args);
            IO.IOMain(args);
            //Asynch.AsynchMain(args);
            //AsynchCPU.AsynchCPUMain(args);
            //Breakfast.BreakfastMain(args);
            //ExtensionMethods.ExtensionMain(args);
            //ComplexNumber.ComplexMain(args);
            //myquiz.Delegates.QuizMain(args);
            //Events.EventsMain(args);
            //Quizzes.QuizzesMain(args);
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            /*foreach (var word in IO.ReadWordsList("words")) {
                Console.Write("{0}\t", word);
            }
            stopWatch.Stop();
            Console.WriteLine(stopWatch.Elapsed);*/
            /*Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            foreach (var word in IO.ReadWordsSortedSet("words")) {
                Console.Write("{0}\t", word);
            }
            stopWatch.Stop();
            Console.WriteLine(stopWatch.Elapsed);*/
            /*Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            foreach (var word in IO.ReadWordsHashSet("words")) {
                Console.Write("{0}\t", word);
            }
            stopWatch.Stop();
            Console.WriteLine(stopWatch.Elapsed);*/
            /*string[] words = { "COMPUTERS", "ZYMOTIC", "AARDVARK", "WORD", "DATABASIC" };
            int count = 0;
            for (int i = 0; i < 100; i++)
            {
                foreach (var word in words)
                {
                    if (IO.ReadWordsList("words").Contains(word))
                    {
                        count++;
                    }
                }
            }
            stopWatch.Stop();
            Console.WriteLine(stopWatch.Elapsed);
            Console.WriteLine(count);
            count = 0;
            stopWatch.Start();
            for (int i = 0; i < 100; i++)
            {
                foreach (var word in words)
                {
                    if (IO.ReadWordsSortedSet("words").Contains(word))
                    {
                        count++;
                    }
                }
            }
            stopWatch.Stop();
            Console.WriteLine(stopWatch.Elapsed);
            Console.WriteLine(count);
            count = 0;
            stopWatch.Start();
            for (int i = 0; i < 100; i++)
            {
                foreach (var word in words)
                {
                    if (IO.ReadWordsHashSet("words").Contains(word))
                    {
                        count++;
                    }
                }
            }
            stopWatch.Stop();
            Console.WriteLine(stopWatch.Elapsed);
            Console.WriteLine(count);*/
            int threeLetter = 0;
            foreach (var word in IO.ReadWordsList("words"))
            {
                if (word.Length == 3)
                {
                    threeLetter++;
                }
            }
            Console.WriteLine(threeLetter);
        }
    }
}
