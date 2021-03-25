# Iterator Pattern
- Here Spammer is the client.
- Program is the application.
- The applicatino configures the collection and iterators, and pass them on to the client.
- A useful trick is to only pass an iterator to a client. This way, you don't expose the collection to the client.
- Different type of iterator can provide different sets of profiles. For example, list of friends, or list of coworkers.