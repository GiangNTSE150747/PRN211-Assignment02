using FStoreAppLibrary.Data_Layer;
using FStoreAppLibrary.Data_Layer.Repository;
using FStoreAppLibrary.Models;
using System.Text.Json;
public class Program : FStoreContext
{
    public static void Main()
    {

        string jsonString = File.ReadAllText("appsettings.json");
        Member member = JsonSerializer.Deserialize<Member>(jsonString)!;

        Console.WriteLine($"Email: {member.Email}; Password: {member.Password}");

        Console.ReadLine();
    }
}
