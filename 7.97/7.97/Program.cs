using System;
public class MainClass
{
  public static void Main()
  {
        int massivLength;
        int sum1=0;
        int sum2=0;
        Console.WriteLine("Задайте длинну масива:");
        massivLength=int.Parse(Console.ReadLine());
        int[] nums = new int[massivLength];
        var random=new Random();
        for(int i=0; i<nums.Length; i++)
        {
            nums[i] = random.Next(0,100);
            if(nums[i]<21)
            {
                sum1 += nums[i];
            }
            if(nums[i]<10)
            {
                sum2 += nums[i];
            }
        }
        Console.WriteLine("а) верно ли, что сумма тех чисел  которые меньше 20,5, не превышает 50");
        if (sum1<=50)
        {
            Console.WriteLine("Сумма не превышает 50");
        }
        else
        {
            Console.WriteLine("Сумма превышает 50");
        }
        Console.WriteLine("б) верно ли, что сумма тех чисел которые не превышают 10, кратна трем?");
        if(sum2%3==0)
        {
            Console.WriteLine("Cумма чисел кратна трём");
        }
        else
        {
            Console.WriteLine("Cумма чисел не кратна трём");
        }






  }
}
