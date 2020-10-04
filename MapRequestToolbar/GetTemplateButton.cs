using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArcGIS.Core.CIM;
using ArcGIS.Core.Data;
using ArcGIS.Core.Geometry;
using ArcGIS.Desktop.Catalog;
using ArcGIS.Desktop.Core;
using ArcGIS.Desktop.Core.Geoprocessing;
using ArcGIS.Desktop.Editing;
using ArcGIS.Desktop.Extensions;
using ArcGIS.Desktop.Framework;
using ArcGIS.Desktop.Framework.Contracts;
using ArcGIS.Desktop.Framework.Dialogs;
using ArcGIS.Desktop.Framework.Threading.Tasks;
using ArcGIS.Desktop.Mapping;

namespace MapRequestToolbar
{
    internal class GetTemplateButton : Button
    {
        protected override void OnClick()
        {
            try
            {
                // Install the toolbox in project folder and set path to the toolbox
                var toolPath = AutoUpdater.UpdateToolbar() + @"\DownloadProjectFiles";

                //launch script tool from gp pane
                //https://github.com/esri/arcgis-pro-sdk/wiki/ProConcepts-Geoprocessing#open-the-tool-dialog-in-the-geoprocessing-pane

                // Set value array (empty values allow user full control) and launch tool
                var dir = @"C:\Users\MWASHBUR\Desktop\MapRequestDev";
                var mapReqID = "123";
                var projectName = "ProjectName";
                var exorNew = "New Template";
                var pathtoEx = "";
                var copyOldData = "";
                var arcProDownload = "Yes";
                var PAGX_Template = "Template_8.5 X 11 Portrait";
                var toolParams = Geoprocessing.MakeValueArray(
                    dir, mapReqID, projectName, exorNew, pathtoEx, copyOldData, arcProDownload, PAGX_Template);
                Geoprocessing.OpenToolDialog(toolPath, toolParams);
            }
            catch (Exception e)
            {
                MessageBox.Show("Something went wrong " + e);
            }
        }
    }
}
