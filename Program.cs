using System;
using System.Collections.Generic;



//https://open.kattis.com/problems/recount

/*
Penny Franklin
Marti Graham
Connie Froggatt
Joseph Ivers
Connie Froggatt
Penny Franklin
Connie Froggatt
Bruce Stanger
Connie Froggatt
Barbara Skinner
Barbara Skinner
***

Connie Froggatt

Penny Franklin
Connie Froggatt
Barbara Skinner
Connie Froggatt
Jose Antonio Gomez-Iglesias
Connie Froggatt
Bruce Stanger
Barbara Skinner
Barbara Skinner
***

Runoff!
*/



namespace ConsoleAppDictionary02
{
    class Program
    {
        static void Main(string[] args)
        {

            //Dictionary to hold the candidate name and voteCount
            Dictionary<string, int> candidateNameVoteCountDictionary = new Dictionary<string, int>();

            int WinningCandidateVoteCount = -1;
            string WinningCandidateName = null;
            int tieCount = 0;

            string currentName = Console.ReadLine();

            //Step 1 Read all the names of the votes casts using a loop and stop reading names when *** is entered.
            while (currentName != "***")
            {
                //Step 2 Find the unique candidate names
                //Step 3 Count the votes cast for each candidate

                // If dictionary does not contain the name add it and make vote count 1
                if (!candidateNameVoteCountDictionary.ContainsKey(currentName))
                {
                    candidateNameVoteCountDictionary.Add(currentName, 1);
                }
                // If dictionary does contain the name then increase the vote count
                else
                {

                    candidateNameVoteCountDictionary[currentName] += 1;
                }


                //Step 4 Find the candidate’s name with the highest amount of votes
                if (candidateNameVoteCountDictionary[currentName] > WinningCandidateVoteCount)
                {
                    //If the current name has the most votes then reset the tieCount
                    WinningCandidateVoteCount = candidateNameVoteCountDictionary[currentName];
                    WinningCandidateName = currentName;
                    tieCount = 0;
                }
                //Step 5 Check for a tie.
                else if (candidateNameVoteCountDictionary[currentName] == WinningCandidateVoteCount)
                {
                    // If the current name matches the winning vote count then add one
                    tieCount += 1;
                }

                currentName = Console.ReadLine();
            }

            // Step 6 print results.  If tie then write Runnoff!.  If not then write the winning candidate name
            if (tieCount > 0)
            {
                Console.WriteLine("Runoff!");
            }
            else
            {
                Console.WriteLine(WinningCandidateName);
            }

            /* this is just for debugging to check if vote count is wrong
             
            foreach (KeyValuePair<string, int> kvp in candidateNameVoteCountDictionary)
            {
                Console.WriteLine(kvp.Key + " " + kvp.Value);
            }
            */

        }
    }
}
