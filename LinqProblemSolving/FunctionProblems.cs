using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqProblemSolving
{
    class FunctionProblems
    {
        List<string> word = new List<string>() { "the", "bike", "this", "it", "tenth", "mathematics" };
        List<string> names = new List<string>() { "Mike", "Brad", "Nevin", "Ian", "Mike" };
        List<string> classGrades = new List<string>() { "80,100,92,89,65", "93,81,78,84,69", "73,88,83,99,64", "98,100,66,74,55" };




        public FunctionProblems()
        {
           
        }

        public void GetSubStringTH()
        {            
            var words = word;
            var wordsWithTH = words.Where(w => w.Contains("th"));
            foreach(var word in wordsWithTH)
            {
                Console.WriteLine(word);                
            }
        }
        public void GetNameOnlyOnce()
        {
            var name = names;
            var nameList = name.Distinct();
            foreach(var names in nameList)
            {
                Console.WriteLine(names);
            }
        }
        //public void GetAverageGrades()
        //{
        //    var grades = classGrades;
        //    double result = (from x in grades select x.Length).Average();
        //    Console.WriteLine(result);
        //}

        //public void GetCharFrequency()
        //{
        //    var name = "Abraham";
        //    var frequency = name.ToLower().Distinct().ToList();
        //    foreach (var instances in frequency)
        //    {
        //        Console.WriteLine(instances);
        //    }
        //}
    }
}
