using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm_FontAwesomeIcons
{
    public partial class FormGoogle : Form
    {
        public FormGoogle()
        {
            InitializeComponent();
        }

        //用来存储音乐全路径
        List<string> listSongs=new List<string>();

        private void iconButtonOpenMusic_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile=new OpenFileDialog();
            openFile.Title = "请选择音乐文件";
            openFile.InitialDirectory = @"E:\Summer_ALL_Files\11. 音乐视频\音乐\post-rock";
            openFile.Multiselect = true;
            openFile.Filter = "音乐文件|*.mp3|*.wav|*.*";
            openFile.ShowDialog();
            //获得在文件夹中选择的所有文件的全路径
            String[] path= openFile.FileNames;
            foreach (var musice in path)
            {
                //将音乐文件的文件名加载到ListBox 中
                listBoxMusic.Items.Add(musice);

                //将音乐文件的文件名存储到泛型集合  中
                listSongs.Add(musice);

            }
        }

        /// <summary>
        /// 实现双击播放
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBoxMusic_DoubleClick(object sender, EventArgs e)
        {
            // SoundPlayer spPlayer=new SoundPlayer();
            //  spPlayer.SoundLocation = listSongs[listBoxMusic.SelectedIndex];
            // spPlayer.Play();
        //    PlayThread(listSongs[listBoxMusic.SelectedIndex]);
            //   Thread thread = new Thread(() => PlayThread(listSongs[listBoxMusic.SelectedIndex]));
            //   thread.Start();
            string path = listSongs[listBoxMusic.SelectedIndex];
            Thread thread = new Thread(() => PlayThread(path));
            thread.Start();

        }

        private void axWindowsMediaPlayer1_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsMediaEnded)
            {
                
               
            }  
          
        }

        private void PlayThread(string path)
        {
            axWindowsMediaPlayer1.URL = path; //音乐文件
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }
        /// <summary>
        /// 下一曲
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void iconButtonNextMusic_Click(object sender, EventArgs e)
        {
            int index = listBoxMusic.SelectedIndex;
            index++;
            if (index == listBoxMusic.Items.Count)
            {
                index = 0;
            }
            PlayThread(listSongs[index]);
        }
    }
}
