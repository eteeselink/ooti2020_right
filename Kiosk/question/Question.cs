namespace Kiosk
{
    public abstract class Question
    {
        public abstract Answer ask();
        public string getQuestion() { return "Test"; }
    }
}