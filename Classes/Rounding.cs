namespace GuesNumber.Classes
{
    public class Rounding
    {
        public static int ceiling { get; set; }
        public static int floor { get; set; }
        public static void RoundNumber(double number){
           number /=10;
           ceiling =(int)Math.Ceiling(number)*10;
           floor =(int)Math.Floor(number)*10;
        }
    }
}