using System;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void Button1_Click(object sender, EventArgs e)
        {
            string path = "c:\\testC\\zipTest";
            try
            {
                Thread th = new Thread(t =>
                {
                    using (Ionic.Zip.ZipFile zip = new Ionic.Zip.ZipFile())
                    {
                        zip.AddDirectory(path);

                        //DirectoryInfo di = new DirectoryInfo(path); 

                        zip.Save("c:\\testC\\abc.zip");
                    }
                })
                { IsBackground = true };
                th.Start(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }
        //.........................................................
        private void Button2_Click(object sender, EventArgs e)
        {
            string path = "c:\\testC\\111.txt";
            try
            {
                Thread th = new Thread(t =>
                {
                    using (Ionic.Zip.ZipFile zip = new Ionic.Zip.ZipFile())  
                    {
                        zip.AddFile(path);

                        zip.Save("c:\\testC\\111.zip");
                    }
                })
                { IsBackground = true };
                th.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }
        //.........................................................




    }
}
