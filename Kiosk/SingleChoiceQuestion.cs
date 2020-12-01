namespace Kiosk
{
    public class SingleChoiceQuestion : Question
    {

        private string question;
        private string[] options;
        private string answer;

        public override string GetAnswer()
        {
            return this.answer;
        }


        public override string[] GetOptions()
        {
            return this.options;
        }

        public override string GetQuestion()
        {
            return this.question;
        }
    }
}