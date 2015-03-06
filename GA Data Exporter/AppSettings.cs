using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace GA_Data_Exporter
{
    sealed class AppSettings : ApplicationSettingsBase
    {
        [UserScopedSetting()]
        [DefaultSettingValue("")]
        public string DatabaseFileName
        {
            get { return (string)this["DatabaseFileName"]; }
            set { this["DatabaseFileName"] = value; }
        }

    }
   
}
