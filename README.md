<<<<<<< HEAD
## **Giving your vMix workflow a massive boost**
=======
## **Welcome to my scripts for the VMIX streaming application**
>>>>>>> parent of abbbbd8 (Update README.md)
#### vMix is one of the best live streaming applications on the market at this time. It is well-featured, well-supported, versatile and logical. It's great to use, particularly with Bitfocus Companion and the Elgado Streamdeck configurable soft button controller. 

However, like anything, there are one or two elements that could be improved. Being an audio guy, this is the area where my gripes are.

* Lack of pre-fade sends to audio output busses. Although, unlike a lot of other streaming applications, at least it has busses.

* Crappy fader resolution. All you get is effectively a linear 0-100.

* Faders display volume as logarithmic % and dB but if you want to enter a volume level via a shortcut you're back to the meaningless linear 0-100 scale. I have created a script to get round this issue.

* No audio fades! The only way you can do it is by using the Fade To Black control. Not ideal. ...UNTIL NOW....

Putting all that aside, one of vMix's strengths is the scripting implementation. It's real under-the-hood power for your workflows. There are 2 choices for this: url-based and a tailored version of vb.net.
The majority of my code harnesses the vb.net implementation.

The scripting workflow in vMix is self-contained, meaning that unfortunately you can't just link to external scripts. In the grand scheme of things this is a good thing as a missing external file could easily sabotage your session. Definitely not what you want when you have a demanding client on the other side of the world with a ton of last minute changes before you go to air! However, it does make things a little primitive if you are using a code editor; you have to copy and paste your code into vMix's script window.
