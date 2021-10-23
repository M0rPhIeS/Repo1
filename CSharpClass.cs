using System;
using System.Threading.Tasks;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace CSharpTest {

    public void Main(string[] args) {
        
        var argc = args.Length;
        
        foreach(var s in args) {
            Console.WriteLine($"arg: {s}");
        }
    }
}
