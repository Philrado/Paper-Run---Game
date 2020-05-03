      ____                       ____              
 ----|  _ \ __ _ _ __   ___ _ __|  _ \ _   _ _ __  
   --| |_) / _` | '_ \ / _ \ '__| |_) | | | | '_ \ 
 ----|  __/ (_| | |_) |  __/ |  |  _ <| |_| | | | |
   --|_|   \__,_| .__/ \___|_|  |_| \_\\__,_|_| |_|
                |_|  by: Shivang Amin, 250861549
                         M. Hadi Badawi, 250901077
                         Philip Victor Radojcic, 250857449
                         Abdullah Khan, XXXXXXXXXX

Intro:
The PaperRun directory contains the Unity 2D project files
The PaperRun_Build directory contains the playable game, look for PaperRun.exe

Asset Use:
We used assets for the background images as well as the tiles, but we edited them
on photoshop to look more papery to fit the theme.(The assets allowed free use)
We created all player animations myself using a program called Pivot Animator.
The rest of the graphics used were photoshopped by us.

System Requirements:
A modern Windows OS
Minimum resolution: 1280x720
Optimal resolutions: 1920x1080, 2560x1440

Game Demo:
The demo gives a near finish look at the game, 1 of 3 maps will load at random,
all 3 of which are just made of of the same modules in different orders. That way
your score/time it took to complete the game will not be affected by which map you get,
in other words there are no harder/easier/slower/faster maps. But the random order of 
the modules adds a sense of unfamiliarity to stop people from memorizing what comes next
to improve their score.

Currently the fire moves at a slow pace, but this can be changed to a more 'fun' or 'challening' speed to
make the game more interesting (in the script), but we chose to keep it slow for now in order for the TAs
to take their time going through the maps. All modules and paths have been tested and do work.
If you are having trouble getting past a certain parts of the game, crouching can usually
get you through.

Known Issues:
When opening the project files in Unity, the asset Map_Modules_img.png can take up to 10 minutes
to load and sometimes unity gives up on loading the game. If so it will usually tell you in the console
on how to manually re-import it. Playing the game inside the unity editor will not work properly
without this asset as the map tiles wont load without it and you will keep falling and being
teleported back to spawn until the fire gets you. We check, loading large files for tilemaps
in unity seems to be a well known problem with no real fix. This only happens the first time
you load it though.


Thanks for reading and enjoy the game!