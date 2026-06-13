int [][]  myArray= new int [3][] ;

myArray[0]= new  int [5];
myArray[1]= new int [3];
myArray[2]= new  int [5];

Random random= new Random();

for (int  i =0 ;i< myArray.Length;++i)
{
    for (int j =0; j < myArray[i].Length ;++j )
    {
        myArray[i][j]= random.Next(1000);
    }
}


for (int  i =0 ;i< myArray.Length;++i)
{
    for (int j =0; j < myArray[i].Length ;++j )
    {
      Console.WriteLine(myArray[i][j] + "\t");
    }
    Console.WriteLine();
}

