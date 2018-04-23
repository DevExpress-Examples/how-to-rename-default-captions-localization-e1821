using System.Windows.Controls;
using DevExpress.AgDataGrid.Localization;

namespace AgDataGrid_Localization {
    public partial class MainPage : UserControl {
        public MainPage() {
            InitializeComponent();
            AgDataGridLocalizer.Active = new MyCustomLocalizer();
            grid.DataSource = ProductList.GetData();
        }
    }

    public class MyCustomLocalizer : AgDataGridLocalizer {
        // Replaces the default string displayed within the empty Column Chooser.
        public override string GetLocalizedString(AgDataGridStringId id) {
            if (id == AgDataGridStringId.ColumnChooserEmptyText)
                return "To hide a column, drop its header here";
            return base.GetLocalizedString(id);
        }
    }
}
