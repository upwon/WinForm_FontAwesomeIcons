using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace WinForm_FontAwesomeIcons
{

    
    public partial class FormMainMenu : Form
    {
        private IconButton currentIconButton;
        private Panel leftBoderBtn;
        private Form currentChildForm;

        // constructor
        public FormMainMenu()
        {
            InitializeComponent();
            leftBoderBtn =new Panel();
            leftBoderBtn.Size=new Size(7,60);
            panelMenu.Controls.Add(leftBoderBtn);

            //Form
            this.Text = string.Empty;
            this.ControlBox = false;  //标题栏不显示控件框
            this.DoubleBuffered = true;  //减少闪烁

            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;  //最大化不覆盖标题栏
        }

        //structs for color
        private struct RGBcolors
        {
            public static Color color1 = Color.FromArgb(242, 12, 0);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
            public static Color color7 = Color.FromArgb(27, 209, 165);
        }
        
        //Methods
        private void ActiveButton(object senderBtn,Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                currentIconButton = (IconButton) senderBtn;
                currentIconButton.BackColor = Color.FromArgb(195, 166, 203); //更改按钮背景颜色
                currentIconButton.ForeColor = color; //更改按钮的文本颜色
                currentIconButton.TextAlign = ContentAlignment.MiddleCenter; //文本居中对齐
                currentIconButton.IconColor = color;    //更改图标颜色
                currentIconButton.TextImageRelation = TextImageRelation.TextBeforeImage;  //文本显示在控件前方
                currentIconButton.ImageAlign = ContentAlignment.MiddleRight;  //图标右对齐

                //left border button
                leftBoderBtn.BackColor = color;
                leftBoderBtn.Location=new Point(0,currentIconButton.Location.Y); //调整位置
                leftBoderBtn.Visible = true;
                leftBoderBtn.BringToFront();  //设在上层

                //Icon Current Child Form 
                iconCurrentChildForm.IconChar = currentIconButton.IconChar;
                iconCurrentChildForm.IconColor = currentIconButton.IconColor;



            }
        }

        private void DisableButton()
        {
            if (currentIconButton != null)
            {
                currentIconButton.BackColor = Color.FromArgb(37, 120, 181); //恢复按钮背景颜色
                currentIconButton.ForeColor = Color.White; //恢复按钮的文本颜色
                currentIconButton.TextAlign = ContentAlignment.MiddleLeft; //文本左对齐
                currentIconButton.IconColor = Color.White;    //恢复图标颜色
                currentIconButton.TextImageRelation = TextImageRelation.ImageBeforeText;  //图标显示在文字前方
                currentIconButton.ImageAlign = ContentAlignment.MiddleLeft;  //图标左对齐

            }
        }

        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {   //只同时打开一个 因此需要先关闭其他的
                currentChildForm.Close();
            }

            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;   //无边框
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            childForm.BringToFront();
            childForm.Show();
            lblChildForm.Text = childForm.Text;

        }

        private void iconBtnGoogle_Click(object sender, EventArgs e)
        {
            ActiveButton(sender,RGBcolors.color1);
            OpenChildForm(new FormGoogle());
        }

        private void iconBtnPlay_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBcolors.color2);
            OpenChildForm(new AboutBox1());

        }

        private void iconBtnDrive_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBcolors.color3);
            OpenChildForm(new FormGoogle());

        }

        private void iconBtnMicrosoft_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBcolors.color4);
            OpenChildForm(new FormSample());

        }

        private void iconBtnBloger_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBcolors.color5);
            OpenChildForm(new FormGoogle());

        }

        private void iconBtnWeibo_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBcolors.color6);
            OpenChildForm(new FormGoogle());

        }

        private void iconBtnWindows_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBcolors.color7);
            OpenChildForm(new AboutBox1());


        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Reset();
            currentChildForm.Close();
        }

        private void Reset()
        {
           DisableButton();
           leftBoderBtn.Visible = false;

           iconCurrentChildForm.IconChar = IconChar.Home;
           iconCurrentChildForm.IconColor = Color.White;
           iconCurrentChildForm.Text = "Home";

        }

        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);

        }

        private void iconButtonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconButtonMax_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void iconButtonMin_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Minimized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }


        }

        private void panelDesktop_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
