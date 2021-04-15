# Mediator Pattern - Adding Observer Pattern
- Common way to implement event handlers.
- Each concrete colleague is a subject.
- The concrete mediator is the observer that subscribes to each concrete colleague.
- When there is a change in the state of a concrete colleague, it notifies the mediator, and the mediator updates other colleagues.