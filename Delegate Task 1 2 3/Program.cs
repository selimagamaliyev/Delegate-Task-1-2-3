using System;
using static Delegate_Task_1_2_3.Program.Person;

namespace Delegate_Task_1_2_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task-1
            //OperetionDelegate opdel = new OperetionDelegate(Add);
            //opdel+= Subtract;
            //opdel+= Multiply;
            //opdel+=Divide;  
            //opdel+=ApplyOperation;

            //opdel(1.3f, 1.2f);

            ////////////////////////////////////////////////////////

            //Task-2
            //Cat cat = new Cat();
            //cat.Play = "---1";
            //Console.WriteLine(cat.Play);
            //cat.Feed = "---2";
            //Console.WriteLine(cat.Feed);
            //cat.Sleep = "---3";
            //Console.WriteLine(cat.Sleep);

            ////////////////////////////////////////////////////////

            //Task-3

            Persondelegeta persondelegeta = new Persondelegeta(FirstName);
            persondelegeta += LastName;
            persondelegeta("Selim", "Agamaliyev");



            //List<string> list = new List<string>(); 
            //list.Add("Selim");
            //list.Add("Agamaliyev");



        }

        #region Task-1

        //Public delegate yaradin adi OperationDelegate olsun hansi ki float tipinde
        //iki deyer qebul edecek ve geriye float deyer qaytarir.
        //4 eded static public metod yaradin.
        //Adlari Add, Subtract, Multiply, Divide.
        //Her biri iki float deyer qebul edecek ve geriye float deyer qaytaracag.
        //Apply operation metodu yaradin hansi ki float tipinde iki deyer qebul edir ve bir delegate qebul edir.
        //Yuxarida sadalanan metodlari o deyerler uzerinde tetbig edir.

        // public delegate void OperetionDelegate(float a, float b);

        // public static void Add(float a, float b)
        // {
        //     Console.WriteLine(a+b);
        // }


        //public static void Subtract(float a, float b)
        // {
        //     Console.WriteLine(a-b);
        // }

        // public static void Multiply(float a, float b)
        // {
        //     Console.WriteLine(a*b);
        // }

        // public static void Divide(float a, float b)
        // {
        //     Console.WriteLine(a/b);
        // }
        // public static void ApplyOperation(float a, float b)
        // {
        //     Console.WriteLine((a+b)-b*a/b);
        // }
        #endregion

        #region Task-2
        //Task 2.
        //2.Cat classiniz olsun.
        //Ichinde onun mood,hungry,energy deye fieldleriniz olsun.
        //Lakin bu fieldlerinkenardan modifybetmek mumkun olmur.
        //Sadece Play(), Feed(),Sleep() metodlari vasitesile o fieldleri deyiwmek olsun.
        //Hansi metodlar hansi fieldler nece deyiwecek onu siz fikirleshin zehmet olmasa.

        //class Cat
        //{
        //    private string mood = "1";
        //    public string Play
        //    {
        //        get
        //        {
        //            return mood;
        //        }
        //        set
        //        {
        //            mood = value;
        //        }
        //    }


        //    private string hungry = "2";
        //    public string Feed
        //    {
        //        get
        //        {
        //            return mood;
        //        }
        //        set
        //        {
        //            mood = value;
        //        }
        //    }


        //    private string energy = "3";
        //    public string Sleep
        //    {
        //        get
        //        {
        //            return mood;
        //        }
        //        set
        //        {
        //            mood = value;
        //        }
        //    }
        #endregion

        #region Task-3
        //Person classiiniz olsun.Icinde firstname ve lastname fieldleri
        //ve her birinci ayriligda console yazan iki metod.
        //Surname ucun ayri metod ve firstname ucun ayri.
        //Bu metodlara uygun delegate olsun.
        //Main metodunda classin bir debe obyektin yaradin.
        //Ve delegate uzerinden obeyktin  bu iki metodunu iwe salin.



        public class Person

        {

            public string FirstName;
            public string LastName;

            public void FirstName1(string a)
            {
                System.Console.WriteLine(a);
            }
            public void LastName1(string b)
            {
                System.Console.WriteLine(b);
            }
            public delegate string Persondelegeta(string a, string b);
        }


        #endregion

        #region Task-4
        // 4.Mobil telefon mentigi uzerinden  abstraction,encapsulation,polymorpishm
        // ve lnheritance conceptkerini tetbig edib yazmaga caliwin.
        // yeni Mobile classiniz olacag ve
        // ona uygun ferqli markalar olacag(samsung, nokia ve s)
        #endregion
        #region Task-5
        //5.User classi yaradin.Icinde ad soyad propertyleri olsun.
        //Daha sonra diger bir metod yaradin
        //hansi ki User List qebul edir ve icindeki userleri bir bir Console-a cixarir.
        //Main metodunda User list yaradib ora userler elave edin
        //ve yazdiginiz metodu orda cagirib icerisine yaratdiginiz bu listi gonderin.


        //public class User
        //{
        //    List<string> list = new List<string>();
        //    list.Add("Selim");
        //    list.Add("Agamaliyev");
        //    public string ad { get; set; }
        //    public string soyad { get; set; }



        //    public void metod()
        //    {

        //    }
        //}
    }
}
