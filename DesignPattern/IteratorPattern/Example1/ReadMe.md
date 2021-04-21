# Iterator Pattern
- This pattern lets you traverse the collection without knowing the uderlying representation (List, Array, etc.).
- The main idea is to extract the traversal behavior of a collection into a separate object called an iterator.
- Typically, clients do not create iterators on their own, but instead get them from collections.
- Because an iterator encapsulates the traversal detail, several iterators can go through the same collection at the same time, independently of each other.