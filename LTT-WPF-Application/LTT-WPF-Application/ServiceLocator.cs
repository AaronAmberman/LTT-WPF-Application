﻿using LTT_WPF_Application.Services;
using LTT_WPF_Application.ViewModels;
using SimpleRollingLogger;

namespace LTT_WPF_Application
{
    internal class ServiceLocator
    {
        #region Fields

        private static ServiceLocator instance = new ServiceLocator();
        private static readonly object @lock = new object();

        #endregion

        #region Properties

        /// <summary>Gets the instance of the <see cref="ServiceLocator" /> to use throughout the entire application.</summary>
        public static ServiceLocator Instance
        {
            get
            {
                lock (@lock)
                {
                    return instance;
                }
            }
        }


        public Logger Logger { get; set; }

        public MainWindowViewModel MainWindowViewModel { get; set; }

        public ThemingService ThemingService { get; set; }

        #endregion

        #region Constructors

        private ServiceLocator()
        {
        }

        #endregion
    }
}
