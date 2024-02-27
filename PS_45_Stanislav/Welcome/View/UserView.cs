﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Welcome.ViewModel;

namespace Welcome.View
{
    internal class UserView
    {
        private UserViewModel _viewModel;

        public UserView(UserViewModel viewModel)
        {
            _viewModel = viewModel;
        }
        public void Display()
        {
            Console.WriteLine("Welcome");
            Console.WriteLine(_viewModel.Name);
            Console.WriteLine(_viewModel.Role);

        }
    }
}
