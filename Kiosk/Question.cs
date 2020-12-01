namespace Kiosk
{
    public abstract class Question
    {
        // TODO make this class abstract
        private string question;
        private string[] options;
        private string answer;

        public string GetQuestion() {};
        public string GetOptions() {};
        public string GetAnswer() {};
    }
}