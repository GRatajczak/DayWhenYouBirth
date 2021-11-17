namespace DayWhenYouBirth
{
    class Program
    {
        static void Main(string[] args)
        {

            var guesser = new DayGuesser();
            guesser.IntroduceTheApp();
            guesser.AskUserForDateOfBirth();
            guesser.CalculateDate();
            guesser.PrintDayOfTheWeek();
        }
    }
}
