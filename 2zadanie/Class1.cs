using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2zadanie
{
    class Class1
    {
        //stan (zmienne- pola)
        List<float> ratings = new List<float>();


        //zachowania
        public void AddRating(float rating)
        {
            ratings.Add(rating);
        }
        public float CalculateAverage()
        {   //obliczanie średniej
            float sum = 0, avg = 0;
            foreach (var rating in ratings)
            {
                sum += rating;
            }
            avg = sum / ratings.Count();
            return avg;
        }
        public float GiveMaxRating()
        {
            return ratings.Max();
        }
        public float GiveMinRating()
        {
            return ratings.Min();
        }
        public float GiveCountRating()
        {
            return ratings.Count();
        }

        public float GiveSumRating()
        {
            return ratings.Sum();
        }
        public float GiveMedianRating()
        {
            float med = 0;
            ratings.Sort();
            if (ratings.Count % 2 == 0)
            {
                med = (float)(ratings[(ratings.Count / 2) - 1] + ratings[(ratings.Count / 2)]) / 2;
            }
            else
            {
                med = (float)ratings[(ratings.Count / 2)];
            }

            return med;
        }
      
        //tutaj dupa się zaczyna
          public float GiveRating()
        {
            for (int i = 0; i < ratings.Count; i++)
            {
               Console.WriteLine(ratings[i]);
            }
        }
        
           
}

        


