using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using System;
using System.Transactions;

namespace RevitAPITraining_NWCExport
{
    [Transaction(TransactionMode.Manual)]
    public class Main : IExternalCommand
    {
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            Document doc = commandData.Application.ActiveUIDocument.Document;

            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string name = "export.nwc";
            NavisworksExportOptions nwcOption = new NavisworksExportOptions();

            doc.Export(path, name, nwcOption);

            return Result.Succeeded;
        }
    }
}
