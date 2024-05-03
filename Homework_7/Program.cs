namespace Homework_7
{
    class Program
    {
        static int[] productsPrice = new int[0];
        static string[] productsList = new string[0];

        static void DisplayMenu()
        {
            Console.WriteLine("1. Add product \n2. Delete product \n3. Clear \n4. Exit");
        }
        enum ListOfItems{
            Food = 1,
            Book = 2,
            Cloth = 3,
            Electronic = 4,
            Toy = 5,
        }
        static void DeleteProductMenu()
        {
            Console.Clear();
            if (productsList.Length == 0)
            {
                Console.WriteLine("No products to delete.");
                return;
            }
            Console.WriteLine(string.Join(" | ", productsList));
            Console.Write($"Enter the product number to delete (1 to {productsList.Length}): ");

            if (int.TryParse(Console.ReadLine(), out int choice))
            {
                if (choice > 0 && choice <= productsList.Length)
                {
                    int indexToDelete = choice - 1; 
                    
                    string[] newList = new string[productsList.Length - 1];
                    int[] newPriceList = new int[productsPrice.Length - 1];
                    int j = 0;

                    for (int i = 0; i < productsList.Length; i++)
                    {
                        if (i != indexToDelete)
                        {
                            newList[j] = productsList[i];
                            newPriceList[j] = productsPrice[i];
                            j++;
                        }
                    }
                    productsList = newList;
                    productsPrice = newPriceList;
                    Console.Clear();
                    Console.WriteLine("Product deleted successfully.");
                    Console.WriteLine($"{string.Join(" | ", productsList)} " +
                                      $"\nTotal price: {productsPrice.Sum()} UAH\n");
                }
                else
                {
                    Console.WriteLine("Invalid product number.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input.");
            }
        } 
        static void AddProductMenu(){
            Console.Clear();
            Console.WriteLine("1. Food \n2. Book \n3. Cloth \n4. Electronic \n5. Toy");
            int price = 0;
            string product = "";
            Console.Write("Enter your product: ");
            if(int.TryParse(Console.ReadLine(), out int choice)){
                switch(choice){
                    case 1:
                        product = ListOfItems.Food.ToString();
                        Console.Write("Enter your price: ");
                        if(int.TryParse(Console.ReadLine(), out price))
                            break;
                        else
                            Console.WriteLine("Invalid number!");
                        return;
                    case 2:
                        product = ListOfItems.Book.ToString();
                        Console.Write("Enter your price: ");
                        if (int.TryParse(Console.ReadLine(), out price))
                            break;
                        else
                            Console.WriteLine("Invalid number!");
                        return;
                    case 3:
                        product = ListOfItems.Cloth.ToString();
                        Console.Write("Enter your price: ");
                        if(int.TryParse(Console.ReadLine(), out price))
                            break;
                        else
                            Console.WriteLine("Invalid number!");
                        return;
                    case 4:
                        product = ListOfItems.Electronic.ToString();
                        Console.Write("Enter your price: ");
                        if(int.TryParse(Console.ReadLine(), out price))
                            break;
                        else
                            Console.WriteLine("Invalid number!");
                        return;
                    case 5:
                        product = ListOfItems.Toy.ToString();
                        Console.Write("Enter your price: ");
                        if(int.TryParse(Console.ReadLine(), out price))
                            break;
                        else
                            Console.WriteLine("Invalid number!");
                        return;
                    default:
                        Console.WriteLine("Invalid input!");
                        return;
                }
                Array.Resize(ref productsList, productsList.Length + 1);
                productsList[productsList.Length - 1] = product;
                Array.Resize(ref productsPrice, productsPrice.Length + 1);
                productsPrice[productsPrice.Length - 1] = price;
                Console.Clear();
                Console.WriteLine($"Product added: {productsList[productsList.Length - 1]}({price} UAH) " +
                                  $"\nTotal price: {productsPrice.Sum()} UAH\n");
            }
            else
                Console.WriteLine("Invalid choice!");
        }

        static void Main(string[] args){
            while(true){
                DisplayMenu();
                Console.Write("Enter your index: ");
                if (int.TryParse(Console.ReadLine(), out int choice))
                {
                    switch (choice)
                    {
                        case 1:
                            AddProductMenu();
                            break;
                        case 2:
                            DeleteProductMenu();
                            break;
                        case 3:
                            Console.Clear();
                            break;
                        case 4:
                            return;
                        default:
                            Console.WriteLine("Invalid input!");
                            break;
                    }
                }
            }
        }
    }
}