using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomConfigurationSection
{
    public class MyAppSpecificConfigurationSection : ConfigurationSection
    {
        [ConfigurationProperty("active", DefaultValue = "true", IsRequired = false)]
        public Boolean Active
        {
            get
            {
                return (Boolean)this["active"];
            }
            set
            {
                this["active"] = value;
            }
        }

        [ConfigurationProperty("application")]
        public ApplicationDetails ApplicationDetails
        {
            get
            {
                return (ApplicationDetails)(this["application"]);
            }
            set
            { this["application"] = value; }
        }
        
    }

    public class ApplicationDetails : ConfigurationElement
    {
        [ConfigurationProperty("name",  IsRequired = true)]
        public String Name
        {
            get
            {
                return (String)this["name"];
            }
            set
            {
                this["name"] = value;
            }
        }

        [ConfigurationProperty("version",  IsRequired = true, DefaultValue = "0.0.0")]
        [RegexStringValidator(@"^\d\.\d\.\d$")]
        public string Version
        {
            get
            { return Convert.ToString(this["version"]); }
            set
            { this["version"] = value; }
        }
    }
}
