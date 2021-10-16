using System;
using System.Collections;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Homework
            //Advertisement ad1 = new Advertisement("Iphone",1000);
            //Advertisement ad2 = new Advertisement("BMW",21000);
            //Advertisement ad3 = new Advertisement("Yasamalda ev",100000);

            //ad1.Category = AdCategory.Phone;

            //Advertisement[] ads = new Advertisement[3];
            //ads[0] = ad2;
            //ads[1] = ad3;
            //ads[2] = ad1;

            //foreach (Advertisement item in ads)
            //{
            //    Console.WriteLine(item);
            //}
            //Array.Sort(ads);
            //Console.WriteLine("Sort olundu");
            //foreach (Advertisement item in ads)
            //{
            //    Console.WriteLine(item);
            //}


            //Console.WriteLine(ad1>ad2);

            //Advertiser advertiser = new Advertiser();
            //Advertiser advertiser2 = new Advertiser();

            //advertiser.AddAdvertisement(ad1);
            //advertiser2.AddAdvertisement(ad2);

            //Console.WriteLine();
            #endregion

            #region Indexer
            //string str = "Mamed";
            //Console.WriteLine(str[0]);

            //Book b1 = new Book("C#","Mamed");
            //Book b2 = new Book("Java","Ismayil");
            //Book b3 = new Book("Js","Rufet");

            //Library l1 = new Library("Libraff");

            //l1.AddBook(b1);
            //l1.AddBook(b2);

            //Console.WriteLine(l1[0]);
            #endregion

            #region generic
            //int[] nums = new int[0];

            //Array.Resize(ref nums, nums.Length + 1);
            //nums[nums.Length - 1] = 5;

            //Array.Resize(ref nums, nums.Length + 1);
            //nums[nums.Length - 1] = 10;

            //Console.WriteLine(nums[0]);

            //MyIntCollection nums = new MyIntCollection();

            //nums.AddItem(4);
            //nums.AddItem(12);
            //nums.AddItem(12);

            //Console.WriteLine(nums[0]);


            //MyStringCollection strings = new MyStringCollection();

            //strings.AddItem("Mamed");
            //strings.AddItem("Isa");
            //strings.AddItem("Ulvi");

            //Console.WriteLine(strings[0]);

            //Person p1 = new Person("Mamed", "Aliyev");


            //MyCollection<string> strs = new MyCollection<string>();
            //strs.AddItem("Salam");

            //Console.WriteLine(strs);

            //MyCollection<int> ints = new MyCollection<int>();
            //ints.AddItem(1);

            //Console.WriteLine(ints);

            //MyCollection<Person> persons = new MyCollection<Person>();
            //persons.AddItem(new Person("Mamed", "Aliyev"));

            //Print<int>(5);
            //Print<string>("Salam");

            #endregion

            #region Collections
            //ArrayList al = new ArrayList();
            //Person p1 = new Person("Mamed", "Aliyev");

            //al.Add(p1);
            //al.Add("Salam");
            //al.Add(123);
            //al.Add(412);
            //al.Add(4234);
            //al.Add(new Person("Isa", "Mamedov"));

            ////al.Clear();


            //al.Remove(p1);
            //al.Remove(new Person("Isa", "Mamedov"));
            //al.RemoveAt(0);
            //al.RemoveRange(0, 2);
            //al.Insert(0, "Salam");
            //al.Add(new Person("Isa", "Mamedov"));
            //Console.WriteLine(al.Contains(new Person("Isa", "Mamedov")));

            //foreach (Object item in al)
            //{
            //    Console.WriteLine(item);
            //}

            //List<Person> people = new List<Person>();

            //people.Add(new Person("Mamed","Aliyev"));
            //people.Add(new Person("Rasim","Imanov"));
            //people.Add(new Person("Isa","Musayev"));

            //int len = people.Count;
            //for (int i = 0; i < len; i++)
            //{
            //    people.RemoveAt(0);
            //}

            //Console.WriteLine(people.Count);

            //foreach (Person item in people)
            //{
            //    Console.WriteLine(item);
            //}

            //foreach (Person item in people)
            //{
            //    people.Remove(item);
            //}

            //foreach (Person item in people)
            //{
            //    Console.WriteLine(item);
            //}


            //List<Person> people2 = new List<Person>();
            //people2.Add(new Person("Konul", "Xasiyeva"));
            //people2.AddRange(people);

            //Console.WriteLine(people2[2]);


            //Dictionary<string, int> nameAges = new Dictionary<string, int>();

            //nameAges.Add("Bashir",12); 
            //nameAges.Add("Mamed",21);
            //nameAges.Add("Emrah", 61);

            //foreach (KeyValuePair<string, int> item in nameAges)
            //{
            //    Console.WriteLine(item.Key+" "+item.Value);
            //}

            //nameAges.Remove("Bashir");

            //Console.WriteLine(nameAges["Emrah"]);

            //Queue<string> q1 = new Queue<string>();
            //q1.Enqueue("Mamed");
            //q1.Enqueue("Kamran");
            //q1.Enqueue("Bashir");

            //Console.WriteLine(q1.Dequeue());

            //Console.WriteLine(q1.Peek());

            //Stack<string> sta1 = new Stack<string>();
            //sta1.Push("Mamed");
            //sta1.Push("Kamran");
            //sta1.Push("Isabala");
            //sta1.Push("Bashir");

            //Console.WriteLine(sta1.Pop());
            //Console.WriteLine(sta1.Peek());
            #endregion
        }

        #region generic

        //public static void Print<T>(T item)
        //{
        //    Console.WriteLine(item);
        //}
        #endregion
    }
    #region generic
    class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public Person(string newPersonsName, string newPersonsSurname)
        {
            Name = newPersonsName;
            Surname = newPersonsSurname;
        }
        public override string ToString()
        {
            return $"{Name} {Surname}";
        }

        public override bool Equals(object obj)
        {
            return ((Name == ((Person)obj).Name) && (Surname == ((Person)obj).Surname));
        }
    }

    ////class MyCollection<T, U> where T : class where U : struct
    //class MyCollection<T>
    //{
    //    private T[] items;

    //    public MyCollection()
    //    {
    //        items = new T[0];
    //    }

    //    public T this[int index]
    //    {
    //        get
    //        {
    //            return items[index];
    //        }
    //    }

    //    public void AddItem(T item)
    //    {
    //        Array.Resize(ref items, items.Length + 1);
    //        items[items.Length - 1] = item;
    //    }
    //}

    //class MyIntCollection
    //{
    //    private int[] items;

    //    public MyIntCollection()
    //    {
    //        items = new int[0];
    //    }

    //    public int this[int index]
    //    {
    //        get
    //        {
    //            return items[index];
    //        }
    //    }

    //    public void AddItem(int item)
    //    {
    //        Array.Resize(ref items, items.Length + 1);
    //        items[items.Length - 1] = item;
    //    }
    //}

    //class MyStringCollection
    //{
    //    private string[] items;

    //    public MyStringCollection()
    //    {
    //        items = new string[0];
    //    }

    //    public string this[int index]
    //    {
    //        get
    //        {
    //            return items[index];
    //        }
    //    }

    //    public void AddItem(string item)
    //    {
    //        Array.Resize(ref items, items.Length + 1);
    //        items[items.Length - 1] = item;
    //    }
    //}

    //class MyPersonCollection
    //{
    //    private Person[] items;

    //    public MyPersonCollection()
    //    {
    //        items = new Person[0];
    //    }

    //    public Person this[int index]
    //    {
    //        get
    //        {
    //            return items[index];
    //        }
    //    }

    //    public void AddItem(Person item)
    //    {
    //        Array.Resize(ref items, items.Length + 1);
    //        items[items.Length - 1] = item;
    //    }
    //}
    #endregion

    #region Indexer

    class Book
    {
        public string Name { get; set; }
        public string Author { get; set; }

        public Book(string Name, string Author)
        {
            this.Name = Name;
            this.Author = Author;
        }

        public override string ToString()
        {
            return $"{Name} - {Author}";
        }
    }
    class Library
    {
        public string Name { get; set; }
        private Book[] Books;

        public Library(string Name)
        {
            this.Name = Name;
            Books = new Book[0];
        }

        public Book this[int index] { 
            get 
            {
                return Books[index];
            }
            //set
            //{
            //    Books[index] = value;
            //}
        }

        public void AddBook(Book book)
        {
            Array.Resize(ref Books, Books.Length+1);
            Books[Books.Length - 1] = book;
        }
    }
    #endregion

    #region Homework
    //class Advertiser : User
    //{
    //    public Advertisement[] Advertisements;
    //    //public Advertisement[] Advertisements { get; set; }

    //    public Advertiser()
    //    {
    //        Advertisements = new Advertisement[0];
    //    }

    //    public void AddAdvertisement(Advertisement ad)
    //    {
    //        Array.Resize(ref Advertisements, Advertisements.Length + 1);
    //        Advertisements[Advertisements.Length-1] = ad;
    //    }
    //}
    //class Advertisement : IComparable
    //{
    //    public string Name { get; set; }
    //    public string SellerName { get; set; }
    //    public double Price { get; set; }

    //    public AdCategory Category { get; set; }

    //    public override string ToString()
    //    {
    //        return $"{Name} - {Price}";
    //    }
    //    public Advertisement(string name, double price)
    //    {
    //        Name = name;
    //        Price = price;
    //    }

    //    public int CompareTo(object obj)
    //    {
    //        return Price.CompareTo(((Advertisement)obj).Price);
    //    }

    //    public static bool operator >(Advertisement adv1, Advertisement adv2)
    //    {
    //        return adv1.Price > adv2.Price;
    //    }
    //    public static bool operator <(Advertisement adv1, Advertisement adv2)
    //    {
    //        return adv1.Price < adv2.Price;
    //    }
    //}

    //enum AdCategory
    //{
    //    Car,Home,Phone
    //}

    //abstract class User
    //{
    //    public string Name { get; set; }
    //    public string Surname { get; set; }
    //}



    //static class Extension
    //{
    //    public static double PriceSum(this Advertisement[] ads)
    //    {
    //        double result = 0;

    //        foreach (Advertisement item in ads)
    //        {
    //            result += item.Price;
    //        }

    //        return result;
    //    }
    //}

    #endregion
}
