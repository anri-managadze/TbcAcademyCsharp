using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;

namespace Task
{
    public class FillingFunctionality
    {
        public int Filling()
        {
            int score = 0;
            string filePath = "quiz.txt";

                using (StreamReader streamReader = new StreamReader(filePath))
                {        
                    string line;
                    while ((line = streamReader.ReadLine()) != null)
                    {             
                        Console.WriteLine(line);
                        Console.WriteLine("Enter the correct answer:");

                        string correctAnswer = streamReader.ReadLine();
                        string userAnswer = Console.ReadLine();

                        if (userAnswer == correctAnswer)
                        {
                            score++;
                        }
                    }
            }
            return score;
        }
    }
}
