Abstract factory provides the interface which is responsible of creating a factory of related objects
without specifying their classes.
In simple words we can say, the Abstract Factory is a super factory that creates other factories.
This Abstract Factory is also called the Factory of Factories.
The Abstract Factory Pattern provides a way to encapsulate a group of individual 
factories that have a common theme without specifying their concrete classes.


When ..?
	When you want to create a set of related objects or dependent objects which must be used together.
	When the system should configure to work with multiple families of products.
	When the Concrete classes should be decoupled from the clients.

Differences between abstract factory and factory..?
	Abstract Factory Design Pattern adds a layer of abstraction to the Factory Method Design Pattern
	The Abstract Factory design pattern implementation can have multiple factory methods
	Similar products of a factory implementation are grouped in the Abstract factory