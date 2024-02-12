using System;

public static class Darts
{
    public static int Score(double x, double y)
    {
        double distanza = Math.Sqrt(x * x + y * y);

        switch(distanza){
            case <= 1:
            return 10;
            case <= 5:
            return 5;
            case <= 10:
            return 1;
            default:
            return 0;
        }
    }
}


