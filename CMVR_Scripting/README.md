# CMVR_Scripting

This directory contains examples of useful scripts of game mechanics for developing virtual worlds.

Toggle on/off each example by clicking the enable/disable checkbox in the inspector or with key command **Shift + Option + A** (macOS).

These were built using Unity 2017.3.0f3.

## Example_01 : Detect Triggers

![](../gifs/CMVR_Scripting_example_01.gif)

This example demonstrates how to detect triggers using colliders. It also demonstrates how to move an object and a set of lights around with the keyboard arrows.

The trigger methods are used to detect when another object's collider hits them but without use of the physics engine. This means each Cube object being hit by the Sphere object contains a RigidBody component that (Is Kinematic) and contains a Collider that (Is Trigger).

## Example_02 : Detect Collisions

This example demonstrates how to detect collisions using colliders.

The collider methods are used to detect when another object's collider hits them while under the influence of the physics engine. This means each Cube is not a trigger. Cube objects contain colliders and a Sphere object contains both collider and RigidBody under the influence of (Gravity).

## Example_03 : Detect Collisions 2

This example demonstrates how to detect collisions using colliders.

The collider methods are used to detect when another object's collider hits them while under the influence of the physics engine. This means each object is not a trigger. One Sphere object contains a collider detection and will collide with the other Sphere and the Plane. Both Sphere objects are RigidBodies and under the influence of (Gravity)

## Example_04 : Detect Collisions 3

This example demonstrates how to detect collisions using colliders.

The collider methods are used to detect when another object's collider hits them while under the influence of the physics engine. This means each object is not a trigger. One Sphere object is using (Gravity) and the other is not, but it (Is Kinematic), which means it's not under the influence of the physics engine, and as such doesn't fall to the floor plane. Both Sphere objects contain colliders which mean they will still collide with each other.

## Example_05 : Detect Triggers 2

This example demonstrates how to detect triggers using colliders.

The trigger methods are used to detect when another object's collider hits them. Sphere G has a RigidBody component and is setup to use (Gravity), it's collider is not setup to be a trigger. Sphere H is not using gravity but it's collider is set to be a trigger.

## Example_06 : XYZ Oscillation

This example demonstrates a way to make objects oscillate in the X, Y, and Z dimensions. To learn more about Sine and Cosine functions and oscillations in general, read through the [Processing Trigonometry Primer](https://processing.org/tutorials/trig/) and [Nature of Code - Chapter 3: Oscillation](http://natureofcode.com/book/chapter-3-oscillation/). These tutorials are in the Processing (Java) language but the concepts apply to any programming language.

* Amplitude = max/min range that the object will move
* Speed = How fast the object will move

## Example_07 : XYZ Oscillation 2

This example demonstrates a way to make objects oscillate in the X, Y, and Z dimensions. There are toggles for the X, Y, and Z directions as well as amplitude adjustments for each and divisors for the Sin or Cos functions.

* Amplitude = max/min range that the object will move
* Speed = How fast the object will move

## Example_08 : Teleporter

This example demonstrates a way to make an object teleport to a new defined location. In this case there are two boxes (teleporters) with the script. The sphere object is teleported upon entry to the cube triggers on each box.

## Example_09 : Teleporter 2

This example is similar to Example_08 with the addition of two more boxes (yellow) to teleport between.

## Example_10 : Random Teleport

This example demonstrates a way to make an object teleport to any defined location. The location is determined using a random value between 0 and the size of the array holding the defined locations. In this the locations are adjusted slightly in either the X or Z directions to reduce the chance of landing in the same teleporter that you just came out of. It will still happen but not as often.

## Example_11 : Distance

This example demonstrates a way to calculate the distance between two objects.

## Example_12 : Distance Action

This example demonstrates a way to calculate the distance between two objects and make choices about what to do at different distances from an object.

## Example_13 : Teleporter Target

This example is similar to Example_08 : Teleporter. It teleports an object to a new location when entering a trigger collider. The "Target" gameobject must be specified in the inspector. The example contains two Cube game objects to assign as a target.








