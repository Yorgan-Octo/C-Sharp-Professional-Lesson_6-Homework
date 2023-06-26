using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.AccessControl;
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

namespace Task_5
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        Assembly assembly;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void OpenFile()
        {
            InfoBox.Clear();
            string line = "";

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Все файлы (*.*)|*.*";

            bool? result = openFileDialog.ShowDialog();

            string filePath = default;
            if (result == true)
            {
                filePath = openFileDialog.FileName;
            }
            else
            {
                throw new Exception();
            }

            try
            {
                assembly = Assembly.LoadFile(filePath);
            }
            catch (Exception)
            {

                throw new Exception();
            }

            Type[] types = assembly.GetTypes();
            InfoBox.Text += line + assembly.FullName + "\n";

            line += "      ";
            foreach (Type type in types)
            {
                InfoBox.Text += line + "Tp: " + type.Name + "\n";

                Type baseType = type.BaseType;
                while (baseType != null)
                {
                    InfoBox.Text += line + "    " + "Bs: " + baseType.Name + "\n";
                    baseType = baseType.BaseType;
                }

                PropertyInfo[] properties = type.GetProperties();
                foreach (var properte in properties)
                {
                    InfoBox.Text += line + "    " + "Pr: " + properte.Name + "\n";
                }

                FieldInfo[] fields = type.GetFields();
                foreach (var field in fields)
                {
                    InfoBox.Text += line + "    " + "Fl: " + field.Name + "\n";
                }


                MethodInfo[] methods = type.GetMethods(BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.DeclaredOnly);
                foreach (var method in methods)
                {
                    InfoBox.Text += line + "    " + "Mth: " + method.Name + "\n";
                }

                foreach (Type altype in types)
                {
                    if (altype.IsClass)
                    {
                        Console.WriteLine(altype.Name);
                    }
                }
            }
        }

        private void OpenButton_Click(object sender, RoutedEventArgs e)
        {
            OpenFile();
        }
    }
}
