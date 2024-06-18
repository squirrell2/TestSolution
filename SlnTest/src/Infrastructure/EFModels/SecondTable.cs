using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.EFModels
{
    public class SecondTable
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int SampleTableId { get; set; }

        public SampleTable SampleTable { get; set; } = new();
    }
}
