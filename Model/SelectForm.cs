using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class SelectForm
    {
        public int FormsId { get; set; }
        public string FormName { get; set; } 
        public SelectForm(int formsId, string formName)
        {
            FormsId = formsId;
            FormName = formName;
        }
    }
}
