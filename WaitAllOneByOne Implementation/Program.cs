using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaitAllOneByOne_Implementation
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Task<int>> taskList = new List<Task<int>>();

            Random randomNumber = new Random();

            for (int i = 0; i < 5; i++)
            {
                taskList.Add(Task.Factory.StartNew<int>(() =>
                {
                    return randomNumber.Next(0, 101);
                }));
            }

            while (taskList.Count > 0)
            {
                int index = Task.WaitAny(taskList.ToArray());

                Console.WriteLine("Hi! My result is " + taskList[index].Result);

                taskList.RemoveAt(index);
            }

            Console.ReadKey();
        }
    }
}
