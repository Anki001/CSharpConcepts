
// All Strike
//int[] rolls = { 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10 }; // sample rolls for a game

//All Spare
//int[] rolls = { 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5 };

// Alternate Spare and Strike
//int[] rolls = { 5, 5, 10, 5, 5, 10, 5, 5, 10, 5, 5, 10, 5, 5, 10, 5, 5 };

// Random
int[] rolls = { 10, 9, 1, 5, 5, 7, 2, 10, 10, 10, 9, 0, 8, 2, 9, 1, 10 };

int score = 0;
int frame = 1;

for (int i = 0; i < rolls.Length && frame <= 10; i++)
{
    score += rolls[i]; // add pins knocked down to score

    if (frame < 10 && rolls[i] == 10) // if strike in a frame before the final frame
    {
        score += rolls[i + 1] + rolls[i + 2]; // add next two rolls as bonus
        //i--; // adjust index to account for bonus rolls
    }
    else if (frame < 10 && rolls[i] + rolls[i + 1] == 10) // if spare in a frame before the final frame
    {
        score += rolls[i + 2]; // add next roll as bonus
    }
    else if (frame == 10) // if in final frame
    {
        if (rolls[i] == 10 || rolls[i] + rolls[i + 1] == 10) // if strike or spare on first or second roll
        {
            score += rolls[i + 1] + rolls[i + 2]; // add next two rolls as bonus            
        }
    }

    if (i % 2 == 1 || rolls[i] == 10) // if end of frame (after second roll or strike)
    {
        frame++; // move to next frame
    }

    if (frame < 10 && rolls[i] == 10)
        i--; // adjust index to account for bonus rolls
}

Console.WriteLine("Total score: " + score); // print total score

