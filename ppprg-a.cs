using System.Globalization;

int[] myArray= new int  [10];
Console.WriteLine("Введи 10 чисел ");


{
    for ( int i=0; i< myArray.Length; i++)
    {
      myArray[i]=int.Parse(Console.ReadLine());
    }
for ( int i=0; i< myArray.Length; i++)
{

     for ( int j = i + 1 ; j<myArray.Length;++j )
      {       
       if (myArray[j]==myArray[i])
        Console.WriteLine("Повторяется число :"+ myArray[j]);
        break;
      }
}
}
