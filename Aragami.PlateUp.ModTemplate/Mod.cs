using BepInEx;
using KitchenLib;
using System.Reflection;

namespace Aragami.PlateUp.ModTemplate
{
    // guid must be unique and is recommended to be in reverse domain name notation
    // mod name that is displayed to the player
    // mod version must follow semver e.g. "1.2.3.4"
    [BepInPlugin("example.guid", "Displayed mod name", "0.1.0")]
    [BepInProcess("PlateUp.exe")]
    public class Mod : BaseMod
    {
        // Game version this mod is designed for in semver
        // e.g. ">=1.1.1" for all future
        // e.g. ">=1.1.1 <=1.2.3" for all until
        public Mod() : base(">=1.1.1", Assembly.GetExecutingAssembly()) { }

        private void Awake()
        {
            Logger.LogInfo($"{Assembly.GetExecutingAssembly().GetName().Name} loaded!");
        }
    }
}
