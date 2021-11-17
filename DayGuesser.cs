using DayWhenYouBirth.Core;
using System;

namespace DayWhenYouBirth
{
    public class DayGuesser
    {
        public DayCalculator Calculator { get; set; }

        public DateTimeOffset UserDateOfBirth { get; set; }

        public DayOfWeek UserDayOfWeek { get; set; }

        public void IntroduceTheApp()
        {
            Console.WriteLine("Cześć, jestem botem który umie wyliczać dzień tygodnia " +
                "na postawie Twojej daty urodzenia!");

            Calculator = new DayCalculator();

        }
        public void AskUserForDateOfBirth()
        {
            Console.WriteLine("Podaj mi swoją date urodzenia: ");

            var userDate = Console.ReadLine();
            
            var success =  DateTimeOffset.TryParse(userDate, out var date);

            if (success)
            {
                UserDateOfBirth = date;
                return;
            }
            Console.WriteLine("Format daty był zły! Podaj ponownie (dd/mm/yy) : ");

            AskUserForDateOfBirth();


        }
        public void CalculateDate()
        {
            if (UserDateOfBirth != null)
            {
                 UserDayOfWeek = Calculator.CalculateDayofTheWeek(UserDateOfBirth);

            }else
            {
                Console.WriteLine("Próbowano obliczyć dzień tygodnia bez podania daty urodzenia!");
                return;
            }
        }
        public void PrintDayOfTheWeek()
        {
            Console.WriteLine("Urodziłeś się: " + EnumExt.ToPolishString(UserDayOfWeek));
        }
    }
}
