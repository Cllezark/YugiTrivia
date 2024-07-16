using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YugiTrivia.Shared
{
    public class CardSet
    {
        public string set_name { get; set; }
        public string set_code { get; set; }
        public int num_of_cards { get; set; }
        public DateOnly tcg_date { get; set; }
        public string set_image { get; set; }
    }
}
