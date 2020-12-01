namespace Kiosk
{
    public struct MultipleChoiceQuestion {
        public string Question { get; init; }
        public string[] Answers { get; init; }
    }

    public class Survey {
        public MultipleChoiceQuestion GetQuestion() {
            return new MultipleChoiceQuestion {
                Question = "What's the best pizza?",
                Answers = new[] { "Margherita", "Pepperoni", "Lahmacun"}
            };
        }

        public string GetCorrectAnswer() {
            return "Lahmacun";
        }
    }
}