﻿/*************************************************
** auth： zsh2401@163.com
** date:  2018/8/15 15:44:31 (UTC +8:00)
** desc： ...
*************************************************/
using AutumnBox.GUI.Depending;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace AutumnBox.GUI.MVVM
{
    class NotificationObject : DependingObject,INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public void RaisePropertyChanged([CallerMemberName]string propertyName=null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}