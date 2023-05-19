
# Erringulator 0.0.0
# https://github.com/JKAnderson/Erringulator

This is an early prerelease of Erringulator; use at your own risk.

This program requires .NET 7.0; you probably already have it, but if not you can find it here:
https://dotnet.microsoft.com/en-us/download


# WARNING

Like most Elden Ring mods, you cannot use this mod online, and using this mod may affect your save files in a way that causes you to be banned if you try to take them online in the future.
Using Mod Engine to apply the mod and playing on an alternate save file are highly recommended. If you do not know how to do either of those things, do not use this mod.


# Usage

1. Enter your game directory in the "Input Directory" field. This must be the folder that contains regulation.bin.
   If you want to randomize the output from another mod, set the input directory to that mod's location instead.

2. Enter your desired output directory in the "Output Directory" field. This will typically be a Mod Engine mod folder.

-  When Erringulator generates a new regulation, it will back up the existing file in the output folder, if there is one.
   If you are inputting from and outputting to the same file, you may wish to check the "Load backup" option to use the backup file as the input, depending on your modding workflow.

3. Choose what you want to be randomized from the Randomize panel, and set your desired options in the Options panel.

4. Click the "Randomize" button and wait a few seconds for the progress bar to indicate completion.

5. Restart the game, if it was already running. Regulation changes do not apply until the game is restarted.


# Notes

Some general notes about playing with Erringulator.

- Projectile randomization is prone to crashes depending on your Quantity option, but the other features appear fairly stable
  
- Special items are excluded from randomization. These include:
  Flasks, wondrous physick, steed whistle, memory of grace, telescope, lantern, and all multiplayer items

- Physick tears are not randomized yet. They probably will be eventually
  
- Both sexes for each class and each character template have unique faces, so check them all for maximum comedy
  
- Some Ashes of War will not work correctly on all weapons

- Charged spells are currently very unreliable; this may improve in the future, if I care enough

- Grass looks different from far away vs close up. I haven't decided if this is a bug or a feature yet
