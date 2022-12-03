string[] text = File.ReadAllLines("./input.txt");

/******** PART ONE ********/

int PartOne()
{
    int value = 0;
    string[] half = new string[2];
    foreach (var line in text)
    {
        half[0] = line[..(line.Length / 2)];
        half[1] = line[(line.Length / 2)..];

        for (int j = 0; j < half[0].Length; j++)
        {
            for (int k = 0; k < half[1].Length; k++)
            {
                if (half[0][j] == half[1][k])
                {
                    value += char.IsUpper(half[0][j]) ? half[0][j] - 38 : half[0][j] - 96;
                    k = half[1].Length;
                    j = half[0].Length;
                }
            }
        }
    }

    return value;
}

/******** PART TWO ********/

int PartTwo()
{
    int value = 0;
    for (int i = 0; i < text.Length; i += 3)
    {
        for (int k = 0; k < text[i].Length; k++) // k = current char in line
        {
            if (!text[i + 1].Contains(text[i][k]) || !text[i + 2].Contains(text[i][k])) continue;
            value += char.IsUpper(text[i][k]) ? text[i][k] - 38 : text[i][k] - 96;
            break;
        }
    }

    return value;
}

Console.WriteLine(PartOne());
Console.WriteLine(PartTwo());