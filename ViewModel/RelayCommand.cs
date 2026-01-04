using System;
using System.Windows.Input;

namespace Calculate_IMT.ViewModel;

public class RelayCommand:ICommand
{
    public Action action;
   

    public RelayCommand(Action action )
    {
        this.action = action;
        
    }

    public bool CanExecute(object? parameter)
    {

        return true;
    }

    public void Execute(object? parameter)
    {
        action();
    }

    public event EventHandler? CanExecuteChanged;
    public void RaiseCanExecuteChanged()
    {
        CanExecuteChanged?.Invoke(this, EventArgs.Empty);
    }
}