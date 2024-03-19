using laba2.lab1DataSetTableAdapters;
using System;
using System.Data;
using System.Windows;

namespace laba2
{
    public partial class DriversWindow : Window
    {
        driversTableAdapter driversAdapter = new driversTableAdapter();
        carsTableAdapter carsTableAdapter = new carsTableAdapter();
        public DriversWindow()
        {
            InitializeComponent();
            DriversData.ItemsSource = driversAdapter.GetData();
            carsBox.ItemsSource = carsTableAdapter.GetData();
            carsBox.DisplayMemberPath = "model";
        }

        private void carsBox_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            if (carsBox.SelectedItem != null) 
            { 
                var id = (int)(carsBox.SelectedItem as DataRowView).Row[0];
                DriversData.ItemsSource = driversAdapter.SearchByCar(id);
            }
        }

        private void clearBotton_Click(object sender, RoutedEventArgs e)
        {
            DriversData.ItemsSource = driversAdapter.GetData();
            firstnameBox.Text = string.Empty;
        }

        /*
        private void createButton_Click(object sender, RoutedEventArgs e)
        {
            var current_car_id = Convert.ToInt32(car_idBox.Text);
            driversAdapter.InsertQuery(firstnameBox.Text, surnameBox.Text, middlenameBox.Text, current_car_id);
            RefreshTable();
        }

        private void updateButton_Click(object sender, RoutedEventArgs e)
        {
            if (DriversData.SelectedItem != null)
            {
                var current_car_id = Convert.ToInt32(car_idBox.Text);
                object id = (DriversData.SelectedItem as DataRowView).Row[0];
                driversAdapter.UpdateQuery(firstnameBox.Text, surnameBox.Text, middlenameBox.Text, current_car_id, Convert.ToInt32(id));
                RefreshTable();
            }
        }

        private void deleteButton_Click(object sender, RoutedEventArgs e)
        {
            if (DriversData.SelectedItem != null)
            {
                object id = (DriversData.SelectedItem as DataRowView).Row[0];
                driversAdapter.DeleteQuery(Convert.ToInt32(id));
                RefreshTable();
            }
        }

        private void RefreshTable()
        {
            DriversData.ItemsSource = driversAdapter.GetData();
        }*/
    }
}
