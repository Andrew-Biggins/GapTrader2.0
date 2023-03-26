using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MvvmArchitecture;

public class ViewModelBase : INotifyPropertyChanged
{
    public event PropertyChangedEventHandler? PropertyChanged;

    protected void SetProperty<T>(ref T member, T value, [CallerMemberName] string propertyName = "")
    {
        if (!Equals(member, value))
        {
            member = value;
            PropertyChanged.Raise(this, propertyName);
        }
    }

    protected void RaisePropertyChanged(string propertyName) => PropertyChanged.Raise(this, propertyName);
}