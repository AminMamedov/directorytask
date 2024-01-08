using producttask.Models;

bool isContinue = true;
while (isContinue)
{
    Console.WriteLine(" 1 - Add Product \n" +
                      " 2 - Show All Products \n"+
                      " 3 - Close" 
                      
                  );
    Console.WriteLine("Enter option number:");
    int option = Convert.ToInt32(Console.ReadLine());
    switch (option)
    {
        case (int)Menu.AddProduct:
            {
                Product product = new Product();
                Type type = product.GetType();
                Console.WriteLine("Enter product id:");
                int id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter prodcut name:");
                string name = Console.ReadLine();
                Console.WriteLine("Enter product price:");
                int price = Convert.ToInt32(Console.ReadLine());
                product.AddProduct(id, name, price);
                StreamWriter sw = new StreamWriter(@".\Test\test.txt", true);
                sw.WriteLine($" Produc name :{product.Name} ; Product Price :{product.Price}");
                sw.Flush();
                sw.Close();


            }
            break;
        case (int)Menu.ShowAllProducts:
            {
                StreamReader streamReader = new StreamReader(@".\Test\test.txt");
                while (!streamReader.EndOfStream)
                {
                    Console.WriteLine(streamReader.ReadLine());
                }
                streamReader.Close();



            }
            break;
        default:
            isContinue = false;
            
            break;
            
    }
}
if (!File.Exists(@".\Test\test.txt"))
{

    File.Create(@".\Test\test.txt");
}

