using System.Windows.Controls;
using JuliusSweetland.OptiKey.Properties;

namespace JuliusSweetland.OptiKey.UI.Views.Management
{
    /// <summary>
    /// Interaction logic for DictionaryView.xaml
    /// </summary>
    public partial class DictionaryView : UserControl
    {
        public DictionaryView()
        {
            InitializeComponent();
        }

        public bool DictionaryControlsAvailable
        {
            get
            {
                return Settings.Default.SuggestionMethod == Enums.SuggestionMethods.NGram
                    || Settings.Default.SuggestionMethod == Enums.SuggestionMethods.Basic;
            }
        }

        public bool DictionaryControlsUnavailable
        {
            get
            {
                return Settings.Default.SuggestionMethod != Enums.SuggestionMethods.NGram
                    && Settings.Default.SuggestionMethod != Enums.SuggestionMethods.Basic;
            }
        }

        public bool DictionaryIsPresage
        {
            get
            {
                return Settings.Default.SuggestionMethod == Enums.SuggestionMethods.Presage;
            }
        }
    }
}
