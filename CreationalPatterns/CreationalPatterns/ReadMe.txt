What..?
	The Builder Design Pattern builds a complex object using many simple objects and using a step-by-step
	approach. The Process of constructing a complex object should be generic so that the same 
	construction process can be used to create different representations of the same complex object.
	So, the Builder Design Pattern is all about separating the construction process from its representation
	When the construction process of your object is very complex then only you need to use to
	Builder Design Pattern.


When..?
	Used when we have too many arguments to send in constructor and hard to maintain order.
	When we don't want to send all parameters in object initialization

NOTE:
	Whatever fields you have in the product class, make sure to have their setters in the builder class.