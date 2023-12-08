

namespace Homework_9_12_2023.Domain.Models
{
    public abstract class Product
    {
       private static int _NextId;
       public int Id { get; set; }  
       public string Name { get; set; }
       public int Price { get; set; }   
       public int Count { get; set; }
       
       public int TotalInCome = 0;


        public abstract void Sell(int ProductCount);
        public abstract void ShowInfo();

        public Product(string name, int price, int count)
        {
            Id=_NextId++;
            Name = name; 
            Price= price;
            Count = count;   
        }
    }
    
}
