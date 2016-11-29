using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomConfigurationSection
{
    public class MyApp
    {

        public static void Main(string[] args)
        {
            MyAppSpecificConfigurationSection Configs = (MyAppSpecificConfigurationSection)System.Configuration.ConfigurationManager.GetSection("myAppSpecificConfigurationSection");

            Console.WriteLine(Configs.Active);
            Console.WriteLine(Configs.ApplicationDetails.Name);
            Console.WriteLine(Configs.ApplicationDetails.Version);
        }
    }
}
