using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Banking;


namespace BankingXamarin
{
    public partial class App : Application


    private BankAccount
       
    public App()
    {
        _account = account;
        InitializeComponent();

        Bank stb = new Bank("Standard Bank", 5336, "Tygervalley");
        Customer myNewCustomer = new Customer("7766445424", "10 me at home", "Luke", "The Driver");
        stb.AddCustomer(myNewCustomer);


        var account = myNewCustomer.ApplyForBankAccount();
        MainPage = new MainPage();
        _account.DepositMoney(6000, DateTime.Now, "Stipend");



        private void DepositButton_Clicked(object sender, EventArgs e)


        {

            decimal depositAmount = 0;
            var valid = decimal.TryParse(DepositAmountEntry.Text, out depositAmount);
            var reason = DepositReasonEntry.Text;
            if (valid)
            {
                _account.DepositMoney(depositAmount, DateTime.Now, reason);
            }
            else
            {
                DisplayAlert("Validation Error", "Please Enter a number", "Cancel");
            }


        }
    }

}

