# Undoable Command
- BoldCommand forwards the request to HtmlDocument. 
Therefore the business logic is implemented in HtmlDocument.
- History is like the Hisotry obj in Memento Pattern.
- Not all command is undoable, so  IUndoableCommand extends ICommand.
- BoldCommand pushes itself to History, because the command should know how to undo itself. 
- UndoCommand is created because there is likely an undo button to undo the command.