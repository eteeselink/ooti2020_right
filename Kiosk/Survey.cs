using System;
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
        
        private static Question q1 = new SingleChoiceQuestion("Is this working?");
        private static Question q2 = new SingleChoiceQuestion("Is this hardcoded?");
        private static Question q3 = new SingleChoiceQuestion("Is this a valid approach?");
        private static Question q4 = new SingleChoiceQuestion("Is this now valid?");

        private Question[] questions = {q1, q2, q3, q4};


        public Survey(string filePath) {
            // read file directly
            this.filePath = filePath;
            if (File.Exists(this.filePath)) {
                Console.Write(this.filePath);
                string text = File.ReadAllText(this.filePath);
                // Console.Write(text);
                // this.questions = JsonSerializer.Deserialize<Question>(filePath);
                // foreach (Question question in this.questions) {
                //     question.ask();
                // }
            } else {
                Console.Write("COULD NOT READ");
            }
        }

        public Question[] GetQuestions() {
            return this.questions;
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