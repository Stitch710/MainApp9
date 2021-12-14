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

namespace MainApp9
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
        }       

        private void Button_Click(object sender, RoutedEventArgs e) //вывод всех книг
        {
            Book book1 = new Book("Дмитрий", "HL", "Дизайн", "100");
            Tablitsa.Items.Add(book1);
            Book book2 = new Book("Дмитрий", "HL", "Продвижение", "80");
            Tablitsa.Items.Add(book2);
            Book book3 = new Book("Сергей", "Просвещение", "Програмирование", "300");
            Tablitsa.Items.Add(book3);
            Book book4 = new Book("Анастасия", "IMP Studio", "Арт", "100");
            Tablitsa.Items.Add(book4);
        }

        private void info_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Пичугин Дмитрий ИСП-31 Заполнить таблицу с учебной литературой с полями: название, автор, издательство, кол - во страниц.Вывести результат на экран.Вывести список книг заданного издательства.");
        } //информация

        private void exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        } //выход

        private void Button_Click_1(object sender, RoutedEventArgs e) //вывод книг выбранного издательства
        {
            Tablitsa.Items.Clear(); //очистка таблицы

            string x = Search.Text;
            Book book1 = new Book("Дмитрий", "HL", "Дизайн", "100");
            if (book1.Copyright == x) Tablitsa.Items.Add(book1);           
            Book book2 = new Book("Дмитрий", "HL", "Продвижение", "80");
            if (book2.Copyright == x) Tablitsa.Items.Add(book2);
            Book book3 = new Book("Сергей", "Просвещение", "Програмирование", "300");
            if (book3.Copyright == x) Tablitsa.Items.Add(book3);
            Book book4 = new Book("Анастасия", "IMP Studio", "Арт", "100");
            if (book4.Copyright == x) Tablitsa.Items.Add(book4);
        }
    }
}
