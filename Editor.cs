namespace DesignPattern_Memento
{
    public class Editor
    {
        private string content;

        public string Content { get => content; set => content = value; }

        public EditorState createState()
        {
            return new EditorState(content);
        }
        public void restore(EditorState state)
        {
            content= state.Content;
        }
    }
}