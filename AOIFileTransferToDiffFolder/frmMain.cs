using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AOIFileTransferToDiffFolder.ComTool;
using AOIFileTransferToDiffFolder.Model;
using AOIFileTransferToDiffFolder.BLL;
using System.IO;
using System.Collections;

namespace AOIFileTransferToDiffFolder
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        FileBll fileBll = new FileBll();

        private void frmMain_Load(object sender, EventArgs e)
        {
            this.Text += "V20190114";
            timer1.Enabled = true;
            btnStop.BackColor = SystemColors.Control;
            btnStop.Enabled = false;
            timerTransfer.Enabled = false;
            string file = string.Format("{0}\\config.xml", Application.StartupPath);          
            if (fileBll.initConfig(file))
            {
                txtSource.Text = BasicData.SouceFolder;
                for(int i = 0; i < BasicData.TargetFolderList.Count; i++)
                {
                    ((TextBox)GetControlInstance(this, "txtTarget"+(i+1).ToString())).Text = BasicData.TargetFolderList[i];
                }
            }
            else
            {
                MessageBox.Show("本地配置文件config.xml丢失或者没有维护正确的目标文件，请重新拷贝程序或者联系MES IT", "错误",MessageBoxButtons.OK,MessageBoxIcon.Error);
                Application.Exit();
            }
            btnStart.Enabled = true;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            timerTransfer.Enabled = true;
            btnStart.Enabled = false;
            btnStart.BackColor = SystemColors.Control;
            btnStop.Enabled = true;
            btnStop.BackColor = Color.Red;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timerTransfer.Enabled = false;
            btnStop.Enabled = false;
            btnStop.BackColor = SystemColors.Control;
            btnStart.Enabled = true;
            btnStart.BackColor = Color.Lime;
        }

        private void timerTransfer_Tick(object sender, EventArgs e)
        {
            fileBll.transferFileToDiffFolder();
            lblSouceQty.Text = BasicData.SouceFileQty.ToString();
            for (int i = 0; i < BasicData.TargetFileQtyList.Count; i++)
            {
                ((Label)GetControlInstance(this, "lblTargetQty" + (i + 1).ToString())).Text = BasicData.TargetFileQtyList[i].ToString();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }


        /// <summary>
        /// 根据指定容器和控件名字，获得控件
        /// </summary>
        /// <param name="obj">容器</param>
        /// <param name="strControlName">控件名字</param>
        /// <returns>控件</returns>
        private object GetControlInstance(object obj, string strControlName)
        {
            IEnumerator Controls = null;//所有控件
            Control c = null;//当前控件
            Object cResult = null;//查找结果
            if (obj.GetType() == this.GetType())//窗体
            {
                Controls = this.Controls.GetEnumerator();
            }
            else//控件
            {
                Controls = ((Control)obj).Controls.GetEnumerator();
            }
            while (Controls.MoveNext())//遍历操作
            {
                c = (Control)Controls.Current;//当前控件
                if (c.HasChildren)//当前控件是个容器
                {
                    cResult = GetControlInstance(c, strControlName);//递归查找
                    if (cResult == null)//当前容器中没有，跳出，继续查找
                        continue;
                    else//找到控件，返回
                        return cResult;
                }
                else if (c.Name == strControlName)//不是容器，同时找到控件，返回
                {
                    return c;
                }
            }
            return null;//控件不存在
        }


    }
}
