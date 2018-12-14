using Strategy.Character.Csl.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Character.Csl.Classes
{
    public class Knight : Actor //"Knight IS-A Actor"
    {
        public Knight()
        {
            weapon = new MaceBehaviour();
        }
        public override void display() => Console.WriteLine("Living or dead, by decree of Shor,\r\n none may pass this perilous bridge 'till I judge them worthy by the warrior's test.");
    }
}
