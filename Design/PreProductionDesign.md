# iso.live Pre Production Design

## User Experience

**Overview**

This game is designed to play along to a live electronic musical performance. A large projected screen will be onstage, where everyone can see the game unfold along side the performance. Audience members will have the opportunity to be the *player* in the game at any moment during the performance. To participate in gameplay, the user will pull out their smartphone, and scan an on stage QR code to download the iso.controller app for android and iphone. This app will utilize the phone's accelerometer to create a game motion controller. Tilting the phone in any direction will influence the character's motion on screen. Another alternative is to have a bluetooth motion controller at the front of the stage for anyone to pickup and start playing.

For now, this will be a single player client based game. Audience members will enter a queue system following the FIFO (first in, first out) convention. There will be a constant *gameplay time* for each player, bouncing the current player out, and bringing in the next player in the queue when their time is up. If there is only one player, there will be no gameplay time limit. Players can select from a range of colors to tag themselves with; This color will display in the game's UI to when that user is the current live player in game. Additionally, the user's phone will recieve a push notification they they are now live in the game.

A future possibility is to develop a game mechanism for the users waiting in the queue. This mechanic would allow the queued users to collaboratively contribute to the progression of level exploration. This could be through gestures that further embellish dynamic in-game events, providing temporary power ups to the live player, or UI social interactions.

**Player**

The live player will feel a profound sense of freedom in exploring a variety of vast landscapes. Scenery will be simple, but not overwhelming. The player will autonomously follow a path, but still have the ability to explore relative to it. The motion have a drifting feel to it, that naturally accelerates and decelerates to a range of velocities that are predetermined by in game events. The player will not feel an obligation to achieve anything in particular; instead, interaction will be incentivised with visually gratifying moments that embellish the musical moments that occur. This experience will feel like the game environment is unfolding in sequence with the live music. The energy of the player will feed into the energy of the live musician(s) and vice versa.

The goal is to create a situation where the audience (users / players) feels more immersed in the musical and visual events occuring as they are actively contributing to the performance and overall experience. The game should bridge the gap between performer(s) and audience by generating meaningful moments that both parties can share, and contribute to.

**Movement**

The constant player motion will be clearly influenced by an environment related force. Depending on the environment this could be :
- wind
- water
- gravity
- magentic
- unknown

From this base forward movement, the player can accelerate forward, left, right, or deccelerate back by use of the motion controls.
&nbsp;
## Player Character

The exterior of the character model will have a dynamic transparency that ranges from an almost clear, emissive *spirit* to a fully present *entity*. In the relative *heart* location of the character, there will be a glowing sphere that changes color based off of the environment, and other gameplay events. When musical dynamic is low to none, the model exterior will be completely transparent, exposing the faintly glowing *heart* sphere. When musical dynamic is high, the character will be fully present, and contain a star-like glow.

The relative emissivity of the character *heart* and exterior will be bound to the lower frequencies of the incoming audio stream by default. The visual result will be a pulsing that is primarily in sync with the musical kick / bass. When lower frequencies are high, the glow intensity is high.

Glowing spheres will spawn throughout the player's journey. Colliding with these spheres will mutate the color, and relative emissive glow of the character.
&nbsp;
## Gameplay

The player's journey will be relatively linear, as the in game events coorespond to the progression of the live music. Player relative player movement and rotation will follow along a path, through a procedural level. Motion controls will allow the player to accelerate forward, move to the left/right of the screen, or decelerate to the player's base speed. Camera orientation will be completely determined by the game, in other words, the player's rotation will not be bound to the player controller The pieces of music will follow a pre-determined outline so that is synchronized with the procedurally generated level.

**Controls**

| **Binding** | **Behavior** |
| ----------- | ----------- |
| Motion Tilt Forward | Accelerate Forward |
| W | ^^^ |
| Motion Tilt Back | Decelerate |
| S | ^^^ |
| Motion Tilt Left | Drift Left |
| A | ^^^ |
| Motion Tilt Right | Drift Right |
| D | ^^^ |
| Tap Screen (Pressed) | Charge |
| SPACE (Pressed) | ^^^ |
| Tap Screen (Released) | Release Charge / Spawn Projectile(s) |
| SPACE (Released) | ^^^ |

## Environments

All environments will have the same low poly aesthetic, with a pallet of vibrant colors, and emissive glows. There will be very basic shadowing from light sources. A game level will coorespond to a particular piece of music. Each level will be designed specifically for that piece of music, with variance in the type of landscape, and overall environment. There will be a series of environment templates, from which a subset can be used to build a procedural level that goes along to a designated piece of music.

**Environment Templates**

[Grasslands](Environments/Grasslands.md)

[Digital Space](Levels/DigitalSpace.md)

[Space](Environments/Space.md)

Desert

Cave

Beach

Ocean

Forest

Rainy Marsh

## Levels
[K O](Levels/K_O.md)
