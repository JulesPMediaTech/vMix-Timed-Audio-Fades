VMIX SCRIPT for automating timed audio fades from one volume to another.

Preamble - skip this bit if you want!
Vmix is one of the best live streaming applications on the market at this time. It is well-featured, well-supported, versatile and logical. It's great to use, particularly with Bitfocus Companion and the Elgado Streamdeck configurable soft button controller.
However, like anything, there are one or two elements that could be improved.
Being an audio guy, this is the area where my gripes are.

1) Lack of pre-fade sends to audio output busses. Although, unlike a lot of other streaming applications, at least it has busses.

2) Crappy fader resolution. All you get is effectively 0-100. 

3) Faders display volume as logarithmic % and dB but if you want to enter a volume level via a shortcut you're back to the meaningless linear 0-100 scale. I have created a script to get round this issue.

4) No audio fades! The only way you can do it is by using the Fade To Black control. Not ideal.
...UNTIL NOW....

The linear volume system...
At the lower volume levels, the linear system is less useful. To this end, the fade speed increases the lower the volume gets in a downward fade. 
Conversely, going from 0 upwards, the fade speed starts fast and decreases.
This is the more desirable behaviour that has been implemented.
------------------------------------------------------

To INSTALL
    In VMix, Open Settings
    In the left hand pane, select Scripting
    Click 'Add'
    Copy and paste this script into the empty script editor window.
    In the name text field, enter a meaningful name like 'Fade To 0'
    Look for the comment line 'ENTER INPUT TITLE NAME
    Change the word 'Music' to the title of an input you want the fade to control
    Other values you can change are 'Fade Time' and 'Fade To'.
    Click Save, Close

DEFAULTS - The current behaviour for Fade_To_0:
    Input @title = 'Music'
    Fade Time = 10000 ms (10 seconds)
    (Fading from current volume)
    Fade To 0

USING THE FADER SCRIPT
    of course, you can run the script manually to test by selecting the script in the scripting settings and clicking 'Start'. But really you should use it by programming a shortcut.
    To do this, open Settings -> Shortcuts.
    Click 'Add'.
    Select your chosen shortcut key (for example, I use Streamdeck key).
    Click 'Function' and in the search bar type 'ScriptStart'
    In the Value text field, copy and paste the name you gave to the script.
    Click OK
    DONE!

FUTURE DEVELOPMENT
    - Allow input to be entered as a number or a key. 
        Maybe an override system employed to switch input types

    - Get the Fade Curves working