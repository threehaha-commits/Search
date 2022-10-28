public static class BinarySearch
{
    /// <summary>
    /// Simple binary search
    /// </summary>
    /// <param name="array">Your array</param>
    /// <param name="value">Find value</param>
    /// <param name="index">If you want return index value that index must be true</param>
    /// <returns>Return -1 if value cannot find</returns>
    public static int Find(int[] array, int value, bool index = false)
    {
        var left = 0;
        var right = array.Length - 1;
        var middle = 0;
        
        while (left <= right)
        {
            middle = (left + right) / 2;
            if (array[middle] == value)
            {
                if (index == false)
                    return middle;
                
                return array[middle];
            }
            
            if (value < array[middle])
                right = middle - 1;
            else
                left = middle + 1;
        }

        return -1;
    }
}