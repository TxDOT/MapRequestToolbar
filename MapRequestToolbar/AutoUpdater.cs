using System.Data;
using System.Diagnostics;
using System.IO;
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
using ArcGIS.Desktop.GeoProcessing;
using ArcGIS.Desktop.Framework.Threading.Tasks;
using ArcGIS.Desktop.Mapping;
using System.Windows;
using ArcGIS.Desktop.Editing.Attributes;
using ArcGIS.Desktop.Core.Geoprocessing;
using System.Threading;
using MessageBox = ArcGIS.Desktop.Framework.Dialogs.MessageBox;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
namespace MapRequestToolbar
{
    class AutoUpdater
    {
        public static string UpdateToolbar() 
        {
            try
            {

                // Set source and local directories and get tbx files
                var sourceDir = @"T:\DATAMGT\MAPPING\Map Requests\_Toolbar";
                var localDir = Project.Current.HomeFolderPath;

                var sourceTBX = Directory.GetFiles(sourceDir, "*.tbx");
                var localTBX = Directory.GetFiles(localDir, "*.tbx");
                return null;

                //    var sourceList = new List<int>();
                //    var localList = new List<int>();

                //    // Loop through each and extract most recent version
                //    foreach (var i in sourceTBX)
                //    {
                //        var parseVer = Convert.ToInt32(Regex.Replace(i, "[^0-9]+", string.Empty));
                //        sourceList.Add(parseVer);
                //    }
                //    foreach (var i in localTBX)
                //    {
                //        var parseVer = Convert.ToInt32(Regex.Replace(i, "[^0-9]+", string.Empty));
                //        localList.Add(parseVer);
                //    }

                //    // Compare local version against source version and install most recent version
                //    if (localList.Max() < sourceList.Max())
                //    {
                //        foreach (var i in localTBX)
                //        {
                //            File.Delete(i);
                //        }
                //        File.Copy(sourceDir + string.Format(@"\ETLQaQC_v{0}.tbx", sourceList.Max()),
                //            localDir + string.Format(@"\ETLQaQC_v{0}.tbx", sourceList.Max()));
                //    }
                //    // Return correct version to launch tool
                //    return sourceList.Max().ToString();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
        }
    }
}
