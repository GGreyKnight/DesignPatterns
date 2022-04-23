using DesignPatterns;

EmailSender emailSender = new EmailSender();

emailSender.SendEmail("to@gmail.com", "title", "body");

static BankAccount GetBankAccount()
{
    var bankAccount = new CompanyBankAccount();
    bankAccount.MakeDeposit(1000);

    return bankAccount;
}