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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TaskManagerApp
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            taskTypeComboBox.Items.Add("Рассылка email");
            taskTypeComboBox.Items.Add("Скачивание файла");
            taskTypeComboBox.Items.Add("Перемещение файлов одного каталога в новый каталог");
            taskTypeComboBox.SelectedIndex = 0;

            periodicityComboBox.Items.Add("Раз в день");
            periodicityComboBox.Items.Add("Раз в неделю");
            periodicityComboBox.Items.Add("Раз в месяц");
            periodicityComboBox.Items.Add("Раз в год");
            periodicityComboBox.SelectedIndex = 0;
        }

        private void WindowClosing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            WindowState = WindowState.Minimized;
            ShowInTaskbar = false;
            e.Cancel = true;
        }

        private void TaskTypeComboBoxSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (taskTypeComboBox.SelectedIndex == 0)
            {
                emailSendingGrid.Visibility = Visibility.Visible;
                emailSendingGrid.IsEnabled = true;

                fileDownloadingGrid.Visibility = Visibility.Hidden;
                fileDownloadingGrid.IsEnabled = false;

                directoryChangingGrid.Visibility = Visibility.Hidden;
                directoryChangingGrid.IsEnabled = false;
            }
            else if (taskTypeComboBox.SelectedIndex == 1)
            {
                emailSendingGrid.Visibility = Visibility.Hidden;
                emailSendingGrid.IsEnabled = false;

                fileDownloadingGrid.Visibility = Visibility.Visible;
                fileDownloadingGrid.IsEnabled = true;

                directoryChangingGrid.Visibility = Visibility.Hidden;
                directoryChangingGrid.IsEnabled = false;
            }
            else
            {
                emailSendingGrid.Visibility = Visibility.Hidden;
                emailSendingGrid.IsEnabled = false;

                fileDownloadingGrid.Visibility = Visibility.Hidden;
                fileDownloadingGrid.IsEnabled = false;

                directoryChangingGrid.Visibility = Visibility.Visible;
                directoryChangingGrid.IsEnabled = true;
            }
        }

        private void AddTask(object sender, RoutedEventArgs e)
        {
            if (datePicker.SelectedDate == null || datePicker.SelectedDate < DateTime.Now)
            {
                MessageBox.Show("Некорректная дата");
                return;
            }
            if (timePicker.SelectedTime == null)
            {
                MessageBox.Show("Некорректное время");
                return;
            }

            if (taskTypeComboBox.SelectedIndex == 0)
            {
                
            }
            else if (taskTypeComboBox.SelectedIndex == 1)
            {

            }
            else
            {
                if (string.IsNullOrEmpty(directoryFromLabel.Text))
                {
                    MessageBox.Show("Введите путь до папки");
                }
                if (string.IsNullOrEmpty(directoryToLabel.Text))
                {
                    MessageBox.Show("Введите путь до папки");
                }
        }
    }
}