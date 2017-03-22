using MyPluginEngine;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalysisResult
{
    class FrmSpatialControlCmd: MyPluginEngine.ICommand
    {
        private MyPluginEngine.IApplication hk;
        private Bitmap m_hBitmap;

        private ESRI.ArcGIS.SystemUI.ICommand cmd = null;

        public FrmSpatialControlCmd()
        {
            m_hBitmap = new Bitmap(@"..\Data\Image\PlanAnalysis\Picture01.png");
        }

        #region ICommond成员

        public Bitmap Bitmap
        {
            get { return m_hBitmap; }
        }

        public string Caption
        {
            get { return "空间管制区冲突\r\n" + "及分区查询"; }
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
            get { return "空间管制区冲突及分区查询"; }
        }

        public string Name
        {
            get { return "FrmSpatialControlCmd"; }
        }

        public void OnClick()
        {
            string fileName = System.IO.Directory.GetCurrentDirectory().ToString() + "\\Data\\PlanAnalysis\\空间管制冲突.mxd";//获取Debug路径
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
            get { return "空间管制区冲突及分区查询"; }
        }
        #endregion
    }
}
