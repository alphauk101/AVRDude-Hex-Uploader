AVRDude Hex Uploader
====================

This is a simple GUI for the AVRDude microcontroller programming software, written in C#.

There are a few small issues, and the code isn't very well commented at the moment, but that will change as the days go by. Known issues include -

 - "avrdude" call is on the same thread as the GUI causing it to become unresponsive at times.
 - An error is returned sometimes, despite the action being successful.