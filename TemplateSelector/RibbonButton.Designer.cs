namespace TemplateSelector
{
    partial class RibbonButton : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public RibbonButton()
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
            this.TemplateSelector = this.Factory.CreateRibbonGroup();
            this.SelectTemplate = this.Factory.CreateRibbonButton();
            this.tab1.SuspendLayout();
            this.TemplateSelector.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab1
            // 
            this.tab1.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.tab1.ControlId.OfficeId = "TabMail";
            this.tab1.Groups.Add(this.TemplateSelector);
            this.tab1.Label = "TabMail";
            this.tab1.Name = "tab1";
            // 
            // TemplateSelector
            // 
            this.TemplateSelector.Items.Add(this.SelectTemplate);
            this.TemplateSelector.Label = "Templates";
            this.TemplateSelector.Name = "TemplateSelector";
            // 
            // SelectTemplate
            // 
            this.SelectTemplate.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.SelectTemplate.Label = "Select";
            this.SelectTemplate.Name = "SelectTemplate";
            this.SelectTemplate.OfficeImageId = "OptionEditableForm";
            this.SelectTemplate.ShowImage = true;
            this.SelectTemplate.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.SelectTemplate_Click);
            // 
            // RibbonButton
            // 
            this.Name = "RibbonButton";
            this.RibbonType = "Microsoft.Outlook.Explorer";
            this.Tabs.Add(this.tab1);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.RibbonButton_Load);
            this.tab1.ResumeLayout(false);
            this.tab1.PerformLayout();
            this.TemplateSelector.ResumeLayout(false);
            this.TemplateSelector.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab tab1;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup TemplateSelector;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton SelectTemplate;
    }

    partial class ThisRibbonCollection
    {
        internal RibbonButton RibbonButton
        {
            get { return this.GetRibbon<RibbonButton>(); }
        }
    }
}
