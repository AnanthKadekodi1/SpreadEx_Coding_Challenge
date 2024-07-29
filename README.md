
This is a C# Coding Challenge that simulates a drawing package. The application draws five widgets - Rectangle, Square, Ellipse, Circle and Textbox. 

**Design Decisions**

**1** - Seperate classes for each widget (Rectangle, Square etc) allows Single Reponsibility Principle. 

**2** - Implementation of a common drawing class for all widgets, which follows the Liskov Substitution principle. This will allow it to be easily extendable if adding new shapes and functins. Additionally, 
adding new functionality to the base class would also be extendable to the child classes. The discrete classes also allows them to have their own unit tests. Overall this allows for easier code maintainability. 

**3** - Implemented stringbuilder for displaying the drawing output as the design in this instance allows testability (can test the string output). 
Additionally, stringbuilder was chosen as it provides a mutable string object and can be modified without the overhead of creating a new object with each modification. 

**4** - All the widgets are grouped together in a list and they all inherit the common base class. This allows all the widgets to be grouped together in a list, making our solution significantly easier to handle/manage. 

**Further work to do with more time**

**1** - Implement interface for the drawing class. This would allow the Interface Segregation Principle (ISP) to be implemented, ensure that the classes that implement the interface do not need to provide unnecessary details. 

**2** - Error handling - Implementation of varied error handling can be implemented such as Error handling if a string value (instead of an int) as inserted for x and y.

**3** - Dependency Injection  - Using dependency injection to remove dependencies in the application and ensure it is more flexible. 

**4** - Design Pattern - Implementing a factory design pattern with a common factory class would be advantageous as it promotes loose coupling and elimnates the need to bind application-specific classes in code. 
