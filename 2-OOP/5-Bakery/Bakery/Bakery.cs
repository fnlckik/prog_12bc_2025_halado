using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;

namespace Bakery
{
    internal class Bakery
    {
        private List<IProduct> products;

        public Bakery(string fileName)
        {
            products = new List<IProduct>();
            try
            {
                using (StreamReader sr = new StreamReader(fileName))
                {
                    while (!sr.EndOfStream)
                    {
                        IProduct product = ReadProduct(sr);
                        products.Add(product);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private IProduct ReadProduct(StreamReader sr)
        {
            string[] temp = sr.ReadLine().Split();
            if (temp.Length == 2) // Coffee
            {
                bool isMilky = temp[1] == "tejes";
                return new Coffee(isMilky);
            }
            else // Scone
            {
                int quantity = int.Parse(temp[1]);
                int price = int.Parse(temp[2]);
                string type = temp[0].Split('_')[0];
                return new Scone(quantity, price, type);
            }
        }

        public void ListProducts()
        {
            foreach (IProduct product in products)
            {
                Console.WriteLine(product);
            }
        }

        public Scone GetScone(string type)
        {
            int i = 0;
            while (i < products.Count)
            {
                Scone scone = products[i] as Scone;
                if (scone?.type == type) return scone;
                i++;
            }
            throw new NullReferenceException("Nincs ilyen pogácsa.");
        }
    }
}
