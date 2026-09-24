using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module5Lab {
    //Class declaration
    internal class Player {
        //Variables - attributes
        private string name;
        private int score;
        private int livesLeft;

        //Constructors -- special methods that make a new object (a new instance of the class)
        //Create a Player object with no values assigned to the attributes
        public Player(){

        } // end constructor 

        //Constructor method creates a new PLayer object and it sets the value for the name
        //attribute
        public Player(string name) {
            //Set the name attribute on the new object to be the name
            //that was passed into the constructor method
            this.name = name;
        } //end constructor 

        // Constructor is going to create a new object and set the value of the name
        //and the number of lives the player has left
        public Player(string name, int startingLives) {
            // Set the name that was passed to the constructor method as the
            // value of the name attribute on the Player object we are making
            this.name = name;

            // Assign the value of the livesleft attribute
            livesLeft = startingLives;
        } //end constructor

        //Methods - these are actions that the object can perform.
        //When you call a method it does a specific task.
        public int GetScore() {
            // this method returns the player's score
            return score;
        } // end method

        // Method's task is to add points to the player's score
        public void AddPoints(int totalPoints) {
            //Add the total points to the score
            score += totalPoints;
        } //end method

        // Method to kill the player in the game
        public void Kill() {
            //Make sure they can't get negative lives
            if (livesLeft > 0) {
                // Remove one of their lives when they get killed
                livesLeft--;
            }
        } // end method

        // Returns the number of lives that are left for the player
        public int GetLivesLeft() {
            // Returns - passes back the number of lives the player has left
            return livesLeft;
        } //end method 
    }
}