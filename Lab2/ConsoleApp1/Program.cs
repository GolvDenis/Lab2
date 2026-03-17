using ClassLibrary1.Task1;
using ClassLibrary1.Task2;
using ClassLibrary1.Task3;
using ClassLibrary1.Task4;
using ClassLibrary1.Task5;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.InputEncoding = System.Text.Encoding.Unicode;
        Console.OutputEncoding = System.Text.Encoding.Unicode;

        Console.WriteLine("Task1:");
        Console.WriteLine("------------------------------");

        SubscriptionCreator web = new WebSite();
        SubscriptionCreator app = new MobileApp();
        SubscriptionCreator call = new ManagerCall();

        var s1 = web.CreateSubscription("domestic");
        var s2 = app.CreateSubscription("educational");
        var s3 = call.CreateSubscription("premium");

        s1.ShowInfo();
        s2.ShowInfo();
        s3.ShowInfo();
        Console.WriteLine("------------------------------");

        Console.WriteLine("Task2:");
        Console.WriteLine("------------------------------");

        ITechFactory[] factories = new ITechFactory[]
{
            new IProneFactory(),
            new KiaomiFactory(),
            new BalaxyFactory()
};

        foreach (var factory in factories)
        {
            Console.WriteLine("Factory: " + factory.GetType().Name);
            var laptop = factory.CreateLaptop();
            var netbook = factory.CreateNetbook();
            var ebook = factory.CreateEBook();
            var phone = factory.CreateSmartphone();

            laptop.ShowInfo();
            netbook.ShowInfo();
            ebook.ShowInfo();
            phone.ShowInfo();

            Console.WriteLine();
        }
        Console.WriteLine("------------------------------");


        Console.WriteLine("Task3:");
        Console.WriteLine("------------------------------");

        var auth1 = Authenticator.Instance;
        var auth2 = Authenticator.Instance;

        auth1.Authenticate("Denys");
        auth2.Authenticate("Admin");

        Console.WriteLine(object.ReferenceEquals(auth1, auth2));
        Console.WriteLine("------------------------------");

        Console.WriteLine("Task4:");
        Console.WriteLine("------------------------------");

        Virus parent = new Virus("Alpha", "Грип A", 0.5, 10);

        Virus child1 = new Virus("Beta-1", "Грип B", 0.3, 5);
        Virus child2 = new Virus("Beta-2", "Грип B", 0.4, 6);
        parent.AddChild(child1);
        parent.AddChild(child2);

        Virus grandChild1 = new Virus("Gamma-1", "Грип C", 0.2, 2);
        Virus grandChild2 = new Virus("Gamma-2", "Грип C", 0.25, 3);
        child1.AddChild(grandChild1);
        child2.AddChild(grandChild2);

        Virus clonedParent = (Virus)parent.Clone();

        Console.WriteLine("=== Оригінальний вірус ===");
        parent.PrintInfo();

        Console.WriteLine("\n=== Клонований вірус ===");
        clonedParent.PrintInfo();

        parent.Name = "Alpha-Mutated";
        parent.Weight = 0.6;
        parent.Children[0].Name = "Beta-1-Mutated";

        Console.WriteLine("\n=== Після змін в оригіналі ===");
        Console.WriteLine("Оригінал:");
        parent.PrintInfo();
        Console.WriteLine("\nКлон (не змінився):");
        clonedParent.PrintInfo();

        Console.WriteLine("------------------------------");

        Console.WriteLine("Task5:");
        Console.WriteLine("------------------------------");

        Director director = new Director();

        var hero = director.CreateHero(new HeroBuilder());
        var enemy = director.CreateEnemy(new EnemyBuilder());

        Console.WriteLine("Hero:");
        hero.Show();

        Console.WriteLine("Enemy:");
        enemy.Show();

        Console.WriteLine("------------------------------");
    }
}