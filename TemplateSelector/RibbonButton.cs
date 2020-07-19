using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Office.Interop.Outlook;
using Microsoft.Office.Tools.Ribbon;

namespace TemplateSelector
{
    public partial class RibbonButton
    {

        private void RibbonButton_Load(object sender, RibbonUIEventArgs e)
        {

        }


        private void SelectTemplate_Click(object sender, RibbonControlEventArgs e)
        {
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Microsoft\\Templates";
                openFileDialog.Filter = "Outlook Template files (*.oft)|*.oft";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filePath = openFileDialog.FileName;
                    MailItem item = Globals.ThisAddIn.Application.CreateItemFromTemplate(filePath);
                    item.Display();
                }
            }
        }
    }
}
