//1
public Position Walk(string direction)
{
   var player = GetPlayer();
   player.Move(direction);
   return player.NewPosition;
} 

//2
public T FindMatch(T t)
{
   var match = (T)container.Get(t);
   return match;
}

//3
public void DoFitnessActivity(Action activity)
{
   GetDressed();
   activity();
   Shower();
}

