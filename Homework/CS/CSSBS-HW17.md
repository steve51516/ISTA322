# C# Programming Homework 17

1. What is a type parameter?
  - specify the types of objects on which they operate.
2. What does a type parameter do?
  - Specalises the method with a class.
  -  Serves as the type used by a method, and is replaced with the real type when compiled.
3. How many type parameters can a generic class have?
  - They can have an unlimited amount of types.
  - See [Microsoft Documentation](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/generics/constraints-on-type-parameters)
4. What is the difference between a generic class and a generalized class?
  - For generalized classes you are using the same instance of that class for all data types. You are casting data to and from object in the same class.
  - There is an instance copy made of a generic class specifically for that data type.
  - Each time you use this class with a type parameter you cause the compiler to generate an entirely new class that happens to have functionality defined by the generic class.
5. What is a constraint? How do you specify a constraint?
  - limit the type parameters of a generic class to those that implement a particular set of interfaces and therefore provide the methods defined by those interfaces
6. What is a generic method? How do you define a generic method?
  - A generic method is a method that is declared with type parameters
  - [MS Generics Documentation](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/generics/generic-methods)
  - You can specalize a generic method on a specific type
```cs
static void Swap<T>(ref T lhs, ref T rhs)
{
    T temp;
    temp = lhs;
    lhs = rhs;
    rhs = temp;
}
```
7. What do we mean when we say that a generic type interface is *invariant*?
  - The `IWrapper<T>` interface is said to be invariant.
  - variance means the type has to match the method.
 - You cannot assign an IWrapper<A> object to a reference of type IWrapper<B>, even if type A is derived from type B.
 - Cannot mix types with object
8. What do we mean when we say that a generic type interface is covariant?
  - With a covariant interface you can pass in a parameter that does not match. You can use the `out` keyword you can have a mismatch. 
    + The `out` keyword means you can return the modified parameter without the return keyword used.
  - Enables you to use a more derived type than originally specified.
  - You can assign an instance of IEnumerable<Derived>
9. Does covariance work with value types? Does it work with reference types?
  - covariance and contravariance enable implicit **reference** conversion for array types, delegate types, and generic type arguments
  - Boxing and unboxing would be needed for value types.
10. What do we mean when we say that a generic type interface is contravariant?
  - You can use the `in` keyword. The in keyword tells the C# compiler that you can either pass the type T as the parameter type to methods or pass any type that derives from T.
  - Enables you to use a more generic (less derived) type than originally specified.
  - You can assign an instance of `Action<Base>` to a variable of type `Action<Derived>`.