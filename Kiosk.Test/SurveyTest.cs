using System;
using Xunit;

namespace Kiosk.Test
{
    public class SurveyTest
    {
        [Fact]
        public void TestThatPasses()
        {
            var survey = new Kiosk.Survey();
            Assert.Contains(survey.GetCorrectAnswer(), survey.GetQuestion().Answers);
        }

        // this test fails, for demonstration purposes. you'll likely want to delete it.
        [Fact]
        public void TestThatFails()
        {
            var survey = new Kiosk.Survey();
            Assert.Contains(survey.GetCorrectAnswer(), "Quattro Formaggi");
        }

    }
}
