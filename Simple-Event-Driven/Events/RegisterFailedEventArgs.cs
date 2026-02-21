class RegisterFailedEventArgs : EventArgs
{
    public string UserName { get; }
    public string Reason { get; }

    public RegisterFailedEventArgs(string userName, string reason)
    {
        UserName = userName;
        Reason = reason;
    }
}
