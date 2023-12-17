using System.Net.Mime;
namespace Calculadora.MVP.View.Main
{
    public interface IMainView
    {
        /// <summary>
        /// É a expressão matemática que aparece no textbox ao fim da digitação (quando o botão de = é apertado).
        /// </summary>
        string Expression             { get; set;  }
        /// <summary>
        /// Lista de botões de operações matemáticas
        /// </summary>
        List<Button> ButtonsOperation { get; } 
        /// <summary>
        /// Este evento envia o número clicado e adiciona-o no textBox
        /// </summary>
        event Action<Button>? SendClickedNumberButton;
        /// <summary>
        /// Este evento envia a operação matemática até a presenter e adiciona-o no textbox.
        /// </summary>
        event Action<Button>? SendClickedOperationButton;
        /// <summary>
        /// Este evento avisa que o botão de resultado foi clicado.
        /// </summary>
        event Action? SendButtonResult;
        /// <summary>
        /// Este evento que o botão de limpar tela foi clicado.
        /// </summary>
        event Action? SendButtonClear;
        /// <summary>
        /// Envia uma mensagem de erro para a view.
        /// </summary>
        /// <param name="caption"></param>
        /// <param name="message"></param>
        void MessageErro(string caption, string message);
    }
}