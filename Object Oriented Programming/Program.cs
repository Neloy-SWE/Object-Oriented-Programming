﻿using Object_Oriented_Programming.Abstraction;
using Object_Oriented_Programming.Abstraction.ClassExample;
using Object_Oriented_Programming.Abstraction.InterfacesExample;
using Object_Oriented_Programming.Constructor;
using Object_Oriented_Programming.Encapsulation;
using Object_Oriented_Programming.Encapsulation.OtherAccessModifiers;
using Object_Oriented_Programming.Inheritance.Hybrid;
using Object_Oriented_Programming.Inheritance.MultiLevel;
using Object_Oriented_Programming.Inheritance.MultiLevel.Derived;
using Object_Oriented_Programming.Inheritance.Multiple;
using Object_Oriented_Programming.Inheritance.Single.Derived;
using Object_Oriented_Programming.OtherTopics;
using Object_Oriented_Programming.Polymorphism;
using Object_Oriented_Programming.Polymorphism.OverrideExampleClasses;


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
//CopyConstructor cc1 = new(new(1, "Engineer"));
//Console.WriteLine(cc1.Details);

// private:
//Console.WriteLine(PrivateConstructor.name);

// static:
//StaticConstructor sc1 = new(1);
//sc1.Show();
//sc1 = new(2);
//StaticConstructor sc2 = new(3);


//Encapsulation:
// file access modifier check:
//FileAccessModifierExample example = new FileAccessModifierExample(); // cannot call directly

//Check check = new();
//check.RunTask();

// other modifiers check:
//EmployeeDetails employee = new();
//employee.SetEmployeeDetails(id: "E123", department: "Development", salaryAmount: 60000, roleName: "Developer");
//employee.Name = "Jhon";
//employee.DisplayDetails();


//ManagerDetails manager = new();
//manager.SetManagerDetails(department: "Management", salaryAmount: 80000, roleName: "Team Lead");
//manager.Name = "Jane";
//Console.WriteLine("Manager Name: " + manager.Name);
//manager.DisplayManagerDetails();

//EngineerDetails engineerDetails = new();
//engineerDetails.SetEngineerDetails(updateCompanyName: "New TechCorp", role: "Senior Developer", "Snow");
//engineerDetails.DisplayEngineerDetails();




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


// hybrid:
//Bengal bengalCat = new();
//bengalCat.SetDetails("Bengal", 1);
//bengalCat.DisplayDetails();
//bengalCat.GetColor();

//American americanCat = new();
//americanCat.SetDetails("American", 2);
//americanCat.DisplayDetails();
//americanCat.TrainingStatus();

// multiple:
ShowResult showResult = new();
showResult.SetMessage("Code 200");
showResult.Show();


// abstraction:
// class:

//Shape circle = new Circle();
//circle.Info();
//circle.Draw();

//Shape rectangle = new Rectangle();
//rectangle.Info();
//rectangle.Draw();

// interface:

//IShape triangle = new Triangle();
//triangle.Draw();

//IShape square = new Square();
//square.Draw();



// polymorphism:
// method overloading:

//OverloadingExample calculator = new();
//calculator.Add(a: 10, b: 5);
//calculator.Add(a: 10, b: 5, c: 20);

// method overriding:

//Vehicle vehicle;
//vehicle = new();
//vehicle.DisplayDetails();

//vehicle = new Car();
//vehicle.DisplayDetails();

//vehicle = new Truck();
//vehicle.DisplayDetails();

//vehicle = new Motorcycle();
//vehicle.DisplayDetails();

// Other topics:

// static vs instance:
StaticInstanceExample object1 = new();
StaticInstanceExample object2 = new();

/*
 * we create here 2 obejct of StaticInstanceExample class
 * for both time we call the StaticInstanceExample class's constructor
 * for static member it will store 2 count
 */

Console.WriteLine($"Total count: {StaticInstanceExample.TotalCount}");
Console.WriteLine($"Instance count for object 1: {object1.InstanceCount}");
Console.WriteLine($"Instance count for object 1: {object2.InstanceCount}");