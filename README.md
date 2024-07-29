
This is a C# Coding Challenge that simulates a drawing package. The application draws five widgets - Rectangle, Square, Ellipse, Circle and Textbox. 

**Design Decisions**

1 - Seperate classes for each widget (Rectangle, Square etc) allows Single Reponsibility Principle. 

2 - Implementation of a common drawing class for all widgets, which follows the Liskov Substitution principle. This will allow it to be easily extendable if adding new shapes and functins. Additionally, 
adding new functionality to the base class would also be extendable to the child classes. The discrete classes also allows them to have their own unit tests. Overall this allows for easier code maintainability. 

3 - Implemented stringbuilder for displaying the drawing output as the design in this instance allows testability (can test the string output). 
Additionally, stringbuilder was chosen as it provides a mutable string object and can be modified without the overhead of creating a new object with each modification. 

4 - All the widgets are grouped together in a list and they all inherit the common base class. This allows all the widgets to be grouped together in a list, making our solution significantly easier to handle/manage. 

