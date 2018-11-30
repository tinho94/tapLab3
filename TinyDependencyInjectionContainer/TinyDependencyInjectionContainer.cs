using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace TinyDependencyInjectionContainer
{
    public class InterfaceInfo
    {
        Assembly dll_path_of_Interface;
        public Type interfaceType;

        public InterfaceInfo(string dll_path_of_Interface, string fully_qualified_Interface_name)
        {
            try
            {
                this.dll_path_of_Interface = Assembly.LoadFrom(dll_path_of_Interface);
            }
            catch (FileNotFoundException)
            {
                throw;
            }

            foreach (Type type in this.dll_path_of_Interface.GetTypes())
            {
                if (type.ToString().Equals(fully_qualified_Interface_name))
                {
                    this.interfaceType = type;
                    return;
                }
            }

            throw new Exception("interface not found in file: "+dll_path_of_Interface);
        }
    }

    public class ClassInfo
    {
        public Assembly dll_path_of_Class;
        public Type classType;

        public ClassInfo(string dll_path_of_Class, string fully_qualified_Class_name)
        {
            try
            {
                this.dll_path_of_Class = Assembly.LoadFrom(dll_path_of_Class);
            }
            catch (FileNotFoundException)
            {
                throw;
            }

            foreach (Type type in this.dll_path_of_Class.GetTypes())
            {
                if (type.ToString().Equals(fully_qualified_Class_name))
                {
                    this.classType = type;
                    return;
                }
            }

            throw new Exception("class not found in file: "+dll_path_of_Class);

        }
    }

    public class InterfaceResolver
    {
        Dictionary<InterfaceInfo,ClassInfo> interface_implementation_associations = new Dictionary<InterfaceInfo, ClassInfo>();
        

        public InterfaceResolver(string configFilePath)
        {
            string[] configFile;
            try
            {
                configFile = File.ReadAllLines(configFilePath);
            }
            catch (FileNotFoundException E)
            {
                throw;
            }
            
            foreach (var line in configFile)
            {
                if (line.StartsWith("#") || line.Equals("")) continue;

                List<string> configline = new List<string>();
                foreach (string s in line.Split('*'))
                {
                    configline.Add(s);
                }

                if (configline.Count != 4) throw new FormatException();

                this.interface_implementation_associations.Add(new InterfaceInfo(configline[0],configline[1]),new ClassInfo(configline[2],configline[3]));
                
            }
        }

        public T Instantiate<T>() where T : class
        {
            foreach (KeyValuePair<InterfaceInfo,ClassInfo> int_class_association in interface_implementation_associations)
            {
                if (int_class_association.Key.interfaceType.Equals(typeof(T)))
                {
                    return (T)Activator.CreateInstance(int_class_association.Value.classType);
                }
            }

            return null;
        }
        
    }
}