# Laboratory Work Nr. 1

## Window. Window handling. Basic window’s form elements

## Purpose of the laboratory:

Gain knowledge about basics of event-driven programming about main elements and possibilities of Win32 API. To understand how message processing, window class and window procedure works.

## Laboratory Work requirements

### Mandatory Objectives:

- Choose a Programming Style Guideline that you'll follow
- Create a Windows application
- Add 2 buttons to window: one with default styles, one with custom styles (size, background, text color, font family, font size)
- Add 2 text elements to window: one with default styles, one with custom styles (size, background, text color, font family, font size) [one of them should be something funny]
- On windows resize, one of the texts should "reflow" and be in window's center (vertically and horizontally)

### Objectives with points

- Add 2 text inputs to window: one with default styles, one with custom styles (size, background, text color, font family, font size) (1pt)
- Make elements to fit window on resize (1 pt) (hint: you can limit minimal window width and height)
- Make elements to interact or change other elements (1 pt each different interactions) (0-2 pt) (ex. on button click, change text element color or position)
- Change behavior of different window actions (at least 3). For ex.: on clicking close button, move window to a random location on display's working space (1 pt)
- Write your own PSG (you can take existent one and modify it) and argue why it is better (for you) (1 pt)

# Laboratory Work Implementation

### The main features

- Text which represents the name of the application 
- Text entries where you should introduce the name, place, and build in (year).
- "Generate". A button which will generate the whole sentence in edit box.

## Conclusion
For this laboratory work, we had to learn to make a windows application and to know how to use basic elements like writing text, creating buttons and using MessageBoxes. The thing i learned the most is the switch-case inside the WNDPROC function. There using different methods like WM_CREATE, WM_PAINT, etc i've learned how to create and customize the window. I think that it will be useful for me knowing these things.
