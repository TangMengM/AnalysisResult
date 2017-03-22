using MyPluginEngine;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalysisResult
{
    class FrmPlanBuildCmd: MyPluginEngine.ICommand
    {
        private MyPluginEngine.IApplication hk;
        private Bitmap m_hBitmap;

        private ESRI.ArcGIS.SystemUI.ICommand cmd = null;

        public FrmPlanBuildCmd()
        {
            m_hBitmap = new Bitmap(@"..\Data\Image\PlanAnalysis\Picture02.png");
        }

        #region ICommond成员

        public Bitmap Bitmap
        {
            get { return m_hBitmap; }
        }

        public string Caption
        {
            get { return "规划区建设用\r\n" + "地冲突查询"; }
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
            get { return "规划区建设用地冲突查询"; }
        }

        public string Name
        {
            get { return "FrmPlanBuildCmd"; }
        }

        public void OnClick()
        {
            string fileName = System.IO.Directory.GetCurrentDirectory().ToString() + "\\Data\\PlanAnalysis\\城规土规冲突.mxd";//获取Debug路径
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
            get { return "规划区建设用地冲突查询"; }
        }
        #endregion
    }
}
