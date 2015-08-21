

namespace Task5
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            ExcelentPupil excelentPupil = new ExcelentPupil();
            BadPupil badPupil = new BadPupil();
            GoodPupil goodPupil = new GoodPupil();
            ClassRoom classRoom = new ClassRoom(goodPupil, badPupil, excelentPupil);
            classRoom.ShowPupil();
        }
    }

}

