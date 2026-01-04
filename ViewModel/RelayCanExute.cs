using System;
using System.Windows.Input;

public class RelayCanExute : ICommand
{
    private Action action;
    Func<bool> canExecute;

    public RelayCanExute(Action action, Func<bool> canExecute)
    {
        this.action = action;
        this.canExecute = canExecute;
    }

    public void RaiseCanExecuteChanged()
    {
        CanExecuteChanged?.Invoke(this, EventArgs.Empty);
    }

    public bool CanExecute(object? parameter)
    {
        return canExecute();
    }

    public void Execute(object? parameter)
    {
        action();
    }

    public event EventHandler? CanExecuteChanged;
}