namespace Kiosk
{
    public class MultipleChoiceAnswer : Answer{

        public string Response;

        public MultipleChoiceAnswer(Question question, string voterName, string response)
        {
            Question = question;
            VoterName = voterName;
            Response = response;
        }
    }
}