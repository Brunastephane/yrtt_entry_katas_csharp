using System;

// Scenario
// Several people are standing in a row divided into two teams. The first person goes into team 1, the second goes into team 2, the third goes into team 1, and so on.

// Task
// Given an array of positive integers (the weights of the people), return a new array of two integers, where the first one is the total weight of team 1, and the second one is the total weight of team 2.

// Notes
// Array size is at least 1.
// All numbers will be positive.

// Input >> Output Examples
// rowWeights([13, 27, 49])  ==>  return (62, 27)
// Explanation:
// The first element 62 is the total weight of team 1, and the second element 27 is the total weight of team 2.

// rowWeights([50, 60, 70, 80])  ==>  return (120, 140)
// Explanation:
// The first element 120 is the total weight of team 1, and the second element 140 is the total weight of team 2.

// rowWeights([80])  ==>  return (80, 0)
// Explanation:
// The first element 80 is the total weight of team 1, and the second element 0 is the total weight of team 2.

namespace TechReturners.Tasks
{
    public class Exercise003
    {
        public static int[] RowWeights(int[] a)
        {
            //Variable count for to verified the position of the weight on the list
            int count = 0;
            //Variables to sum the weights for each team
            int team1 = 0;
            int team2 = 0;

            //A Loop for check each item
            foreach (int item in a)
            {
                //This is verified if the position is even or odd, if is even sum to team1, if isnt, sum to team2
                if (count % 2 == 0)
                {
                    team1 = team1 + item;
                }
                else
                {
                    team2 = team2 + item;
                }
                count++;
            }

            return new int[] {team1,team2};
            throw new NotImplementedException();
        }
    }
}

