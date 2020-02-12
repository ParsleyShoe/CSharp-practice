using System;
using System.Collections.Generic;
using System.Text;

namespace PigDice {
    class PigDiceGame {
        private Random rnd = new Random(DateTime.Now.Millisecond);
        public int RollTheDie() {
            return rnd.Next(1, 7);
        }
        public int PigDice() {
            var score = 0;
            var roll = RollTheDie();
            while (roll != 1) {
                score += roll;
                roll = RollTheDie();
            }
            return score;
        }
        public void Play() {
            var score = PigDice();
            Console.WriteLine($"Your score is {score}.");
        }
        public void Play100() {
            var WorldRecord = 350;
            var HighScore = 0;
            var GamesToPlay = 3000;
            while (GamesToPlay > 0 || HighScore < WorldRecord) {
                var score = PigDice();
                if (score > HighScore) {
                    HighScore = score;
                    Console.Write($"Your new high score is {HighScore}...\n");
                }
                GamesToPlay--;
            }
        }
        public void PlayPlay() {
            var score = PigDice();
            if (score < 87) {
                score = PigDice();
            } else Console.WriteLine(score);
        }
    }
}