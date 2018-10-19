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
        public int NumVotes { get; private set; } // get to return the value and private set so we can only modify from this class

        public StackOverflowPost(string title, string descripion)
        {
            this._title = title;
            this._description = descripion;
            this._creationDate = DateTime.Now;
            this.NumVotes = 0;
        }

        public void VotePost(int applyVote)
        {
            this.NumVotes += applyVote;
        }        
    }
}
