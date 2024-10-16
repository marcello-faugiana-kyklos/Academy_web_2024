using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Newtonsoft.Json.JsonConvert;

namespace ConsoleNet8.CippaLippa;

class Class1
{
    // JSon JavaScript Object Notation
    // YAML Yet Another Markup Language
    // DSL  Domain Specific Language
    
    private void DoStuff()
    {
        Queue q = new Queue();
        SerializeObject(new Class1());
    }

}

public class Class2
{
    private int _x;
}
