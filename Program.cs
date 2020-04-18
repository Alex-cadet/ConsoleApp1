using System;

namespace ConsoleApp1{    
    class EvNumS
    {
     static void Main() {

   int Sum=0;
   Random rnd = new Random();
    int[] Arr = new int[10];
    Console.Write("Массив из чисел: [ "); 
    for(int i=0; i<Arr.Length; i++)
     {
    Arr[i]=rnd.Next(30);
    Console.Write(Arr[i]+" ");
         if(Arr[i]%2==0)
         Sum=Sum+Arr[i];       
      }
    Console.Write("]");  
      Console.WriteLine();
Console.WriteLine("Сумма чётных чисел массива равна {0}",Sum);
      }
  }
}
