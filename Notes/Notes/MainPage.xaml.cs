using System;
using System.IO;
using Xamarin.Forms;

namespace Notes
{
    public partial class MainPage : ContentPage
    {
        //_filename refers to where the file will be stored\
        //Path.Combine concatenates variables together into single string
        string _fileName = Path.Combine(
            Environment.GetFolderPath(
                Environment.SpecialFolder.LocalApplicationData
                ), "notes.txt"
            );
        public MainPage()
        {
            InitializeComponent();

            //display file contents if file exists
            if (File.Exists(_fileName))
            {
                editor.Text = File.ReadAllText(_fileName);
            }
        }

        void OnSaveButtonClicked(object sender, EventArgs e)
        {
            File.WriteAllText(_fileName, editor.Text);
        }

        void OnReloadButtonClicked(object sender, EventArgs e)
        {
            if (File.Exists(_fileName))
            {
                editor.Text = string.Empty;
                editor.Text = File.ReadAllText(_fileName);
            }
        }

        //delete file if it exists and clear editor textbox
        void OnDeleteButtonClicked(object sender, EventArgs e)
        {
            if (File.Exists(_fileName))
            {
                File.Delete(_fileName);
            }
            editor.Text = string.Empty;
        }
    }
}
