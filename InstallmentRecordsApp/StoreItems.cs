
namespace InstallmentRecordsApp
{
    public class StoreItems
    {
        
        
        private string buyerName;
        private double _itemNumber;
        private double _installationPlan;
        private decimal _priceOfProduct;
        private decimal _percentage;
        private decimal _quantity;
        private decimal _totalAmount;
        private DateTime _date;
        private decimal _payment;

         
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
            Console.WriteLine(" 1. Daily ........... 10% payment.\n " +
                "2. Weekly ........... 15% payment.\n " +
                "3. Bi-Weekly ........... 20% payment.\n " +
                "4. Monthly ........... 25% payment.\n " +
                "5. 6-Months ........... 30% payment.\n " +
                "6. One-Year ........... 35% payment.\n");
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
            _percentage = (decimal)(1d / 100); //10% for daily installment plan
            Console.WriteLine("You choosed Daily installment plan!\n");
            Console.WriteLine("Press any key to continue...");
             
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("You are expected to pay 10% of {0} daily.\n", _totalAmount);

            _date = DateTime.Now;
            Console.WriteLine("Installment payment will start on {0}\n", _date.AddDays(1).ToLongDateString());
            Console.WriteLine();

            _payment = (_percentage * _totalAmount);
            
            Console.WriteLine();
            Console.WriteLine(".......Track of Installment Records.......\n");

            

            for (decimal i = _payment; i <= _totalAmount; i += _payment)
            {
                Console.WriteLine("{0} will pay #{1} on {2}," +
                    " Total: #{3} ", buyerName, _payment, _date.ToLongDateString(), i);
                _date = _date.AddDays(1);
            }

            Console.WriteLine();
            Console.WriteLine("Congratulations!!!! Payment Completed!");


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
            _percentage = (decimal)(15d / 100); //15% for weekly installment plan
            Console.WriteLine("You choosed Weekly installment plan!\n");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("You are expected to pay 15% of {0} weekly.\n", _totalAmount);

            _date = DateTime.Now;
            Console.WriteLine("Installment payment will start on {0}\n", _date.AddDays(1).ToLongDateString());
            Console.WriteLine();

            _payment = (_percentage * _totalAmount);
            

            Console.WriteLine();
            Console.WriteLine(".......Track of Installment Records.......\n");

            

            for (decimal i = _payment; i <= _totalAmount; i += _payment)
            {
                Console.WriteLine("{0} will pay #{1} on {2}," +
                    " Total: #{3} ", buyerName, _payment, _date.ToLongDateString(), i);
                _date = _date.AddDays(7);
            }

            Console.WriteLine();
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
            _percentage = (decimal)(20d / 100); //20% for bi-weekly installment plan
            Console.WriteLine("You choosed bi-weekly installment plan!\n");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("You are expected to pay 20% of {0} bi-weekly.\n", _totalAmount);

            _date = DateTime.Now;
            Console.WriteLine("Installment payment will start on {0}\n", _date.AddDays(1).ToLongDateString());
            Console.WriteLine();

            _payment = (_percentage * _totalAmount);
            

            Console.WriteLine();
            Console.WriteLine(".......Track of Installment Records.......\n");



            for (decimal i = _payment; i <= _totalAmount; i += _payment)
            {
                Console.WriteLine("{0} will pay #{1} on {2}," +
                    " Total: #{3} ", buyerName, _payment, _date.ToLongDateString(), i);
                _date = _date.AddDays(14);
            }

            Console.WriteLine();
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
            _percentage = (decimal)(25d / 100); //25% for monthly installment plan
            Console.WriteLine("You choosed monthly installment plan!\n");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("You are expected to pay 25% of {0} monthly.\n", _totalAmount);

            _date = DateTime.Now;
            Console.WriteLine("Installment payment will start on {0}\n", _date.AddDays(1).ToLongDateString());
            Console.WriteLine();

            _payment = (_percentage * _totalAmount);



            Console.WriteLine();
            Console.WriteLine(".......Track of Installment Records.......\n");



            for (decimal i = _payment; i <= _totalAmount; i += _payment)
            {
                Console.WriteLine("{0} is expected to pay #{1} on {2}," +
                    " Total: #{3} ", buyerName, _payment, _date.ToLongDateString(), i);
                _date = _date.AddMonths(1);
            }

            Console.WriteLine();
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
            _percentage = (decimal)(30d / 100); //30% for six months installment plan
            Console.WriteLine("You choosed six months installment plan!\n");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("You are expected to pay 30% of {0} every six months.\n", _totalAmount);

            _date = DateTime.Now;
            Console.WriteLine("Installment payment will start on {0}\n", _date.AddDays(1).ToLongDateString());
            Console.WriteLine();

            _payment = (_percentage * _totalAmount);
           



            Console.WriteLine();
            Console.WriteLine(".......Track of Installment Records.......\n");



            for (decimal i = _payment; i <= _totalAmount; i += _payment)
            {
                Console.WriteLine("{0} is expected to pay #{1} on {2}," +
                    " Total: #{3} ", buyerName, _payment, _date.ToLongDateString(), i);
                _date = _date.AddMonths(6);
            }

            Console.WriteLine();
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
            _percentage = (decimal)(35d / 100); //35% for yearly installment plan
            Console.WriteLine("You choosed one year installment plan!\n");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("You are expected to pay 35% of {0} yearly.\n", _totalAmount);

            _date = DateTime.Now;
            Console.WriteLine("Installment payment will start on {0}\n", _date.AddDays(1).ToLongDateString());
            Console.WriteLine();

            _payment = (_percentage * _totalAmount);



            Console.WriteLine();
            Console.WriteLine(".......Track of Installment Records.......\n");



            for (decimal i = _payment; i <= _totalAmount; i += _payment)
            {
                Console.WriteLine("{0} is expected to pay #{1} on {2}," +
                    " Total: #{3} ", buyerName, _payment, _date.ToLongDateString(), i);
                _date = _date.AddYears(1);
            }

            Console.WriteLine();
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
