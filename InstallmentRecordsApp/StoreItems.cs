
namespace InstallmentRecordsApp
{
    public class StoreItems
    {
        
        
        private string buyerName;
        private double _itemNumber;
        private double _installationPlan;
        private double _priceOfProduct;
        private double _quantity;
        private double _totalAmount;
        private DateTime _date;
        private double _payment;

        public const double percent1 = 0.05;
        public const double percent2 = 0.06;
        public const double percent3 = 0.07;
        public const double percent4 = 0.08;
        public const double percent5 = 0.09;
        public const double percent6 = 0.1;


        public StoreItems()
        {

        }

        public void AppStart()
        {
            try 
            { 
            Console.WriteLine("Welcome to Chy's Store!\n");
            Console.WriteLine("We have the following items...\n");
            Console.WriteLine(" 1. HP Laptop (#120,000)\n 2. iPhone  (#300,000)\n 3. Tablet  (#250,000)\n 4. SmartWatch  (#20,000)\n 5. None of these items\n ");
            Console.WriteLine("Enter the item number to choose an item to buy: ");
            _itemNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the quantity: ");
            _quantity = Convert.ToInt32(Console.ReadLine());
            

            Console.WriteLine("Enter your name: ");
            buyerName = Console.ReadLine();
            if (buyerName == "")
            {
                throw new UnacceptedInputException("Name is Empty, please enter your name.\n");
            }
            
            Console.WriteLine("Noted!\n");

            switch (_itemNumber) 
            {
                case 1:
                    
                    _priceOfProduct = 120000;
                    _totalAmount = _priceOfProduct * _quantity;
                    Console.WriteLine("Price of Product : #{0}\n", _priceOfProduct);
                    Console.WriteLine("Quantity : {0}\n", _quantity);
                    Console.WriteLine("Total Amount : #{0}\n ",_totalAmount);
                    Console.WriteLine(" Choose an installment Plan of your Choice.\n Our installment plans are: ");
                    
                    installmentPlans();
                    break;

                case 2:
                    
                    _priceOfProduct = 300000;
                    _totalAmount = _priceOfProduct * _quantity;
                    Console.WriteLine("Price of Product : #{0}\n", _priceOfProduct);
                    Console.WriteLine("Quantity : {0}\n", _quantity);
                    Console.WriteLine("Total Amount : #{0}\n ", _totalAmount);
                    Console.WriteLine(" Choose an installment Plan of your Choice.\n Our installment plans are: ");

                    installmentPlans();
                    break;

                case 3:
                    _priceOfProduct = 250000;
                    _totalAmount = _priceOfProduct * _quantity;
                    Console.WriteLine("Price of Product : #{0}\n", _priceOfProduct);
                    Console.WriteLine("Quantity : {0}\n", _quantity);
                    Console.WriteLine("Total Amount : #{0}\n ", _totalAmount);
                    Console.WriteLine(" Choose an installment Plan of your Choice.\n Our installment plans are: ");

                    installmentPlans();
                    break;

                case 4:
                    _priceOfProduct = 20000;
                    _totalAmount = _priceOfProduct * _quantity;
                    Console.WriteLine("Price of Product : #{0}\n", _priceOfProduct);
                    Console.WriteLine("Quantity : {0}\n", _quantity);
                    Console.WriteLine("Total Amount : #{0}\n ", _totalAmount);
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

        public void installmentPlans() 
        {
            try
            { 
            Console.WriteLine(" 1. Daily ........... 5% payment.\n " +
                "2. Weekly ........... 6% payment.\n " +
                "3. Bi-Weekly ........... 7% payment.\n " +
                "4. Monthly ........... 8% payment.\n " +
                "5. 6-Months ........... 9% payment.\n " +
                "6. One-Year ........... 10% payment.\n");
            _installationPlan = Convert.ToInt32(Console.ReadLine());

            switch (_installationPlan)
            {
                case 1:
                    Console.Clear();
                    daily();

                    break;
                case 2:
                    Console.Clear();
                    weekly();
                    break;
                case 3:
                    Console.Clear();
                    biWeekly();
                    break;
                case 4:
                    Console.Clear();
                    monthly();
                    break;
                case 5:
                    Console.Clear();
                    sixMonths();
                    break;
                default:
                    Console.Clear();
                    yearly();
                    break;
            }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                installmentPlans();
            }
        }

        public void daily() 
        {
            try 
            { 
            
            Console.WriteLine("You choosed Daily installment plan!\n");
            Console.WriteLine("Press any key to continue...");
             
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("You are expected to pay 5% of {0} daily.\n", _totalAmount);

            _date = DateTime.Now;
            Console.WriteLine("Installment payment will start on {0}\n", _date.ToLongDateString());
            Console.WriteLine();

            _payment = (percent1 * _totalAmount);
            
            Console.WriteLine();
            Console.WriteLine(".......Track of Installment Records.......\n");
               
            

            for (double i = _payment; i <= _totalAmount; i += _payment)
            {
                Console.WriteLine("{0} will pay #{1} on {2}," +
                    " Total: #{3}\n ", buyerName, _payment, _date.ToLongDateString(), i);
                _date = _date.AddDays(1);
            }

            Console.WriteLine("The End!");
                


            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                daily();
            }

        }

        public void weekly() 
        {
            try
            { 
            
            Console.WriteLine("You choosed Weekly installment plan!\n");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("You are expected to pay 6% of {0} weekly.\n", _totalAmount);

            _date = DateTime.Now;
            Console.WriteLine("Installment payment will start on {0}\n\n", _date.ToLongDateString());
            Console.WriteLine();

            _payment = (percent2 * _totalAmount);
            

            Console.WriteLine(".......Track of Installment Records.......\n");

            

            for (double i = _payment; i <= _totalAmount; i += _payment)
            {
                Console.WriteLine("{0} will pay #{1} on {2}," +
                    " Total: #{3} \n", buyerName, _payment, _date.ToLongDateString(), i);
                _date = _date.AddDays(7);
            }

            Console.WriteLine("Congratulations!!!! Payment Completed!");
        }
        catch (Exception e) 
        {
            Console.WriteLine(e.Message);
            weekly();
        }

}

        public void biWeekly()
        {
            try { 
            
            Console.WriteLine("You choosed bi-weekly installment plan!\n");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("You are expected to pay 7% of {0} bi-weekly.\n", _totalAmount);

            _date = DateTime.Now;
            Console.WriteLine("Installment payment will start on {0}\n\n", _date.ToLongDateString());
            

            _payment = (percent3 * _totalAmount);
            

           
            Console.WriteLine(".......Track of Installment Records.......\n");



            for (double i = _payment; i <= _totalAmount; i += _payment)
            {
                Console.WriteLine("{0} will pay #{1} on {2}," +
                    " Total: #{3} \n", buyerName, _payment, _date.ToLongDateString(), i);
                _date = _date.AddDays(14);
            }

            Console.WriteLine("Congratulations!!!! Payment Completed!");

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                biWeekly();
            }
        }

        public void monthly()
        {
            try { 
            
            Console.WriteLine("You choosed monthly installment plan!\n");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("You are expected to pay 8% of {0} monthly.\n", _totalAmount);

            _date = DateTime.Now;
            Console.WriteLine("Installment payment will start on {0}\n\n", _date.ToLongDateString());
            

            _payment = (percent4 * _totalAmount);



            
            Console.WriteLine(".......Track of Installment Records.......\n");



            for (double i = _payment; i <= _totalAmount; i += _payment)
            {
                Console.WriteLine("{0} is expected to pay #{1} on {2}," +
                    " Total: #{3} \n", buyerName, _payment, _date.ToLongDateString(), i);
                _date = _date.AddMonths(1);
            }

            
            Console.WriteLine("Congratulations!!!! Payment Completed!");

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                monthly();
            }
        }

        public void sixMonths()
        {
            try { 
            
            Console.WriteLine("You choosed six months installment plan!\n");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("You are expected to pay 9% of {0} every six months.\n", _totalAmount);

            _date = DateTime.Now;
            Console.WriteLine("Installment payment will start on {0}\n\n", _date.ToLongDateString());
            

            _payment = (percent5 * _totalAmount);
           
            Console.WriteLine(".......Track of Installment Records.......\n");



            for (double i = _payment; i <= _totalAmount; i += _payment)
            {
                Console.WriteLine("{0} is expected to pay #{1} on {2}," +
                    " Total: #{3} \n", buyerName, _payment, _date.ToLongDateString(), i);
                _date = _date.AddMonths(6);
            }

           
            Console.WriteLine("Congratulations!!!! Payment Completed!");

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                sixMonths();
            }
        }

        public void yearly()
        {
            try { 
            
            Console.WriteLine("You choosed one year installment plan!\n");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("You are expected to pay 10% of {0} yearly.\n", _totalAmount);

            _date = DateTime.Now;
            Console.WriteLine("Installment payment will start on {0}\n\n", _date.ToLongDateString());
            

            _payment = (percent6 * _totalAmount);



           
            Console.WriteLine(".......Track of Installment Records.......\n");



            for (double i = _payment; i <= _totalAmount; i += _payment)
            {
                Console.WriteLine("{0} is expected to pay #{1} on {2}," +
                    " Total: #{3} \n", buyerName, _payment, _date.ToLongDateString(), i);
                _date = _date.AddYears(1);
            }

            
            Console.WriteLine("Congratulations!!!! Payment Completed!");

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                yearly();
            }
        }


    }
}
