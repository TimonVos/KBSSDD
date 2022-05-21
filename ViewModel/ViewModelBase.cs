using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Service.AssessmentServices;
using Service.Database;
using ViewModel.FormAssessment;

namespace ViewModel
{
    /// <summary>
    /// Base viewmodel class for all view models to inherit property changed functionality and shared objects
    /// </summary>
    public class ViewModelBase : INotifyPropertyChanged
    {
        #region ViewModels_SharedObjects
        /// <summary>
        /// Factory object used in view models to create other view models based off of models
        /// </summary>
        protected AssessmentFormFactory Factory = new();
        /// <summary>
        /// Assessment helper object for the view models for functionality like grade calculations
        /// </summary>
        protected AssessmentHelper Helper = new();
        #endregion
        #region INotifyPropertChanged_Implementation
        /// <summary>
        /// Event called upon when during the use of the screens a property is changed
        /// </summary>
        public event PropertyChangedEventHandler? PropertyChanged;
        /// <summary>
        /// PropertyChanged event handler, uses c# property changed event args
        /// </summary>
        /// <param name="propertyName">Name of the currently changing property</param>
        protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion

    }
}
