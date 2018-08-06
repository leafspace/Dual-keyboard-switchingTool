﻿using Caliburn.Micro;
using Panuon.UIBrowser.ViewModels.Partial;
using System;
using System.ComponentModel.Composition;
using System.Windows.Threading;

namespace Panuon.UIBrowser.ViewModels
{
    [Export(typeof(IShell))]

    public class MainWindowViewModel : Conductor<IShell>.Collection.OneActive, IShell
    {
        public MainWindowViewModel()
        {
            ActivateItem(new IntroductionViewModel());
        }

        public void ChangeSelect(int select)
        {
            switch (select)
            {
                case 0:
                    ActivateItem(new IntroductionViewModel());
                    return;
                case 1:
                    ActivateItem(new WindowsViewModel());
                    return;
                case 2:
                    ActivateItem(new ButtonsViewModel());
                    return;
                case 3:
                    ActivateItem(new TextBoxsViewModel());
                    return;
                case 4:
                    ActivateItem(new PasswordBoxsViewModel());
                    return;
                case 5:
                    ActivateItem(new CheckBoxsViewModel());
                    return;
                case 6:
                    ActivateItem(new RadioButtonsViewModel());
                    return;
                case 7:
                    ActivateItem(new TreeViewsViewModel());
                    return;
                case 8:
                    ActivateItem(new ProgressBarsViewModel());
                    return;
                case 9:
                    ActivateItem(new SpecialViewModel());
                    return;
                case 101:
                    ActivateItem(new LineChartsViewModel());
                    return;

            }
        }

    }
}
