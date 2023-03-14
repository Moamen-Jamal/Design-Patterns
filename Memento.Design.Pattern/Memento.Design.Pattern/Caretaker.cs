using System.Diagnostics;

namespace Memento.Design.Pattern
{
    /// <summary>
    /// The 'Caretaker' class
    /// The Caretaker knows not only “when” and “why” to capture the originator’s state, but also when the state should be restored.
    /// A caretaker can keep track of the originator’s history by storing a stack of mementos.
    /// When the originator has to travel back in history, the caretaker fetches the topmost memento from the stack and passes it to the originator’s restoration method.
    /// In this implementation, the memento class is nested inside the originator. 
    /// This lets the originator access the fields and methods of the memento, even though they’re declared private. 
    /// On the other hand, the caretaker has very limited access to the memento’s fields and methods, which lets it store mementos in a stack but not tamper with their state.
    /// </summary>
    public class Caretaker
    {
        private Stack<CheckPointMemento> saves = new Stack<CheckPointMemento>();

        public void Save(GameOriginator game)
        {
            saves.Push(game.Save());
        }
        public void Revert(GameOriginator game)
        {
            game.Revert(saves.Pop());
        }
    }
}
