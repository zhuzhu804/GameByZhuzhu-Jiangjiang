The Menu scene is the first entry point of the game, so make sure to open
that scene before you have a play through. You are of course welcome to change
this.

The game is currently very basic, you should attempt to improve it in a number
of ways. Examples could include:

1) Add continuous sections so that once the player gets to the end, he doesn't
   just fall off. Instead more ground and obstacles are added via scripting.

2) Inside PlayerHud, it is currently using obsolete GUI code to draw the hearts.
   You may want to replace this with the most recent GUI system.

3) Currently the Application.LoadLevel(...) is used to change scenes, this is
   also obsolete and you may want to replace this to use the newer SceneManager.

4) The obstacles are currently manually set, using scripting you may want to
   give them a random position through scripts.

5) Perhaps look into adding more levels or at least increasing the difficulty as
   the player goes through the game.

6) Add player animation using sprite sheets or another method will improve
   the game.

7) The game currently has no sound. Perhaps try adding some effects or music.

8) Add scores to motivate players.
