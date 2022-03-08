using System;
using MvvmCross;
using MvvmCross.ViewModels;

namespace Demo
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            RegisterAppStart<MainViewModel>();
        }
    }
}
