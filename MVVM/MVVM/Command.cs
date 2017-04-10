using System;
using System.Diagnostics;
using System.Windows.Input;

namespace MVVM
{
    public class Command : ICommand
    {
        #region Fields
        readonly Action<object> _action;
        readonly Predicate<object> _canExecute;
        #endregion

        #region Constructors
        public Command(Action<object> execute) : this(execute, ((object param) => true)) { }
        public Command(Action<object> execute, Predicate<object> canExecute)
        {
            if (execute == null)
            {
                throw new ArgumentNullException("execute");
            }
            else
            {
                _action = execute;
                _canExecute = canExecute;
            }
        }
        #endregion

        #region ICommand Members
        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }
        [DebuggerStepThrough]
        public bool CanExecute(object parameter)
        {
            return _canExecute(parameter);
        }
        public void Execute(object parameter)
        {
            _action(parameter);
        }
        #endregion
    }
}
