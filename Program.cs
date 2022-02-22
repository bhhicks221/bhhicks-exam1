using System;
using System.IO;
using System.Collections.Generic;

namespace bhhicks_exam1
{
    class Program
    {
        static void Main(string[] args)
        {
            Trainer myTrainer = new Trainer(){Name = "Jeff"};
            myTrainer.trainBehavior = new Sit();
            myTrainer.trainBehavior.Train();

            Trainer newTrainer = new Trainer(){Name = "Dave"};
            newTrainer.trainBehavior = new Shake();
            newTrainer.trainBehavior.Train();

            Trainer anotherTrainer = new Trainer(){Name = "DeMarcus"};
            anotherTrainer = new Stay();
            anotherTrainer.trainBehavior.Train();
        }
    }
}
