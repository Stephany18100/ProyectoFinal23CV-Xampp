using ProyectoFinal23CV.Entities;
using ProyectoFinal23CV.Services;
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

namespace ProyectoFinal23CV.VistaWFP
{
    /// <summary>
    /// Lógica de interacción para Sistema.xaml
    /// </summary>
    public partial class Sistema : Window
    {
        public Sistema()
        {
            InitializeComponent();
            GetUserTable();
        }

        private void UserTable_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        UsuarioServices services = new UsuarioServices();
        Usuario usuario = new Usuario();
       
     
        public void  GetUserTable() 
        {
            UserTable.ItemsSource = services.GetUser();

        }

        private void BtnAdd_Click_1(object sender, RoutedEventArgs e)
        {
            usuario.Nombre = txt_nombre.Text;
            usuario.UserName = txtuser.Text;
            usuario.Password = txtpassword.Text;
            services.AddUser(usuario);

            txt_nombre.Clear();
            txtuser.Clear();
            txtpassword.Clear();
            GetUserTable();

            MessageBox.Show("Se agrego Correctamente");
        }
    }
}
