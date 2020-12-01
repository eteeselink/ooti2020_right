using Spectre.Console;

namespace Kiosk
{
    public class FreeQuestion : Question
    {
        string Question;

        public FreeQuestion(string question)
        {
            Question = question;
        }

        public override Answer ask()
        {
            string response = AnsiConsole.Ask<string>(Question);
            return new FreeAnswer(this, "voterName", response);
        }
    }
}