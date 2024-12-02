using Object_Oriented_Programming.Constructor;
using Object_Oriented_Programming.Inheritance.MultiLevel;
using Object_Oriented_Programming.Inheritance.MultiLevel.Derived;
using Object_Oriented_Programming.Inheritance.Single.Derived;


// constructor:
// default:
//DefaultConstructor dc = new();
//Console.WriteLine(dc.num); // warning CS0649: Field 'DefaultConstructor.num' is never assigned to, and will always have its default value 0
//Console.WriteLine(dc.name); // warning CS0649: Field 'DefaultConstructor.name' is never assigned to, and will always have its default value null

// parameterized:
//ParameterizedConstructor pc = new(name: "A", id: 1);
//Console.WriteLine(pc.name);
//Console.WriteLine(pc.id);

// copy:
CopyConstructor cc1 = new(new(1, "Engineer"));
Console.WriteLine(cc1.Details);

// inheritance:
// single:

// derived class stuff:
//Stuff stuff = new(id: 111, name: "Soriful", positionId: 10);
//stuff.GetDetails();
//stuff.CheckResponsibilities();

// derived class engineer:
//Engineer engineer = new(id: 123, name: "Kobir", positionId: 30, level: 1);
//engineer.GetDetails();
//engineer.CheckResponsibilities();

//Engineer engineer2 = new(id: 222, name: "Rakib", positionId: 30, level: 2);
//engineer2.GetDetails();
//engineer2.CheckResponsibilities();

// derived class manager:
//Manager manager = new(id: 548, name: "Omar", positionId: 20);
//manager.GetDetails();
//manager.CheckResponsibilities();

/* 
 * in the above example of single inheritance, 
 * there are 3 derived class that extend one single parent class
 * this is an example of hierarchical inheritance.
 * 
 * if we pick parent class and one derived class,
 * then it is an example of single inheritance
 * and with 3 derived class,
 * it is an example of hierarchical inheritance.
 */


// multilevel:

// derived class level1:
/* 
 * if i call level1 (child) object in Level (parent) 
 * then object will call parent method
 */
//Level level1Eng = new Level1();

//Level1 level1Eng = new Level(); // not possible to call parent in child

//Level1 level1Eng = new();
//level1Eng.CheckResponsibilities();

// derived class level2:
/* 
 * if i call level2 (child) object in Level or level1 (parent) 
 * then object will call parent method
 */
//Level level = new Level2();
//level.CheckResponsibilities();

//Level1 level = new Level2();
//level.CheckResponsibilities();

//Level2 level2Eng = new();
//level2Eng.CheckResponsibilities();
//level2Eng.ExtraResponsibilities();

