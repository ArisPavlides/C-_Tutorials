using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Summarising_Text
{
    enum SentenceParams
    {
        MaxLength = 20
    }

    class Program
    {
        static void Main()
        {
            string nabokov = @"As he crossed toward the pharmacy at the corner he involuntarily 
turned his head because of a burst of light that had ricocheted from his temple, and saw, with that 
quick smile with which we greet a rainbow or a rose, a blindingly white parallelogram of sky being unloaded 
from the van—a dresser with mirrors across which, as across a cinema screen, passed a flawlessly clear reflection 
of boughs sliding and swaying not arboreally, but with a human vacillation, produced by the nature of those who 
were carrying this sky, these boughs, this gliding façade.";

            string summary = GetSummary(nabokov);

            Console.WriteLine(summary);
            Console.ReadLine();
        }

        static string GetSummary(string nabokov)
        {
            if (nabokov.Length < (int)SentenceParams.MaxLength) { return nabokov; }

            else
            {
                string[] words = nabokov.Split(' ');
                int totalCharacters = 0;
                List<string> wordList = new List<string>();

                foreach (string word in words)
                {
                    wordList.Add(word);
                    totalCharacters += word.Length + 1; // +1 for spaces

                    if (totalCharacters >= (int)SentenceParams.MaxLength) { break; }
                }

                return String.Join(" ", wordList) + "...";
            }
        }
    }
}
