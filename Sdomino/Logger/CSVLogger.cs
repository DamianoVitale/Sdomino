using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sdomino.Ordini;

namespace Sdomino.Logger
{
    internal class CSVLogger
    {
        private readonly Scontrino scontrino;

        public CSVLogger(Scontrino _scontrino)
        {
            scontrino = _scontrino;
        }

        public void WriteOnFile(string filePath)
        {
            string line = $"Scontrino numero: {scontrino.Id}, Totale ordine: {scontrino.Totale.ToString("C")}";

            using (StreamWriter writer = new StreamWriter(filePath, true))
                writer.WriteLine(line);
        }
    }
}
