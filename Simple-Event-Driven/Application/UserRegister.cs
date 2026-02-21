class UserRegister
{

    // create event hear
    public event EventHandler<UserRegisteredEventArgs> UserRegistered;
    public event EventHandler<RegisterFailedEventArgs> RegisterFailed;
    // logic
    public void Register(string userName, string password)
    {
        if (userName.ToUpper() == "ADMIN" && password == "123456")
        {

            OnUserRegistered(new UserRegisteredEventArgs(userName));
        }
        else
        {
            OnRegisterFailed(new RegisterFailedEventArgs(userName, "Invalid username or password"));
        }
    }
    protected virtual void OnUserRegistered(UserRegisteredEventArgs args)
    {
        UserRegistered?.Invoke(this, args);
    }
    protected virtual void OnRegisterFailed(RegisterFailedEventArgs args)
    {
        RegisterFailed?.Invoke(this, args);
    }
}
