// See https://aka.ms/new-console-template for more information

using Dictionary;
class Program
{
    static void Main(string[] args)
    {
        MyDictionary<string, int> myDictionary = new MyDictionary<string,int>();
        myDictionary.Add("Bir", 1);
        myDictionary.Add("İki", 2);
        myDictionary.Add("Üç", 3);
        myDictionary.Add("İki", 5);


        myDictionary.Listele(myDictionary);

        



    }

}

