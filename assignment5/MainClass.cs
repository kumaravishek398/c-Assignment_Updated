using System;
using System.Collections;

namespace TeamPlayer  
{
    public class Player   
    {
        
        public String PlayerName ;
        public int RunScored ;

       //using parameterized constructor to initilize the fields
        public Player(string name, int runs){   
        PlayerName = name;
        RunScored = runs;
        
        }
    }

     public class Team :IEnumerable
{
        
    Player[] arrayOfPlayers=new Player[4];

    public Team()
    {

    arrayOfPlayers[0]=new Player("Virat", 150);
    arrayOfPlayers[1]= new Player("Avishek", 54);
    arrayOfPlayers[2]= new Player("Russel", 45);
    arrayOfPlayers[3] =new Player("Maxwell", 84);  
        
    }
        
        public IEnumerator GetEnumerator()  //implementing GetEnumerator method of IEnumerable interface
        {
           return arrayOfPlayers.GetEnumerator();

        }
}

        class MainClass   //driver code
        {
            static void Main(String[] args)
            {
                Team india=new Team();
                foreach(Player obj in india)
                {
                Console.WriteLine("Name: {0} and Run scored: {1}",obj.PlayerName,obj.RunScored);
                }
            }
        }

}


