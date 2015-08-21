using System;

namespace Task5
{
    class ClassRoom
    {
        private Pupil ClassPupil1;
        private Pupil ClassPupil2;
        private Pupil ClassPupil3;

        public ClassRoom(Pupil pupil1, Pupil pupil2)
        {
            this.ClassPupil1 = pupil1;
            this.ClassPupil2 = pupil2;
        }

        public ClassRoom(Pupil pupil1, Pupil pupil2, Pupil pupil3)
        {
            this.ClassPupil1 = pupil1;
            this.ClassPupil2 = pupil2;
            this.ClassPupil3 = pupil3;
        }

        public void ShowPupil()
        {

            if (ClassPupil1 != null && ClassPupil2 != null && ClassPupil3 == null)
            {
                ShowPupilInfo(ClassPupil1);
                ShowPupilInfo(ClassPupil2);

            }
            else
            {
                ShowPupilInfo(ClassPupil1);
                ShowPupilInfo(ClassPupil2);
                ShowPupilInfo(ClassPupil3);
            }
        }

        private void ShowPupilInfo(Pupil ClassPupil)
        {
            ClassPupil.Study();
            ClassPupil.Read();
            ClassPupil.Write();
            ClassPupil.Relax();
            Console.WriteLine("----------------");
        }
    }
}
