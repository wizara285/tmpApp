using tmpApp;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        User user = new User()
        {
            Id = 1,
            Name = "Test",
            Age = 18,
            Email = "test@gmail.com"
        };

        Console.WriteLine($"{user.Name}");

    }
}