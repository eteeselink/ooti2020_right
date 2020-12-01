using Spectre.Console;

namespace Kiosk
{
    /// This is just an example program. The design is obviously horrible.
    /// You're expected to pretty much replace all the code during today. 
    ///
    /// It uses Spectre.Console, an easy library for simple console UI apps:
    /// https://spectresystems.github.io/spectre.console/
    class Program
    {
        static void Main(string[] args)
        {
            var survey = new Survey();
            var question = survey.GetQuestion();

            var prompt = new TextPrompt<string>(question.Question);
            foreach(var a in question.Answers) {
                prompt.AddChoice(a);
            }
            var answer = AnsiConsole.Prompt(prompt);

            if(answer == survey.GetCorrectAnswer()) {
                AnsiConsole.Markup("That's [underline green]correct[/]!");
            }
            else {
                AnsiConsole.Markup("That's [underline red]wrong[/]!");
            }
        }
    }
}
