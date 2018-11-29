using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinyDependencyInjectionContainer
{

    
    public class InterfaceResolver
    {
        private String interfacePathname;
        private String classPathname;

        public InterfaceResolver(String configFilePath)
        {
            string[] configFile = File.ReadAllLines(configFilePath);
            
            foreach (var line in configFile)
            {
                Console.WriteLine(line.ToString());
            }

        }
       
    }
}
