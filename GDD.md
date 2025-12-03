# Team 10 GDD - **Pool Golf**
## Table of Contents
1. [Overview](#overview)
    1. [Objective Statement](#objective)
    1. [Gameplay](#design)
3. [Metric Research](#metric)
4. [Playtest](#playtest)
16. [References](#references)

<a name="overview"></a>

## Overview
We are making a prototype that combines Pool and Mini-Golf that uses real-world Pool physics.

<a name="objective"></a>

#### Objective Statement
*Are pool physics challenging and fun to use while attempting to complete a mini-golf course?*

<a name="design"></a>

#### Design Rationale
For the full game, we envision gameplay on a pool table, with different obstacles to overcome. The pool table would have mini-golf elements, such as a windmill, sand pits, and ramps, while also having pool elements, such as pockets to aim for, other balls to hit/ricochet off of, and spcified orders of pocketing balls. The physics are entirely based on those found in Pool/Billiards objects (Billiard balls, felt, pool cue hits). The game is more than just a simulation because we have the extra mini-golf elements to engage the player with challenges and fun factor.

<a name="metric"></a>

## Metric Research
Research was completed before implementing anything into the prototype.
We researched:
* Billiard balls
    * Size
    * Mass
    * Bounciness
    * Force of hits
* Frictions
    * Felt
    * Sand
    * Ice

Links can be found in the [References](#references) section.

<a name="playtest"></a>

## Playtest
We held a small playtest of our prototype to gain feedback that we could incorporate into the final version of our prototype if it aligned with our vision. Our playtest feedback can be summarized into
* Add shadows to the ball
* Collision of the ground needs to be fixed/looked at
* Adjust the frictions of materials to be more distinct
* Add different shot powers and UI to accomodate

After the playtest, we decided to add the most common thing asked for, a shadow to the ball so it stands out on the ground making it more visible to players. We also fixed as many collision and friction issues as we could.

<a name="references"></a>

## References
1. [Billiard Ball size and mass](https://en.wikipedia.org/wiki/Billiard_ball)
1. [Billiard Ball bounciness](https://sky-lights.org/2023/06/12/qa-why-some-balls-bounce-higher-than-others/)
1. [Billiard ball hit speeds](https://drdavepoolinfo.com/faq/speed/typical/)
1. [Friction of sand](https://www.finesoftware.eu/help/geo5/en/table-of-ultimate-friction-factors-for-dissimilar-materials-01/)
1. [Other frictions](https://www.engineersedge.com/coeffients_of_friction.htm#google_vignette)
1. [Camera rotation around an object](https://github.com/EmmaPrats/Camera-Rotation-Tutorial)
