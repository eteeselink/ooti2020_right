using Spectre.Console;
using System.Collections.Generic;

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
            var survey = new Survey("questions.json");
            var questions = survey.GetQuestions();
            
            var voterAnswerMap = new SortedDictionary<string, List<Answer>>();

            //hacky
            var yesAnswers = new List<int>();

            // var users = getUsers();
            // hardcoded for now
            string[] users = {"Dan", "Leon", "Niki"};
            
            foreach (var user in users) {
                // Styled text announcing the next user
                var rule = new Rule("[red]" + user + "[/]");
                rule.LeftAligned();
                AnsiConsole.Render(rule);
                AnsiConsole.MarkupLine("[bold]" + user + "[/] - It's your turn to answer the questions.");
                
                var answers = new List<Answer>();
                foreach (var q in questions) {
                    var answer = q.ask();
                    answers.Add(answer);
                }
                voterAnswerMap.Add(user, answers);
            }

            // Count yes/no result
            
            
            // Create a canvas

            YesNoDetailedResult detailedResult = new YesNoDetailedResult();
            detailedResult.show(7, 5);
        }
    }
}
