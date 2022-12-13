

namespace InstallmentRecordsApp;

public partial class Store
{
    public void AppStart()
    {
        try
        {
            Console.WriteLine("Welcome to Chy's Store!\nWe have the following items...\n");
            Console.WriteLine(" 1. HP Laptop (#120,000)\n 2. iPhone  (#300,000)\n 3. Tablet  (#250,000)\n 4. SmartWatch  (#20,000)\n 5. None of these items\n ");

            Console.WriteLine("Enter the item number to choose an item to buy: ");
            _itemNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the quantity: ");
            _quantity = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Enter your name: ");
            buyerName = Console.ReadLine();
            if (buyerName == string.Empty)
            {
                throw new UnacceptedInputException("Name is Empty, please enter your name.\n");
            }

            Console.WriteLine("Noted!\n");

            switch (_itemNumber)
            {
                case 1:

                    _priceOfProduct = 120000;
                    _totalAmount = _priceOfProduct * _quantity;
                    Console.WriteLine($"Price of Product : #{_priceOfProduct}\nQuantity : {_quantity}\nTotal Amount : #{_totalAmount}\n");
                    Console.WriteLine(" Choose an installment Plan of your Choice.\n Our installment plans are: ");

                    installmentPlans();
                    break;

                case 2:

                    _priceOfProduct = 300000;
                    _totalAmount = _priceOfProduct * _quantity;
                    Console.WriteLine($"Price of Product : #{_priceOfProduct}\nQuantity : {_quantity}\nTotal Amount : #{_totalAmount}\n");
                    Console.WriteLine(" Choose an installment Plan of your Choice.\n Our installment plans are: ");

                    installmentPlans();
                    break;

                case 3:
                    _priceOfProduct = 250000;
                    _totalAmount = _priceOfProduct * _quantity;
                    Console.WriteLine($"Price of Product : #{_priceOfProduct}\nQuantity : {_quantity}\nTotal Amount : #{_totalAmount}\n");
                    Console.WriteLine(" Choose an installment Plan of your Choice.\n Our installment plans are: ");

                    installmentPlans();
                    break;

                case 4:
                    _priceOfProduct = 20000;
                    _totalAmount = _priceOfProduct * _quantity;
                    Console.WriteLine($"Price of Product : #{_priceOfProduct}\nQuantity : {_quantity}\nTotal Amount : #{_totalAmount}\n");
                    Console.WriteLine(" Choose an installment Plan of your Choice.\n Our installment plans are: ");

                    installmentPlans();
                    break;

                case 5:
                    Console.WriteLine("Sorry, the item you want is not in our store. See you next time!");
                    break;

                default:
                    Console.WriteLine("Please, Enter the correct Item Number!");
                    break;
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            AppStart();
        }
    }
}
