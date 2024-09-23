//Function to create array and fill with preset values
string[,] arrayFiller()
{
    string[,] fruits = { { "apple", "red" }, { "apple", "yellow" }, { "banana", "yellow" } };
    return fruits;
}

//Function that determines the sum of the ascii values given a string
int asciiSum(string s)
{
    int totalAscii = 0;
    foreach (char c in s)
    {
        int asciiChar = System.Convert.ToInt32(c);
        //Console.WriteLine(asciiChar);
        totalAscii += asciiChar;
    }
    return totalAscii;
}

//Hashing Function - Receives ascii sum and array size and returns the index to store in 
int hashFunction(int sum, int arraySize)
{
   int indexOutput = sum % arraySize;
   return indexOutput;
}

//create and fill the array
string[,] fruits = arrayFiller(); 

//nested loop iterates through array, handing strings to the asciiSum and hashFunctions to output index values
for (int i=0; i<fruits.GetLength(0); i++)
{
    string fruitName = fruits[i, 0];
    int sum = asciiSum(fruitName);
    int index = hashFunction(sum, fruits.GetLength(0));
    Console.WriteLine(index);
}