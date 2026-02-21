namespace Model;

public class User
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Email { get; set; }
    public static bool operator ==(User UserOne, User USerTwo)
    {
        return UserOne.Id == USerTwo.Id;
    }
    public static bool operator !=(User UserOne, User USerTwo)
    {
        return UserOne.Id != USerTwo.Id;
    }
    public void PrintName(User user)
    {
        try
        {
            Console.WriteLine(user.Name);
        }
        catch (Exception)
        {

            throw;
        }


    }
}
