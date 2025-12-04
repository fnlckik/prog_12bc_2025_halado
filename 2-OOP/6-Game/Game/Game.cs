using System;
using System.Collections.Generic;
using System.IO;

namespace Game
{
    internal class Game
    {
        private List<Character> characters;
        private Hero hero;

        public Game(string fileName)
        {
            hero = new Hero("Neo", 42, 100);
            characters = new List<Character>();
            try
            {
                using (StreamReader sr = new StreamReader(fileName))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] temp = sr.ReadLine().Split();
                        string name = temp[1];
                        int health = int.Parse(temp[2]);
                        int damage = int.Parse(temp[3]);
                        if (temp[0] == "Fighter") // Fighter
                        {
                            characters.Add(new Fighter(name, damage, health));
                        }
                        else // Archer
                        {
                            bool fast = temp.Length == 4;
                            characters.Add(new Archer(name, damage, health, fast));
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void ListEnemies()
        {
            characters.Sort();
            foreach (Character character in characters)
            {
                Console.WriteLine(character);
            }
        }

        public void Simulate()
        {
            Console.WriteLine();
            foreach (Enemy enemy in characters)
            {
                Console.WriteLine(enemy);

                while (!enemy.IsDead() && !hero.IsDead())
                {
                    hero.Attack(enemy);
                    if (!enemy.IsDead())
                    {
                        enemy.Attack(hero);
                    }
                }

                if (hero.IsDead())
                {
                    Console.WriteLine("Vereség!");
                    return;
                }

                Console.WriteLine("Győzelem!");
                hero.Heal();
            }
            Console.WriteLine("A hős mindenkit legyőzött!");
        }
    }
}
