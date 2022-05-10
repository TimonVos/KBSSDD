using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Model;

namespace ViewModel
{
    public class CriterionViewModel
    {
        public Criterion? Model { get; set; }
        public CompetenceViewModel? Competence { get; set; }

        public CriterionViewModel()
        {

        }
    }
}
