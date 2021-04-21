# Visitor Pattern
- It is useful when you need to perform an operation on all elements of a complex object structure.
- Double Dispatch
  - Concrete visitor is passed to element.
  - Concrete element passes itself to the visitor.
- It is better to use it when the object structure is stable, an dyou want to frequently add new operations. For example, html has a rather stable amount of nodes. 