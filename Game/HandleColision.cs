using System;
using Byui.Games.Casting;
using Byui.Games.Scripting;
using Byui.Games.Services;


namespace Example.Colliding
{
    /// <summary>
    /// Detects and resolves collisions between actors.
    /// </summary>
    public class CollideActorsAction : Byui.Games.Scripting.Action
    {
        private IKeyboardService _keyboardService;

        public CollideActorsAction(IServiceFactory serviceFactory)
        {
            _keyboardService = serviceFactory.GetKeyboardService();
        }

        public override void Execute(Scene scene, float deltaTime, IActionCallback callback)
        {
            try
            {
                // get the actors from the cast
                Actor 
                Actor bullet = scene.GetFirstActor("bullets");
                Actor alien = scene.GetFirstActor("aliens");
                



                /// THIS STUFF HERE IS FROM THE EXAMPLE CODE!!! WE'LL NEED TO UPDATE FROM HERE WHEN BULLETS AND ACTORS ARE MADE.

                // detect a collision between the actors.
                if (actor2.Overlaps(actor1)) // If bullet hits actor
                {
                    // Remove both actors
                    Remove(actor2);
                    Remove(actor1);
                }
                else
                {
                    // otherwise, remove at end of screen
                    
                }
            }
            catch (Exception exception)
            {
                callback.OnError("Couldn't check if actors collide.", exception);
            }
        }
        // From Corn
        private void HandleGameOver(Cast cast)
        {
            if (_isGameOver == true)
            {
                Snake p1 = (Snake)cast.GetFirstActor("p1");
                Snake p2 = (Snake)cast.GetFirstActor("p2");
                Food bullet = (Food)cast.GetFirstActor("bullet");
                Food invader = (Food)cast.GetFirstActor("invader");

                // create a "game over" message
                int x = Constants.MAX_X / 2;
                int y = Constants.MAX_Y / 2;
                Point position = new Point(x, y);

                Actor message = new Actor();
                message.SetText("Game Over!");
                message.SetPosition(position);
                cast.AddActor("messages", message);

                // make everything white
                
                    segment.SetColor(Constants.WHITE);
              
                    segment2.SetColor(Constants.WHITE);

                    food.SetColor(Constants.WHITE);
            }
        }
    }
}