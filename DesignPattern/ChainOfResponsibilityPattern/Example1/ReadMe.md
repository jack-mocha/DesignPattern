# Chain of Responsibility
- It allows you to form a pipline (like a linked list) to process a request. Each handler in the pipline can decide either to process the request or pass it on to the next handler.
- A good example is processing a HttpRequest.
- Open for extension, and closed for modification.
- Another approach is to let the handler decide whether it can handle the request or not. If it can, it does not pass the request further.
- A request can be sent to any handler. It does not have to start from the first one.
- You can assemble the chain at runtime
- The client needs to handle
  - Some requests may not reach the end of the chain
  - Others may reach the end of the chain unhandled.

#### Ref
- https://refactoring.guru/design-patterns/chain-of-responsibility