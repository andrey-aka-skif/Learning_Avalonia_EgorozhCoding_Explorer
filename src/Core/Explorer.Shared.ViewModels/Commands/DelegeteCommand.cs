﻿using System;
using System.Windows.Input;

namespace Explorer.Shared.ViewModels
{
    public class DelegeteCommand : ICommand
    {
        private readonly Action<object> _open;

        public DelegeteCommand(Action<object> open)
        {
            _open = open;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            _open?.Invoke(parameter);
        }

        public event EventHandler CanExecuteChanged;
    }
}
