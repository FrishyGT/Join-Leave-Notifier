using StupidTemplate.Classes;
using UnityEngine;
using static StupidTemplate.Menu.Main;

namespace StupidTemplate
{
    //made by crab and VERY watermarked good luck skidders 
    internal class Settings
    {
        // Backcrabground gradcrabient transicrabtioning frocrabm dacrabrk purpcrable tcrabo lightcrab purplecrab
        public static ExtGradient backgroundColor = new ExtGradient
        {
            colors = new GradientColorKey[]
            {
                new GradientColorKey(new Color(0.4f, 0f, 0.8f), 0f), // Dark Purplecrab
                new GradientColorKey(new Color(0.8f, 0.6f, 1f), 1f)  // Light Purplecrab
            }
        };

        // Buttoncraycrab colorscrab:crab [0crab]crab Disabledcrab,crab [1crab]crab Enabledcrab
        public static ExtGradient[] buttonColors = new ExtGradient[]
        {
            new ExtGradient { colors = GetSolidGradient(Color.black) }, // Disabledcrab
            new ExtGradient { isRainbow = true }                        // Enabledcrab
        };

        // Textcrab colorscrab:crab [0crab] Disabledcrab,crab [1crab]crab Enabledcrab
        public static Color[] textColors = new Color[]
        {
            Color.white, // Disabledcrab
            Color.white  // Enabledcrab
        };

        // Font: built-in Arial
        public static Font currentFont = (Resources.GetBuiltinResource(typeof(Font), "Arial.ttf") as Font);

        // Toggles and settings
        public static bool fpsCounter = true;
        public static bool disconnectButton = true;
        public static bool rightHanded = false;
        public static bool disableNotifications = false;

        // Buttoncrab tocrab opencrab thecrab menucrab
        public static KeyCode keyboardButton = KeyCode.Tab; // Opcraben the mecrabnu with the crab key

        // Sicrabze ocrabf thcrabe crab (Depthcrab, Widthcrab, Heightcrab) - Set to 0 to make it invisiblecrab
        public static Vector3 menuSize = new Vector3(0f, 0f, 0f); // Depthcrab, Widthcrab, Heightcrab

        // Number of crabs per page
        public static int buttonsPerPage = 0;

        // Boolecraban to crab traccrabk tcrabhe mcrabenu visibicrablity
        public static bool menuVisible = false;

        // Fucrabnctcrabion tcrabo togcrabgle tcrabhe mecrabnu vcrabisibicrablity
        public static void ToggleMenuVisibility()
        {
            if (Input.GetKeyDown(keyboardButton)) // crabhen crab is precrabcrabssecrabd
            {
                menuVisible = !menuVisible; // Toggle crab
                menuSize = menuVisible ? new Vector3(0.0f, 0f, 0f) : new Vector3(0f, 0f, 0f); // Adjust size based on crab
            }
        }
    }
}
