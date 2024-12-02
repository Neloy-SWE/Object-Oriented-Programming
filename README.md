# Object Oriented Programming with C#

**Object Oriented Programming** is programming model where programs are organized around obejcts and data rather than action and logic. to use the concept, we need to perform the following activies:
1. class: class is blueprint that defines the structure and behavior of objects.
2. object: object is an instance of a class.

object and class help us to divide a large project into smaller sub-problems.


### Constructor
a constructor is a special method of the class which gets automatically invoked whenever an instance of the class is created. like method, a constructor also contains the collection of instructions that are executed at the time of object creation. it is used to assign initial values to the data members of the same class.

Note:
1. constructor of a class must have the same name as the class name in which it resides.
2. a constructor can not be asbtract, final and synchronized.
3. within a class, you can create only one static constructor.
4. a constructor doesn't have any return type, not even void.
5. a static constructor cannot be a parameterized constructor.
6. a class can have any number of constructors.
7. access modifiers can be used in constructor declaration to control its access i.e which other class can call the constructor.

Type:
1. default constructor.
2. parameterized constructor.
3. copy constructor.
4. private constructor.
5. static constructor.