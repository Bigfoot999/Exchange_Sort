using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exchange_Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int len = 1000;  //kích thước 1 mảng của mẫu thử
            int round = 1000;  //số lần chạy để lấy thời gian chạy trung bình
            Random random = new Random();
            Timing timing = new Timing();
            Ex_Sort ex_Sort = new Ex_Sort();
            int[] arr_random = new int[len];  //Tạo mảng các phần tử random tử 0 đến 100
            int[] arr_increase = new int[len];
            int[] arr_decrease = new int[len];
            int temp;
            Console.WriteLine("========================================== Running, plese wait .... ==========================================");
            double timeRunRandom = 0;
            double timeRunIncrease = 0;
            double timeRunDecrease = 0;
            double timecomplexityRunRandom = 0;   //Time complexity (độ phức tạp thời gian) của mảng random
            double timecomplexityRunIncrease = 0; //Time complexity (độ phức tạp thời gian) của mảng tăng dần
            double timecomplexityRunDecrease = 0; //Time complexity (độ phức tạp thời gian) của mảng giảm dần

            for (int i = 0; i < round; i++)   //Chạy 1000 lần để lấy thời gian chạy trung bình
            {
                for (int j = 0; j < len; j++)
                {
                    temp = random.Next(0, 100);
                    arr_random[j] = temp;
                    arr_increase[j] = temp;
                    arr_decrease[j] = temp;
                }
                Array.Sort(arr_increase); //Tạo mảng tăng dần
                Array.Reverse(arr_decrease); //Tạo mảng giảm dần

                // Random
                timing.startTime();
                timecomplexityRunRandom += ex_Sort.ExSort(arr_random);
                timing.StopTime();
                timeRunRandom += timing.Result().TotalMilliseconds;
                // Increase
                timing.startTime();
                timecomplexityRunIncrease += ex_Sort.ExSort(arr_increase);
                timing.StopTime();
                timeRunIncrease += timing.Result().TotalMilliseconds;
                // Decrease
                timing.startTime();
                timecomplexityRunDecrease += ex_Sort.ExSort(arr_decrease);
                timing.StopTime();
                timeRunDecrease += timing.Result().TotalMilliseconds;
            }
            Console.WriteLine("========================================== Result ==========================================");
            Console.WriteLine("Thời gian chạy trung bình của thuật toán Exchange sort cho Array random (Worst case) là: " + timeRunRandom / round + " ms");
            Console.WriteLine("Thời gian chạy trung bình của thuật toán Exchange sort cho Array increased (Best case) là: " + timeRunIncrease / round + " ms");
            Console.WriteLine("Thời gian chạy trung bình của thuật toán Exchange sort cho Array decreased (Average case) là: " + timeRunDecrease / round + " ms");
            Console.WriteLine("Độ phức tạp thời gian của mảng random là: " + timecomplexityRunRandom / round);
            Console.WriteLine("Độ phức tạp thời gian của mảng tăng dần là: " + timecomplexityRunIncrease / round);
            Console.WriteLine("Độ phức tạp thời gian của mảng giảm dần là: " + timecomplexityRunDecrease / round);



        }
    }
}
