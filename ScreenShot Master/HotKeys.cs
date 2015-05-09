using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.Windows.Forms;
namespace ScreenShot_Master
{
    static class HotKeyS
    {
        [DllImport("user32.dll")]
        private static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vk);
        [DllImport("user32.dll")]
        private static extern bool UnregisterHotKey(IntPtr hWnd, int id);
        public enum KeyModifer
        {
            None = 0,
            Alt = 1,
            Control = 2,
            Shift = 4,
            WinKey = 8
        }
        static Dictionary<int, EventHandler> dict;
        static Dictionary<KeyValuePair<KeyModifer, Keys>, int> keysId;
        static int count;
        static IntPtr handle;
        public static IntPtr Handle
        {
            get 
            {
                if (handle == null)
                    handle = MainForm.ActiveForm.Handle;
                return handle;
            }
            set
            {
                handle = value;
            }
        }
        public static void Init()
        {
            if (keysId != null)
                UnregisterAll();
            dict = new Dictionary<int, EventHandler>();
            keysId = new Dictionary<KeyValuePair<KeyModifer, Keys>, int>();
        }
        static public void RegstrerHotkey(KeyModifer keyMod, Keys hotkey, EventHandler onPress)
        {
            count++;
            dict.Add(count, onPress);
            try
            {
                keysId.Add(new KeyValuePair<KeyModifer, Keys>(keyMod, hotkey), count);
                RegisterHotKey(Handle, count, (int)keyMod, hotkey.GetHashCode());
            }
            catch { }
        }
        static public void UnregisterHotkey(KeyModifer keyMod, Keys hotkey)
        {
            int id;
            KeyValuePair<KeyModifer, Keys> p = new KeyValuePair<KeyModifer, Keys>(keyMod, hotkey);
            keysId.TryGetValue(p,out id);
            UnregisterHotKey(Handle, id);
            keysId.Remove(p);
            dict.Remove(id);
        }
        static public void UnregisterAll()
        {
            int id;
            for (int i = keysId.Count - 1; i >= 0;i-- )
            {
                KeyValuePair<KeyModifer, Keys> p = keysId.Keys.ElementAt<KeyValuePair<KeyModifer, Keys>>(i);
                keysId.TryGetValue(p, out id);
                UnregisterHotKey(Handle, id);
                keysId.Remove(p);
                dict.Remove(id);
            }
        }
        static public void Update(Message mes)
        {
            if (dict.Count == 0)
                return;
            if(mes.Msg == 0x0312)
            {
                int id = mes.WParam.ToInt32();
                dict[id](null, null);
            }

        }
    }
}
