
//Using if while
//display the cube of the odd numbers from 1 to 25 (inclusive) using a WHILE loop

int idx = 1;

while(idx <= 25)
{
    if(idx % 2 == 0)
    {
        idx++; //still need to increment it.
        continue; //skip it
    }
    //the number is odd
    Console.WriteLine($"{idx}^3 is {idx * idx * idx}");

    idx++; //don't forget this!
}
Console.WriteLine("Done");