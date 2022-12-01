string[] lines = File.ReadAllLines("input.txt");  

int max = 0;
int sum = 0;
int buff;
int [] maxValues = new int [lines.Length];
int i = 0; 

foreach (string line in lines) 
{
    if(line == "") {
        if(max <= sum) {
            max = maxValues[i++] = sum;
            Console.WriteLine(sum);
        }
        sum = 0;
    }
    else{
        buff = int.Parse(line);
        sum += buff;
    }
} 

Array.Resize(ref maxValues, i);
int topThree = maxValues[i-1] + maxValues[i - 2] + maxValues[i -3];
Console.WriteLine("Maximum: " + max);
Console.WriteLine("MaxThree: " + topThree);


