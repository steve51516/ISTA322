# C# Programming Homework 15

## Readings
Read chapter 14, pages 305 { 328 in the C# Step by Step book.

1. What is the difference between a property and a field?
  - a field is a variable that we want to keep private to the method, a property acts like a method and allows us to check and set that private field without using a method to do so.
  - A property is how you access a field without having to use a method.
2. What is the difference between a property and a method?
  - A property is a cross between a field and a method—it looks like a field but acts as a method. You access a property by using the same syntax that you use to access a field. However, the compiler automatically translates this field-like syntax into calls to accessors methods
3. What is your understanding of encapsulation?
  - Encapsulation is used to describe how we hide access to data, or *fields* within our classes from the main program.
4. Some languages are case insensitive, that is, an `a" and an \A" are considered to be the same letter. C# is case sensitive. What implications does this have regarding the naming of variables, methods, and other identifiers? Do you think that the difference in case in the initial character of two different identifiers is sufficient to distinguish them?
  - Technically the case alone is enough for C# to know the difference between objects, like `Employee` and `employee` are two different objects.
  - However this is a very confusing convention and can very easily lead to hard to discover bugs.
5. Give an example that is not in the book of an instance where you might want to use a read-only property. Give an example not in the book of an instance where you might want to use s write-only property.
  - A read only property obviously will be good for a constant value that doesn't change, but we need to read. It would be bad if that value was changed. The `Math.Pi` field is probably a good example.
  - A write only property that isn't a password might be a program that works based on side affects, or a field that is passed outside of the program and should not be read internally. Maybe like a file written to a hard drive.
6. Can you think of a reason why you might ever want to make getters and setters private? Give an example. Also, make a case why getters and setters should never be private.
  - If I had a field that was only supposed to be accessed internally by my method, but I also wanted to control it's access with get; set.
  - This defeats the purpose of having properties if you make them private, there's really not a need for them at all.
7. What are restrictions on the use of properties?
  - You can assign a value through a property of a structure or class only after the structure or class has been initialized.
  - You can’t use a property as a ref or an out argument to a method (although you can use a write-able field as a ref or an out argument
  - You can’t declare properties by using `const`.
8. What is an object initializer? What is the syntax for an object initializer?
  - When you create an instance of a class, you can initialize it by specifying the names and values for any public properties that have set accessors.
```cs
Triangle tri1 = new Triangle { Side3Length = 15 };
Triangle tri2 = new Triangle { Side1Length = 15, Side3Length = 20 };
Triangle tri3 = new Triangle { Side2Length = 12, Side3Length = 17 };
Triangle tri4 = new Triangle { Side1Length = 9, Side2Length = 12, Side3Length = 15 };
```