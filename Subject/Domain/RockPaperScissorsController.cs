using System;
using System.Collections.Generic;
using System.Text;

namespace Subject.Domain
{
    public enum Hand
    {
        Rock,
        Scissors,
        Paper
    }

    public enum Result
    {
        Win,
        Losing,
        Tie
    }

    class RockPaperScissorsController
    {
        // C#8.0より追加されたswitch式
        // 万が一を考え、null許容
        public Result? RockJudge(Hand enemyHand) => (enemyHand) switch
        {
            Hand.Rock => Result.Tie,
            Hand.Scissors => Result.Win,
            Hand.Paper => Result.Losing,
            _ => null
        };

        public Result? ScissorsJudge(Hand enemyHand) => (enemyHand) switch
        {
            Hand.Rock => Result.Losing,
            Hand.Scissors => Result.Tie,
            Hand.Paper => Result.Win,
            _ => null
        };

        public Result? PaperJudge(Hand enemyHand) => (enemyHand) switch
        {
            Hand.Rock => Result.Win,
            Hand.Scissors => Result.Losing,
            Hand.Paper => Result.Tie,
            _ => null
        };
    }
}
