using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using Outlook = Microsoft.Office.Interop.Outlook;
using Office = Microsoft.Office.Core;

namespace TodoistDesktopLinker
{
    public partial class ThisAddIn
    {
        private void ThisAddIn_Startup(object sender, System.EventArgs e)
        {

        }

        private static string base64Encode(string plainText)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
            return System.Convert.ToBase64String(plainTextBytes);
        }

        public static void processMessage()
        {
            Outlook.Explorer currentOutlookInstance = Globals.ThisAddIn.Application.ActiveExplorer();
            int selectedMessageCount = currentOutlookInstance.Selection.Count;

            if(selectedMessageCount != 1)
            {
                // Make sure that only a single message is selected to generate a task from
                System.Windows.Forms.MessageBox.Show("Please select one message only");
            }
            else
            {
                // Get the currently selected Outlook Message
                Outlook.MailItem currentMailItem = Globals.ThisAddIn.Application.ActiveExplorer().Selection[1];

                // Extract the message ID from the message (so that we can find it if we move it)
                const string PR_INTERNET_MESSAGE_ID_W_TAG = "http://schemas.microsoft.com/mapi/proptag/0x1035001F";
                Outlook.PropertyAccessor oPropAccessor = currentMailItem.PropertyAccessor;

                string messageID = (string)oPropAccessor.GetProperty(PR_INTERNET_MESSAGE_ID_W_TAG);
                string base64MessageId = base64Encode(messageID);

                // Generate the task "link" string that goes into todoist

                string todoistTaskName = $"[{currentMailItem.Subject}](odmessage:{base64MessageId})";

                System.Windows.Forms.Clipboard.SetText(todoistTaskName);

                //System.Windows.Forms.MessageBox.Show(todoistTaskName);
                //System.Windows.Forms.MessageBox.Show(currentMailItem.Subject);
                //System.Windows.Forms.MessageBox.Show(messageID);
            }
            
            
            // Execute the AutoHotKey automation to open up a Todoist Window and put the task in there
            System.Diagnostics.Process externalCommand = new System.Diagnostics.Process();

            // Set the working directory for the AHK compiled script or otherwise it will end up crashing
            externalCommand.StartInfo.WorkingDirectory = AppContext.BaseDirectory;
            externalCommand.StartInfo.FileName = "TodoistDesktopAutomation.exe";

            externalCommand.Start();
        }

        private void ThisAddIn_Shutdown(object sender, System.EventArgs e)
        {
            // Note: Outlook no longer raises this event. If you have code that 
            //    must run when Outlook shuts down, see https://go.microsoft.com/fwlink/?LinkId=506785
        }

        #region VSTO generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InternalStartup()
        {
            this.Startup += new System.EventHandler(ThisAddIn_Startup);
            this.Shutdown += new System.EventHandler(ThisAddIn_Shutdown);
        }
        
        #endregion
    }
}
