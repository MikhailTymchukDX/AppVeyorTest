using AppVeyorTest;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WikiUpdater {
    class Program {
        static void Main(string[] args) {
            var documentedClassType = typeof(TestClass);
            File.WriteAllText(Path.Combine(args[0], "Accordion.md"),
                String.Join(", ", documentedClassType.GetMethods().Select(m => m.Name)));
        }
    }
}
