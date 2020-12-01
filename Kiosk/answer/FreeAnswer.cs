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

        public override Question Question { 
            get => throw new System.NotImplementedException(); 
            init => throw new System.NotImplementedException(); 
        }
        public override string VoterName { 
            get => throw new System.NotImplementedException();
            init => throw new System.NotImplementedException(); }
    }
}