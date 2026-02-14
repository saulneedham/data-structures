using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADSPortEx2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            BSTree<Film> filmTree = new BSTree<Film>();

            filmTree.InsertItem(new Film("The Social Network", "Fincher", 5));
            filmTree.InsertItem(new Film("The Imitation Game", "Tyldum", 11));
            filmTree.InsertItem(new Film("Ex Machina", "Garland", 6));
            filmTree.InsertItem(new Film("Her", "Jonze", 3));
            filmTree.InsertItem(new Film("The Matrix", "Wachowski", 14));

            AVLTree<Film> filmAvlTree = new AVLTree<Film>();

            filmAvlTree.InsertItem(new Film("The Social Network", "Fincher", 5));
            filmAvlTree.InsertItem(new Film("The Imitation Game", "Tyldum", 11));
            filmAvlTree.InsertItem(new Film("Ex Machina", "Garland", 6));
            filmAvlTree.InsertItem(new Film("Her", "Jonze", 3));
            filmAvlTree.InsertItem(new Film("The Matrix", "Wachowski", 14));


            while (true)
            {
                Console.WriteLine("\nSelect an option:");
                Console.WriteLine("1. Display all items (InOrder Traversal)");
                Console.WriteLine("2. Display all items (PreOrder Traversal)");
                Console.WriteLine("3. Display all items (PostOrder Traversal)");
                Console.WriteLine("4. Add item to tree");
                Console.WriteLine("5. Display tree height");
                Console.WriteLine("6. Count items in the tree");
                Console.WriteLine("7. Update an item in the tree");
                Console.WriteLine("8. Get balance factor (testing)");
                Console.WriteLine("9. Add item to AVL tree");
                Console.WriteLine("10. Remove item from AVL tree");
                Console.Write("Enter your choice: ");

                string choice = Console.ReadLine();
                Console.WriteLine();

                switch (choice)
                {
                    case "1":
                        string inBuffer = "";
                        filmTree.InOrder(ref inBuffer);
                        Console.WriteLine("Tree items (In-Order): " + inBuffer);
                        break;

                    case "2":
                        string preBuffer = "";
                        filmTree.PreOrder(ref preBuffer);
                        Console.WriteLine("Tree items (Pre-Order): " + preBuffer);
                        break;

                    case "3":
                        string postBuffer = "";
                        filmTree.PostOrder(ref postBuffer);
                        Console.WriteLine("Tree items (Post-Order): " + postBuffer);
                        break;

                    case "4":
                        Console.Write("Enter the movie title: ");
                        string title = Console.ReadLine();
                        Console.Write("Enter the movies director: ");
                        string director = Console.ReadLine();
                        Console.Write("Enter the quantity in archives: ");
                        int quantity = Convert.ToInt32(Console.ReadLine());

                        filmTree.InsertItem(new Film(title, director, quantity));
                        Console.WriteLine(title + " added to tree!");
                        break;

                    case "5":
                        Console.WriteLine("Tree height: " + filmTree.Height());
                        break;

                    case "6":
                        Console.WriteLine("Tree count: " + filmTree.Count());
                        break;

                    case "7":
                        Console.WriteLine("Enter the movie title to update: ");
                        string titleToUpdate = Console.ReadLine();
                        Console.WriteLine("Enter the movies new director: ");
                        string newDirector = Console.ReadLine();
                        Console.WriteLine("Enter the new quantity in archives: ");
                        int newQuantity = Convert.ToInt32(Console.ReadLine());

                        Film updatedFilm = new Film(titleToUpdate, newDirector, newQuantity);
                        filmTree.Update(updatedFilm);
                        break;

                    case "8":
                        Console.WriteLine(filmAvlTree.GetBalanceFactor(filmAvlTree.Root));

                        break;

                    case "9":
                        Console.Write("Enter the movie title: ");
                        string titleAvl = Console.ReadLine();
                        Console.Write("Enter the movies director: ");
                        string directorAvl = Console.ReadLine();
                        Console.Write("Enter the quantity in archives: ");
                        int quantityAvl = Convert.ToInt32(Console.ReadLine());

                        filmAvlTree.InsertItem(new Film(titleAvl, directorAvl, quantityAvl));
                        Console.WriteLine(titleAvl + " added to AVL tree!");

                        break;

                    case "10":
                        Console.Write("Enter the movie title to be removed: ");
                        string titleToRemove = Console.ReadLine();

                        filmAvlTree.RemoveItem(titleToRemove);
                        break;
                }
            }
        }
    }
}
