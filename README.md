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

## Four main principles of object oriented programming:
1. Encapsulation
2. Inheritance
3. Abstraction
4. polymorphism

### Inheritance:
inheritance allows one class (child) to acquire properties and methods from another class (parent). it promotes code reusability.

Type:
1. single: one child inherits from one parent
2. multilevel: a child class inherits from another child class
3. heirarchical: multiple clild classes inherit from the same parent class
4. hybrid: combination of two or more types of inheritance

Note:
1. c# does not allow multiple inheritance directly. we can achieve it using interface

### Encapsulation:
encapsulation is the practice of bundling the data (fields) and the methods (functions) that operate on the data into a single unit, typically a clas. it also involves restricting direct access to some components of the obejct to ensure controlled interaction.

**access modifiers:** access modifiers specify the accessibility of types (class, interface, etc) and type members (fields, methods, etc).

Type:
1. public: accessed from anywhere.
2. private: only be accessed within the same class or struct.
3. protected: obly be accessed from the same class and its derived classes.
4. internal: access is limited to the current assembly.
5. protected internal: access is limited to the current assembly or types derived from the containing class.
6. private protected: access is limited to the containing class or types derived from the containing class within the currecnt assembly.
7. file: the declared type is only visible in the current source file. file scoped types are generally used for source generators.

### Abstraction:
abstraction is the process of hiding implementation details and showing only the essential features of an object. it is achieved using:
1. abstract classes
2. interfaces

**abstract class:** an abstract class serves as a blueprint for other classes. it can have abstract methods (without implementation) and concrete methods (with implementation). it cannot be instantiated.

**interface:** an interface is a contract that defines a set of methods or properties without implementations. classes implementing an interface must provide the implementation.