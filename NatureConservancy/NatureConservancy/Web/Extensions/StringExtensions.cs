using System;

namespace NatureConservancy
{
    public static class StringExtensions
    {
        public static string AppSetting(this string SettingName)
        {
            return System.Configuration.ConfigurationManager.AppSettings[SettingName];
        }

        public static int ToInt(this string item)
        {
            return Int32.Parse(item);
        }
    }  
}