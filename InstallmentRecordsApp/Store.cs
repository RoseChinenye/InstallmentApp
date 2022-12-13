
namespace InstallmentRecordsApp;

public partial class Store
{
    
    private double _itemNumber, _quantity, _priceOfProduct;
    private double _installationPlan, _totalAmount, _payment;
    private DateTime _date;
    private string? buyerName;

    public const double percent1 = 0.05,
        percent2 = 0.06,
        percent3 = 0.07,
        percent4 = 0.08,
        percent5 = 0.09,
        percent6 = 0.1;

    
    public void daily()
    {
        try
        {

            Console.WriteLine("You choosed Daily installment plan!\n");
            Console.WriteLine("Press any key to continue...");

            Console.ReadKey();
            Console.Clear();
            Console.WriteLine($"You are expected to pay 5% of {_totalAmount} daily.\n");


            _date = DateTime.Now;
            Console.WriteLine($"Installment payment will start on {_date.ToLongDateString()}\n\n");


            _payment = (percent1 * _totalAmount);


            Console.WriteLine(".......Track of Installment Records.......\n");


            for (double i = _payment; i <= _totalAmount; i += _payment)
            {
                Console.WriteLine($"{buyerName} will pay #{_payment} on {_date.ToLongDateString()}, Total: #{i}\n ");
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

            Console.WriteLine("You choosed Weekly installment plan!\nPress any key to continue...");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine($"You are expected to pay 6% of {_totalAmount} weekly.\n");

            _date = DateTime.Now;
            Console.WriteLine($"Installment payment will start on {_date.ToLongDateString()}\n\n");


            _payment = (percent2 * _totalAmount);


            Console.WriteLine(".......Track of Installment Records.......\n");


            for (double i = _payment; i <= _totalAmount; i += _payment)
            {
                Console.WriteLine($"{buyerName} will pay #{_payment} on {_date.ToLongDateString()}, Total: #{i} \n");
                _date = _date.AddDays(7);
            }

            Console.WriteLine("The End!");
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            weekly();
        }

    }

    public void biWeekly()
    {
        try
        {

            Console.WriteLine("You choosed bi-weekly installment plan!\nPress any key to continue...");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine($"You are expected to pay 7% of {_totalAmount} bi-weekly.\n");

            _date = DateTime.Now;
            Console.WriteLine($"Installment payment will start on {_date.ToLongDateString()}\n\n");


            _payment = (percent3 * _totalAmount);

            Console.WriteLine(".......Track of Installment Records.......\n");


            for (double i = _payment; i <= _totalAmount; i += _payment)
            {
                Console.WriteLine($"{buyerName} will pay #{_payment} on {_date.ToLongDateString()}, Total: #{i} \n");
                _date = _date.AddDays(14);
            }

            Console.WriteLine("The End!");

        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            biWeekly();
        }
    }

    public void monthly()
    {
        try
        {

            Console.WriteLine("You choosed monthly installment plan!\nPress any key to continue...");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine($"You are expected to pay 8% of { _totalAmount} monthly.\n");

            _date = DateTime.Now;
            Console.WriteLine($"Installment payment will start on {_date.ToLongDateString()}\n\n");

            _payment = (percent4 * _totalAmount);

            Console.WriteLine(".......Track of Installment Records.......\n");


            for (double i = _payment; i <= _totalAmount; i += _payment)
            {
                Console.WriteLine($"{buyerName} is expected to pay #{_payment} on {_date.ToLongDateString()}," +
                    $" Total: #{i} \n");
                _date = _date.AddMonths(1);
            }


            Console.WriteLine("The End!");

        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            monthly();
        }
    }

    public void sixMonths()
    {
        try
        {

            Console.WriteLine("You choosed six months installment plan!\nPress any key to continue...");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine($"You are expected to pay 9% of {_totalAmount} every six months.\n");

            _date = DateTime.Now;
            Console.WriteLine($"Installment payment will start on {_date.ToLongDateString()}\n\n");


            _payment = (percent5 * _totalAmount);

            Console.WriteLine(".......Track of Installment Records.......\n");


            for (double i = _payment; i <= _totalAmount; i += _payment)
            {
                Console.WriteLine($"{buyerName} is expected to pay #{_payment} on {_date.ToLongDateString()}," +
                    $" Total: #{i} \n");
                _date = _date.AddMonths(6);
            }


            Console.WriteLine("The End!");

        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            sixMonths();
        }
    }

    public void yearly()
    {
        try
        {

            Console.WriteLine("You choosed one year installment plan!\nPress any key to continue...");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine($"You are expected to pay 10% of {_totalAmount} yearly.\n");

            _date = DateTime.Now;
            Console.WriteLine($"Installment payment will start on {_date.ToLongDateString()}\n\n");


            _payment = (percent6 * _totalAmount);

            Console.WriteLine(".......Track of Installment Records.......\n");

            for (double i = _payment; i <= _totalAmount; i += _payment)
            {
                Console.WriteLine($"{buyerName} is expected to pay #{_payment} on {_date.ToLongDateString()}, Total: #{i} \n");
                _date = _date.AddYears(1);
            }

            Console.WriteLine("The End!");

        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            yearly();
        }
    }

}
