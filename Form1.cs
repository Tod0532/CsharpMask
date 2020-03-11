using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.IO.Ports;

namespace Mask
{
    public partial class Form1 : Form
    {
        public string txtSelect = "";       
        Control[] readtext;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            readtext = new Control[] { txtName, txtPhoneNumber, txtCardNumber, txtAddress };
        }

        private void btnClearText_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < readtext.Length; i++)
            {
                readtext[i].Text = "";
            }
        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetText(txtSelect.ToString());
                SendKeys.SendWait("^V");
                timer1.Stop();
            }
            catch (Exception ex)
            {
                timer1.Enabled = false;
                MessageBox.Show("内容不能为空！"+ex.Message);
             
            }

        }

        private void frmActivated(object sender, EventArgs e)
        {
            HotKey.RegisterHotKey(Handle, 100, 0, Keys.F1); //定义热键为Escape，这里实现了屏幕系统退出
            HotKey.RegisterHotKey(Handle, 101, 0, Keys.F2); //注册F1热键,根据id值101来判断需要执行哪个函数
            HotKey.RegisterHotKey(Handle, 102, 0, Keys.F3); //注册F2热键,根据id值102来判断需要执行哪个函数
            HotKey.RegisterHotKey(Handle, 103, 0, Keys.F4); //注册F2热键,根据id值102来判断需要执行哪个函数
        }

        private void frm_Leave(object sender, EventArgs e)
        {
            //注销Id号为100的热键设定
            HotKey.UnregisterHotKey(Handle, 100);
            //注销Id号为101的热键设定
            HotKey.UnregisterHotKey(Handle, 101);
            //注销Id号为102的热键设定
            HotKey.UnregisterHotKey(Handle, 102);
            HotKey.UnregisterHotKey(Handle, 103);
        }
        protected override void WndProc(ref Message m)
        {
            const int WM_HOTKEY = 0x0312;
            //按快捷键 
            switch (m.Msg)
            {
                case WM_HOTKEY:
                    switch (m.WParam.ToInt32())
                    {
                        case 100:    //F1
                            txtSelect = txtName.Text.Trim();
                            timer1.Start();
                            break;
                        case 101:    //F2 
                            txtSelect = txtPhoneNumber.Text.Trim();
                            timer1.Start();
                            break;
                        case 102:    //F3 全屏
                            txtSelect =txtCardNumber.Text.Trim();
                            timer1.Start();
                            break;
                        case 103:    //F4 全屏
                            txtSelect = txtAddress.Text.Trim();
                            timer1.Start();
                            break;

                    }
                    break;
            }
            base.WndProc(ref m);
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "数据文件(*.txt)|*.txt|All files(*.*)|*.*";//设置为数据文件或所有文件
            sfd.DefaultExt = "txt"; //设置默认扩展名为txt
            if (sfd.ShowDialog() == DialogResult.OK) //打开对话框 
            {
                try
                {
                    StreamWriter m_SW = new StreamWriter(sfd.FileName);// 实例化StreamWriter类 
                    for (int i = 0; i < readtext.Length; i++)
                    {
                        m_SW.WriteLine(readtext[i].Text.Trim());

                    }
                    m_SW.Close();
                }// 关闭文件 } 
                catch (IOException ex)
                {
                    MessageBox.Show("写入出错！\n" + ex.Message);
                    return;
                }
            }
        }

        private void BtnRead_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "数据文件(*.txt)|*.txt|All files(*.*)|*.*";//设置为数据文件或所有文件
            ofd.DefaultExt = "txt"; //设置默认扩展名为txt f
            if (ofd.ShowDialog() == DialogResult.OK) //打开对话框 
            {
                try
                {
                    StreamReader m_SW = new StreamReader(ofd.FileName);// 实例化StreamWriter类 
                    for (int i = 0; i < readtext.Length; i++)
                    {
                        readtext[i].Text = Convert.ToString(m_SW.ReadLine()).Trim();
                    }
                    m_SW.Close();
                }// 关闭文件 } 
                catch (IOException ex)
                {
                    MessageBox.Show("写入出错！\n" + ex.Message);
                    return;
                }
            }
        }
    }
}
