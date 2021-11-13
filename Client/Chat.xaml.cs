﻿/*using System;
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

namespace Client
{
    /// <summary>
    /// Interaction logic for Chat.xaml
    /// </summary>
    public partial class ChatView : UserControl
    {
        ChatVM obj;
        public ChatView()
        {
            InitializeComponent();
            obj = new ChatVM();
            DataContext = obj;
        }
        public void OnClick(object sender, RoutedEventArgs e)
        {
            if (obj.Trial("i"))
                t1.Visibility = System.Windows.Visibility.Visible;
            else
                t1.Visibility = System.Windows.Visibility.Collapsed;
        }
    }
}
*/

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using System.ComponentModel;
using Content;

using Client.ViewModels;

namespace Client
{
    /// <summary>
    /// Interaction logic for ChatView.xaml
    /// </summary>
    public partial class Chat : UserControl
    {
        public string Text { get; set; }
        public string FilePath { get; set; }
        //public string FileName { get; set; }
        //ObservableCollection<Message> allmessages;
        public Chat()
        {
            InitializeComponent();

            //ChatViewModel viewModel = new ChatViewModel();
            //subscribe to the property changed event
           
            /* viewModel.PropertyChanged += Listner;
            this.DataContext = viewModel;*/

            //allmessages = new ObservableCollection<Message>();
            //allmessages.Add(new Message { TextMessage = "Hello ,how are you?", Time = DateTime.Now.ToString(), Status = "Sent", tofrom = true });
            //allmessages.Add(new Message { TextMessage = "Hello,I am fine.Wbu?", Time = DateTime.Now.ToString(), Status = "Sent", tofrom = false });
          //  this.myChat.ItemsSource = allmessages;
            //System.Diagnostics.Debug.WriteLine(allmessages.Count);
        }
        private void Listner(object sender, PropertyChangedEventArgs e)
        {
           /* string propertyName = e.PropertyName;
            ChatViewModel viewModel = this.DataContext as ChatViewModel;
            if (propertyName == "ReceivedFile")
            {
            }
            else if (propertyName == "ReceivedMsg")
            {
                allmessages.Add(new Message { TextMessage = viewModel.ReceivedMsg, Time = DateTime.Now.ToString(), Status = "Sent", tofrom = false });
            }*/
        }
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void OnUploadButtonClick(object sender, RoutedEventArgs e)
        {
            // Create OpenFileDialog
            Microsoft.Win32.OpenFileDialog openFileDlg = new Microsoft.Win32.OpenFileDialog();

            // Launch OpenFileDialog by calling ShowDialog method
            Nullable<bool> result = openFileDlg.ShowDialog();
            // Get the selected file name and display in a TextBox.
            // Load content of file in a TextBlock
            if (result == true)
            {
                FilePath = openFileDlg.FileName;
             //   allmessages.Add(new Message { TextMessage = FilePath.ToString(), Time = DateTime.Now.ToString(), Status = "Sent", tofrom = true });
                //TextBlock1.Text = System.IO.File.ReadAllText(openFileDlg.FileName);
            }
        }

        private void OnSentButtonClick(object sender, RoutedEventArgs e)
        {
           // allmessages.Add(new Message { TextMessage = this.SendTextBox.Text, Time = DateTime.Now.ToString(), Status = "Sent", tofrom = true });

        }

        private void OnReplyButtonClick(object sender, RoutedEventArgs e)
        {
            //allmessages.Add(new Message { TextMessage = "Reply button clicked", Time = DateTime.Now.ToString(), Status = "Sent", tofrom = true });

        }
        private void OnStarButtonClick(object sender, RoutedEventArgs e)
        {
            /*ChatViewModel viewModel = this.DataContext as ChatViewModel;
            if (sender is RadioButton)
            {
                RadioButton cmd = (RadioButton)sender;
                if (cmd.DataContext is Message)
                {
                    Message m = (Message)cmd.DataContext;
                    viewModel.StarChat(m.MessageId);
                    //System.Diagnostics.Debug.WriteLine(m.TextMessage);
                }
            }*/
        }
        private void OnCloseButtonClick(object sender, RoutedEventArgs e)
        {
            //this.Close();
        }
    }
}