
using Record_Book_MVVM.ViewModel;
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

namespace Record_Book_MVVM.Views
{
	
	public partial class AddUser : Window
	{
		public AddUser()
		{
			InitializeComponent();
			AddUserViewModel addUserViewModel = new AddUserViewModel();
			this.DataContext = addUserViewModel;

		}
	}
}
