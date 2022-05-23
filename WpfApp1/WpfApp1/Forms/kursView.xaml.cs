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
using WpfApp1.Entities;

namespace WpfApp1.Forms
{
    /// <summary>
    /// Логика взаимодействия для kursView.xaml
    /// </summary>
    public partial class kursView : Window
    {
        KursEntities context = DbManager.GetContext();
        int NumPages;
        int NumEnriesPerPage = 5;
        int NumCurrentPage = 1;
        public kursView()
        {
            InitializeComponent();
            RefreshData();
            //CmbSort.SelectedIndex = 0;
            //FillComboBox();
            //CmbService.SelectedIndex = 0;
        }
        public void RefreshData()
        {
            List<Client> clien = context.Client.ToList();
            //clien = Search(clien);
            //clien = Sort(clien);
            ////  clien = Filter(clien); 
            NumPages = (int)Math.Ceiling((clien.Count * 1.0) / NumEnriesPerPage);
            if (NumCurrentPage > NumPages)
                NumCurrentPage = NumPages;

            clien = clien.Skip((NumCurrentPage - 1) * NumEnriesPerPage).
                Take(NumEnriesPerPage).ToList();
            LviewKurs.ItemsSource = clien;
            CurrentPageBox.Text = NumCurrentPage + " / " + NumPages;
        }
        //        private void FillComboBox()
        //        {
        //            List<NameService> name = context.NameService.ToList();
        //            NameService nan = new NameService {Name="Все курсы" };
        //            nan.Name = "Все курсы";
        //            name.Insert(0, nan);
        //            CmbService.ItemsSource = name;
        //            CmbService.SelectedIndex = 0;
        //        }
        //        //поиск
        //        private List<Client> Search(List<Client> client)
        //        {
        //            if (!string.IsNullOrWhiteSpace(TxbSearch.Text))
        //                client = client.Where(x => x.Surname.ToString().Contains(TxbSearch.Text)
        //                || x.Name.ToString().Contains(TxbSearch.Text)
        //                || x.Lastname.ToString().Contains(TxbSearch.Text)).ToList();
        //            return client;
        //        }
        //        //сортировка
        //        private List<Client> Sort(List<Client> client)
        //        {
        //            if (CmbSort.SelectedIndex == 1)
        //                client = client.OrderBy(x => x.Surname).ToList();
        //            else if (CmbSort.SelectedIndex == 2)
        //                client = client.OrderByDescending(x => x.Surname).ToList() ;
        //            return client;
        //        }
        //        //фильтрация
        //        private List<ServiceClent> Filter(List<ServiceClent> client)
        //        {

        //            if (CmbService.SelectedIndex > 0)
        //                client = client.Where(x => x.NameService ==
        //                CmbService.SelectedItem as NameService).ToList();
        //            return client;
        //        }

        //        private void TxbSearch_TextChanged(object sender, TextChangedEventArgs e)
        //        {
        //            RefreshData();
        //        }

        //        private void CmbSort_SelectionChanged(object sender, SelectionChangedEventArgs e)
        //        {
        //            RefreshData();
        //        }

        //        private void CmbService_SelectionChanged(object sender, SelectionChangedEventArgs e)
        //        {
        //            RefreshData();
        //        }

        //первая
        private void FirstPageBtn_Click(object sender, RoutedEventArgs e)
        {
            NumCurrentPage = 1;
            RefreshData();
        }

        //предыдущая
        private void PreviuosPageBtn_Click(object sender, RoutedEventArgs e)
        {
            if (NumCurrentPage != 1)
                NumCurrentPage--;
            RefreshData();
        }

        //следующая
        private void NextPageBtn_Click(object sender, RoutedEventArgs e)
        {
            if (NumCurrentPage != NumPages)
                NumCurrentPage++;
            RefreshData();
        }

        //последняя страница пхаха)
        private void LastPageBtn_Click(object sender, RoutedEventArgs e)
        {
            NumCurrentPage = NumPages;
            RefreshData();
        }

        //        private void AddBtn_Click(object sender, RoutedEventArgs e)
        //        {
        //            new Add().Show();
        //        }
        //    }
        //}
    }
}

