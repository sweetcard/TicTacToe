using System;

namespace Domain
{
    public static class Rule
    {
        public static readonly int BoardSize = 3;
        public static readonly TimeSpan TurnTimeout = TimeSpan.FromSeconds(10);
    }
}
