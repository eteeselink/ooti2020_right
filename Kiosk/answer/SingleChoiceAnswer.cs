namespace Kiosk
{
    public class SingleChoiceAnswer : Answer{

        public bool Response;

        public SingleChoiceAnswer(Question question, string voterName, bool response)
        {
            Question = question;
            VoterName = voterName;
            Response = response;
        }
    }
}