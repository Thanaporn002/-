using System.Collections.Generic;
using System;

public class Login
{
    public void ShowLogin() 
    {
        Console.Clear();
        PrintLogin();
    }

    public bool InputLogin(List<User> listUsers) {
        string name = InputName();
        string password = InputPassword();

        foreach (User user in listUsers) {
            Console.WriteLine(user.GetName());
            if (user.GetName() == name && user.GetPassword() == password) {
                return ShowMenuForce(user);
            }
        }

        return false;
    }

    private void ShowMenuForce(User user) {
        Force.InputForce(user);
    }

    public string InputName() 
    {
        Console.Write("Input name: ");

        return Console.ReadLine();
    }

    public string InputPassword() 
    {
        Console.Write("Input Password: ");

        return Console.ReadLine();
    }

    private void PrintLogin() {
        Console.WriteLine("Login successfully");
        Console.WriteLine("---------------------------");
    }
}