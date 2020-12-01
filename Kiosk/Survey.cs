using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Kiosk
{
    // public struct MultipleChoiceQuestion {
    //     public string Question { get; init; }
    //     public string[] Answers { get; init; }
    // }

    public class Survey {
        private string filePath;
        private Question[] questions;

        public Survey(string filePath) {
            this.filePath = filePath;
            if (File.Exists(this.filePath)) {
                this.questions = JsonSerializer.Deserialize<Question>(filePath);
            }
        }

        public Question[] GetQuestions() {
            return questions;
        }

        // public MultipleChoiceQuestion GetQuestion() {
        //     return new MultipleChoiceQuestion {
        //         Question = "What's the best pizza?",
        //         Answers = new[] { "Margherita", "Pepperoni", "Lahmacun"}
        //     };
        // }

        // public string GetCorrectAnswer() {
        //     return "Lahmacun";
        // }
    }
}