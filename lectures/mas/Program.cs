using System;

namespace mas
{
    class Program
    {
        static void Main(string[] args)
        {
            // переворот массива
            int l = 0, r = size - 1;
            while(l < r)
            { 
                l++; r--;
            }
            int temp = mas[l];
            mas[l] = mas[r];
            mas[r] = temp;
            l++;r--;


            // переворот соседних элементов с шагом 2
            for (i = 0; i < size - 1; i+=2)
            {
                int temp = mas[i];
                mas[i] = mas[i+1];
                mas[i+1] = temp;
                i += 2;
            }

            // циклический сдвиг на К элементов влево(вправо)
            int temp = 0;
            for (i=0; i<size-1; i++)
            {
                a[i] = a[i + 1];
                a[size - 1] = temp;
            }
        }
    }
}
