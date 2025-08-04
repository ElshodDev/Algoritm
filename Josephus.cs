namespace Algoritm
{
    public class Josephus
    { 
        public static List<object> JosephusPermutation(List<object> items, int k)
        {
           List<object> result = new List<object>();
            int index = 0;
            while (items.Count>0) 
            {
                index=(index+k-1)%items.Count;
                result.Add(items[index]);
                items.RemoveAt(index);
            }
            return result;
        }
    }
}
