using System;


namespace Task5
{
    class BadPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine("BadPupil: study bad");
        }

        public override void Read()
        {
            Console.WriteLine("BadPupil: very bad read");
        }

        public override void Write()
        {
            Console.WriteLine("BadPupil: bad read");
        }

        public override void Relax()
        {
            Console.WriteLine("BadPupil: relax excellent");
        }

    }
}
