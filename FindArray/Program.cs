string[] FindArray(string[] arr){
    int counter = 0;
    for(int i = 0; i < arr.Length; i++){
        if(arr[i].Length <= 3) counter +=1;
    }

    string[] newArray = new string[counter];
    int index = 0;

    for(int i = 0; i < arr.Length; i++){
        if(arr[i].Length <= 3){
            newArray[index] = arr[i];
            index += 1;
        }
    }
    return newArray;
}

void Show(string [] arr){

    Console.Write("{");
    for(int i = 0; i < arr.Length; i++){
        Console.Write(arr[i] + " ");
    }
    Console.WriteLine("\b}");
}

string[] test1 = {"hello", "2", "world", ":-)"};
string[] test2 = {"1234", "1567", "computer science", "-2"};
string[] test3 = {"Russia", "Denmark", "Kazan"};

string[] test1Arr = FindArray(test1);
string[] test2Arr = FindArray(test2);
string[] test3Arr = FindArray(test3);

Show(test1);
Show(test1Arr);
Show(test2);
Show(test2Arr);
Show(test3);
Show(test3Arr);