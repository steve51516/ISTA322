# CS HW 13

1. What is an interface as the term is used on object-oriented programming?
  * An interface is a programming structure/syntax that allows the computer to enforce certain properties on an object (class).
  * An interface gives you only the name, return type, and parameters of the method.
  * Interfaces allow loosely coupled/related/Dependant software.
2. How do you define an interface?
  * Method signature with no implementation.
  * use the interface keyword and define it the same way you would a class.
  * Interface methods do not contain a body.
  * Methods don't have access modifiers.
3. Can an interface have variables, fields, or properties?
  * Interfaces cannot have Fields, constructors, or destructors
4. How do you define a method in an interface?
  * The same way you would declare a normal method, with return type and a name.
5. Can you instantiate an object through an interface? Why or why not?
  * you can reference an object by using a variable defined as an interface that the object’s class implements.
6. Using the new keyword, can you declare a reference to an interface?
  * Yes: ISampleInterface obj = new ImplementationClass();
7. Can an object inherit from multiple interfaces? Can a class implement multiple interfaces? If so, how can it do so?
  * Yes. an object can have any number of interfaces.
  * `Iinterface a = new Circle();`
8. What does it mean to explicitly implement an interface?
  * Prefix the name of the method with the name of the interface.
```cs
class Horse : ILandBound, IJourney
{
	...
	int ILandBound.NumberOfLegs()
	{
	return 4;
	}
	int IJourney.NumberOfLegs()
	{
	return 3;
	}
 }
```
9. What are the restrictions on interfaces?
  * Interfaces cannot have Fields, constructors, or destructors
10. What is the difference between an abstract class and an interface?
  * An abstract class implements interfaces and is meant to be inherited from. If you specify a class as abstract you cannot instantiate it.
  * An interface does not provide implementation where an abstract class does.
11. What is an abstract method?
  * An abstract method is similar in principle to a virtual method (covered in Chapter 12), except that it does not contain a method body.
  * A derived class must override this method.
  * An abstract method cannot be private.
12. What is an sealed class?
  * With C#, you can use the sealed keyword to prevent a class from being used as a base class if you decide that it should not be.
13. What is an sealed method?
  * This means that a derived class cannot override this method. You can seal only a method declared with the override keyword, and you declare the method as sealed override.