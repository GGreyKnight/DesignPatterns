using DesignPatterns;
using DesignPatterns.DependencyInversion;

User user = new User();
user.Email = "abc@abc.abc";
user.Password = "abc";

AutenticationManager autenticationManager = new AutenticationManager(new SmsNotification());
autenticationManager.Authenticate(user, "abc@abc.abc", "abc");


EmailSender emailSender = new EmailSender();

emailSender.SendEmail("to@gmail.com", "title", "body");

static BankAccount GetBankAccount()
{
    var bankAccount = new CompanyBankAccount();
    bankAccount.MakeDeposit(1000);

    return bankAccount;
}