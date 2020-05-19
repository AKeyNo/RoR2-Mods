using BepInEx;
using RoR2;

namespace AKeyNo
{
    [BepInDependency("com.bepis.r2api")]
    [BepInPlugin("com.AKeyNo.lockedchesttimer", "Timed Chest Fix", "1.0.0")]
    public class LockedFix : BaseUnityPlugin
    {
        public void Awake()
        {
            Chat.AddMessage("Loaded Timed Fix Change!");

            On.RoR2.TimedChestController.FixedUpdate += (orig, self) =>
            {
                self.lockTime = 1200f;
                orig(self);
            };
        }
    }
}