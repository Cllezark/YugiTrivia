using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YugiTrivia.Shared
{
    public class TriviaCard
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public DateOnly? TcgDate { get; set; }
        public DateOnly? OcgDate { get; set; }
        public string? Artwork { get; set; }
    }
}
