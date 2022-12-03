const int win = 6;      //win
const int draw = 3;    //draw
const int lost = 0;     //loose

const int rock = 1;     //eA pX 1
const int paper = 2;    //eB pY 2
const int scissors = 3; //eC pZ 3

int points = 0;

bool check = true;

foreach (string line in System.IO.File.ReadLines(@"input.txt"))
{

    if(line == "A X"){ // loose mit scissors
        points += lost + scissors;
    }else if(line == "A Y"){ // draw mit rock
        points += draw + rock;
    }else if(line == "A Z"){ // win mit papars
        points += win + paper;
    }else if(line == "B X"){ // loose mit rock
        points += lost + rock;
    }else if(line == "B Y"){ // draw mit paper
        points += draw + paper;
    }else if(line == "B Z"){ // win mit scissors
        points += win + scissors;
    }else if(line == "C X"){ // loose mit paper
        points += lost + paper;
    }else if(line == "C Y"){ // draw mit scissors
        points += draw + scissors;
    }else if(line == "C Z"){ // win mit rock
        points += win + rock;
    }else{
        check = false;
    }

}

System.Console.WriteLine(check);
System.Console.WriteLine(points); 
