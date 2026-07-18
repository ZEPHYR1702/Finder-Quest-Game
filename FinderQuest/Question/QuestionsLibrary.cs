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
            new Questions("Planet tempat manusia tinggal?", "bumi", 20),
            new Questions("Hewan yang dikenal sebagai raja hutan?", "singa", 20),
            new Questions("Berapa hasil dari 10 x 5?", "50", 50),
            new Questions("Planet terbesar di tata surya?", "jupiter", 50),
            new Questions("Organ tubuh yang digunakan untuk memompa darah?", "jantung", 50),
            new Questions("Benua terbesar di dunia?", "asia", 50),
            new Questions("Apa simbol kimia untuk emas?", "au", 70),
            new Questions("Berapa jumlah provinsi di Indonesia?", "38", 70),
            new Questions("Planet yang dikenal sebagai Planet Merah?", "mars", 70),
            new Questions("Apa nama proses tumbuhan membuat makanan sendiri?", "fotosintesis", 70),
            new Questions("Satuan SI untuk kuat arus listrik?", "ampere", 70),
        };

        private static Random random = new Random();

        public static Questions GetRandomQuestion()
        {
            int index = random.Next(masterPool.Count);
            return masterPool[index];
        }
    }
}