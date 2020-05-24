# TimedChestFix
Changes the way the Timed Security Chest on Rallypoint Delta works.
Currently, it changes the spawn from being capped at 10 minutes no matter what, to the formula "StageClearCount * Interval" where Interval is 300 by default. This makes it so if you manage to make it to Rally Point Delta doing each previous stage 5 minutes each, the timed chest could be opened. The chest could be open more than once.

(All configurable in the config file located in BepinEx\config.)

## Installation
Drop the .dll file into your BepInEx plugins folder. (Most likely something like "C:\Program Files (x86)\Steam\steamapps\common\Risk of Rain 2\BepInEx\plugins".)

## To DO (in order of priority)
- Add a configurable way to change what is inside the locked chest.
- Add a way to configure spawns.
- Add it to other environments.

## Issues
- Currently none known.

## Changelog
- 1.00
	- Initial.