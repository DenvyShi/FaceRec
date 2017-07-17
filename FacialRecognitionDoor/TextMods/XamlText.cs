using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacialRecognitionDoor.TextMods
{
    public static class XamlText
    {
        public static string DetailsBlockIntro = "Click the + icon to add a whitelisted user. Click the doorbell icon to try and unlock the door";
        public static string DetailsBlockDebug = "This is a test";


        public static string DetailsBlockSuccess(string name)
        {
            return "Welcome " + name + " you  have been recognised";
        }
    }
}
