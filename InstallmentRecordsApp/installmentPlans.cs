
namespace InstallmentRecordsApp;

public partial class Store
{
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
                    weekly();
                    break;
                case 3:
                    biWeekly();
                    break;
                case 4:
                    monthly();
                    break;
                case 5:
                    sixMonths();
                    break;
                default:
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

}
