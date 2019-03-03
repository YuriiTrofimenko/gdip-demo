using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace GDIpDemo.Utils
{
    class Reflector
    {
        public static IEnumerable<string> GetClasses(string nameSpace)
        {
            Assembly asm = Assembly.GetExecutingAssembly();
            var result =
                asm.GetTypes()
                .Where(type => type.Namespace == nameSpace)
                .Select(type => type.Name);
                //.ToList();
            Console.WriteLine(result);
            return result;
        }
    }
}
