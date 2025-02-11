namespace ConsoleApp1;

public class Onno
{
    public void Run()
    {
        //do something
    }

    public bool IsPrime(int number)
    {
        if (number <= 1) return false;
        if (number == 2) return true;
        if (number % 2 == 0) return false;
        for (int i = 3; i <= Math.Sqrt(number); i += 2)
        {
            if (number % i == 0) return false;
        }
        return true;
    }

    public void Timer(int seconds)
    {
        System.Threading.Thread.Sleep(seconds * 1000);
    }
}
