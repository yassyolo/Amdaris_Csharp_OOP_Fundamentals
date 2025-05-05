What code smells did you see?
- Really long method (Register), everything was nested, low readability and really hard to follow
- Register had too many responsibilities 
- Hardcoded values
- Duplicated validation logic
- Tight coupling with external classes 

What problems do you think the Speaker class has?
-The code violates SRP because it does too many things at once(validation, registration, fee calculation, session filtering)
- Difficult to test the code and we cannot maintain it easily
- The logic is hard to follow and understand

Which clean code principles (or general programming principles) did it violate?
- Single Responsibility Principle  because it does too many things at once.
- Open/Closed Principleb ecause it is not easy to extend or modify without changing the existing code.
- Dependency Inversion Principle because it depends on concrete implementations of external services instead of abstractions.
- Liskov Substitution Principle because it uses exceptions to control the flow of the program instead of using polymorphism.
- Interface Segregation Principle because it has a lot of methods that are not related to each other, there should be interfaces introduced that introduce logic for each responsibility.

What refactoring techniques did you use?
- Split Register into smaller methods 
- Introduced constants for hardcoded values
- Moved business logic to smaller methods to reduce complexity and improve readability
- Encapsulated validation in the constructor
- Moved exceptions to separate classes
- Moved enums to a separate file
- Introduced interfaces for external dependencies and not concrete implementations
- Added folder structure to separate concerns



