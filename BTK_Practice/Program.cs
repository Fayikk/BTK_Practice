using BTK_Practice;
using System;

namespace MyApp
{
    class Program
    {



     



        static void Main(string[] args)
        {
            ProductService productService = new ProductService();

            foreach (var item in productService.GetProducts())
            {
                Console.WriteLine(item.Price);
                Console.WriteLine(item.Brand);
                Console.WriteLine(item.CategoryId);
                Console.WriteLine(item.Type);
                Console.WriteLine("-----------------");
            } 






            //Base newBase = new Base();
            //DivideObjects obj = new() { Param1 = 33, Param2 = 9 };

            //newBase.PrintDivideResult(obj);

            //Console.WriteLine();








            //Queue<int> ints = new Queue<int>();

            //ints.Enqueue(1);
            //ints.Enqueue(2);
            //ints.Enqueue(3);
            //ints.Enqueue(4);
            //ints.Enqueue(5);

            //ints.Dequeue();

            //Console.WriteLine(ints.Peek());











            //Stack<int> numbers = new Stack<int>();

            //numbers.Push(1);
            //numbers.Push(2);
            //numbers.Push(3);
            //numbers.Push(4);
            //numbers.Push(5);

            //numbers.Pop();

            //Console.WriteLine(numbers.Peek());









            //int List oluşturlaım ve listenin içerisindeki elemanları tek tek çarpalım
            //List<string> isimler = new List<string>() {"Ahmet","Büşra","Can","Deniz" };

            //Console.WriteLine("İsim Kontrolü");
            //string isim = Console.ReadLine();

            //if (isimler.Select(name => name.ToLower()).ToList().Contains(isim.ToLower()))
            //{
            //    Console.WriteLine("İsim Mevcut");
            //}
            //else
            //{
            //    Console.WriteLine("İsim mevcut değil");
            //}
            //Console.WriteLine("Silinecek İsim");
            //string silinecekIsim = Console.ReadLine();

            //isimler.Remove(silinecekIsim);

            //foreach (var item in isimler.OrderBy(x=>x).ToList())
            //{
            //    Console.WriteLine(item);
            //}















            List<int> values = new List<int>() {1,2,3,4,6,7,8,9 };

            int temp1 = 1;

            foreach (var item in values)
            {
                temp1 = temp1 * item;
            }

            Console.WriteLine(temp1);







            List<string> countries = new List<string>() { "Turkey", "USA", "Brazil" };


            foreach (var item in countries)
            {
                Console.WriteLine(item);
            }







            //



            //Diziyi küçükten büyüğe sıralayın
            int[] satislar = { 100, 200, 150, 175, 300, 250, 400 };

            int n = satislar.Length;

            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (satislar[j] > satislar[j + 1])
                    {
                        int temp = satislar[j];
                        satislar[j] = satislar[j + 1];
                        satislar[j + 1] = temp;
                    }
                }
            }


            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(satislar[i]);
            }






            //int temp = 0;

            //for(int i = 0; i < satislar.Length; i++)
            //{
            //    if (temp < satislar[i])
            //    {
            //        temp = satislar[i];
            //    }
            //}


            //Console.WriteLine(temp);



















            Mathetmatic math = new Mathetmatic();

            int param = 10;
            int param2 = 20;


            int value = math.Topla(param,param2);
            Console.WriteLine(value);
            //math.Topla2(param, param2);




            //int i = 0;

            //while (i < 10)
            //{
            //    ++i;
            //    i++;
            //    i = i + 1;
            //    Console.WriteLine(i);

            //}







            ////int[] arr = new int[99];



            ////arr[0] = 1;
            ////arr[1] = 2;
            ////arr[2] = 3;
            ////arr[3] = 4;
            ////arr[4] = 5;

            //////0,1
            ////int[] sayilar = { 1, 2, 3, 4, 5, 932 };

            //////son eleman ile ilk eleman toplayın

            ////for (int i = 0; i < sayilar.Length; i++)
            ////{
            ////    //Console.WriteLine(sayilar[i]);
            ////    //Console.WriteLine(i);
            ////    if (sayilar[i]%2 == 0)
            ////    {
            ////        Console.WriteLine(sayilar[i]);
            ////    }
            ////}





            ////Console.WriteLine(arr[0] + arr[1]);





            //int deger = Convert.ToInt32(Console.ReadLine()) ;


            ////Console.WriteLine("benim değerim{0}", deger);



            //int number = 10;

            //string btkValue = "Btk Akademi";

            //bool isValidate = true;

            //char character = 'C';

            //int sayac = 5;



            //switch (character)
            //{
            //    case 'A':
            //        Console.WriteLine("A");
            //    break;
            //    case 'B':
            //        Console.WriteLine("B");
            //    break;
            //    case 'C':
            //        Console.WriteLine("C");
            //    break;
            //    default:
            //        break;
            //}




            //if (sayac > 6)
            //{
            //    Console.WriteLine("Rakam 6dan büyüktür");
            //}
            //else if (sayac == 6)
            //{
            //    Console.WriteLine(" Rakam 6ya eşittir");
            //}
            //else if (sayac < 6)
            //{
            //    Console.WriteLine("Else bloğu");
            //}
            //else
            //{
            //    Console.WriteLine("Else bloğu");

            //}















            //Sayı 10
            //sayı belirlyelim sayı eğer 10'a eşitse,10 küçük eşit ise,10 büyük eşit ise










        }
    }
}