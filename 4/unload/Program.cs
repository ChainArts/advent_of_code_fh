int counter = 0;
int savedi =0;
int[] firstnum= new int[2];
int[] secondnum= new int[2];
string[] items = System.IO.File.ReadAllLines(@"input.txt");
foreach(string item in items){
    for(int i = 0; i<item.Length; i++){
        if(item.Substring(i,1)== ","){
            int.TryParse(item.Substring((savedi),(i-savedi)), out firstnum[1]);
            savedi=i+1;
        }if(i>3 && item.Substring(i,1)=="-"){
            int.TryParse(item.Substring((savedi),(i-savedi)), out secondnum[0]);
            savedi = i+1;
            int.TryParse(item.Substring((savedi), (item.Length-i-1)), out secondnum[1]);
            savedi=0;
        }else if(item.Substring(i,1)== "-"){
            int.TryParse(item.Substring(savedi,(i-savedi)), out firstnum[0]);
            savedi=i+1;
        }
    }
    if(((secondnum[0]<=firstnum[0])&&(firstnum[0]<=secondnum[1]))||((firstnum[0]<=secondnum[0])&&(secondnum[0]<=firstnum[1]))){
        counter +=1;
        Console.WriteLine("Contained");
    }else{
        Console.WriteLine("no Contained");
    }
}
Console.Write(counter);