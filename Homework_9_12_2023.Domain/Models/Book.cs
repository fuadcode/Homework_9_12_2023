


namespace Homework_9_12_2023.Domain.Models
{
    public class Book : Product
    {
        public Book(string name, int price, int count) : base(name, price, count)
        {
            
        }
        public string AuthorName { get; set; }
        public int PageCount { get; set; }
        public override void Sell(int ProductCount)
        {
            if (Count > ProductCount)
            {
                Count -= ProductCount;
                TotalInCome += ProductCount * Price;
                Console.WriteLine($"{TotalInCome}");
            }
            else
            {
                Console.WriteLine("Mehsulun sayi istenilen mehsuldan azdir..");
            }
        }
        public override void ShowInfo()
        {
            Console.WriteLine($"{Name}, {Price}, {Count}, {TotalInCome}");
        }
    }
}
