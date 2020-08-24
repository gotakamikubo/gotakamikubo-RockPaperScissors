using Subject.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Subject.Applications
{
    class AppService
    {
        private List<Result?> results = new List<Result?>();

        private Random random;

        private RockPaperScissorsState rockPaperScissorsState = new RockPaperScissorsState();

        public string ConvertJapanese(Hand hand) => (hand) switch
        {
            Hand.Rock => "グー",
            Hand.Scissors => "チョキ",
            Hand.Paper => "パー",
            _ => "エラー"
        };

        public void AddResult(Result? result)
        {
            results.Add(result);
        }

        public int GetTotalRecord()
        {
            return results.Count();
        }

        public Hand GetEnemyHand()
        {
            random = new Random();

            return (Hand)random.Next(0, 3);
        }


        // LINQによって求める結果の数を返す
        public int GetWinRecord()
        {
            var win = results.Where(w => w == Result.Win).Select(w => w);

            return win.Count();
        }

        public int GetLoseRecord()
        {
            var lose = results.Where(l => l == Result.Losing).Select(l => l);

            return lose.Count();
        }

        public int GetTieRecord()
        {
            var tie = results.Where(t => t == Result.Tie).Select(t => t);

            return tie.Count();
        }

        public string ValidateName(string name)
        {
            if(name.Length == 0)
            {
                return "あなた";
            }

            return name;
        }

        public int WinRateCalculate()
        {
            var win = results.Where(w => w == Result.Win).Select(w => w);

            int totalRecord = results.Count();

            int winRecord = win.Count();

            int winRate = winRecord != 0 ? (200 * winRecord + 1) / (totalRecord * 2): 0;

            return winRate;
        }
    }
}
