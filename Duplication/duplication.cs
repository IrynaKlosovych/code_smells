//1
public Position WalkNorth()
{
   var player = GetPlayer();
   player.Move("N");
   return player.NewPosition;
}
 
public Position WalkSouth()
{
   var player = GetPlayer();
   player.Move("S");
   return player.NewPosition;
}
 
public Position WalkEast()
{
   var player = GetPlayer();
   player.Move("E");
   return player.NewPosition;
}
 
public Position WalkWest()
{
   var player = GetPlayer();
   player.Move("W");
   return player.NewPosition;
}

//2
public int FindIntMatch(int i)
{
   var match = (int)container.Get(i);
   return match;
}
 
public string FindStringMatch(string s)
{
   var match = (string)container.Get(s);
   return match;
}

//3
public void GoForRun()
{
   GetDressed();
   Run();
   Shower();
}
 
public void LiftWeights()
{
   GetDressed();
   Lift();
   Shower();
}

