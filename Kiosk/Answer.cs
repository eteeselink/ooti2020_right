namespace Kiosk
{
    public struct Answer
    {
        public Question Question{get; init;}
        public string VoterName{get; init;} 
        public bool Response{get; init;}
    }
}