using System;

namespace EvCharge
{
    class Program
    {
        static Menu menu;

        static void Main(string[] args) {
            ListUsersWhenLogin();

            ShowMenu();
        }

        static void ListUsersWhenLogin() {
            Program.menu = new Menu();
        }

        static void ShowMenu() {
            Program.menu.ShowMenu();
        }

    }
}