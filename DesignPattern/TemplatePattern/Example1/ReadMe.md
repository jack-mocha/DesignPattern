# Template Pattern
- This pattern lets you break a monolithic algorithm(a large method) into several smaller steps.
- It provides the skeleton of an algorithm.
- You use it when there are several methods that are identical between several concrete classes.
- You can also add hooks in the template method(The one that is exposed to the client). It provides subclasses with additional extension points. It is usualy placed before and after crutial steps of an algorithm.
- Hook in this context refers to a virtual method that has empty body, which allows subclasses to implement it.
- You don't want the template method to be overridden. In C#, it means don't make it virtual.
- Abstract methods should be decorated with the protected key word, because you do not want to expose them to the client.
- **Template** is based on inheritance, while **Strategy** is based on composition
- **Template** works at the class level, so it is static.
- **Strategy** works at the object level, letting you switch behaviors at runtime.
#### Ref
- https://refactoring.guru/design-patterns/template-method