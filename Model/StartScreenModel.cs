using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class StartScreenModel
    {
        public int StartFormId { get; set; }
        public string Name { get; set; }


        public StartScreenModel(int startFormId, string name)
        {
            StartFormId = startFormId;
            Name = name;
        }
    }
}
