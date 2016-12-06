using Microsoft.Win32;
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

namespace ListBoxApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        //Bouttons images
        private void btCerise_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Title = "Choisir une photo";
            op.Filter = "Images|*.jpg;*.jpeg;*.png|" + "JPEG (*.jpg;*.jpeg)|*.jpg;*.jpeg|" + "Portable Network Graphic (*.png)|*.png";
            if (op.ShowDialog() == true)
            {
                img1.Source = new BitmapImage(new Uri(op.FileName));
                MessageBox.Show("image bien sélectionné", "Information ", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void btBanane_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Title = "Choisir une photo";
            op.Filter = "Images|*.jpg;*.jpeg;*.png|" + "JPEG (*.jpg;*.jpeg)|*.jpg;*.jpeg|" + "Portable Network Graphic (*.png)|*.png";
            if (op.ShowDialog() == true)
            {
                img2.Source = new BitmapImage(new Uri(op.FileName));
                MessageBox.Show("image bien sélectionné", "Information ", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void btPasteque_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Title = "Choisir une photo";
            op.Filter = "Images|*.jpg;*.jpeg;*.png|" + "JPEG (*.jpg;*.jpeg)|*.jpg;*.jpeg|" + "Portable Network Graphic (*.png)|*.png";
            if (op.ShowDialog() == true)
            {
                img3.Source = new BitmapImage(new Uri(op.FileName));
                MessageBox.Show("image bien sélectionné", "Information ", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void btAnanas_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Title = "Choisir une photo";
            op.Filter = "Images|*.jpg;*.jpeg;*.png|" + "JPEG (*.jpg;*.jpeg)|*.jpg;*.jpeg|" + "Portable Network Graphic (*.png)|*.png";
            if (op.ShowDialog() == true)
            {
                img4.Source = new BitmapImage(new Uri(op.FileName));
                MessageBox.Show("image bien sélectionné", "Information ", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void btFraise_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Title = "Choisir une photo";
            op.Filter = "Images|*.jpg;*.jpeg;*.png|" + "JPEG (*.jpg;*.jpeg)|*.jpg;*.jpeg|" + "Portable Network Graphic (*.png)|*.png";
            if (op.ShowDialog() == true)
            {
                img5.Source = new BitmapImage(new Uri(op.FileName));
                MessageBox.Show("image bien sélectionné", "Information ", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void btOrange_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Title = "Choisir une photo";
            op.Filter = "Images|*.jpg;*.jpeg;*.png|" + "JPEG (*.jpg;*.jpeg)|*.jpg;*.jpeg|" + "Portable Network Graphic (*.png)|*.png";
            if (op.ShowDialog() == true)
            {
                img6.Source = new BitmapImage(new Uri(op.FileName));
                MessageBox.Show("image bien sélectionné", "Information ", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void btPoire_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Title = "Choisir une photo";
            op.Filter = "Images|*.jpg;*.jpeg;*.png|" + "JPEG (*.jpg;*.jpeg)|*.jpg;*.jpeg|" + "Portable Network Graphic (*.png)|*.png";
            if (op.ShowDialog() == true)
            {
                img7.Source = new BitmapImage(new Uri(op.FileName));
                MessageBox.Show("image bien sélectionné", "Information ", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void btPomme_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Title = "Choisir une photo";
            op.Filter = "Images|*.jpg;*.jpeg;*.png|" + "JPEG (*.jpg;*.jpeg)|*.jpg;*.jpeg|" + "Portable Network Graphic (*.png)|*.png";
            if (op.ShowDialog() == true)
            {
                img8.Source = new BitmapImage(new Uri(op.FileName));
                MessageBox.Show("image bien sélectionné", "Information ", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void btKiwi_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Title = "Choisir une photo";
            op.Filter = "Images|*.jpg;*.jpeg;*.png|" + "JPEG (*.jpg;*.jpeg)|*.jpg;*.jpeg|" + "Portable Network Graphic (*.png)|*.png";
            if (op.ShowDialog() == true)
            {
                img9.Source = new BitmapImage(new Uri(op.FileName));
                MessageBox.Show("image bien sélectionné", "Information ", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void btMelon_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Title = "Choisir une photo";
            op.Filter = "Images|*.jpg;*.jpeg;*.png|" + "JPEG (*.jpg;*.jpeg)|*.jpg;*.jpeg|" + "Portable Network Graphic (*.png)|*.png";
            if (op.ShowDialog() == true)
            {
                img10.Source = new BitmapImage(new Uri(op.FileName));
                MessageBox.Show("image bien sélectionné", "Information ", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void btPêches_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Title = "Choisir une photo";
            op.Filter = "Images|*.jpg;*.jpeg;*.png|" + "JPEG (*.jpg;*.jpeg)|*.jpg;*.jpeg|" + "Portable Network Graphic (*.png)|*.png";
            if (op.ShowDialog() == true)
            {
                img11.Source = new BitmapImage(new Uri(op.FileName));
                MessageBox.Show("image bien sélectionné", "Information ", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        //Manipulations buttons 
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (TextBlock1.Text.Length == 0)
            {
                MessageBox.Show("SVP ajouter un article", "Erreur ", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                ListBoxItem item = new ListBoxItem();
                item.Content = TextBlock1.Text;

                item.FontWeight = FontWeights.Bold;
                item.FontFamily = new FontFamily("Verdana");
                item.FontSize = 12;
                item.Margin = new Thickness(40, 0, 0, 0);

                FruitList.Items.Add(item);

                TextBlock1.Clear();
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (FruitList.SelectedItems.Count == 0)
            {
                MessageBox.Show("SVP selectionner l'article à supprimer", "Erreur ", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                while (FruitList.SelectedItems.Count > 0)
                {
                    FruitList.Items.Remove(FruitList.SelectedItems[0]);
                }
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            FruitList.SelectedIndex = 0;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            FruitList.SelectedIndex = FruitList.Items.Count - 1;
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            int nextIndex = 0;
            if ((FruitList.SelectedIndex >= 0) && (FruitList.SelectedIndex < (FruitList.Items.Count - 1)))
                nextIndex = FruitList.SelectedIndex + 1;
            FruitList.SelectedIndex = nextIndex;
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            /*foreach (object obj in FruitList.Items)
                FruitList.SelectedItems.Add(obj);*/

            FruitList.SelectAll();
        }

       
    }
}
