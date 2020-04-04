# TDD Notes
**Three Laws of TDD**
- Never write even a line of production code before writing a failing test
- Write a minimal test which is enough to see the failure
- Don't write production code more han enough to pass the failing test
___
**Keep your Test clean**

Design Smell
1. Rigidity
- Software is rigid. If the cost of making a single change is very high.
- Reason: tight coupling between module.
2. Fragility
- Software is fragile if small changes in one module cause bugs appearance in other.
- Reason: tight coupling between components.
3. Immobility
- Software is immoble when its components can't be reused in other system.
- Reason: tight coupling between components.
4. Visosity
- The software is viscose when adding a single feature evokes dealing with tons of aspects.
- Reason: tight coupling between components.
5. Needless Complexity
- Software is needlessly complex if developers are trying to forcast the future, introducing excesive points of extension.
- Concentrate on the current requirements, construting the supple architcture which can bend to meet new requirements.

**SOLID Principles**
- SRP - Single Responsibility Principle
- OCP - Open/Closed Principle
- LSP - Liskov Subsititution Principle
- ISP - Interface Segregation Principle
- DIP - Dependency Inversion Principle

**F.I.R.S.T**
- Fast
- Independent
- Repeatable
- Self-Validation
- In-Time
___
**Types of Test**
- Unit Tests - verify the behavior of a unit under test in isolation 
- Integration Tests - verify the behavior of either a part of a system or a whole system
- Acceptance Tests - verify the software from the user's point of view

**Frameworks and Tools**
1. Accepting Testing Tools
- SpecFlow
- FitNess for .NET
2. Unit Testing Frameworks
- NUnit
- MSTest
- xUnit
3. UI-Testing Frameworks
- Seleium
- VS Code UI Test
- TestStack.White
___
