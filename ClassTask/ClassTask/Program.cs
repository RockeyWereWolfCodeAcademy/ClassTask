namespace ClassTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User firstUser = new User("rockeywerewolf", "notmyrealpasswordlol");
            firstUser.Login("rockeywerewolf", "myrealpassword123");
            firstUser.Login("rockeywerewolf", "notmyrealpasswordlol");
            firstUser.Login("rockeywerewolf", "notmyrealpasswordlol");
            firstUser.Logout();
            firstUser.Logout();
            User secondUser = new User("ulviabdullazada", "123495678");
            secondUser.Login("ulviabdullazada", "123495678");
            secondUser.Login("ulviabdullazada", "123495678");
            secondUser.Logout();
            secondUser.Logout();
        }
    }
}