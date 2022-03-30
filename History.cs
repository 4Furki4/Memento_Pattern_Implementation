using System.Collections.Generic;
using System.Collections;

namespace DesignPattern_Memento
{
    public class History
    {
        private List<EditorState> states = new List<EditorState>();
        public void push(EditorState state)
        {
            states.Add(state);
        }
        public EditorState pop ()
        {
            var lastIndex= states.Count-1;
            var lastState= states[lastIndex];
            states.Remove(lastState);
            return lastState;
        }
    }
    
}