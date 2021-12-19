using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lquizzes.com
{
    public class Quizzes
    {
        public List<Quiz> quizzes;

    }
    public class Quiz
    {
        public int id;
        public string Name;
        public string description;
        public List<Question> questions;
        public string image;
        public int success_score;

        public Quiz(string name, string description, List<Question> questions, string image, int success_score)
        {
            Name = name;
            this.description = description;
            this.questions = questions;
            this.image = image;
            this.success_score = success_score;
        }
    }

    public class Question
    {
        public string question;
        public List<string> answers;
        public int correct;
        public int points;
        public Question(string question, List<string> answers, int correct, int points)
        {
            this.question = question;
            this.answers = answers;
            this.correct = correct;
            this.points = points;
        }
    }

    public class result
    {
        public Boolean success;
        public int grade;
    }
}