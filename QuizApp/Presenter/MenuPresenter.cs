using System.Windows.Forms;
using QuizApp.Model;
using QuizApp.Model.Interface;
using QuizApp.View;
using QuizApp.View.Interface;

namespace QuizApp.Presenter
{
  public class MenuPresenter
  {
    private readonly IMenuModel _model;
    private readonly IMenuView _view;

    // TODO: Impl DI    

    public MenuPresenter(IMenuModel model, IMenuView view)
    {
      _model = model;
      _view = view;
    }

    public void StartQuiz()
    {
      QuizView view = new QuizView();
      view.ShowDialog();
    }
  }
}
