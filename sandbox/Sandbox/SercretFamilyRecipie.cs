using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Security.Cryptography;

public class SecretFamilyRecipie
{
    public List<string> _ingredients = new List<string>();
    public List<string> _directions = new List<string>();

    private string _password;

    public SecretFamilyRecipie(string password)
    {
        if (password == _password)
        {
            Console.WriteLine(_ingredients);
        }
        else
        {
            Console.WriteLine("Incorrect Password");
        }
        _ingredients.Add("Bread");
        _ingredients.Add("Peanut-Butter");
    }
}

