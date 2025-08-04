using System.ComponentModel.Design;

namespace Algoritm
{
    public class ZeroFromEnd
    {
     public static int[] MoveZeros(int[] arr)
        {
            List<int> result = new List<int>();
            int zeroCount = 0;
            foreach (int num in arr) 
            {
                if(num == 0)
                    zeroCount++;
                else
                    result.Add(num);
            }
            for(int i=0; i<zeroCount; i++)
            {
                result.Add(0);
            }
            return result.ToArray();
        }
    }
}
