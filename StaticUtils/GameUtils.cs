using System;

static class GameUtils
{
    public static int Clamp(int value, int min, int max)
    {
        if (value < min) return min;
        if (value > max) return max;
        return value;
    }

    public static int GetPercentage(int current, int max) => (int)(((double) current / max) * 100);

    public static bool IsInRange(int value, int min, int max) => (min <= value && value <= max);
}