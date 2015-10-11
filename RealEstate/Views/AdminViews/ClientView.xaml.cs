using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;
using Framework.UI.Controls;

namespace RealEstate.Views.AdminViews
{
    /// <summary>
    /// Interaction logic for ClientView.xaml
    /// </summary>
    public partial class ClientView
    {
        public ClientView()
        {
            InitializeComponent();
        }

        private void RE_Clients_Loaded(object sender, RoutedEventArgs e)
        {
            RefreshClients();
        }

        private void BT_AddClient_Click(object sender, RoutedEventArgs e)
        {
            OpenAddClientOverlay();
        }

        private void BT_EditClient_Click(object sender, RoutedEventArgs e)
        {
            if (DG_Clients.SelectedIndex != -1)
            {
                OpenEditClientOverlay();
            }
            else
            {
                DisplayNotifyBox("Cannot edit", "Please select an client to edit", 2);
            }
        }

        private void DisplayNotifyBox(string title, string message, int duration)
        {
            this.Dispatcher.Invoke(() =>
            {
                NotifyBox.Show(null, title, message, new TimeSpan(0, 0, duration), false);
            });
        }

        private async void BT_DeleteClient_Click(object sender, RoutedEventArgs e)
        {
            if (DG_Clients.SelectedIndex != -1)
            {
                MessageBoxResult result = await MessageDialog.ShowAsync("Are you Sure?", "Are you sure you want to delete " + GetSelectedEmail(), MessageBoxButton.YesNo, MessageDialogType.Light);
                if (result == MessageBoxResult.Yes)
                {
                    DeleteClient();
                }
                RefreshClients();
            }
            else
            {
                DisplayNotifyBox("Cannot delete", "Please select an client to delete", 2);
            }
        }

        private void DeleteClient()
        {
            new System.Threading.Thread(() =>
            {
                Classes.ClientManager clientManager = new Classes.ClientManager();

                if (clientManager.DeleteClient(GetSelectedEmail()))
                {
                    DisplayNotifyBox("Deleted", "The record has been deleted", 3);
                }
                else
                {
                    DisplayNotifyBox("Not Deleted", GetSelectedName() + " " + GetSelectedSurname() + " has not been deleted", 3);
                }

            }).Start();
        }

        private void ClientOverlays_OnClose(object sender, EventArgs e)
        {
            RefreshClients();
        }

        private void OpenAddClientOverlay()
        {
            Overlays.Client.AddClientOverlay clientOverlay = new Overlays.Client.AddClientOverlay();
            clientOverlay.OnExit += ClientOverlays_OnClose;
            clientOverlay.Owner = Framework.UI.Controls.Window.GetWindow(this);
            clientOverlay.Show();
        }

        private void OpenEditClientOverlay()
        {
            Overlays.Client.EditClientOverlay clientOverlay = new Overlays.Client.EditClientOverlay(GetSelectedEmail());
            clientOverlay.OnExit += ClientOverlays_OnClose;
            clientOverlay.Owner = Framework.UI.Controls.Window.GetWindow(this);
            clientOverlay.Show();
        }

        private void BT_EditPreferences_Click(object sender, RoutedEventArgs e)
        {
            if (DG_Clients.SelectedIndex != -1)
            {
                OpenEditPreferenceOverlay();
            }
            else
            {
                DisplayNotifyBox("Cannot Edit Preference", "Please select an client to edit preferences", 2);
            }
        }

        private void OpenEditPreferenceOverlay()
        {
            Overlays.Preferences.EditPreferenceOverlay preferenceOverlay = new Overlays.Preferences.EditPreferenceOverlay(GetSelectedEmail());
            preferenceOverlay.OnExit += ClientOverlays_OnClose;
            preferenceOverlay.Owner = Framework.UI.Controls.Window.GetWindow(this);
            preferenceOverlay.Show();
        }

        private void BT_Refresh_Click(object sender, RoutedEventArgs e)
        {
            RefreshClients();
        }

        private void RefreshClients()
        {
            new System.Threading.Thread(() =>
            {
                ClearClientsGrid();
                Classes.DatabaseManager dbManager = new Classes.DatabaseManager();
                var clientNames = dbManager.ReturnQuery("SELECT Client_Name, Client_Surname, Client_Phone, Client_Email FROM Clients ORDER BY Client_Surname, Client_Name;");

                foreach (var client in clientNames)
                {
                    InsertIntoClientsGrid(client[0], client[1], client[2], client[3]);
                }

            }).Start();
        }

        private void ClearClientsGrid()
        {
            this.Dispatcher.Invoke(() =>
            {
                DG_Clients.Items.Clear();
            });
        }

        private void InsertIntoClientsGrid(string clientName, string clientSurname, string clientPhone, string clientEmail)
        {
            this.Dispatcher.Invoke(() =>
            {
                DG_Clients.Items.Add(new GridViewSources.Client() { Name = clientName, Surname = clientSurname, Phone = clientPhone, Email = clientEmail });
            });
        }

        private void DG_Clients_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (DG_Clients.SelectedIndex != -1)
            {
                TB_SelectedClient.Text = GetSelectedName() + " " + GetSelectedSurname();
            }
            else
            {
                TB_SelectedClient.Text = "";
            }

        }

        private string GetSelectedName()
        {
            string selectedName = "";

            this.Dispatcher.Invoke(() =>
            {
                selectedName = (DG_Clients.SelectedItem as GridViewSources.Client).Name;
            });

            return selectedName;
        }

        private string GetSelectedSurname()
        {
            string selectedSurname = "";

            this.Dispatcher.Invoke(() =>
            {
                selectedSurname = (DG_Clients.SelectedItem as GridViewSources.Client).Surname;
            });

            return selectedSurname;
        }

        private string GetSelectedEmail()
        {
            string selectedEmail = "";

            this.Dispatcher.Invoke(() =>
            {
                selectedEmail = (DG_Clients.SelectedItem as GridViewSources.Client).Email;
            });

            return selectedEmail;
        }
    }
}
