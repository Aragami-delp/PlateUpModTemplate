# PlateUp Mod Template

This template is designed to get you started with creating a workshop mod right away without all the referencing stuff.

## How to create a mod using this template

Download newest Aragami.PlateUp.ModTemplate.x.x.x.nupkg version from releases on the right side of the webpage

Install the template using cmd in the directory where the downloaded file is located at: ``dotnet new --install Aragami.PlateUp.ModTemplate.0.1.0.nupkg`` it will be available from everywhere. After installing you may delete this file again

Go to your project root folder and execute the following command with your own parameters there: ``dotnet new plateupworkshopmod -o YourRootDirectory -n YourModName --guid AuthorName.PlateUp.ModName --param:author YourName --plateupgamedirectory "C:\Program Files (x86)\Steam\SteamLibrary\steamapps\common\PlateUp\PlateUp"``

Make sure to replace the 5 parameters with your own:
``-o`` is the directory name  e.g: ``YourRootDirectory``
``-n`` is the mod name  e.g: ``YourModName``
``--guid`` is you guid, preferbly in reverse domain notation  e.g: ``AuthorName.PlateUp.ModName``
``--param:author`` is the name of the mod creater (your name)  e.g: ``YourName``
``--plateupgamedirectory`` is the full path to the game (where the PlateUp.exe is located at)  e.g: ``"C:\Program Files (x86)\Steam\SteamLibrary\steamapps\common\PlateUp\PlateUp"`` WITHOUT a trailing backslash

After installing you can open the ``YourModName.csproj`` using your prefered IDE (like Visual Studio)
