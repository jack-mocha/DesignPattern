# Adapter Pattern
- Use this pattern when you want to allow objects with incompatible interfaces to collaborate.
- You can do adapters like
    - adapter between BU and EU
    - adapter between XML and JSON
    - adapter that simply works with a 3rd party library, which, of course, does not implement your interface.
- 2 ways to implement Adapter
    - Composition - ex. CaramelFilter
    - Inheritance - ex. CaramelAdapter
- Favor composition over inheritance, because composition has more flexibility. If IFilter is not an interface but an abstract class, you won't be able to implement 2 classes in C#.

#### Ref
- https://refactoring.guru/design-patterns/adapter