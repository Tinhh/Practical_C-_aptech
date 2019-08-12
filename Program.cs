using System;
using System.Collections.Generic;

namespace ConsoleApplication3
{
    internal class Program
    {
        int productID;
        string productname;
        string price;  
        /*public Program(int productId, string productname, string price)
        {
            this.productID = productId;
            this.productname = productname;
            this.price = price;
        }*/

        public int ProductId
        {
            get => productID;
            set => productID = value;
        }

        public string Productname
        {
            get => productname;
            set => productname = value;
        }

        public string Price
        {
            get => price;
            set => price = value;
        }
  
        public static void Main(string[] args)
        {
            Program prg = new Program();
             prg.showmenu();
        }

        public void showmenu()
        {
            Console.WriteLine("1. Them vao 1 san pham");
            Console.WriteLine("2. Hien thi danh sach san pham");
            Console.WriteLine("3. Xoa san pham");
            Console.WriteLine("4. Exit");
            int menu = Convert.ToInt16(Console.ReadLine());
            
            switch (menu)
            {
                case 1: addproduct();
                    showmenu();
                        break;
                case 2: displayproduct();
                    showmenu();
                    break;
                case 3: deleteproduct();
                    showmenu();
                    break;
                case 4:
                    break;
            }
        }

        public void addproduct()
        {
            Console.WriteLine("Nhap vao ID san pham");
            productID = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap vao ten san pham");
            productname = Console.ReadLine();
            Console.WriteLine("Gia thanh san pham");
            Price = Console.ReadLine();
        }

        public void displayproduct()
        {
            Console.WriteLine("ID: " + productID);
            Console.WriteLine("Name: " + productname);
            Console.WriteLine("Price: " + Price);
        }
        public void deleteproduct()
        {
            Console.WriteLine("Nhap vao id san pham can xoa");
            int x = Convert.ToInt32(Console.ReadLine());
            
        }
    }
}