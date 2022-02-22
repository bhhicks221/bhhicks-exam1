
using System;
using System.IO;

namespace bhhicks_exam1
{
    public class Trainer : ITrain
    {
        public string Name { get; set;}
        public ITrain trainBehavior{get; set;}

        public Trainer()
        {
            trainBehavior = new Shake();
        }
        public void SetTrainBehavior(ITrain trainBehavior)
        {
            this.trainBehavior = trainBehavior;
        }
    }
}