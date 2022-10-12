// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

string[] FirstArray = new string[4] {"Hello", "2", "world", ":-)"};
string[] SecondArray = new string[FirstArray.Length];

void SelectionMassive(string[] FirstArray, string[] SecondArray)
{
    int count = 0;
    for (int i = 0; i< FirstArray.Length; i++)
    {
        if(FirstArray[i].Length <= 3)
        {
            SecondArray[count] = FirstArray[i];
            count++;
        }
    }
}

void PrintArray(string[] array)
{
    Console.Write("[" + string.Join(", ", array) + "]");
    Console.WriteLine();
}

SelectionMassive(FirstArray, SecondArray);
PrintArray(SecondArray);







