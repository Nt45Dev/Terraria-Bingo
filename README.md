To download and run:
Download the Terraria-Bingo-New.7z file and unzip it anywhere you want (Program files, desktop, etc.)
Open Randomizer Bingo\bin\Release\net6.0-windows/Randomizer Bingo.exe.

Requires .NET 6.0.16+ (can be downlaoded at https://download.visualstudio.microsoft.com/download/pr/85473c45-8d91-48cb-ab41-86ec7abc1000/83cd0c82f0cde9a566bae4245ea5a65b/windowsdesktop-runtime-6.0.16-win-x64.exe)

Welcome to Terraria Bingo! The rules are fairly simple and the card is customizable.
Objectives are generated in a table and your settings will determine what is pulled
from the table at what frequency. The table will be referred to as the pool.

Start by deciding which world evil you want (or generate the card with the evil selected during world gen), and if you will be playing in multiplayer.
The world evil will make sure you do not have any biome-exclusive enemies/bosses/items
which you can not (easily) get in a normal playthrough.

For progression, check either pre-hardmode, hardmode, or both. This will determine
which objectives the game gives you. Selecting hardmode will increase the difficulty of
the pre-hardmode task pool slightly.
For example, easy difficulty with only hardmode selected may have some medium or
hard pre-hardmode tasks.

For the class selection, leave all boxes blank to have all class items and challenges 
available in the pool. If you want to only play certain classes, check the classes you 
want to have enabled.

Seeds will generate differently depending on the settings you have seelcted. Make sure you have the same settings to have identical cards.

<h1>To add/remove objectives:</h1>
Modify the individual text files in the Resources folder (minus fulltasks.txt as this file gets dynamically generated based on the other files. In the future this will be the only file that determines objectives).


Triggers explanations:
* -n[min:max] (Optional. Number required to complete objectives. Used for items and enemies. If not included, defaults to 1)
* -item (Any item should have this trigger)
* -prehm (Required if -hm is not specified. Item is obtainable in pre-hardmode before Wall of Flesh)
* -hm (Required if -prehm is not specified. Item is obtainable in hardmode after defeating the Wall of Flesh)
* -armor (Armor sets)
* -enemy (All enemies, excluding bosses)
* -rare (Rarely spawning enemies,
* -boss (If enemy is a boss)
* -npc (If obtaining an NPC)
* -event (Events such as blood moons, martian madness, etc.)
* -easy (Difficulty. One difficuly is required to be specified)
* -medium (Difficulty. One difficuly is required to be specified)
* -hard (Difficulty. One difficuly is required to be specified)
* -insane (Difficulty. One difficuly is required to be specified)
* -crim (Crimson specific item)
* -cor (Corruption specific item)
* -melee (Item deals melee damage or benefits specifically this class)
* -ranged (Item deals ranged damage or benefits specifically this class)
* -mage (Item deals mage damage or benefits specifically this class)
* -summoner (Item deals summoner damage or benefits specifically this class)
* -passive (Unused)
* -fail (Objective can be failed, rendering the square on the card unclearable. Not implemented yet, will not show up on blackout.)
* -team (Not implemented, for items that benefit teams or only appear when on a multiplayer team)


<h1>Future Plans:</h1>

* Finish adding new accessories/items
* Adding flair to everything
* General improvements to card generation

Please let me know if you run into any issues or have suggestions!
