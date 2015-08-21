using System;


namespace Task5
{
    class GoodPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine("Good pupil: study good");
        }

        public override void Read()
        {
            Console.WriteLine("Good pupil: very good read");
        }

        public override void Write()
        {
            Console.WriteLine("Good pupil: good read");
        }

        public override void Relax()
        {
            Console.WriteLine("Good pupil: relax very good");
        }
    }
}
