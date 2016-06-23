using System.Drawing;
using System.Windows.Forms;
using QuizApp.Model;
using QuizApp.Presenter;
using QuizApp.Service;
using QuizApp.View.Interface;

namespace QuizApp.View
{
  public partial class QuizView : Form, IQuizView
  {
    private QuizPresenter _presenter;
    private readonly bool _shuffleAnswers;
    private readonly bool _hideAnswerLetter;
    private readonly int _repetitionNumber;
    private readonly string _textFromResource;

    public QuizView(bool shuffleAnswers, bool hideAnswerLetter, int repetitionNumber, string textFromResource)
    {
      InitializeComponent();
      _shuffleAnswers = shuffleAnswers;
      _hideAnswerLetter = hideAnswerLetter;
      _repetitionNumber = repetitionNumber;
      _textFromResource = textFromResource;
    }

    private void buttonNextQuestion_Click(object sender, System.EventArgs e)
    {
      buttonCheck.Enabled = true;      
      _presenter.SetNextQuestion();
    }

    public string Question
    {
      get { return textBoxQuestion.Text; }
      set { textBoxQuestion.Text = value; }
    }

    public string Answer1
    {
      get { return textBoxAnswer1.Text; }
      set { textBoxAnswer1.Text = value; }
    }

    public string Answer2
    {
      get { return textBoxAnswer2.Text; }
      set { textBoxAnswer2.Text = value; }
    }

    public string Answer3
    {
      get { return textBoxAnswer3.Text; }
      set { textBoxAnswer3.Text = value; }
    }

    public string Answer4
    {
      get { return textBoxAnswer4.Text; }
      set { textBoxAnswer4.Text = value; }
    }

    public string Answer5
    {
      get { return textBoxAnswer5.Text; }
      set { textBoxAnswer5.Text = value; }
    }

    public Color ColorAnswer1
    {
      set { textBoxAnswer1.ForeColor = value; }
    }

    public Color ColorAnswer2
    {
      set { textBoxAnswer2.ForeColor = value; }
    }

    public Color ColorAnswer3
    {
      set { textBoxAnswer3.ForeColor = value; }
    }

    public Color ColorAnswer4
    {
      set { textBoxAnswer4.ForeColor = value; }
    }

    public Color ColorAnswer5
    {
      set { textBoxAnswer5.ForeColor = value; }
    }

    public bool CheckedAnswer1
    {
      get { return checkBoxAnswer1.Checked; }
      set { checkBoxAnswer1.Checked = value; }
    }

    public bool CheckedAnswer2
    {
      get { return checkBoxAnswer2.Checked; }
      set { checkBoxAnswer2.Checked = value; }
    }

    public bool CheckedAnswer3
    {
      get { return checkBoxAnswer3.Checked; }
      set { checkBoxAnswer3.Checked = value; }
    }

    public bool CheckedAnswer4
    {
      get { return checkBoxAnswer4.Checked; }
      set { checkBoxAnswer4.Checked = value; }
    }

    public bool CheckedAnswer5
    {
      get { return checkBoxAnswer5.Checked; }
      set { checkBoxAnswer5.Checked = value; }
    }   

    public bool CheckButtonEnabled
    {
      get { return buttonCheck.Enabled; }
      set { buttonCheck.Enabled = value; }
    }

    public bool LearnedButtonEnabled
    {
      get { return buttonQuestionLearned.Enabled; }
      set { buttonQuestionLearned.Enabled = value; }
    }

    public bool NextButtonEnabled
    {
      get { return buttonNextQuestion.Enabled; }
      set { buttonNextQuestion.Enabled = value;}
    }

    public void SetHeightAnswer1(int height)
    {
      textBoxAnswer1.Height = height;
    }

    public bool VisibleAnswer1
    {
      set
      {
        textBoxAnswer1.Visible = value;
        checkBoxAnswer1.Visible = value;
      }
    }

    public bool VisibleAnswer2
    {
      set
      {
        textBoxAnswer2.Visible = value;
        checkBoxAnswer2.Visible = value;
      }
    }

    public bool VisibleAnswer3
    {
      set
      {
        textBoxAnswer3.Visible = value;
        checkBoxAnswer3.Visible = value;
      }
    }

    public bool VisibleAnswer4
    {
      set
      {
        textBoxAnswer4.Visible = value;
        checkBoxAnswer4.Visible = value;
      }
    }

    public bool VisibleAnswer5
    {
      set
      {
        textBoxAnswer5.Visible = value;
        checkBoxAnswer5.Visible = value;
      }
    }

    private void QuizView_Load(object sender, System.EventArgs e)
    {
      _presenter = new QuizPresenter(
        new QuizModel(
          _shuffleAnswers, 
          _hideAnswerLetter,
          _repetitionNumber,
          _textFromResource),
        this,
        new QuizReader());
    }

    private void buttonCheck_Click(object sender, System.EventArgs e)
    {
      _presenter.CheckAnswers();
      buttonCheck.Enabled = false;
    }

    private void buttonQuestionLearned_Click(object sender, System.EventArgs e)
    {
      _presenter.QuestionLearned();
    }
  }
}
    