using System;
using System.Collections.Generic;
using System.Text;
using System.Timers;

namespace TypeFast
{
    class Game
    {
        public Game()
        {
            score = 0;
            words = WordProvider.GetWords();
            random = new Random();
            time = new TimeSpan(0, 0, 60);
            timer = new Timer(time.TotalMilliseconds);
            timer.AutoReset = false;
            timer.Elapsed += TimeUp;
            timeIsUp = false;
        }

        private int score;
        private string[] words;
        private Random random;

        private Timer timer;
        private TimeSpan time;
        private bool timeIsUp;

        public void Start()
        {
            timer.Start();
            DateTime startTime = DateTime.Now;
            while (!timeIsUp)
            {
                Console.Clear();
                string word = words[random.Next(words.Length)];
                Console.WriteLine($"Score: {score}");
                Console.WriteLine($"Time remaining: {(int)((startTime - DateTime.Now + time).TotalSeconds)} seconds");
                Console.WriteLine();
                Console.WriteLine(word);
                Console.WriteLine();
                string typedWord = Console.ReadLine();
                if (typedWord == word)
                    score++;
                else
                    score--;
            }
        }

        private void TimeUp(object source, ElapsedEventArgs e)
        {
            timeIsUp = true;
            Console.Clear();
            Console.WriteLine("Time is up!");
            Console.WriteLine($"Your score: {score}");
            Console.WriteLine();
        }
    }
}
