public class AnswerStack
{
    public string Text { get; private set; }
    public bool IsTrue { get; private set; }

    public AnswerStack(string text, bool isTrue)
    {
        Text = text;
        IsTrue = isTrue;
    }
}