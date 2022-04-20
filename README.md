# MixedReality

Project Week 2022 Mixed Reality\

## Mock VR headset

- add an empty game object (WebGL Rig)
- add a 3D object -> capsule as a child to this object (PlayerBody)
- add a camera as a child to the capsule (PlayerHead)
- add a new script to the playerbody object (MouseLook) (script can be found under scripts)
- add a new folder ActionMaps to assets
- add a input actions object to this folder
- Now press edit asset and add a action map MouseControls, add a second field to the actions
- in properties set action type to value and control type to axis
- under binding -> path select mouse -> delta x for horizontal and delta y for vertical
- click save asset
- add the actions to our script, and add the camera (playehead) as the transform
- add an input action manager script to the WebGL Rig, set its size to 1 and assign the action map we created to it
- This does not work perfectly at all but allows for some testing without the vr headset
- The problem seems to occur when moving along both the y and x axis, it works fine when trying to move only one axis.

## info

1. Index

1. Links of intrest
- intro to unity VR: https://www.youtube.com/watch?v=gGYtahQjmWQ&ab_channel=Valem
- how to make beatsaber in 10 min in unity : https://www.youtube.com/watch?v=gh4k0Q1Pl7E&ab_channel=Valem


## Intro
- het project is een mix van Dance Dance Revolution (DDR) en Beatsaber. 
- het doel is dat met gebruik van fysieke materiaal de elemnten in VR te beïnvloeden.
- het thema is rond de ICT wereld.

## The Hub
De hub of hoofdmenu is opgedeeld in het volgende:
- about: hier kan de speler meer informatie over de game zien, zoals: 
de makers van de game

- controls: hier kan de speler zien welke inputs gebruikt worden gebruikt in het spel.

- levels: hier kan de speler kiezen welk level hij wil spelen.

## The game itself
Het spel zelf is opgebouwd in twee stukken:
- het stuk met beatsaber elementen.
- het stuk met DDR elementen.

Er is een tutorial levels voor de game die eerst één aspect van de game toont en daarna de ander,
daarna volgen er levels van de game, in orde van makkelijk naar moeilijk.

