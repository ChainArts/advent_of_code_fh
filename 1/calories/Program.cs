string[] lines = File.ReadAllLines("input.txt");  

int sum = 0;
int buff;
int [] maxValues = new int [lines.Length];
int i = 0; 

foreach (string line in lines) 
{
    if(line == "") {
        maxValues[i++] = sum;
        sum = 0;
    }
  
    int.TryParse(line, out buff);
    sum += buff;
}

Array.Resize(ref maxValues, i);
Array.Sort(maxValues);
int topThree = 0;
for(int j = 1; j <= 3; j++){
    topThree += maxValues[i-j];
    Console.WriteLine(maxValues[i-j]);

}
Console.WriteLine("Maximum: " + maxValues[i-1]);
Console.WriteLine("MaxThree: " + topThree);
