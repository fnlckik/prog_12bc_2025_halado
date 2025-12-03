using System.Collections.Generic;
using System.IO;

namespace Bakery
{
    internal class Bakery
    {
        private List<IProduct> products;

        public Bakery(string fileName)
        {
            using (StreamReader sr = new StreamReader(fileName))
            {
                // TODO
            }
        }
    }
}
