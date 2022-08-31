using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectOshKUU.ViewModels
{
    public static class StaticLanguageClass
    {
        public delegate void LanguageDelegateHandler();
        public delegate void RoomDelegateHandler(string room);

        public static event LanguageDelegateHandler LanguageDelegate;
        public static event RoomDelegateHandler SelectRoomDelegate;
        public static event RoomDelegateHandler SelectBuilding;
        public static string Lang { get; set; } = "RU";
        public static bool AccessAccount = false;
        public static void SelectBuildingMethod(string build)
        {
            SelectBuilding(build);
        }
        public static void SelectRoomMethod(string room)
        {
            SelectRoomDelegate(room);
        }
        public static void DelegateMethod(string lang)
        {
            if (lang == "KG")
                Lang = "KG";
            else
                Lang = "RU";
            LanguageDelegate();
        }
    }
}
