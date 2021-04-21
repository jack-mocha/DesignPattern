# State Pattern
- Based on the state of the context, the context acts differently. 
- This is a good example of Open/Close Principle - Open for extension, but closed for modification.
- Here Canvas is the context.
- Based on the current tool that is set, MouseDown and MouseUp acts accordinly.
- The program can be extended by adding more implementation of ITool.
- State objects may store a backreference to the context object. Through this reference, the state can fetch any 
  required info from the context object.
- To avoid duplication of similar code across multiple states, and intermediate abstract class can be provided to encapsulate common behavior.
- Both context and concrete states can set the next state of the context and perform the actual state transition.
  
#### Ref
- https://refactoring.guru/design-patterns/state