﻿using Prism.Interactivity.InteractionRequest;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChartListModule.ViewModels
{
    public class ConfirmViewModel : BindableBase, IInteractionRequestAware
    {
        private ItemSelectionNotification notification;



        public INotification Notification { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public Action FinishInteraction { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
