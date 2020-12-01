namespace Kiosk
{
    public class ScoreAnswer : Answer{

        public int Score;

        public ScoreAnswer(Question question, string voterName, int score)
        {
            Question = question;
            VoterName = voterName;
            Score = score;
        }
    }
}