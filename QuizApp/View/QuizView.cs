using System.Windows.Forms;
using QuizApp.Model;
using QuizApp.Presenter;
using QuizApp.Service;
using QuizApp.View.Interface;

namespace QuizApp.View
{
  public partial class QuizView : Form, IQuizView
  {
    private readonly QuizPresenter _presenter;

    public QuizView()
    {
      _presenter = new QuizPresenter(
        new QuizModel(),
        this,
        new QuizReader());

      InitializeComponent();
    }

    private void button1_Click(object sender, System.EventArgs e)
    {

    }
  }
}
