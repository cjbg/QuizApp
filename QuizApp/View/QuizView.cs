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

    public QuizView()
    {
      InitializeComponent();
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
      get { return checkBoxAnswer1.Text; }
      set { checkBoxAnswer1.Text = value; }
    }

    public string Answer2
    {
      get { return checkBoxAnswer2.Text; }
      set { checkBoxAnswer2.Text = value; }
    }

    public string Answer3
    {
      get { return checkBoxAnswer3.Text; }
      set { checkBoxAnswer3.Text = value; }
    }

    public string Answer4
    {
      get { return checkBoxAnswer4.Text; }
      set { checkBoxAnswer4.Text = value; }
    }

    public string Answer5
    {
      get { return checkBoxAnswer5.Text; }
      set { checkBoxAnswer5.Text = value; }
    }

    public Color ColorAnswer1
    {
      set { checkBoxAnswer1.ForeColor = value; }
    }

    public Color ColorAnswer2
    {
      set { checkBoxAnswer2.ForeColor = value; }
    }

    public Color ColorAnswer3
    {
      set { checkBoxAnswer3.ForeColor = value; }
    }

    public Color ColorAnswer4
    {
      set { checkBoxAnswer4.ForeColor = value; }
    }

    public Color ColorAnswer5
    {
      set { checkBoxAnswer5.ForeColor = value; }
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

    private void QuizView_Load(object sender, System.EventArgs e)
    {
      _presenter = new QuizPresenter(
        new QuizModel(),
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
