using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;

namespace AppEjemploWindows10
{
    class Orientation : StateTriggerBase
    {
        public Orientation()
        {
            Window.Current.SizeChanged += (s, e) =>
            {
                SetActive(ApplicationView.GetForCurrentView().Orientation.Equals(this.TheOrientation));
            };

            SetActive(ApplicationView.GetForCurrentView().Orientation.Equals(this.TheOrientation));
        }

        public ApplicationViewOrientation TheOrientation { get; set; }
    }
}
