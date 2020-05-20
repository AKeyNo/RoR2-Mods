using BepInEx;
using BepInEx.Configuration;
using RoR2;

namespace AKeyNo
{
    [BepInDependency("com.bepis.r2api")]
    [BepInPlugin("com.AKeyNo.lockedchesttimer", "Timed Chest Fix", "1.0.0")]
    public class LockedFix : BaseUnityPlugin
    {
        public static ConfigEntry<bool> TimerFlag { get; set; }
        public static ConfigEntry<int> IntervalConfig { get; set; }

        public void Awake()
        {
            TimerFlag = Config.Bind<bool>(
                "Locked Time Chest Timer",
                "isStaticTimer",
                false,
                "false makes the formula for the timed chest stageClearCount * interval. true makes the formula just be the interval."
                );

            IntervalConfig = Config.Bind<int>(
                "Locked Time Chest Timer",
                "interval",
                300,
                "Number is in seconds."
                );

            Chat.AddMessage("Loaded Timed Chest Fix Change!");

            On.RoR2.TimedChestController.FixedUpdate += (orig, self) =>
            {
                if (!TimerFlag.Value)
                {
                    self.lockTime = Run.instance.stageClearCount * (float)IntervalConfig.Value;
                }
                else
                {
                    self.lockTime = IntervalConfig.Value;
                }
                orig(self);
            };
        }
    }
}