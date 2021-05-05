# Flyweight Pattern
- It is used when you have many objects that have common fields, which consumes a lot of memory. 
- You extract those common fields(intrinsic states) to a new class as flyweight.
- Use contextual object to contain flyweight, and also provide extrinsic states.
- Use factory to create/get the flyweight object.
- The factory will check first if the flyweight exists. It returns the flyweight if it exists, or create a new one and store it when it does not exist yet.
- The service object in example1 provides a collection of the contextual object.
- The pattern is most usefull when:
    - an application needs to spawn a huge number of similar objects
    - this drains all available RAM on a target device
    - the objects contain duplicate states which can be extracted and shared between multiple objects

#### Ref
- https://refactoring.guru/design-patterns/flyweight  