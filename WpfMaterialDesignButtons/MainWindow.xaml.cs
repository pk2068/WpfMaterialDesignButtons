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

namespace WpfMaterialDesignButtons
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow:Window
	{
		public MainWindow()
		{
			InitializeComponent();
		}

		private void CreateButton_Click( object sender,RoutedEventArgs e )
		{
			this.lblstatus.Content = "CreateButton_Click";
			this.btnPopupChoices.IsOpen = false;
		}

		private void CreateDocButton_Click1( object sender,RoutedEventArgs e )
		{
			this.lblstatus.Content = "CreateDOCButton_Click";
		}

		private void CreateXlsButton_Click1( object sender,RoutedEventArgs e )
		{
			this.lblstatus.Content = "CreateXLSButton_Click";
		}
		private void CreateTxtButton_Click1( object sender,RoutedEventArgs e )
		{
			this.lblstatus.Content = "CreateTXTButton_Click";
		}

		private void AddButtonContextMenu_Click1( object sender,RoutedEventArgs e )
		{
			this.lblstatus.Content = "AddButton_Click";
			bool _isOpen = this.btnPopupChoices.IsOpen;
			this.btnPopupChoices.IsOpen = !_isOpen;
		}

		private void FINDClick( object sender,RoutedEventArgs e )
		{
			this.btnPopupChoices.IsOpen = false;
			this.lblstatus.Content = "FIND";
		}
		private void TRANSFERClick( object sender,RoutedEventArgs e )
		{
			this.btnPopupChoices.IsOpen = false;
			this.lblstatus.Content = "TRANSFER";
		}
		private void DTMFClick( object sender,RoutedEventArgs e )
		{
			this.btnPopupChoices.IsOpen = false;
			this.lblstatus.Content = "DTMF";
		}
	}
}
