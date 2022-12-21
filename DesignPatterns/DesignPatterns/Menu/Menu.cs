using DesignPatterns.Patterns.AbstractFactory;
using DesignPatterns.Patterns.ChainOfResponsability;
using DesignPatterns.Patterns.Prototype;
using DesignPatterns.Patterns.Proxy;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Menu
{
    public class Menu
    {
        const string MENU =
                "---- * ---- * ---- * ---- * ---- * ---- * ---- * ---- * ---- * ----\n" +
                "\n" +
                "                       MENU INICIAL\n" +
                "\n" +
                "Informe a opção de Design Pattern:\n" +
                " 1 - Chain of Responsability (Caroline)\n" +
                " 2 - Proxy (Eduardo)\n" +
                " 3 - Abstract Factory (Edelberto)\n" +
                " 4 - State (Paulo)\n" +
                " 5 - Visitor (Denilson)\n" +
                " 6 - Visitor (Hector)\n" +
                " 7 - Builder (Guilherme)\n" +
                " 8 - Interpreter (Daniela)\n" +
                " 9 - Bridge (William)\n" +
                "10 - Prototype (Matheus)\n" +
                "11 - Adapter (Mateus)\n" +
                "12 - Composite (Nelson)\n" +
                "\n" +
                "Opção: ";

        public Menu()
        {
            ExibeMenu();

        }

        private void ExibeMenu()
        {
            string opcao = "a";

            while (!opcao.Equals("0"))
            {
                Console.Write(MENU);

                opcao = Console.ReadLine();

                Console.WriteLine("\nResultado:\n");

                switch (opcao)
                {
                    case "0":
                        break;

                    case "1":
                        ChainOfResponsabilityApp chainOfResponsabilityApp = new ChainOfResponsabilityApp();
                        break;

                    case "2":
                        ProxyApp proxyApp = new ProxyApp();
                        break;

                    case "3":
                        AbstractFactoryApp abstractFactoryApp = new AbstractFactoryApp();
                        break;

                    case "4":
                        break;

                    case "5":
                        break;

                    case "6":
                        break;

                    case "7":
                        break;

                    case "8":
                        break;

                    case "9":
                        break;

                    case "10":
                        PrototypeApp _prototype = new PrototypeApp();
                        break;

                    case "11":
                        break;

                    case "12":
                        break;

                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }
            }

            

            

        }
    }
}
