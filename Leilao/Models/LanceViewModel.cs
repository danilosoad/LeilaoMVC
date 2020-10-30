using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Leilao.Models
{
    public class LanceViewModel
    {
        public int id { get; set; }
        public string CPF { get; set; }
        public string responsavelLance { get; set; }
        public double valorLance { get; set; }
    }
}
