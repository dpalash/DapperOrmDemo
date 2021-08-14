using System;
using System.Collections.Generic;
using System.Data;
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
using DapperOrmDemo.DBEntities;
using DapperOrmDemo.Repository;

namespace DapperOrmDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly DapperRepository _dapperRepository;
        public MainWindow()
        {
            InitializeComponent();

            _dapperRepository = new DapperRepository();
        }

        private void BtnPopulateAuthorsDataInDatabase_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnGetAllAuthors_Click(object sender, RoutedEventArgs e)
        {
            var allAuthorsRecordFromDatabase = _dapperRepository.GetAllAuthors();
        }

        private void BtnBulkInsertIntoAuthorsTable_Click(object sender, RoutedEventArgs e)
        {
            var listOfAuthors = GenerateListOfAuthors();
            _dapperRepository.BulkInsertInAuthorsTable(listOfAuthors);
        }

        private void BtnBulkInsertIntoAuthorsTableWithSp_Click(object sender, RoutedEventArgs e)
        {
            var authorsDataTable = GenerateAuthorsDataTable();
            _dapperRepository.BulkInsertInAuthorsTableWithSp(authorsDataTable);
        }

        private void BtnBulkInsertIntoUsersTableWithSp_Click(object sender, RoutedEventArgs e)
        {
            var usersDataTable = GenerateUsersDataTable();
            _dapperRepository.BulkInsertInUsersTableWithSp(usersDataTable);
        }

        private void BtnGetAllAuthorsAndUsers_Click(object sender, RoutedEventArgs e)
        {
            var dataAsTupleFrom2DifferentTables = _dapperRepository.GetDataFrom2TablesWithSingleQuery();
        }

        private List<Authors> GenerateListOfAuthors()
        {
            List<Authors> listOfAuthors = new List<Authors>();
            for (int i = 0; i < 100000; i++)
            {
                listOfAuthors.Add(new Authors()
                {
                    FirstName = $"Palash-{i}",
                    LastName = $"Debnath-{i}",
                    Age = i,
                    Comment = "The IsOpen property of the Popup that is created by the control template of the MenuItem is bound to the IsSubmenuOpen property of the MenuItem. That's to say, when the user click ouside, the MenuItem loses keyboard focus and set its IsSubmenuOpen property to false. So the Popup in the visual tree of the MenuItem is closed. An ugly workaround to keep the Popup open when the user clicks ouside of the MenuItem is to set the IsSubmenuOpen property to true in the PreviewLostKeyboardFocus event handler of the MenuItem.For example:",
                    Comment1 = "The IsOpen property of the Popup that is created by the control template of the MenuItem is bound to the IsSubmenuOpen property of the MenuItem. That's to say, when the user click ouside, the MenuItem loses keyboard focus and set its IsSubmenuOpen property to false. So the Popup in the visual tree of the MenuItem is closed. An ugly workaround to keep the Popup open when the user clicks ouside of the MenuItem is to set the IsSubmenuOpen property to true in the PreviewLostKeyboardFocus event handler of the MenuItem.For example:",
                    Comment2 = "The IsOpen property of the Popup that is created by the control template of the MenuItem is bound to the IsSubmenuOpen property of the MenuItem. That's to say, when the user click ouside, the MenuItem loses keyboard focus and set its IsSubmenuOpen property to false. So the Popup in the visual tree of the MenuItem is closed. An ugly workaround to keep the Popup open when the user clicks ouside of the MenuItem is to set the IsSubmenuOpen property to true in the PreviewLostKeyboardFocus event handler of the MenuItem.For example:",
                    Comment3 = "The IsOpen property of the Popup that is created by the control template of the MenuItem is bound to the IsSubmenuOpen property of the MenuItem. That's to say, when the user click ouside, the MenuItem loses keyboard focus and set its IsSubmenuOpen property to false. So the Popup in the visual tree of the MenuItem is closed. An ugly workaround to keep the Popup open when the user clicks ouside of the MenuItem is to set the IsSubmenuOpen property to true in the PreviewLostKeyboardFocus event handler of the MenuItem.For example:",
                    Comment4 = "The IsOpen property of the Popup that is created by the control template of the MenuItem is bound to the IsSubmenuOpen property of the MenuItem. That's to say, when the user click ouside, the MenuItem loses keyboard focus and set its IsSubmenuOpen property to false. So the Popup in the visual tree of the MenuItem is closed. An ugly workaround to keep the Popup open when the user clicks ouside of the MenuItem is to set the IsSubmenuOpen property to true in the PreviewLostKeyboardFocus event handler of the MenuItem.For example:",
                    Comment5 = "The IsOpen property of the Popup that is created by the control template of the MenuItem is bound to the IsSubmenuOpen property of the MenuItem. That's to say, when the user click ouside, the MenuItem loses keyboard focus and set its IsSubmenuOpen property to false. So the Popup in the visual tree of the MenuItem is closed. An ugly workaround to keep the Popup open when the user clicks ouside of the MenuItem is to set the IsSubmenuOpen property to true in the PreviewLostKeyboardFocus event handler of the MenuItem.For example:",
                    Comment6 = "The IsOpen property of the Popup that is created by the control template of the MenuItem is bound to the IsSubmenuOpen property of the MenuItem. That's to say, when the user click ouside, the MenuItem loses keyboard focus and set its IsSubmenuOpen property to false. So the Popup in the visual tree of the MenuItem is closed. An ugly workaround to keep the Popup open when the user clicks ouside of the MenuItem is to set the IsSubmenuOpen property to true in the PreviewLostKeyboardFocus event handler of the MenuItem.For example:",
                    Comment7 = "The IsOpen property of the Popup that is created by the control template of the MenuItem is bound to the IsSubmenuOpen property of the MenuItem. That's to say, when the user click ouside, the MenuItem loses keyboard focus and set its IsSubmenuOpen property to false. So the Popup in the visual tree of the MenuItem is closed. An ugly workaround to keep the Popup open when the user clicks ouside of the MenuItem is to set the IsSubmenuOpen property to true in the PreviewLostKeyboardFocus event handler of the MenuItem.For example:",
                    Comment8 = "The IsOpen property of the Popup that is created by the control template of the MenuItem is bound to the IsSubmenuOpen property of the MenuItem. That's to say, when the user click ouside, the MenuItem loses keyboard focus and set its IsSubmenuOpen property to false. So the Popup in the visual tree of the MenuItem is closed. An ugly workaround to keep the Popup open when the user clicks ouside of the MenuItem is to set the IsSubmenuOpen property to true in the PreviewLostKeyboardFocus event handler of the MenuItem.For example:",
                    Comment9 = "The IsOpen property of the Popup that is created by the control template of the MenuItem is bound to the IsSubmenuOpen property of the MenuItem. That's to say, when the user click ouside, the MenuItem loses keyboard focus and set its IsSubmenuOpen property to false. So the Popup in the visual tree of the MenuItem is closed. An ugly workaround to keep the Popup open when the user clicks ouside of the MenuItem is to set the IsSubmenuOpen property to true in the PreviewLostKeyboardFocus event handler of the MenuItem.For example:",
                    Comment10 = "The IsOpen property of the Popup that is created by the control template of the MenuItem is bound to the IsSubmenuOpen property of the MenuItem. That's to say, when the user click ouside, the MenuItem loses keyboard focus and set its IsSubmenuOpen property to false. So the Popup in the visual tree of the MenuItem is closed. An ugly workaround to keep the Popup open when the user clicks ouside of the MenuItem is to set the IsSubmenuOpen property to true in the PreviewLostKeyboardFocus event handler of the MenuItem.For example:",
                    Comment11 = "The IsOpen property of the Popup that is created by the control template of the MenuItem is bound to the IsSubmenuOpen property of the MenuItem. That's to say, when the user click ouside, the MenuItem loses keyboard focus and set its IsSubmenuOpen property to false. So the Popup in the visual tree of the MenuItem is closed. An ugly workaround to keep the Popup open when the user clicks ouside of the MenuItem is to set the IsSubmenuOpen property to true in the PreviewLostKeyboardFocus event handler of the MenuItem.For example:",
                    Comment12 = "The IsOpen property of the Popup that is created by the control template of the MenuItem is bound to the IsSubmenuOpen property of the MenuItem. That's to say, when the user click ouside, the MenuItem loses keyboard focus and set its IsSubmenuOpen property to false. So the Popup in the visual tree of the MenuItem is closed. An ugly workaround to keep the Popup open when the user clicks ouside of the MenuItem is to set the IsSubmenuOpen property to true in the PreviewLostKeyboardFocus event handler of the MenuItem.For example:",
                    Comment13 = "The IsOpen property of the Popup that is created by the control template of the MenuItem is bound to the IsSubmenuOpen property of the MenuItem. That's to say, when the user click ouside, the MenuItem loses keyboard focus and set its IsSubmenuOpen property to false. So the Popup in the visual tree of the MenuItem is closed. An ugly workaround to keep the Popup open when the user clicks ouside of the MenuItem is to set the IsSubmenuOpen property to true in the PreviewLostKeyboardFocus event handler of the MenuItem.For example:",
                    Comment14 = "The IsOpen property of the Popup that is created by the control template of the MenuItem is bound to the IsSubmenuOpen property of the MenuItem. That's to say, when the user click ouside, the MenuItem loses keyboard focus and set its IsSubmenuOpen property to false. So the Popup in the visual tree of the MenuItem is closed. An ugly workaround to keep the Popup open when the user clicks ouside of the MenuItem is to set the IsSubmenuOpen property to true in the PreviewLostKeyboardFocus event handler of the MenuItem.For example:",
                    Comment15 = "The IsOpen property of the Popup that is created by the control template of the MenuItem is bound to the IsSubmenuOpen property of the MenuItem. That's to say, when the user click ouside, the MenuItem loses keyboard focus and set its IsSubmenuOpen property to false. So the Popup in the visual tree of the MenuItem is closed. An ugly workaround to keep the Popup open when the user clicks ouside of the MenuItem is to set the IsSubmenuOpen property to true in the PreviewLostKeyboardFocus event handler of the MenuItem.For example:"
                });
            }

            return listOfAuthors;
        }

        private DataTable GenerateAuthorsDataTable()
        {
            var output = new DataTable();

            output.Columns.Add("FirstName", typeof(string));
            output.Columns.Add("LastName", typeof(string));
            output.Columns.Add("Age", typeof(int));
            output.Columns.Add("Comment", typeof(string));
            output.Columns.Add("Comment1", typeof(string));
            output.Columns.Add("Comment2", typeof(string));
            output.Columns.Add("Comment3", typeof(string));
            output.Columns.Add("Comment4", typeof(string));
            output.Columns.Add("Comment5", typeof(string));
            output.Columns.Add("Comment6", typeof(string));
            output.Columns.Add("Comment7", typeof(string));
            output.Columns.Add("Comment8", typeof(string));
            output.Columns.Add("Comment9", typeof(string));
            output.Columns.Add("Comment10", typeof(string));
            output.Columns.Add("Comment11", typeof(string));
            output.Columns.Add("Comment12", typeof(string));
            output.Columns.Add("Comment13", typeof(string));
            output.Columns.Add("Comment14", typeof(string));
            output.Columns.Add("Comment15", typeof(string));

            for (int i = 0; i < 50000; i++)
            {
                output.Rows.Add(
                    $"Palash-{i}",
                    $"Debnath-{i}",
                    $"{i}",
                    "The IsOpen property of the Popup that is created by the control template of the MenuItem is bound to the IsSubmenuOpen property of the MenuItem. That's to say, when the user click ouside, the MenuItem loses keyboard focus and set its IsSubmenuOpen property to false. So the Popup in the visual tree of the MenuItem is closed. An ugly workaround to keep the Popup open when the user clicks ouside of the MenuItem is to set the IsSubmenuOpen property to true in the PreviewLostKeyboardFocus event handler of the MenuItem.For example:",
                    "The IsOpen property of the Popup that is created by the control template of the MenuItem is bound to the IsSubmenuOpen property of the MenuItem. That's to say, when the user click ouside, the MenuItem loses keyboard focus and set its IsSubmenuOpen property to false. So the Popup in the visual tree of the MenuItem is closed. An ugly workaround to keep the Popup open when the user clicks ouside of the MenuItem is to set the IsSubmenuOpen property to true in the PreviewLostKeyboardFocus event handler of the MenuItem.For example:",
                    "The IsOpen property of the Popup that is created by the control template of the MenuItem is bound to the IsSubmenuOpen property of the MenuItem. That's to say, when the user click ouside, the MenuItem loses keyboard focus and set its IsSubmenuOpen property to false. So the Popup in the visual tree of the MenuItem is closed. An ugly workaround to keep the Popup open when the user clicks ouside of the MenuItem is to set the IsSubmenuOpen property to true in the PreviewLostKeyboardFocus event handler of the MenuItem.For example:",
                    "The IsOpen property of the Popup that is created by the control template of the MenuItem is bound to the IsSubmenuOpen property of the MenuItem. That's to say, when the user click ouside, the MenuItem loses keyboard focus and set its IsSubmenuOpen property to false. So the Popup in the visual tree of the MenuItem is closed. An ugly workaround to keep the Popup open when the user clicks ouside of the MenuItem is to set the IsSubmenuOpen property to true in the PreviewLostKeyboardFocus event handler of the MenuItem.For example:",
                    "The IsOpen property of the Popup that is created by the control template of the MenuItem is bound to the IsSubmenuOpen property of the MenuItem. That's to say, when the user click ouside, the MenuItem loses keyboard focus and set its IsSubmenuOpen property to false. So the Popup in the visual tree of the MenuItem is closed. An ugly workaround to keep the Popup open when the user clicks ouside of the MenuItem is to set the IsSubmenuOpen property to true in the PreviewLostKeyboardFocus event handler of the MenuItem.For example:",
                    "The IsOpen property of the Popup that is created by the control template of the MenuItem is bound to the IsSubmenuOpen property of the MenuItem. That's to say, when the user click ouside, the MenuItem loses keyboard focus and set its IsSubmenuOpen property to false. So the Popup in the visual tree of the MenuItem is closed. An ugly workaround to keep the Popup open when the user clicks ouside of the MenuItem is to set the IsSubmenuOpen property to true in the PreviewLostKeyboardFocus event handler of the MenuItem.For example:",
                    "The IsOpen property of the Popup that is created by the control template of the MenuItem is bound to the IsSubmenuOpen property of the MenuItem. That's to say, when the user click ouside, the MenuItem loses keyboard focus and set its IsSubmenuOpen property to false. So the Popup in the visual tree of the MenuItem is closed. An ugly workaround to keep the Popup open when the user clicks ouside of the MenuItem is to set the IsSubmenuOpen property to true in the PreviewLostKeyboardFocus event handler of the MenuItem.For example:",
                    "The IsOpen property of the Popup that is created by the control template of the MenuItem is bound to the IsSubmenuOpen property of the MenuItem. That's to say, when the user click ouside, the MenuItem loses keyboard focus and set its IsSubmenuOpen property to false. So the Popup in the visual tree of the MenuItem is closed. An ugly workaround to keep the Popup open when the user clicks ouside of the MenuItem is to set the IsSubmenuOpen property to true in the PreviewLostKeyboardFocus event handler of the MenuItem.For example:",
                    "The IsOpen property of the Popup that is created by the control template of the MenuItem is bound to the IsSubmenuOpen property of the MenuItem. That's to say, when the user click ouside, the MenuItem loses keyboard focus and set its IsSubmenuOpen property to false. So the Popup in the visual tree of the MenuItem is closed. An ugly workaround to keep the Popup open when the user clicks ouside of the MenuItem is to set the IsSubmenuOpen property to true in the PreviewLostKeyboardFocus event handler of the MenuItem.For example:",
                    "The IsOpen property of the Popup that is created by the control template of the MenuItem is bound to the IsSubmenuOpen property of the MenuItem. That's to say, when the user click ouside, the MenuItem loses keyboard focus and set its IsSubmenuOpen property to false. So the Popup in the visual tree of the MenuItem is closed. An ugly workaround to keep the Popup open when the user clicks ouside of the MenuItem is to set the IsSubmenuOpen property to true in the PreviewLostKeyboardFocus event handler of the MenuItem.For example:",
                    "The IsOpen property of the Popup that is created by the control template of the MenuItem is bound to the IsSubmenuOpen property of the MenuItem. That's to say, when the user click ouside, the MenuItem loses keyboard focus and set its IsSubmenuOpen property to false. So the Popup in the visual tree of the MenuItem is closed. An ugly workaround to keep the Popup open when the user clicks ouside of the MenuItem is to set the IsSubmenuOpen property to true in the PreviewLostKeyboardFocus event handler of the MenuItem.For example:",
                    "The IsOpen property of the Popup that is created by the control template of the MenuItem is bound to the IsSubmenuOpen property of the MenuItem. That's to say, when the user click ouside, the MenuItem loses keyboard focus and set its IsSubmenuOpen property to false. So the Popup in the visual tree of the MenuItem is closed. An ugly workaround to keep the Popup open when the user clicks ouside of the MenuItem is to set the IsSubmenuOpen property to true in the PreviewLostKeyboardFocus event handler of the MenuItem.For example:",
                    "The IsOpen property of the Popup that is created by the control template of the MenuItem is bound to the IsSubmenuOpen property of the MenuItem. That's to say, when the user click ouside, the MenuItem loses keyboard focus and set its IsSubmenuOpen property to false. So the Popup in the visual tree of the MenuItem is closed. An ugly workaround to keep the Popup open when the user clicks ouside of the MenuItem is to set the IsSubmenuOpen property to true in the PreviewLostKeyboardFocus event handler of the MenuItem.For example:",
                    "The IsOpen property of the Popup that is created by the control template of the MenuItem is bound to the IsSubmenuOpen property of the MenuItem. That's to say, when the user click ouside, the MenuItem loses keyboard focus and set its IsSubmenuOpen property to false. So the Popup in the visual tree of the MenuItem is closed. An ugly workaround to keep the Popup open when the user clicks ouside of the MenuItem is to set the IsSubmenuOpen property to true in the PreviewLostKeyboardFocus event handler of the MenuItem.For example:",
                    "The IsOpen property of the Popup that is created by the control template of the MenuItem is bound to the IsSubmenuOpen property of the MenuItem. That's to say, when the user click ouside, the MenuItem loses keyboard focus and set its IsSubmenuOpen property to false. So the Popup in the visual tree of the MenuItem is closed. An ugly workaround to keep the Popup open when the user clicks ouside of the MenuItem is to set the IsSubmenuOpen property to true in the PreviewLostKeyboardFocus event handler of the MenuItem.For example:",
                    "The IsOpen property of the Popup that is created by the control template of the MenuItem is bound to the IsSubmenuOpen property of the MenuItem. That's to say, when the user click ouside, the MenuItem loses keyboard focus and set its IsSubmenuOpen property to false. So the Popup in the visual tree of the MenuItem is closed. An ugly workaround to keep the Popup open when the user clicks ouside of the MenuItem is to set the IsSubmenuOpen property to true in the PreviewLostKeyboardFocus event handler of the MenuItem.For example:");
            }

            return output;
        }

        private DataTable GenerateUsersDataTable()
        {
            var output = new DataTable();

            output.Columns.Add("FirstName", typeof(string));
            output.Columns.Add("LastName", typeof(string));
            output.Columns.Add("CreateDate", typeof(DateTime));

            for (int i = 0; i < 20000; i++)
            {
                output.Rows.Add($"Palash-{i}", $"Debnath-{i}", $"{DateTime.UtcNow}");
            }

            return output;
        }

    }
}
