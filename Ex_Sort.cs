using System;
class Ex_Sort
{
    public double ExSort(int[] arr)
    {
        double countloop1 = 0;  //so lan lap vòng 1
        double countloop2 = 0;  //so lan lap vòng 2
        double Timecomplexity;   // tong so lan lap
        int n = arr.Length;
        int temp;
        
        for (int i = 0; i < arr.Length; i++)
        {
            countloop1++;
            for (int j = i + 1; j < arr.Length; j++)
            {
                if (arr[i] > arr[j])
                {
                    temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                    countloop2++;
                }
            }
        }
        if (countloop2 == 0)
        {
            Timecomplexity = countloop1;
        }
        else
        {
            Timecomplexity = (countloop1 * countloop2);
        }
        return Timecomplexity;

    }
}

