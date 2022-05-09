using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Model
{
    public class Criterium
    {
        #region Properties

        public string? Name { get; set; }
        public string? UniqueName { get; set; }
        public string? Description { get; set; }
        public List<string>? RatingsList;

        private Dictionary<Rating, string>? _ratingsDictionary;
        public Dictionary<Rating, string>? RatingsDictionary
        {
            get => _ratingsDictionary;
            set
            {
                RatingsList = new List<string>();
                foreach (var rating in value)
                {
                    RatingsList.Add(rating.ToString());
                }

                _ratingsDictionary = value;
            }
        }
        #endregion

        public override string ToString()
        {
            return Name;
        }
    }
}
