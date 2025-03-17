using System;
class Ex_Sort
{
    public double countloop1 { get; set; }  //so lan lap vòng 1   
    public double countloop2 { get; set; }  //so lan lap vòng 2
    public double countloop3 { get; set; }  //so lan lap cua các phần tử có giá trị giống nhau
    public double Timecomplexity { get; set; }    // tong so lan lap
    public Ex_Sort()
    {
        countloop1 = 0;
        countloop2 = 0;
        countloop3 = 0;
        Timecomplexity = 0;
    }
    public double ExSort(int[] arr)
    {

        int n = arr.Length;
        int temp;

        for (int i = 0; i < n -1; i++)
        {
            countloop1++;
            for (int j = i + 1; j < n; j++)
            {
                if (arr[i] == arr[j])
                {
                    countloop3++;
                }
                else if (arr[i] > arr[j])
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


