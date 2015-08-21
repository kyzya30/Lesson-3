using System;


namespace Task5
{
    internal class ExcelentPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine("Excellent pupil: study excellent");
        }

        public override void Read()
        {
            Console.WriteLine("Excellent pupil: very good read");
        }

        public override void Write()
        {
            Console.WriteLine("Excellent pupil: very good read");
        }

        public override void Relax()
        {
            Console.WriteLine("Excellent pupil: relax bad");
        }

    }
}
