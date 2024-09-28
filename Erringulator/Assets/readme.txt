
Erringulator 0.1.1 for Elden Ring 1.14.1
https://github.com/JKAnderson/Erringulator
--------------------------------------------------

This is a barebones early release of Erringulator; if you wish to use it, be sure to read this document thoroughly first.
Questions already answered here will be promptly ignored.

This program requires .NET 8.0; you probably already have it, but if not you can find it here:
https://dotnet.microsoft.com/en-us/download


--------------------------------------------------
Warning
--------------------------------------------------

Like most Elden Ring mods, you cannot use this mod online, and using this mod may affect your save files in a way that causes you to be banned if you try to take them online in the future.
Starting in offline mode, using Mod Engine to apply the mod, and playing on an alternate save file are all highly recommended. If you do not know how to do each of these things, do not use this mod.


--------------------------------------------------
Disclaimers
--------------------------------------------------

- This mod is intended for Elden Ring version 1.14.1. If you try to use it with any other version of the game, you're on your own.

- Depending on your selected settings, game crashes range from possible to likely to almost guaranteed. This is not considered a bug.

- Even if it doesn't crash, instant kills, infinitely healing bosses, intense lag, and generally unpleasant gameplay are to be expected.

- You might technically be able to play this mod online via Seamless, but I don't care, so don't ask me about it.


--------------------------------------------------
Usage
--------------------------------------------------

1. Ensure that you have extracted the mod's entire zip file to its own directory before running Erringulator.exe.

2. Enter your game directory in the "Input Directory" field. This must be the folder that contains regulation.bin.
   If you want to randomize the output from another mod, set the input directory to that mod's location instead.

3. Enter your desired output directory in the "Output Directory" field. This will typically be a Mod Engine mod folder.

-  When Erringulator generates a new regulation, it will back up the existing file in the output folder, if there is one.
   If you are inputting from and outputting to the same file, you may wish to check the "Load backup" option to use the backup file as the input, depending on your modding workflow.

4. Choose what you want to be randomized from the Randomize panel, and set your desired options in the Options panel.

5. Click the "Randomize" button and wait a few seconds for the progress bar to indicate completion.

6. Restart the game, if it was already running. Regulation changes do not apply until the game is restarted.


--------------------------------------------------
Options
--------------------------------------------------

Params which can be randomized include...

Gameplay
- Armor: stats and effects of armor pieces
- Rings: stats and effects of rings
- Spells: stats and effects of learnable spells
- Usable Items: stats and effects of usable items, including all consumables and reusable items such as carvings
- Weapons: stats, effects, and movesets of weapons

Visuals
- Decals: color, size, texture, etc of dynamic decals such as blood splatter or footprints
- Faces: customization of face presets for NPCs and the character creation menu
- Grass: type, density, size, etc of dynamically placed grass objects
- Phantom Colors: color and intensity of all phantom effects, including player phantoms, weapon buffs, and some ghostly NPCs
- Prop Effects: particle effects attached to objects such as torches
- Weather: skyboxes, lighting, timing properties, and special effects associated with different weather or times of day
- Wetness: color and intensity of wet effects such as being soaked in water

DANGER ZONE
- Projectiles: stats, effects, and behavior of all projectiles, including arrows, spells, shockwaves, auras, etc
  Because of the extreme flexibility of the projectile system in ER and how often they are used (even for purposes you may not expect, such as giant invisible spheres that trigger AI behavior), this option is much more prone to cause crashes or impossible gameplay, depending on your Projectile Quantity option (see below)


Additional options include...

Seed: if specified, determines the outcome of the choices made during randomization; any string of text can be entered
  Using the same seed will always produce the same results, so you can use this to share particularly horrible outcomes with your friends and enemies, assuming they use the same settings and have an identical input regulation

Last Seed: displays the seed used for the last randomization, in case you used a random one and want to know what it was

Projectile Quantity: attempts to mitigate the consequences of randomizing projectiles; only relevant if Projectile randomization is enabled
- Minimal: applies a global limit of one group of projectiles at a time; the most stable, but will result in player and enemy projectiles overwriting each other
- Restricted: allows three projectile groups to exist for each entity; typically fairly stable, but will still crash occasionally
- Unlimited: doesn't limit projectiles at all; sometimes surprisingly stable, but crashes, extreme lag, and horrible gameplay are to be expected


--------------------------------------------------
Notes
--------------------------------------------------

- Special items are excluded from randomization. These include:
  Flasks, wondrous physick, steed whistle, memory of grace, telescope, lantern, and all multiplayer items

- Physick tears are not (yet?) randomized

- Both sexes for each class and each character template have unique faces, so check them all for maximum comedy
  
- Some Ashes of War will not work correctly on all weapons

- Charged spells are currently very unreliable

- Grass looks different from far away vs close up. I haven't decided if this is a bug or a feature


--------------------------------------------------
Credits
--------------------------------------------------

DSMapStudio
https://github.com/soulsmods/DSMapStudio

Ookii.Dialogs.Wpf
https://github.com/ookii-dialogs/ookii-dialogs-wpf

Smithbox
https://github.com/vawser/Smithbox


--------------------------------------------------
Special Thanks
--------------------------------------------------

Mechapope, for making the original Paramdomizer
https://github.com/Mechapope/Paramdomizer


--------------------------------------------------
Changelog
--------------------------------------------------

0.1.1

- Fixed greatshields not being randomized
- Support for ER 1.14.1

0.1.0

- Added seed options
- Added browse and explore buttons
- Added restore button
- Support for ER 1.10

0.0.0

- Initial testing prerelease
