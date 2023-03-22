using System;

namespace RefReturn
{
    class Product // 겟더셋 방식
    {
        private int price = 100;

        public ref int GetPrice()
        {
            return ref price;
        }
        public void PrintPrice()
        {
            Console.WriteLine($"Price : {price}");
        }
    }
  
    class MainApp
    {
        static void Main(string[] args)
        {
            Product carrot = new Product(); // 변수 안에 Product가 객체화
            ref int ref_local_price = ref carrot.GetPrice();
            int normal_local_price = carrot.GetPrice();

            carrot.PrintPrice();
            Console.WriteLine($"Ref Local Price : {ref_local_price}");
            Console.WriteLine($"Normal Local Price : {normal_local_price}");

            ref_local_price = 200;

            carrot.PrintPrice();
            Console.WriteLine($"Ref Local Price : {ref_local_price}");
            Console.WriteLine($"Normal Local Price : {normal_local_price}");
        }
    }
}
