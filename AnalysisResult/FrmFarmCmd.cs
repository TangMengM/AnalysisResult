using ESRI.ArcGIS.Carto;
using MyPluginEngine;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnalysisResult
{
    class FrmFarmCmd: MyPluginEngine.ICommand
    {
        private MyPluginEngine.IApplication hk;
        private Bitmap m_hBitmap;

        private ESRI.ArcGIS.SystemUI.ICommand cmd = null;

        public FrmFarmCmd()
        {
            m_hBitmap = new Bitmap(@"..\Data\Image\PlanAnalysis\Picture05.png");
        }

        #region ICommond成员

        public Bitmap Bitmap
        {
            get { return m_hBitmap; }
        }

        public string Caption
        {
            get { return "基本农田/林地\r\n"+"冲突查询"; }
        }

        public string Category
        {
            get { return "MainMenu"; }
        }

        public bool Checked
        {
            get { return false; }
        }

        public bool Enabled
        {
            get { return true; }
        }

        public int HelpContextId
        {
            get { return 0; }
        }

        public string HelpFile
        {
            get { return ""; }
        }

        public string Message
        {
            get { return "基本农田/林地冲突查询"; }
        }

        public string Name
        {
            get { return "FrmFarmCmd"; }
        }

        public void OnClick()
        {
            string fileName = System.IO.Directory.GetCurrentDirectory().ToString() + "\\Data\\PlanAnalysis\\农田林地冲突.mxd";//获取Debug路径
            hk.PageLayoutControl.LoadMxFile(fileName);
            //将地图全屏最大化
            hk.PageLayoutControl.Extent = hk.PageLayoutControl.FullExtent;
        }

        public void OnCreate(IApplication hook)
        {
            if (hook != null)
            {
                this.hk = hook;
            }
        }

        public string Tooltip
        {
            get { return "基本农田/林地冲突查询"; }
        }
        #endregion
    }
}
