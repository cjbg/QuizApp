using QuizApp.Interfaces;
using QuizApp.Model;
using QuizApp.View;

namespace QuizApp.Presenter
{
  public class MenuPresenter
  {
    private readonly IMenuModel _model;
    private readonly IMenuView _view;

    // TODO: Impl DI
    public MenuPresenter()
      : this(new MenuModel(), new MenuView())
    {      
    }

    public MenuPresenter(IMenuModel model, IMenuView view)
    {
      _model = model;
      _view = view;
    }
  }
}
