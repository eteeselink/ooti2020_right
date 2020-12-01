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

        public override Question Question { 
            get => throw new System.NotImplementedException(); 
            init => throw new System.NotImplementedException(); 
        }
        public override string VoterName { 
            get => throw new System.NotImplementedException();
            init => throw new System.NotImplementedException(); }
    }
}