

string[] lines = File.ReadAllLines("input.txt");  

int max = 0;
int sum = 0;
int buff;
int len = lines.Length;
int [] maxValues = new int [len];
int i = 0; 

foreach (string line in lines) 
{
    if(line == "") {
        if(max < sum) {
            max = sum;
            maxValues[i++] = max;
        }
        sum = 0;
    }
    int.TryParse(line, out buff);
    sum += buff;
} 

Array.Resize(ref maxValues, i);
foreach (int item in maxValues)
{
    Console.WriteLine(item);
}
int topThree = maxValues[i-1] + maxValues[i - 2] + maxValues[i -3] + maxValues[i -4];
Console.WriteLine("Maximum: " + max);
Console.WriteLine("MaxThree: " + topThree);


