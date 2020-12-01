namespace Kiosk{
    public class ScoreAnswer : Answer{

        public int Score;

        public ScoreAnswer(Question question, string voterName, int score)
        {
            Question = question;
            VoterName = voterName;
            Score = score;
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