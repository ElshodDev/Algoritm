namespace Algoritm
{
  public class HumantakeCatandDog
    {  public static int[] humanYearsCatYearsDogYears(int humanYears)
        {
            int catYears = humanYears==1 ? 15 :
                 humanYears==2 ? 24 : 24+(humanYears-2)*4;
            int dogYears = humanYears==1 ? 15 :
                humanYears==2 ? 24 : 24+(humanYears-2)*5;

            return new int[] { humanYears, catYears, dogYears };
        }
    }
}
