using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_5_Student_Scores
{
    class Student
    {
        private string name;
        private int yeargroup;
        private int[] examscores = new int[5];


        public Student(string name, int yeargroup, int score1, int score2, int score3, int score4, int score5)
        {
            this.name = name;
            this.yeargroup = yeargroup;
            examscores[0] = score1;
            examscores[1] = score2;
            examscores[2] = score3;
            examscores[3] = score4;
            examscores[4] = score5;
        }

        public Student(string name, int yeargroup, int[] examscores)
        {
            this.name = name;
            this.yeargroup = yeargroup;
            this.examscores = examscores;
        }

        public double Getaverage()
        {
           int total = 0;
            for(int i = 0; i < 4; i = i + 1)
            {
                 total = total + examscores[i];
            }
            double average = (double) total / examscores.Length;
            return average;
        }

        public int Gethighest()
        {
            int highest = examscores[0];
            for(int i = 1; i < examscores.Length; i = i + 1)
            {
                if (examscores[i] > highest) highest = examscores[i];
            }
            return highest;
        }
        


        public int Getlowest()
        {
            int lowest = examscores[0];
            for (int i = 1; i < examscores.Length; i = i + 1)
            {
                if (examscores[i] < lowest) lowest = examscores[i];
            }
            return lowest;
        }

        public int[] Getallscores()
        {
            return examscores;
        }


    }
}
