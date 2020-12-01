namespace Kiosk
{
    public abstract class Answer
    {
        public abstract Question Question{get; init;}
        public abstract string VoterName{get; init;}
    }
}