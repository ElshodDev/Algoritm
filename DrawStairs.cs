namespace Algoritm
{
    public class DrawStairs
    {
        public static string DrawStairFunc(int stairHeight)
        {
            string stairs=string.Empty;
            char space = ' ';
            for (int iteration = 1; iteration < stairHeight; iteration++) 
            {
                stairs +="I\n"+new String(space, count: iteration);
            }
            return stairs+"I";
        }
    }
}
