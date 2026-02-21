var smsService = new SmsService(); 
var userRegister = new UserRegister();
try
{
    userRegister.UserRegistered += smsService.SendSuccessRegister;
    userRegister.RegisterFailed += smsService.SendFailStatus;
    userRegister.Register("admin", "123456");
}
catch (Exception)
{
    throw;
}
finally
{
    // for GC
    userRegister.UserRegistered -= smsService.SendSuccessRegister;
    userRegister.RegisterFailed -= smsService.SendFailStatus;

}

