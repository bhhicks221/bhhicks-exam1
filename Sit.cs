using System;
using System.IO;

namespace bhhicks_exam1
{
    public class Sit : ITrain
    {
        public override void Train()
        {
            Console.WriteLine("I'm teaching the dog to sit.");
        }
    }
}