namespace HarmonicNumber;

     class program
     {

    static double nthHarmonic(int N)
    {
        float harmonic = 1;

        for (int i = 2; i <= N; i++)
        {
            harmonic += (float)1 / i;
        }

        return harmonic;
    }
    static public void Main()
    {
        int N = 0;

        Console.Write(nthHarmonic(N));
    }
}


