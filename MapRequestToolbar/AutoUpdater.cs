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
                
                // Create lists to hold tbx files
                var sourceList = new List<string>();
                var localList = new List<string>();

                // Loop through each tbx list and write to new lists
                foreach (var i in sourceTBX)
                {
                    sourceList.Add(i);
                }
                foreach (var i in localTBX)
                {
                    localList.Add(i);
                }

                // update project folder with toolbox (assumes only 1 tbx in sourceDir)
                var sourcePath = sourceList.ElementAt(0);
                var toolName = Path.GetFileName(sourcePath);
                var localPath = localDir + @"\" + toolName;

                if (!File.Exists(localPath))
                {
                    if (!localList.Contains(sourceList.ElementAt(0)))
                    {
                        File.Copy(sourcePath, localPath);
                    }
                }
                
                return localPath;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
        }
    }
}
