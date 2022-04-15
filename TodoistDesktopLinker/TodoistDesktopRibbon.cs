using Microsoft.Office.Tools.Ribbon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TodoistDesktopLinker
{
    public partial class TodoistDesktopRibbon
    {
        private void TodoistDesktopRibbon_Load(object sender, RibbonUIEventArgs e)
        {
            //System.Windows.Forms.MessageBox.Show("Desktop Ribbon Load Function");
        }

        private void btnTodoistDesktopAdd_Click(object sender, RibbonControlEventArgs e)
        {
            ThisAddIn.processMessage();
        }
    }
}
