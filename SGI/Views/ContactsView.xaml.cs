using SGI.ViewModels;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SGI.Views
{
    /// <summary>
    /// Lógica de interacción para ContactsView.xaml
    /// </summary>
    public partial class ContactsView : UserControl
    {
        public ContactsView()
        {
            InitializeComponent();

        }
        private void DataGridContacts_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
                DataGridCellInfo cell0 = DataGridContacts.SelectedCells[0]; txtId.Text = ((TextBlock)cell0.Column.GetCellContent(cell0.Item)).Text;
                DataGridCellInfo cell1 = DataGridContacts.SelectedCells[1]; txtName.Text = ((TextBlock)cell1.Column.GetCellContent(cell1.Item)).Text;
                DataGridCellInfo cell2 = DataGridContacts.SelectedCells[2]; txtPrimerAP.Text = ((TextBlock)cell2.Column.GetCellContent(cell2.Item)).Text;
                DataGridCellInfo cell3 = DataGridContacts.SelectedCells[3]; txtSegundoAP.Text = ((TextBlock)cell3.Column.GetCellContent(cell3.Item)).Text;
                DataGridCellInfo cell4 = DataGridContacts.SelectedCells[4]; txtCelular.Text = ((TextBlock)cell4.Column.GetCellContent(cell4.Item)).Text;
                DataGridCellInfo cell5 = DataGridContacts.SelectedCells[5]; txtEmail.Text = ((TextBlock)cell5.Column.GetCellContent(cell5.Item)).Text;
                DataGridCellInfo cell6 = DataGridContacts.SelectedCells[6]; txtCargo.Text = ((TextBlock)cell6.Column.GetCellContent(cell6.Item)).Text;
               
                DataGridCellInfo cell7 = DataGridContacts.SelectedCells[7]; cbxArea.Text = ((TextBlock)cell7.Column.GetCellContent(cell7.Item)).Text;
                DataGridCellInfo cell8 = DataGridContacts.SelectedCells[8]; cbxTienda.Text = ((TextBlock)cell8.Column.GetCellContent(cell8.Item)).Text;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
        }
    }
}

