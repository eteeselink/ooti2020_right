using Spectre.Console;

namespace Kiosk
{
    public class ScoreQuestion : Question
    {
        string Question;

        public ScoreQuestion(string question)
        {
            Question = question;
        }

        public override Answer ask()
        {
            var response = AnsiConsole.Prompt(
                new TextPrompt<string>(Question)
                    .InvalidChoiceMessage("[red]Answer has to be between 1 and 5[/]")
                    .AddChoice("1")
                    .AddChoice("2")
                    .AddChoice("3")
                    .AddChoice("4")
                    .AddChoice("5"));

            return new ScoreAnswer(this, "voterName", int.Parse(response));
        }
    }
}