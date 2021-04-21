# Strategy Pattern
- Used when you have a family for algorithm that does the same thing. For example, different types of compressors/filters.
- It is similar to **State Pattern**. The main difference is that _State_ allows each concrete state to set the context's next state. Whereas each concrete strategy does not know about each other.
- It is similar to **Command Pattern**. _Command_ converts any operation into an object. _Strategy_ usually describes different ways of doing the same thing.

#### Ref
- https://refactoring.guru/design-patterns/strategy