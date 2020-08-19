# ASP.NET Core 3 Homework 03

## Readings
  - Read chapter 03, in the Pro ASP.NET Core 3 book.

## Class Discussion Questions
  - Your written homework is due as directed. Format your homework in MarkDown. Be prepared to discuss each of the following questions is class.

1. What is the most important part of an ASP.NET Core 3 application?
  - The data model is the most important part of any ASP.NET Core application.
2. What is the domain model?
  - contains the C# objects (known as domain objects) that make up the universe of the application and the methods that manipulate them.
3. Where are the model classes in an ASP.NET Core 3 application placed?
  - 
4. How many action methods can a controller class define?
  - As many as needed. [Link to docs.microsoft.com](https://docs.microsoft.com/en-us/previous-versions/aspnet/dd410269(v=vs.100))
  - A single controller class can define multiple action methods, and the convention is to group related actions together in the
same controller
5. What is a tag helper?
  - is an instruction for Razor that will be performed when the view is rendered
  - In this chapter the book used the *tag helper* asp-action to present the user with a URL
6. What does the asp-action attribute do?
  - The asp-action attribute is an instruction to add an href attribute to the a element that contains a URL for an action method
  - this tag helper tells Razor to insert a URL for an action method defined by the same controller for which the current view is being rendered
7. What is the difference between HTTP GET and HTTP POST? This is an important question, and you should understand the difference.
  - Get asks for the original form.
      + A GET request is what a browser issues normally each time someone clicks a link. This version of the action will be responsible for displaying the initial blank form when
someone first visits /Home/RsvpForm.
  - Accepts the form from the user.
      + y default, forms rendered using Html.BeginForm() are submitted by the browser as a POST request. This version of the action will be responsible for receiving submitted data and deciding what to do with it.
8. What is model binding?
  - whereby incoming data is parsed and the key/value pairs in the HTTP request are used to populate properties of domain model types
  - Model binding is a powerful and customizable feature that eliminates the grind of dealing with HTTP requests directly and lets you work with C# objects rather than dealing with individual data values sent by the browser.
9. Why should we validate user data? How do we validate user data?
  - We should validate user input to ensure that our program is working with the proper data. This will reduce exceptions thrown, security risks, errors in general.
  - In an ASP.NET Core application, validation rules are defined by applying attributes to model classes, which means the same validation rules can be applied in any form that uses that class
  - ASP.NET Core relies on attributes from the System.ComponentModel.
DataAnnotations namespace
10. What, specifically, is the ModelState.IsValid property?
  - It is a boolean value that is true or false depending on the results of the validation
  - that provides details of the outcome of the model binding process.
11. What does the asp-validation-summary do?
  - it displays a list of validation errors when the view is rendered
  - The value for the asp-validation-summary attribute is a value from an enumeration called ValidationSummary, which specifies what types of validation errors the summary will contain.
12. Static content consists of content such as images, script files, style files, etc. In an ASP.NET Core application, what is the name of the folder that contains static content?
  - The convention in ASP.NET Core projects is that static content delivered to clients is placed into the wwwroot folder and organized by content type 
      + CSS stylesheets go into the wwwroot/css folder
      + JavaScript files go into the wwwroot/js folder
13. What is Bootstrap? Who developed Bootstrap? Is Bootstrap a proprietary package? If not, what is it?
  - It's an open source 
  - Bootstrap defines classes that can be used to style forms.
  - which is a good CSS framework originally developed by Twitter that has become a major open source project and a mainstay of web application development