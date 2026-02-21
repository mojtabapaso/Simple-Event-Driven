class SmsService
{
    public void SendSuccessRegister(object? sender, UserRegisteredEventArgs e)
    {
        Console.WriteLine($"Register Successed  UserName: {e.UserName}, RegisterDate {e.RegisterDate} ");
    }
    public void SendFailStatus(object? sender, RegisterFailedEventArgs e)
    {
        Console.WriteLine($"Register FAILED - UserName: {e.UserName}, Reason: {e.Reason}");
    }
    // other function
    public void SendSms(string message)
    {
        Console.WriteLine($"message  {message}");
    }


}
