using System;

namespace Threehaha
{
    public static class Array
    {
        public static void Check<T>(T[] array)
        {
            if (array == null)
                throw new ArgumentNullException("Массив не должен быть null!");
            if (array.Length == 0)
                throw new ArgumentOutOfRangeException("Массив не может быть равен 0");
        }
    }
}