namespace TodoistDesktopLinker
{
    partial class TodoistDesktopRibbon : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public TodoistDesktopRibbon()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tab1 = this.Factory.CreateRibbonTab();
            this.groupTodoistDesktop = this.Factory.CreateRibbonGroup();
            this.btnTodoistDesktopAdd = this.Factory.CreateRibbonButton();
            this.tab1.SuspendLayout();
            this.groupTodoistDesktop.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab1
            // 
            this.tab1.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.tab1.ControlId.OfficeId = "TabMail";
            this.tab1.Groups.Add(this.groupTodoistDesktop);
            this.tab1.Label = "TabMail";
            this.tab1.Name = "tab1";
            // 
            // groupTodoistDesktop
            // 
            this.groupTodoistDesktop.Items.Add(this.btnTodoistDesktopAdd);
            this.groupTodoistDesktop.Label = "Todoist Desktop";
            this.groupTodoistDesktop.Name = "groupTodoistDesktop";
            // 
            // btnTodoistDesktopAdd
            // 
            this.btnTodoistDesktopAdd.Label = "Add to Todoist Desktop";
            this.btnTodoistDesktopAdd.Name = "btnTodoistDesktopAdd";
            this.btnTodoistDesktopAdd.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnTodoistDesktopAdd_Click);
            // 
            // TodoistDesktopRibbon
            // 
            this.Name = "TodoistDesktopRibbon";
            this.RibbonType = "Microsoft.Outlook.Explorer";
            this.Tabs.Add(this.tab1);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.TodoistDesktopRibbon_Load);
            this.tab1.ResumeLayout(false);
            this.tab1.PerformLayout();
            this.groupTodoistDesktop.ResumeLayout(false);
            this.groupTodoistDesktop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab tab1;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup groupTodoistDesktop;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnTodoistDesktopAdd;
    }

    partial class ThisRibbonCollection
    {
        internal TodoistDesktopRibbon TodoistDesktopRibbon
        {
            get { return this.GetRibbon<TodoistDesktopRibbon>(); }
        }
    }
}
