using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Answers
{
    class StackOverflowPost
    {
        private readonly string _title;
        private readonly string _description;
        private readonly DateTime _creationDate;
        private int numVotes;

        public StackOverflowPost(string title, string descripion)
        {
            this._title = title;
            this._description = descripion;
            this._creationDate = DateTime.Now;
            this.numVotes = 0;
        }

        public void VotePost(int applyVote)
        {
            this.numVotes += applyVote;
        }

        public int ReturnVotes()
        {
            return numVotes;
        }
    }
}
