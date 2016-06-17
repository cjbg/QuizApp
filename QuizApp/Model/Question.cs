using System.Collections.Generic;
using System.Linq;

namespace QuizApp.Model
{
  public class Question
  {
    public int Number { get; set; }

    public int RepetitionNumber { get; set; }

    public string Name { get; set; }

    public List<Answer> Answers { get; set; }    
  }
}
