namespace AT_211_v23_lab3
{

    internal class Program
    {
        private static Random random = new Random();

        public static int RandomRange(int minValue, int maxValue)
        {
            return random.Next(minValue, maxValue + 1);
        }

        public static void slide()
        {
            for (int i = 0; i < 30; i++) { Console.Write("="); }
            Console.WriteLine();
        }


        public static void RandomFill_2d_array(int[,] arr, int row, int col, int min_value, int max_value)
        {

            for (int i = 0; i < row; i++)
            {

                for (int j = 0; j < col; j++)
                {
                    arr[i, j] = RandomRange(min_value, max_value);
                }
            }
        }

        public static void print_2d_array(int[,] arr, int row, int col)
        {
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.Write(arr[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

        public static void print_2d_array_row(int[,] arr, int row_index, int col)
        {
            for (int j = 0; j < col; j++)
            {
                Console.Write(arr[row_index, j] + "\t");
            }
            Console.WriteLine();
        }

        public static int sum_in_array_row(int[,] arr, int row_index, int col)
        {
            int tmp_sum = 0;
            for (int j = 0; j < col; j++)
            {
                tmp_sum += arr[row_index, j];
            }
            return tmp_sum;
        }

        private static void Task1()
        {
            int count_worker = 20;
            int count_month = 12;
            int[,] worker_arr = new int[count_worker, count_month];

            RandomFill_2d_array(worker_arr, count_worker, count_month, 1, 1000);

            print_2d_array(worker_arr, count_worker, count_month);
            Console.Write("\nEnter number of worker to print >> ");
            int row_index = Convert.ToInt32(Console.ReadLine()) - 1;
            print_2d_array_row(worker_arr, row_index, count_month);
            Console.WriteLine($"Total in year = {sum_in_array_row(worker_arr, row_index, count_month)}$");
        }

        private static void Matrix_v1(int[,] arr, int row, int col, int n)
        {
            Console.WriteLine("\n\nMatrix V1 ::");
            slide();
            for (int i = 0; i < row; i++)
            {
                int counter = 1;
                for (int j = 0; j < col; j++)
                {
                    if (i % 2 == 0)
                    {
                        arr[i, j] = counter++;
                    }
                    else
                    {
                        arr[i, j] = n - j;
                    }
                }
            }
            print_2d_array(arr, row, col);
        }

        private static void Matrix_v2(int[,] arr, int row, int col, int n)
        {
            Console.WriteLine("\n\nMatrix V2 ::");
            slide();
            int index = n - 1;
            int counter = 1;
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    if (j == index)
                    {
                        arr[i, index--] = counter++;
                    }
                }
            }
            print_2d_array(arr, row, col);
        }

        private static void Matrix_v3(int[,] arr, int row, int col, int n)
        {
            Console.WriteLine("\n\nMatrix V3 ::");
            slide();
            int index = 0;
            int counter = 0;
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    if (j == index)
                    {
                        arr[i, index] = n - counter++;
                    }
                }
                index++;
            }
            print_2d_array(arr, row, col);
        }

        private static void Matrix_v4(int[,] arr, int row, int col, int n)
        {
            Console.WriteLine("\n\nMatrix V4 ::");
            slide();
            int index = 0;
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {

                    if (j == index)
                    {
                        arr[i, index] = (i + 1) * (i + 2);
                    }
                }
                index++;
            }
            print_2d_array(arr, row, col);
        }

        private static void Matrix_v5(int[,] arr, int row, int col, int n)
        {
            Console.WriteLine("\n\nMatrix V5 ::");
            slide();
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                        arr[i, j] = 1;
                }
            }
            for (int i = 1; i < row-1; i++)
            {
                for (int j = 1; j < col-1; j++)
                {
                    arr[i, j] = 0;
                }
            }
            print_2d_array(arr, row, col);
        }

        private static void Matrix_v6(int[,] arr, int row, int col, int n)
        {
            Console.WriteLine("\n\nMatrix V6 ::");
            slide();
            int counter = 0;
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col-counter; j++)
                {
                    arr[i, j] = i+1;
                }
                counter++;
            }
            print_2d_array(arr, row, col);
        }

        private static void Matrix_v7(int[,] arr, int row, int col, int n)
        {
            Console.WriteLine("\n\nMatrix V7 ::");
            slide();
            int start = 0;
            int end=col;
            for (int i = 0; i < (row/2); i++)
            {
                for (int j = start; j < end; j++)
                {
                    arr[i, j] = 1;
                }
                start++;
                end--;
            }
            for (int i = (row / 2)-1; i < row; i++)
            {
                for (int j = start; j < end; j++)
                {
                    arr[i, j] = 1;
                }
                start--;
                end++;
            }
            print_2d_array(arr, row, col);
        }

        private static void Matrix_v8(int[,] arr, int row, int col, int n)
        {
            Console.WriteLine("\n\nMatrix V8 ::");
            slide();
            int start = 1;
            int end = col-1;
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    arr[i, j] = 1;
                }
            }
            for (int i = 0; i < (row / 2); i++)
            {
                for (int j = start; j < end; j++)
                {
                    arr[i, j] = 0;
                }
                start++;
                end--;
            }
            for (int i = (row / 2) - 1; i < row; i++)
            {
                for (int j = start; j < end; j++)
                {
                    arr[i, j] = 0;
                }
                start--;
                end++;
            }
            print_2d_array(arr, row, col);
        }
        private static void Task2()
        {
            while (true)
            {
                Console.WriteLine("Enter size N, must be pair >>");
                int N = Convert.ToInt32(Console.ReadLine());
                if (N % 2 == 0)
                {
                    int[,] arr = new int[N, N];
                    Matrix_v1(arr, N, N, N);
                    Matrix_v2(arr, N, N, N);
                    Matrix_v3(arr, N, N, N);
                    Matrix_v4(arr, N, N, N);
                    Matrix_v5(arr, N, N, N);
                    Matrix_v6(arr, N, N, N);
                    Matrix_v7(arr, N, N, N);
                    Matrix_v8(arr, N, N, N);
                    break;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Data error,Enter pair N !!!");
                    Console.ResetColor();
                }
            }
        }

        private static void Task3()
        {

            const int student_count = 20;
            const int lesons_count = 10;

            int[,] marks_array = new int[student_count, lesons_count];

            const int min_mark = 1;
            const int max_mark = 12;

            RandomFill_2d_array(marks_array, student_count, lesons_count, min_mark, max_mark);
            print_2d_array(marks_array, student_count, lesons_count);

            int count_marks = 0;
            int tmp_sum = 0;

            for (int i = 0; i < student_count; i++)
            {
                sum_in_array_row(marks_array, i, lesons_count);
                for (int j = 0; j < lesons_count; j++)
                {
                    tmp_sum += marks_array[i, j];
                    count_marks++;
                }
            }
            int average = tmp_sum / count_marks;
            Console.WriteLine($"Total marks >> {tmp_sum} || total count of marks >> {count_marks}");
            Console.WriteLine($"\nAverage mark in class is >> " + average);

        }


        private static void Task4()
        {
            const int row = 2;
            const int col = 10;
            int[,] xy_array = new int[row, col];

            RandomFill_2d_array(xy_array, row, col, 1, 10);//row 0 = x;  row 1 = y;
            Console.WriteLine("X:\nY:\n");
            print_2d_array(xy_array, row, col);

            int max_result = 0;
            int max_result_pair_index = 0;

            for (int i = 0; i < col; i++)
            {
                int tmp = Convert.ToInt32(Math.Pow(xy_array[0, i], 2)) - (3 * xy_array[1, i]);
                if (max_result < tmp)
                {
                    max_result = tmp;
                    max_result_pair_index = i;
                }
            }
            Console.WriteLine($"Max result will be {max_result} in pair index = {max_result_pair_index}");
        }

        static void Main(string[] args)
        {
            Task1();
            Task2();
            Task3();
            Task4();
        }
    }
}
