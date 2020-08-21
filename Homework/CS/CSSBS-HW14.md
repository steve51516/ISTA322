# CS homework 14

1. What is the difference between a managed resource and an unmanaged resource?
  - Managed resources are resources that garbage collection manages, like reference values.
  - Unmanaged resources are data types that are managed elsewhere, like file streams, database connections, etc.
2. When is memory for an object (reference type) allocated? When is the memory deallocated?
  - when the *new* keyword is executed memory is allocated and then initialized.
3. What is a destructor?
  - Makes a managed resource available for immediate disposal by setting any references that the object has to this resource to null.
  - if an object references an unmanaged resource, either directly or indirectly, a destructor can prove useful.
4. What is the difference in syntax between a constructor and a destructor?
  - The difference is that a tilde is placed before the class name, similar to how a constructor is written with class name, no return type, and tilde added.
  - The syntax for writing a destructor is a tilde (~) followed by the name of the class.
```cs
~FileProcessor()
{
this.file.Close();                                                 
}
```
5. Give some examples of scarce resources. Why would you want to manage scarce resources?
  - memory, database connections, or file handles.
6. What is exception-safe disposal?
  - data that will be disposed of even if there is an unhanded exception.
  - to call the disposal method within a finally block.
  - to place your code inside a using block
7. How do you think that the using statement works for resource management? Give an informal, English language, explanation of how it works.
  - the using statement creates a new scope and once that scope is finished everything inside of it is disposed of. This is also exception free as the resources are always released even if there's an exception.
8. What ill effects could result from attempting to dispose of a resource more than once?
  - **Horrible** *and* **disastrous** effects. I could not find a solid answer and the book just says horrible things might happen.
9. We will look at threads later in the term. For now, what is your understanding of how threads interact with resource management? A good guess is a sufficient answer to this question.
  - A processor operates on many threads to do many things seemingly at the same time.
  - A thread is a separate path of execution in an application. Windows uses threads to enable an application to perform multiple operations concurrently.
10. Why does the book recommend not attempting to force the garbage collector? Are their any exceptions to this recommendation?
  - Garbage collection tasks are expensive and will slow your program down. If you don't need to dispose of something immediately, it's better to make a couple of large cleaning sweeps than a lot of small cleaning tasks.
  - Garbage collection could have already released the resource before you call the dispose method as well.