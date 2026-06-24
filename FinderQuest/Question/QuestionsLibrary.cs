using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinderQuest.Class;

namespace FinderQuest.Question
{
    public class QuestionsLibrary
    {
        private static List<Questions> masterPool = new List<Questions>
        {
            new Questions("1 + 1 =", 2.ToString(), 100),
            new Questions("Ibu kota Indonesia?", "jakarta", 50),
            new Questions("Kapan Indonesia Merdeka?", "1945", 70),
        };

        private static Random random = new Random();

        public static Questions GetRandomQuestion()
        {
            int index = random.Next(masterPool.Count);
            return masterPool[index];
        }
    }
}