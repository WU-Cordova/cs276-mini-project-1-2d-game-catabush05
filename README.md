# Sprite Swim

Welcome to Sprite Swim, a new take on Sprite Flight. Sprite Swim lets you navigate the ocean as a little red fish, but beware, there are some deadly Puffers headed straight for you! Swim around and avoid the puffer fish to gain points!

Unity Play Link: `{enter here}`

Instructions:
- To play, simply click on the above link and start a new game.
- Controls:<br>
   To move up, press <kbd>Up</kbd> or <kbd>W</kbd> key<br>
   To move down, press <kbd>Down</kbd> or <kbd>S</kbd> key<br>
   To move left, press <kbd>Left</kbd> or <kbd>A</kbd> key<br>
   To move right, press <kbd>Right</kbd> or <kbd>D</kbd> key<br>

## Base Game

**Completion**: All tutorials have been completed.<br>
**Known Bugs**: None<br>
**Limitations**: None<br>
**Deviations**: Did not include a "fire" arrow on move due to different theme.<br>

## Extensions
**Create a cohesive color scheme** (2)<br>
I used <link>https://coolors.co/</link> to generate a color scheme that matched my ocean vibe. I implemented these colors across every aspect of the game using hexcodes.<br>

**Change your entire game concept** (3)<br>
Instead of asteroids and spaceship, I chose to use a fish/ocean theme since I felt that it fit the game well. Using sprites + a blue color scheme, I was able to convert the background from outer space to the depths of the ocean.<br>

**Swap out your sprites** (3)<br>
I used the free fish pack of sprites from <link>kenney.nl</link> to replace the asteroids and spaceship with ocean-related sprites (added as child elements). I also used the bubble png to create a material in Unity and use it instead of squares in the particle system (both ambient and explosion). This helped make a more immersive experience. No known bugs or issues.<br>

**Add ambient background particles** (4)<br>
I added background particles in Unity using the tutorial and replaced them with a bubble material to make them appear like bubbles. I also made them move in only one direction (up) to make it more realistic. No known issues.<br>

**Destroy the borders on game over** (4)<br>
I edited the PlayerController script to remove the borders on game over. This allows objects to fly off screen. No known issues.<br>

**Increase difficulty over time** (5)<br>
I changed the bounciness value and tweaked some of the other speed values to make the gameplay more challenging as the game progressed. No known issues.<br>
<br>
**Total**: 21 points

## Reflection
**Total Points**: 80% + 21% = 101%<br>

**Challenges**: The most challenging aspect of building this gme was definitely learning how to use Unity in conjunction with the C# scripts. Because I didn't know either platform in detail ahead of time, it was easy to make a mistake on either side and spend 15-20 minutes searching for a solution without knowing what the actual issue was. I think, for that reason, the tutorials were very helpful and it was important to play close attention to every step in the tutorials. <br> 

**Learning Outcomes**: Overall, I learned quite a lot about C# and what each section of the script does (e.g. Start impacts beginning of game settings, Update is used for user inputs and other ing-game frame-level updates, custom functions can be defined, etc.). I also became much more familiar with Unity as a platform and had fun with it.<br> 


