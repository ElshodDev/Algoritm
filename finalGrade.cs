namespace Algoritm
{
    public class finalGrade
    {
        public static int FinalGrade(int examGrade, int countProject)
        {
            return
            examGrade>90 | countProject > 10 ? 100 :
            examGrade>75 | countProject >= 5 ? 90 :
            examGrade>50 | countProject >= 2 ? 75 :
            0;
        }
    }
}
