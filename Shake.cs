using System;
using System.IO;

namespace bhhicks_exam1
{
    public class Shake : ITrain
    {
        public override void Train()
        {
            Console.WriteLine("I'm teaching the dog to shake.");
        }
    }
}