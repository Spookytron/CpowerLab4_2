using System;

namespace Lab4_2_MenuItem
{
    class MenuItem
    {
        private int ID;
        private string Name;
        private string Description;
        private decimal Price;



        public MenuItem(int _ID, string _Name, string _Description, decimal _Price)
        {
            ID = _ID;
            Name = _Name;
            Description = _Description;
            Price = _Price;
        }
        public void Print()
        {
            Console.WriteLine("\nMenuItem Info");
            Console.WriteLine($"ID : {ID}");
            Console.WriteLine($"Name : {Name}");
            Console.WriteLine($"Description: {Description}");
            Console.WriteLine($"Price : {Price}");
        }
        public void setID(int _ID)
        {
            ID = _ID;
        }
        public void setName(string _Name)
        {
            if (_Name == " ")
            {
                Name = "EMPTY";
            }
            else
            {
                Name = _Name;
            }
        }
        public void setDesc(string _Description)
        {
            if (_Description == " ")
            {
                Description = "EMPTY";
            }
            else
            {
                Description = _Description;
            }
        }
        public void setPrice(decimal _Price)
        {
            if (_Price >= 0.50m && _Price <= 10.00m)
            {
                Price = _Price;
            }
            else if (_Price < 0.50m)
            {
                Price = 0.50m;
            }
            else
            {
                Price = 10.0m;
            }
        }
        public decimal getPrice()
        {
            return Price;
        }
        public string getDescrip()
        {
            return Description;
        }
        public string getName()
        {
            return Name;
        }
        public int getID()
        {
            return ID;
        }
        public void MenuConstruct(int _ID, string _Name, string _Description, decimal _Price)
        {
            ID = _ID;
            Name = _Name;
            Description = _Description;
            Price = _Price;
        }
        public void EmptyConstruct(int _ID, string _Name, decimal _Price)
        {
            ID = _ID;
            Name = _Name;
            Description = "EMPTY";
            Price = _Price;
        }
        public override string ToString()
        {
            return $"\nMenuItem Info\nID:{ID}\nName:{Name}\nDescription:{Description}\nPrice:{Price}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MenuItem Spicy = new MenuItem(17, "Potato", "One Potato", 0.49m);
            Spicy.setPrice(20.0m);
            Spicy.Print();
            Spicy.MenuConstruct(30, "Wild", "Robot", 10.0m);
            string potato = Spicy.ToString();
            Console.WriteLine(potato);
        }
    }
}
