﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArcGIS.Core.CIM;
using ArcGIS.Core.Data;
using ArcGIS.Core.Geometry;
using ArcGIS.Desktop.Catalog;
using ArcGIS.Desktop.Core;
using ArcGIS.Desktop.Editing;
using ArcGIS.Desktop.Extensions;
using ArcGIS.Desktop.Framework;
using ArcGIS.Desktop.Framework.Contracts;
using ArcGIS.Desktop.Framework.Dialogs;
using ArcGIS.Desktop.Framework.Threading.Tasks;
using ArcGIS.Desktop.Mapping;

namespace MapRequestToolbar
{
    internal class UploadProjectFilesButton : Button
    {
        protected override void OnClick()
        {
            try
            {
                //call autoupdater method here
                //set version path
                //launch script tool from gp pane
                //https://github.com/esri/arcgis-pro-sdk/wiki/ProConcepts-Geoprocessing#open-the-tool-dialog-in-the-geoprocessing-pane

                MessageBox.Show("Uploading project files to T Drive...");
            }
            catch (Exception e)
            {
                MessageBox.Show("Something went wrong " + e);
            }
        }
    }
}
