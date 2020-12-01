namespace Kiosk
{
    public abstract class Question
    {
        // TODO make this class abstract
        // private string question;
        // private string[] options;
        // private string answer;

        public abstract string GetQuestion();
        public abstract string[] GetOptions();
        public abstract string GetAnswer();
    }
}