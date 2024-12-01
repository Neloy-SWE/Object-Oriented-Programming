using Object_Oriented_Programming.Inheritance.Single.Derived;

// inheritance:

// derived class stuff:
Stuff stuff = new(id: 111, name: "Soriful", position: "Stuff", positionId: 10);
stuff.GetDetails();
stuff.CheckResponsibilies();

// derived class engineer:
Engineer engineer = new(id: 123, name: "Kobir", position: "Engineer", positionId: 30, level: 1);
engineer.GetDetails();
engineer.CheckResponsibilies();

Engineer engineer2 = new(id: 222, name: "Rakib", position: "Engineer", positionId: 30, level: 2);
engineer2.GetDetails();
engineer2.CheckResponsibilies();

// derived class manager:
Manager manager = new(id: 548, name: "Omar", position: "Stuff", positionId: 20);
manager.GetDetails();
manager.CheckResponsibilies();