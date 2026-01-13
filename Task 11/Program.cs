namespace Task_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            // BOSS
            const string bossName = "Dana White";
            int bossHealth = random.Next(500, 4500);
            int bossDamage = random.Next(10, 100);
            // BOSS

            // HERO
            string playerName = ReadLine();
            int playerHealth = random.Next(100, 800);
            int playerMana = random.Next(100, 3000);
            int playerPhysicalDamage = random.Next(30, 300);
            int playerFireBall = random.Next(50, 450);
            int playerBlast = random.Next(100, 1000);
            // HERO
        }
}
