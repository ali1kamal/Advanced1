namespace advanced1;

public class Maximum
{
    public T FindMax<T>(List<T> items) where T: IComparable
    {
        T max = items[0];
        foreach (T item in items) 
        {
            if(item.CompareTo(max) > 0)
                max = item;
        }   
        return max;
    }
}
