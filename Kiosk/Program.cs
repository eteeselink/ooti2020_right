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
            //var survey = new Survey("questions.json");
            // var questions = survey.GetQuestions();
            // hard-coded for now
            var question1 = new SingleChoiceQuestion("Are you doing well?");
            var question5 = new SingleChoiceQuestion("Have you got everything ready?");
            var question6 = new SingleChoiceQuestion("Are you ready to leave for dinner?");
            // var question2 = new MultipleChoiceQuestion("What do you prefer for dinner?", new string[]{"Sandwich", "Noodle", "Rice", "Nothing"});
            // var question3 = new ScoreQuestion("How would you rank your work this afternoon");
            // var question4 = new MultipleChoiceQuestion("Which do you prefer for lunch?", new string[]{"Sandwich", "Noodle", "Rice", "Nothing"});
            var questions = new List<Question>();
            questions.Add(question1);
            questions.Add(question5);
            questions.Add(question6);
            // questions.Add(question2);
            // questions.Add(question3);
            // questions.Add(question4);

            var voterAnswerMap = new SortedDictionary<string, List<Answer>>();


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
                    var answer = q.Ask();
                    answers.Add(answer);
                }
                voterAnswerMap.Add(user, answers);
            }
            
            // Create a canvas

            YesNoDetailedResult detailedResult = new YesNoDetailedResult();
            detailedResult.show(7, 5);
        }
    }
}
