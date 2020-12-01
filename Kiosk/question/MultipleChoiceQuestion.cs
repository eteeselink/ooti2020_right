using Spectre.Console;

namespace Kiosk
{
    public class MultipleChoiceQuestion : Question
    {
        string Question;
        string[] Options;

        public MultipleChoiceQuestion(string question, string[] options)
        {
            Question = question;
            Options = options;
        }

        public override Answer ask()
        {
            var prompt = new TextPrompt<string>(Question)
                .InvalidChoiceMessage("[red]That's not a valid option[/]");
            foreach(var o in Options) {
                prompt.AddChoice(o);
            }
            var response = AnsiConsole.Prompt(prompt);
            return new MultipleChoiceAnswer(this, "voterName", response);
        }
    }
}