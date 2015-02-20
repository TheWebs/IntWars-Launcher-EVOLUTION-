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
using MahApps;
using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;
using System.Windows.Threading;

namespace LoginSystem
{
    /// <summary>
    /// Interaction logic for IntClient.xaml
    /// </summary>
    public partial class IntClient : MetroWindow
    {
        int i;
        public IntClient()
        {
            InitializeComponent();
            if(NameBox.Text == "")
            {
                NameBox.Text = users.Default.Name;
            }
            if (RankBox.Text == "")
            {
                RankBox.Text = users.Default.Rank;
            }
            if (SkinBox.Text == "")
            {
                SkinBox.Text = users.Default.Skin;
            }
            if (ChampionBox.Text == "")
            {
                ChampionBox.Text = users.Default.Champion;
            }
            if (RibbonBox.Text == "")
            {
                RibbonBox.Text = users.Default.Ribbon;
            }
            if (SideBox.Text == "")
            {
                SideBox.Text = users.Default.Side;
            }
            if (IconBox.Text == "")
            {
                IconBox.Text = users.Default.Icon;
            }                   
        }

        public void DoEvents()
        {
            DispatcherFrame frame = new DispatcherFrame();
            Dispatcher.CurrentDispatcher.BeginInvoke(DispatcherPriority.Background,
                new DispatcherOperationCallback(ExitFrame), frame);
            Dispatcher.PushFrame(frame);
        }

        public object ExitFrame(object f)
        {
            ((DispatcherFrame)f).Continue = false;

            return null;
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            users.Default.Name = NameBox.Text;
            users.Default.Champion = ChampionBox.Text;
            users.Default.Rank = RankBox.Text;
            users.Default.Skin = SkinBox.Text;
            users.Default.Ribbon = RibbonBox.Text;
            users.Default.Side = SideBox.Text;
            users.Default.Icon = IconBox.Text;
            ConfiguraLua.GuardaDefenicoes(RankBox.Text, NameBox.Text, ChampionBox.Text, SideBox.Text, SkinBox.Text, RibbonBox.Text, IconBox.Text);
            while(i <= 100)
            {
                ProgressBar1.Value = i;
                DoEvents();
                System.Threading.Thread.Sleep(10);
                i++;
            }
            label.Visibility = Visibility.Visible;
            DoEvents();
            System.Threading.Thread.Sleep(2000);
            i = 0;
            ProgressBar1.Value = i;
        }
    }
}
