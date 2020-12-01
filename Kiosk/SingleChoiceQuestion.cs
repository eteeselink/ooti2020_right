namespace Kiosk
{
    class SingleChoiceQuestion : Question
    {
        public string GetQuestion() {
            return this.question;
        };

        public string GetOptions() {
            return this.options;
        };

        public string GetAnswer() {
            return this.answer;
        };
    }
}