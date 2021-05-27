using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Abecedario
{
    class Program
    {
        static int limiteAbecedario = 90;

        public static void AbecedarioImpar()
        {
            int inicio = 65;
            while (inicio < limiteAbecedario)
            {
                switch (inicio)
                {
                    case 65: Console.WriteLine("Tarea 1: A"); Thread.Sleep(1000); break;
                    case 67: Console.WriteLine("Tarea 1: C"); Thread.Sleep(1000); break;
                    case 69: Console.WriteLine("Tarea 1: E"); Thread.Sleep(1000); break;
                    case 71: Console.WriteLine("Tarea 1: G"); Thread.Sleep(1000); break;
                    case 73: Console.WriteLine("Tarea 1: I"); Thread.Sleep(1000); break;
                    case 75: Console.WriteLine("Tarea 1: K"); Thread.Sleep(1000); break;
                    case 77: Console.WriteLine("Tarea 1: M"); Thread.Sleep(1000); break;
                    case 79: Console.WriteLine("Tarea 1: O"); Thread.Sleep(1000); break;
                    case 81: Console.WriteLine("Tarea 1: Q"); Thread.Sleep(1000); break;
                    case 83: Console.WriteLine("Tarea 1: S"); Thread.Sleep(1000); break;
                    case 85: Console.WriteLine("Tarea 1: U"); Thread.Sleep(1000); break;
                    case 87: Console.WriteLine("Tarea 1: W"); Thread.Sleep(1000); break;
                    case 89: Console.WriteLine("Tarea 1: Y"); Thread.Sleep(1000); break;
                }
                inicio += 2;
            }
        }

        public static void AbecedarioPar()
        {
            int inicio = 66;
            while (inicio <= limiteAbecedario)
            {
                switch (inicio)
                {
                    case 66: Console.WriteLine("Tarea 2: B"); Thread.Sleep(1000); break;
                    case 68: Console.WriteLine("Tarea 2: D"); Thread.Sleep(1000); break;
                    case 70: Console.WriteLine("Tarea 2: F"); Thread.Sleep(1000); break;
                    case 72: Console.WriteLine("Tarea 2: H"); Thread.Sleep(1000); break;
                    case 74: Console.WriteLine("Tarea 2: J"); Thread.Sleep(1000); break;
                    case 76: Console.WriteLine("Tarea 2: L"); Thread.Sleep(1000); break;
                    case 78: Console.WriteLine("Tarea 2: N"); Thread.Sleep(1000); break;
                    case 80: Console.WriteLine("Tarea 2: P"); Thread.Sleep(1000); break;
                    case 82: Console.WriteLine("Tarea 2: R"); Thread.Sleep(1000); break;
                    case 84: Console.WriteLine("Tarea 2: T"); Thread.Sleep(1000); break;
                    case 86: Console.WriteLine("Tarea 2: V"); Thread.Sleep(1000); break;
                    case 88: Console.WriteLine("Tarea 2: X"); Thread.Sleep(1000); break;
                    case 90: Console.WriteLine("Tarea 2: Z"); Thread.Sleep(1000); break;
                }
                inicio += 2;
            }
        }

        static void Main(string[] args)
        {
            var t1 = new Task(AbecedarioImpar);
            t1.Start();

            var t2 = new Task(AbecedarioPar);
            t2.Start();

            Task.WaitAll(t1, t2);
            Console.ReadKey();
        }
    }
}