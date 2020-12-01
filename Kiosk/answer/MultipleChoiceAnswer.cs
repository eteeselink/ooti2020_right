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

        public override Question Question { 
            get => throw new System.NotImplementedException(); 
            init => throw new System.NotImplementedException(); 
        }
        public override string VoterName { 
            get => throw new System.NotImplementedException();
            init => throw new System.NotImplementedException(); }
    }
}