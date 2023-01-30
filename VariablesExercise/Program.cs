namespace VariablesExercise
{
    public class Program
    {
        static void Main(string[] args)
        {


            string dinosaurName = "Dino";

            int dinoAge = 25;

            char dinoNickname = 'D';

            bool dinoIsNice = true;

            double dinoSalary = 1200000.73;

            decimal dinoSpeed = 8.3375m;

            string niceMsg = dinoIsNice ? "Hes a nice dinosaur" : "Hes not a nice dinosaur";


            Console.WriteLine($"There once was a fast dinosaur named {dinosaurName}. Dino is {dinoAge} years old. Dino's best friends call him {dinoNickname}. {niceMsg} to all his friends. Dino makes {dinoSalary} dollars a year so he shares his money with his friends. Dino is a professional sprinter. Dino can run a 200 meter dash in {dinoSpeed} seconds. I wish I was fast like {dinosaurName}.");

            

        }
    }
}
