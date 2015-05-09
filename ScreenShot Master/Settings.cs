using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.IO.IsolatedStorage;

using SreenShotClass;
namespace ScreenShot_Master
{
    static class Settings
    {
        public static Dictionary<string, string> Dictionary { get; private set; }
        /// <summary>
        /// обновляем юиюлиотеку настроек
        /// </summary>
        public static void Refresh()
        {
            Dictionary = GetSettings();
        }
        public static void DeleteKey(string key)
        {
            Dictionary<string, string> dic = GetSettings();
            dic.Remove(key);
            SaveSettings(dic);
        }
        public static void EditKey(string key,string value)
        {
            if (!KeyExist(key))
            {
                AddSettings(key, value);
                return;
            }
            Dictionary<string, string> dic = GetSettings();
            dic[key] = value;

            SaveSettings(dic);

        }
        public static SH_Settings GetSH_Settings()
        {

            return new SH_Settings(Dictionary["FolderPath"], Helper.ConvertStringToImageFormat(Dictionary["ImageFormat"]));
        }
        private static void SaveSettings(Dictionary<string, string> dic)
        {
            using (IsolatedStorageFile iso = IsolatedStorageFile.GetStore(IsolatedStorageScope.User | IsolatedStorageScope.Domain | IsolatedStorageScope.Assembly, null, null))
            {
                using (IsolatedStorageFileStream stream = iso.OpenFile("settings", FileMode.OpenOrCreate, FileAccess.Write))
                {
                    using (StreamWriter wr = new StreamWriter(stream, Encoding.Default))
                    {
                        foreach (KeyValuePair<string, string> p in dic)
                        {
                            wr.WriteLine(p.Key + "#$#" + p.Value);
                        }
                        wr.Dispose();
                        wr.Close();
                    }
                    stream.Dispose();
                    stream.Close();
                }
                iso.Dispose();
                iso.Close();
            }
            Refresh();
        }
        /// <summary>
        ///  Adding setting to setting dictionary
        /// </summary>
        /// <param name="key"> key </param>
        /// <param name="value"> value </param>
        public static void AddSettings(string key, string value)
        {
            if(KeyExist(key))
            {
                EditKey(key, value);
                return;
            }
            using (IsolatedStorageFile iso = IsolatedStorageFile.GetStore(IsolatedStorageScope.User | IsolatedStorageScope.Domain | IsolatedStorageScope.Assembly, null, null))
            {
                using(IsolatedStorageFileStream stream = iso.OpenFile("settings",FileMode.Append,FileAccess.Write))
                {
                    using (StreamWriter wr = new StreamWriter(stream,Encoding.Default))
                    {
                        wr.WriteLine(key + "#$#" + value);
                        wr.Dispose();
                        wr.Close();
                    }
                    stream.Dispose();
                    stream.Close();
                }
                iso.Dispose();
                iso.Close();
            }
            Refresh();
        }
        /// <summary>
        /// Getting the dictionary of settings
        /// </summary>
        /// <returns> Dictionary of string KEY VALUE  </returns>
        private static Dictionary<string, string> GetSettings()
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();

            using (IsolatedStorageFile iso = IsolatedStorageFile.GetStore(IsolatedStorageScope.User | IsolatedStorageScope.Domain | IsolatedStorageScope.Assembly, null, null))
            {
                using (IsolatedStorageFileStream stream = iso.OpenFile("settings", FileMode.OpenOrCreate, FileAccess.Read))
                {
                    using (StreamReader read = new StreamReader(stream, Encoding.Default))
                    {
                        while(!read.EndOfStream)
                        { 
                            string line = read.ReadLine();
                            if (line != null && line.Length > 1)
                            {
                                string[] el = line.Split("#$#".ToCharArray());
                                if(!dic.ContainsKey(el[0]))
                                    dic.Add(el[0], el[el.Length - 1]);
                            }
                       }
                        read.Dispose();
                        read.Close();
                    }
                    stream.Dispose();
                    stream.Close();
                }
                iso.Dispose();
                iso.Close();
            }
            return dic;
        }

        public static bool KeyExist(string key)
        {
            Dictionary<string, string> dic = GetSettings();
            return dic.ContainsKey(key);
        }
        public static bool ValueExist(string value)
        {
            Dictionary<string, string> dic = GetSettings();
            return dic.ContainsValue(value);
        }
        public static string GetValue(string key)
        {
            Dictionary<string, string> dic = GetSettings();
            if (!dic.ContainsKey(key)) throw new UnknownKeyException();
            return dic[key];
        }
        public static string GetValue(string key,string defaultValue)
        {
            if (!KeyExist(key))
                return defaultValue;
            else
                return GetValue(key);
        }
        public static string GetKey(string value)
        {
            Dictionary<string, string> dic = GetSettings();
            
            foreach(KeyValuePair<string,string> pair in dic)
            {
                if (pair.Value == value) return pair.Key;
            }
            return null;
        }

    }
    public class UnknownKeyException : Exception
    {
        public string Message = "This key didn't exist in settings dictionary";
    }
}
