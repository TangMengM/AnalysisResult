using MyPluginEngine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalysisResult
{
    class AnalysisResultMenuBar : IMenuDef
    {
        #region IMenuDef成员
        public string Caption
        {
            get { return "多规合一结果查看"; }
        }

        public string Name
        {
            get { return "AnalysisResultMenu"; }
        }

        public long ItemCount
        {
            get { return 5; }
        }

        public void GetItemInfo(int pos, ItemDef itemDef)
        {
            switch (pos)
            {
                case 0:
                    itemDef.ID = "AnalysisResult.FrmSpatialControlCmd";
                    itemDef.Group = false;
                    break;
                case 1:
                    itemDef.ID = "AnalysisResult.FrmPlanBuildCmd";
                    itemDef.Group = true;
                    break;
                case 2:
                    itemDef.ID = "AnalysisResult.FrmForestCmd";
                    itemDef.Group = false;
                    break;
                case 3:
                    itemDef.ID = "AnalysisResult.FrmForest2";
                    itemDef.Group = false;
                    break;
                case 4:
                    itemDef.ID = "AnalysisResult.FrmFarmCmd";
                    itemDef.Group = false;
                    break;
               
                default:
                    break;
            }
        }
        #endregion
    }
}
