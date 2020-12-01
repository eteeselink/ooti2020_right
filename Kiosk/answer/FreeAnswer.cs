namespace Kiosk
{
    public class FreeAnswer : Answer{

        public string Response;

        public FreeAnswer(Question question, string voterName, string response)
        {
            Question = question;
            VoterName = voterName;
            Response = response;
        }
    }
}