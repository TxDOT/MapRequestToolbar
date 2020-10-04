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
    internal class UploadMapToAGOButton : Button
    {
        protected override void OnClick()
        {
            try
            {
                //call autoupdater method here
                //set version path
                var toolPath = AutoUpdater.UpdateToolbar() + @"\UploadToAGO";
                //launch script tool from gp pane
                //https://github.com/esri/arcgis-pro-sdk/wiki/ProConcepts-Geoprocessing#open-the-tool-dialog-in-the-geoprocessing-pane
                //ProjectFolder = arcpy.GetParameterAsText(0)
                //MapTitle = arcpy.GetParameterAsText(1) # If you type "Test" in the tool, it will catch all items with the title contains "test" => How to convert it from relative search to hard code?
                //MapDesc = arcpy.GetParameterAsText(2)
                //MapTags = arcpy.GetParameterAsText(3)
                var projectPath = Project.Current.HomeFolderPath;
                var mapName = "";
                var mapDesc = "";
                var mapTags = "";
                var toolParams = Geoprocessing.MakeValueArray(projectPath, mapName, mapDesc, mapTags);
                Geoprocessing.OpenToolDialog(toolPath, toolParams);
            }
            catch (Exception e)
            {
                MessageBox.Show("Something went wrong " + e);
            }
        }
    }
}
