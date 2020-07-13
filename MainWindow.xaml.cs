using System;
using System.Collections;
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

namespace arrayListHomework
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ArrayList customerName;
        public MainWindow()
        {
            InitializeComponent();
            customerName = new ArrayList();
        }

        private void btn_Add_Click(object sender, RoutedEventArgs e)
        {
            customerName.Add(txtName.Text);
            txtShow.Text = txtName.Text + "- Add Complete";                    
        }

        private void btn_Show_Click(object sender, RoutedEventArgs e)
        {
            foreach (string csNameData in customerName)
            {
                int i = csNameData.Count();
                txtShow.Text = csNameData;
                MessageBox.Show("No of Character - "+i.ToString());
            }
            MessageBox.Show("Total Member is : "+customerName.Count.ToString());
        }

        private void btn_Remove_Click(object sender, RoutedEventArgs e)
        {
            customerName.Remove(txtName.Text);
            txtShow.Text = txtName.Text + "- Deleted";
        }
    }
}
