namespace lec4_task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("this program to enter array like {1,1,1,2} and get occarance is : 3 \n ");
            int[] arr = new int[5] ;
            int occurence = 0;
            //int n = 0;
            Console.WriteLine(" array size is 5 element , enter elements  of array ");
           // n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"enter element {i+1} of array :  ");
                arr[i]= Convert.ToInt32(Console.ReadLine());
            }


            Console.Write(" your array is : { ");
            for (int i = 0; i < 5; i++)
            {
                Console.Write($" {arr[i]} ");
            }
            Console.WriteLine("}");

            Console.WriteLine("\n enter number to check how many repeate \n ");
            occurence = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"the answer of occurence is :  {GetOccuernce(arr, occurence)}");

            
        }

        static int GetOccuernce(int[]Arr,int x) {
            int temp=0;
            for(int i = 0; i < Arr.Length; i++)
            {
                if (Arr[i] == x)
                {
                    temp++;
                }
            }
            return temp;
          
        }
    }
}
