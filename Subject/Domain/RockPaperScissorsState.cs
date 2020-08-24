using System;
using System.Collections.Generic;
using System.Text;

namespace Subject.Domain
{
    public class RockPaperScissorsState
    {
        private string name;

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        private int totalRecord;

        public int TotalRecord
        {
            get { return this.totalRecord; }
            set { this.totalRecord = value; }
        }

        private int winRecord;

        public int WinRecord
        {
            get { return this.winRecord; }
            set { this.winRecord = value; }
        }

        private int loseRecord;

        public int LoseRecord
        {
            get { return this.loseRecord; }
            set { this.loseRecord = value; }
        }

        private int tieRecord;

        public int TieRecord
        {
            get { return this.tieRecord; }
            set { this.tieRecord = value; }
        }

        public bool IsValidState(string name, int totalRecord, int winRecord, int loseRecord, int tieRecord)
        {
            Name = name;

            TotalRecord = totalRecord;

            WinRecord = winRecord;

            LoseRecord = loseRecord;

            TieRecord = tieRecord;

            return true;
        }
    }
}
