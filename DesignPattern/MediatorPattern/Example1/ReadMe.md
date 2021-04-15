# Mediator Pattern
- Instead of having multiple classes depending on each other's state, all classes depends on the mediator class to make changes.
- A real-world analogy is that many airplanes depends on the tower's(mediator) command.
- Concrete colleagues(airplanes) should not know each other, and the concrete mediator, but should have refernce to the mediator interface. 
- The concrete mediator composes of concrete colleagues and holds the logic of what to do when each concrete collegaues changes its state.
- The concrete mediator can run the risk of having bulky logics in the update method that updates each concrete colleague.
- Adding observer pattern to mediator pattern is a popular way of solving this. See **Example 2**.