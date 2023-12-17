using Calculadora.MVP.Model.Main;
using Calculadora.MVP.Presenter.Main;
using Calculadora.MVP.View.Main;

namespace Calculadora;

public partial class MainView : Form, IMainView
{
    #region Entities
    private readonly MainPresenter _mainPresenter;
    #endregion

    #region Constructor
    public MainView()
    {
        InitializeComponent();
        _mainPresenter = new MainPresenter(this, new MainModel());
        ButtonsOperation = new List<Button>() { btnPlus, btnDivision, btnLess, btnMultiplicacao };
    }
    # endregion

    #region IMainView Attributes
    public string Expression { get => txtResult.Text; set => txtResult.Text = value; }
    public List<Button> ButtonsOperation { get; private set;}
    #endregion

    #region IMainView Events
    public event Action<Button>? SendClickedNumberButton;
    public event Action<Button>? SendClickedOperationButton;
    public event Action? SendButtonResult;
    public event Action? SendButtonClear;
    #endregion

    #region IMainViewMethods
    public void MessageErro(string caption, string message) => MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
    #endregion

    #region Methods
    private void clickedButtonsNumber(object sender, EventArgs e)    => SendClickedNumberButton?.Invoke(sender as Button);
    private void clickedButtonsOperation(object sender, EventArgs e) => SendClickedOperationButton?.Invoke(sender as Button);
    private void ClickedButtonResult(object sender, EventArgs e)     => SendButtonResult?.Invoke();
    private void ClickedButtonClear(object sender, EventArgs e)      => SendButtonClear?.Invoke();
    private void exit(object sender, EventArgs e)                    => Application.Exit();
    #endregion
}