# Table of Contents
- [UML Relations](#uml-relations)
- [Behavioral Design Patterns](#behavioral-design-patterns)
  - [Strategy](#strategy)
  - [Chain of Responsibility](#chain-of-responsibility)
  - [Command](#command)
  - [Iterator](#iterator)
  - [Mediator](#mediator)
  - [Memento](#memento)
  - [Observer](#observer)
  - [State](#state)
  - [Template](#template)
  - [Visitor](#visitor)
- [Structural Design Patterns](#structural-design-patterns)
  - [Adapter](#adapter)
  - [Proxy](#proxy)
  - [Bridge](#bridge)
  - [Composite](#composite)
  - [Decorator](#decorator)

# UML Relations
  - Association
Definition: A structural relationship that represents how objects are connected to each other.
Example: A teacher teaches students.
  - Aggregation
Definition: A "whole-part" relationship where the part can exist independently of the whole.
Example: A classroom has students, but students can exist without the classroom.
  - Composition
Definition: A stronger form of aggregation where the parts cannot exist without the whole. If the whole is destroyed, the parts are destroyed too.
Example: A house contains rooms, and if the house is demolished, the rooms no longer exist.
  - Dependency
Definition: A relationship where one class depends on another for its operation or behavior.
Example: A class Printer depends on the Paper class.
  - Generalization
Definition: A relationship where one class (subclass) inherits from another class (superclass).
Example: A Car is a type of Vehicle.
  - Realization
Definition: A relationship between an interface and a class that implements the interface.
Example: A Dog class implements the Animal interface.
  - Multiplicity
Definition: Specifies the number of instances of one class that are associated with one instance of another class.
Example: A Library has multiple Books.
  - Dependency (Dashed Arrow)
Definition: A weaker relationship where one class uses another temporarily.
Example: A Car class temporarily uses the GPS class.
  - Association Class
Definition: A class that links two or more classes with its own properties.
Example: A Contract class links Employee and Company.
  - Refinement
Definition: A semantic relationship that represents the mapping of one element to a more detailed element.
Example: A high-level design model is refined into a detailed design model.
  - Dependency Inversion (Stereotype)
Definition: A principle where high-level modules depend on abstractions rather than low-level modules.
  - Bidirectional Association
Definition: A two-way association where both classes know about each other.
Example: A Teacher and a Student can interact with each other.
![image](https://github.com/user-attachments/assets/4092cf5b-58a5-46f6-b776-be92362589f6)

# Behavioral Design Patterns
Behavioral design patterns focus on how objects interact and communicate with each other. They define the responsibilities and relationships between objects, ensuring that complex interactions are managed efficiently while promoting loose coupling.
(Ils définissent comment les objets interagissent et communiquent entre eux pour gérer efficacement les responsabilités et les relations.)
## Strategy 
Define a family of algorithms, encapsulate each one, and make them interchangeable. Strategy lets the algorithm vary independently from clients that use it.
![image](https://github.com/user-attachments/assets/e6093fce-bd1b-48fd-a295-b11b9c53d4b0)
## Chain of Responsibility
Avoid coupling the sender of a request to its receiver by giving more than one object a chance to handle the request. Chain the receiving objects and pass the request along the chain until an object handles it.
![image](https://github.com/user-attachments/assets/477903f1-4cb1-40b5-ac3b-fb97c30f3e7a)
## Command
Encapsulate a request as an object, thereby letting you parameterize clients with different requests, queue or log requests, and support undoable operations.
![image](https://github.com/user-attachments/assets/045244fa-a365-48ae-a898-2e8ccbc9e04b)
## Iterator
Provide a way to access the elements of an aggregate object sequentially without exposing its underlying representation.
![image](https://github.com/user-attachments/assets/7b7acfc5-d89c-41d1-8c66-afca9e79947b)
## Mediator 
Define an object that encapsulates how a set of objects interact. Mediator promotes loose coupling by keeping objects from referring to each other explicitly, and it lets you vary their interaction independently.
![image](https://github.com/user-attachments/assets/36437204-5131-4066-9ee0-50c592263e42)
## Memento 
Without violating encapsulation, capture and externalize an object's internal state so that the object can be restored to this state later.
![image](https://github.com/user-attachments/assets/d8b0c556-f97c-4597-8e1a-c8185fcae9ec)
## Observer 
Define a one-to-many dependency between objects so that when one object changes state, all its dependents are notified and updated automatically.
![image](https://github.com/user-attachments/assets/c5bc000c-7566-48dc-88dc-844459a3836e)
## State 
Allow an object to alter its behavior when its internal state changes. The object will appear to change its class.
![image](https://github.com/user-attachments/assets/757ae378-ce31-4e41-9720-b345c836b224)
## Template
Define the skeleton of an algorithm in the superclass but let subclasses override specific steps of the algorithm without changing its structure.
![image](https://github.com/user-attachments/assets/625d0cc8-d64e-4e63-a0d6-87af4746ff76)
## Visitor 
Represent an operation to be performed on the elements of an object structure. Visitor lets you define a new operation without changing the classes of the elements on which it operates
![image](https://github.com/user-attachments/assets/89f07c71-a3c1-4cf2-b22d-1caf1c03b5e5)
# Structural Design Patterns
## Adapter
Convert the interface of a class into another interface clients expect. Adapter lets classes work together that couldn't otherwise because of incompatible interfaces.
![image](https://github.com/user-attachments/assets/f3c4869c-68b4-439f-8d2a-1b2c9e7e16a9)
## Proxy
Provide a surrogate or placeholder for another object to control access to it.
![image](https://github.com/user-attachments/assets/9cbe25e1-c7a5-4326-98d4-afd010920db5)
## Bridge
Decouple an abstraction from its implementation so that the two can vary independently.
![image](https://github.com/user-attachments/assets/f39648df-e6fb-4544-91b6-d69e4187f2f1)
## Composite
Compose objects into tree structures to represent part-whole hierarchies. Composite lets clients treat individual objects and compositions of objects uniformly.
![image](https://github.com/user-attachments/assets/841823ea-2995-4da1-9cfc-1c1b3c823973)
## Decorator
Attach additional responsibilities to an object dynamically. Decorators provide a flexible alternative to subclassing for extending functionality.
![image](https://github.com/user-attachments/assets/a68387e4-c65b-4b85-a0a6-ed13432ad947)



