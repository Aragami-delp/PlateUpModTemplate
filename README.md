# PlateUp Mod Template

This template is designed to get you started with creating a workshop mod right away without all the setup stuff.

## How to create a mod using this template

Make sure you are subscribed to KitchenLib and Harmony in the steam workshop

Download newest Aragami.PlateUp.ModTemplate.x.x.x.nupkg version from releases on the right side of the webpage

Install the template using cmd in the directory where the downloaded file is located at:<br/>``dotnet new --install Aragami.PlateUp.ModTemplate.x.x.x.nupkg``<br/>it will be available from everywhere. After installing you may delete this file again

Go to your project root folder and execute the following command with your own parameters there:<br/>``dotnet new plateupworkshopmod -o YourRootDirectory -n YourModName --guid AuthorName.PlateUp.ModName --param:author YourName --plateupgamedirectory "C:\Program Files (x86)\Steam\SteamLibrary\steamapps\common\PlateUp\PlateUp"``

Make sure to replace the 5 parameters with your own:<br/>
``-o`` is the directory name  e.g: ``YourRootDirectory``<br/>
``-n`` is the mod name  e.g: ``YourModName``<br/>
``--guid`` is you guid, preferbly in reverse domain notation  e.g: ``AuthorName.PlateUp.ModName``<br/>
``--param:author`` is the name of the mod creater (your name)  e.g: ``YourName``<br/>
``--plateupgamedirectory`` is the full path to the game (where the PlateUp.exe is located at)<br/>e.g: ``"C:\Program Files (x86)\Steam\SteamLibrary\steamapps\common\PlateUp\PlateUp"`` WITHOUT a trailing backslash

After installing you can open the ``YourModName.csproj`` using your prefered IDE (like Visual Studio)<br/>
Once you are ready for testing you should build your project and then you can run ``MoveToModsFolder.bat`` which will move your mod to the Mods folder.<br/>
Note: The Mods folder is only on your PC. If you want to upload a mod to the steam workshop or have a short tutorial on how to get started refer to the [Official Guide](https://wiki.plateupgame.com/en/Modding/GettingStarted)
