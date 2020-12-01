using Spectre.Console;

namespace Kiosk
{
    public class SingleChoiceQuestion : Question
    {
        string Question;

        public SingleChoiceQuestion(string question)
        {
            Question = question;
        }

        public override Answer ask()
        {
            var response = AnsiConsole.Prompt(
                new TextPrompt<string>(Question)
                    .InvalidChoiceMessage("[red]Please answer yes or no[/]")
                    .AddChoice("yes")
                    .AddChoice("no"));

            return new SingleChoiceAnswer(this, "voterName", response == "yes");
        }
    }
}