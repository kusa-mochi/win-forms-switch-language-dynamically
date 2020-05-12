using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using App1.Properties;

namespace App1
{
    public class ResourceService
    {
        public static string Locale { get; set; } = "";

        public static string GetString(string key)
        {
            ResourceManager manager;

            switch (Locale)
            {
                case "ja-JP":
                    manager = Properties.Resources_ja_JP_.ResourceManager;
                    break;
                default:
                    manager = Properties.Resources.ResourceManager;
                    break;
            }

            return manager.GetString(key);
        }
    }
}
