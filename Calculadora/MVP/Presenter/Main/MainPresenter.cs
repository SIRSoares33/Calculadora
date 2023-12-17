using Calculadora.Entities;
using Calculadora.MVP.Model.Main;
using Calculadora.MVP.View.Main;

namespace Calculadora.MVP.Presenter.Main
{
    public class MainPresenter
    {
        #region Entities
        private readonly IMainView _view;
        private readonly MainModel _model;
        #endregion

        #region Constructor
        public MainPresenter(IMainView view, MainModel model)
        {
            _view                             =  view;
            _view.SendClickedNumberButton    += addNumberClickedInExpression;
            _view.SendClickedOperationButton += addOperationClickedInExpression;
            _view.SendButtonResult           += resultButton;
            _view.SendButtonClear            += clearButton;

            _model = model;
        }
        #endregion

        #region Methods
        private void addNumberClickedInExpression(Button button) => _view.Expression += button.Text;

        private void addOperationClickedInExpression(Button button) 
        {
            foreach (Button buttonOpearation in _view.ButtonsOperation)
            {
                buttonOpearation.Enabled = false;
                buttonOpearation.Cursor = Cursors.No;
            }
            _view.Expression += button.Text;
        }
        private void resultButton() 
        {
            string[] operations = new string[] {"+", "-", "*", "/"};
            
            try
            {
                foreach (string operation in operations)
                {

                    if (_view.Expression.Contains(operation))
                        _view.Expression += " = " + _model.CheckExpression(new Calculation(_view.Expression.Split(operation).Select(long.Parse).ToArray()), operation).ToString();
                }
            }
            catch(ArgumentException ex)
            {
                _view.MessageErro("Erro", ex.Message);
            }
        }
        private void clearButton()
        {
            _view.Expression = string.Empty;

            foreach (Button buttonOpearation in _view.ButtonsOperation)
            {
                buttonOpearation.Enabled = true;
                buttonOpearation.Cursor = Cursors.Hand;
            }
        }
        #endregion
    }
}