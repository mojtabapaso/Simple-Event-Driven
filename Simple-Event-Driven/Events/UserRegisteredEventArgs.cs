class UserRegisteredEventArgs : EventArgs
{
    public string UserName { get; }
    public DateTime RegisterDate { get; }

    public UserRegisteredEventArgs(string userName)
    {
        UserName = userName;
        RegisterDate = DateTime.Now;
    }
}
