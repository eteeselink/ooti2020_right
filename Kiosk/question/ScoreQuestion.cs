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
                new TextPrompt<int>(Question)
                    .Validate(i =>
                    {
                        return i switch
                        {
                            < 1 => ValidationResult.Error("[red]Too low[/]"),
                            > 5 => ValidationResult.Error("[red]Too high[/]"),
                            _ => ValidationResult.Success(),
                        };
                    }));

            return new ScoreAnswer(this, "voterName", response);
        }
    }
}