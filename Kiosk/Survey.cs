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
        private SingleChoiceQuestion[] questions;

        public Survey(string filePath) {
            // read file directly
            this.filePath = filePath;
            if (File.Exists(this.filePath)) {
                Console.Write(this.filePath);
                string text = File.ReadAllText(this.filePath);
                // Console.Write(text);
                // using FileStream openStream = File.OpenRead(this.filePath);
                // this.questions = await JsonSerializer.DeserializeAsync<WeatherForecast>(openStream);
                this.questions = JsonSerializer.Deserialize<SingleChoiceQuestion[]>(filePath);
                foreach (Question question in this.questions) {
                    Console.Write(question.GetQuestion());
                }
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