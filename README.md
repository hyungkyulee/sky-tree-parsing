# sky-tree-parsing

## Project Dev Environment
- .NET Core Console Application
- Solution
 |- TreeParsing : Main Project (dotnetcore3.1)
 |- TreeParsing.Test : Unit Test Project (NUnit)

## Software Design
- TDD : Failed Test -> Pass Test -> Refactoring
  1) Tree_Instance_Can_Be_Created() : To create a Tree and test
  2) Traverse_The_Constructed_Tree_Structure_Successfully() : To traverse and get output
  
- SOLID : in this simple application, Single Responsibility and Open for extension/Close for modification are used mainly.
  - Node Class: in-Memory Data model
  - Tree Class : domain model, including business logic to handle Tree manupulation (add/insert and traverse/search)
    - nodes creation on a contructor, method overloading on 'Add' and 'Traverse'
    - Information hiding with 'private' keyword
    
- Exception handling on format error


## Run Application
- input parameter : a comma separated list of numbers
- output : a comma separated list of numbers

