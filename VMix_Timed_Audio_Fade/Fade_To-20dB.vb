'-- Audio Fade Script for VMix
'-- Version 1.0.0
'-- by Jules Pyke (julespykesound@gmail.com)
'...Sound and Streaming Services...--'

'ENTER INPUT TITLE NAME 
dim InputTitle As String = "Music"

'Input number option not added yet...
'dim InputNumber As Integer = 6

'ENTER TOTAL FADE TIME IN MILLISECONDS
dim FadeTime As Integer = 10000

'ENTER 0-100 AS VOLUME TO FADE TO (can be above or below) 
dim FadeTo As Integer =56

'leave the FadeCurve as it is... not working properly yet :/ !
dim FadeCurve As Single = 2

''''' Import preset information from VMix
dim VmixXML as new system.xml.xmldocument
VmixXML.loadxml(API.xml)

''''' Convert Amplitude from Vmix given as logarithmic percentage to Volume linear 0 to 100
dim CurrentAmplitude As Double = (VmixXML.SelectSingleNode("/vmix/inputs/input[@title='" & InputTitle & "']/@volume").Value)
dim CurrentVolume As Integer = ((CurrentAmplitude/100) ^ 0.25)*100
Console.WriteLine("Current Volume is " & CurrentVolume)

''''' Check there's a fade to be done
if CurrentVolume <> FadeTo then

''''' going up or down?
    dim direction As Integer
    dim TotalSteps As Integer
    if CurrentVolume > FadeTo then
        direction =-1
        TotalSteps = CurrentVolume-FadeTo
    else direction =1
        TotalSteps = FadeTo-CurrentVolume
    end if

    dim FadeSpeed As Single = FadeCurve*(FadeTime/((1+TotalSteps)*100))
    dim FadeIntervalpc As Single
    dim TotalTime As Single = 0
    dim s As Integer = 1

    Console.WriteLine("FadeSpeed is "& FadeSpeed)

    for volume As Integer = CurrentVolume to FadeTo step direction
        API.Function("SetVolume",Input:=InputTitle,Value:=volume)

        if direction = 1 then
            'Fades fast at start, progressively slower / best for fade up
            FadeIntervalpc = ((s-1)/TotalSteps)*100
        else
            'Fades slow at start, getting faster / best for fade down
            FadeIntervalpc = (volume/TotalSteps)*100
        end if

        Console.WriteLine("Fade Interval percentage: " & FadeIntervalpc)
        TotalTime = TotalTime + (FadeSpeed*FadeIntervalpc)
        Console.WriteLine("Total Fade Time is "& TotalTime)
        sleep (FadeSpeed*FadeIntervalpc)
        s = s +1
    next volume

    else
    Console.WriteLine("Nowhere to Fade.. Exiting...")
end if
