# State Pattern
- Based on the state of the context, the context acts differently. 
- This is a good example of Open/Close Principle - Open for extension, but closed for modification.
- Here Canvas is the context.
- Based on the current tool that is set, MouseDown and MouseUp acts accordinly.
- The program can be extended by adding more implementation of ITool.