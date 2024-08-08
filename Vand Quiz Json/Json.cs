using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using static Vand_Quiz_Json.Program;

namespace Vand_Quiz_Json
{
    public class Quizzen
    {
        public int Id { get; set; }
        public string Spørgsmål { get; set; }
        public List<string> Options { get; set; }
        public int Svar { get; set; }
    }
}
