namespace DXIvoiceDemo
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            barManager1 = new DevExpress.XtraBars.BarManager(components);
            bar1 = new DevExpress.XtraBars.Bar();
            bbiGenerateInvoices = new DevExpress.XtraBars.BarButtonItem();
            bbiGeneateCustomers = new DevExpress.XtraBars.BarButtonItem();
            barStaticItem1 = new DevExpress.XtraBars.BarStaticItem();
            beiNumberObject = new DevExpress.XtraBars.BarEditItem();
            repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            bbiExportCSV = new DevExpress.XtraBars.BarButtonItem();
            bbiExportXML = new DevExpress.XtraBars.BarButtonItem();
            bar3 = new DevExpress.XtraBars.Bar();
            barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            repositoryItemRadioGroup1 = new DevExpress.XtraEditors.Repository.RepositoryItemRadioGroup();
            layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            xtcData = new DevExpress.XtraTab.XtraTabControl();
            xtpInvoice = new DevExpress.XtraTab.XtraTabPage();
            layoutControl2 = new DevExpress.XtraLayout.LayoutControl();
            layoutControl3 = new DevExpress.XtraLayout.LayoutControl();
            gcInvoice = new DevExpress.XtraGrid.GridControl();
            gvInvoice = new DevExpress.XtraGrid.Views.Grid.GridView();
            layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            xtpCustomers = new DevExpress.XtraTab.XtraTabPage();
            layoutControl4 = new DevExpress.XtraLayout.LayoutControl();
            gcCustomers = new DevExpress.XtraGrid.GridControl();
            gvCustomers = new DevExpress.XtraGrid.Views.Grid.GridView();
            layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            Root = new DevExpress.XtraLayout.LayoutControlGroup();
            layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControl5 = new DevExpress.XtraLayout.LayoutControl();
            layoutControlGroup4 = new DevExpress.XtraLayout.LayoutControlGroup();
            reportGenerator1 = new DevExpress.XtraReports.ReportGeneration.ReportGenerator(components);
            bbiExportPDF = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)barManager1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemTextEdit1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemRadioGroup1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControl1).BeginInit();
            layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)xtcData).BeginInit();
            xtcData.SuspendLayout();
            xtpInvoice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)layoutControl2).BeginInit();
            layoutControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)layoutControl3).BeginInit();
            layoutControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gcInvoice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gvInvoice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlGroup2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlGroup1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem2).BeginInit();
            xtpCustomers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)layoutControl4).BeginInit();
            layoutControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gcCustomers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gvCustomers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlGroup3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Root).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControl5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlGroup4).BeginInit();
            SuspendLayout();
            // 
            // barManager1
            // 
            barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] { bar1, bar3 });
            barManager1.DockControls.Add(barDockControlTop);
            barManager1.DockControls.Add(barDockControlBottom);
            barManager1.DockControls.Add(barDockControlLeft);
            barManager1.DockControls.Add(barDockControlRight);
            barManager1.Form = this;
            barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] { bbiGenerateInvoices, bbiGeneateCustomers, beiNumberObject, barStaticItem1, bbiExportCSV, bbiExportXML, bbiExportPDF });
            barManager1.MaxItemId = 8;
            barManager1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] { repositoryItemRadioGroup1, repositoryItemTextEdit1 });
            barManager1.StatusBar = bar3;
            // 
            // bar1
            // 
            bar1.BarName = "Tools";
            bar1.DockCol = 0;
            bar1.DockRow = 0;
            bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] { new DevExpress.XtraBars.LinkPersistInfo(bbiGenerateInvoices), new DevExpress.XtraBars.LinkPersistInfo(bbiGeneateCustomers), new DevExpress.XtraBars.LinkPersistInfo(barStaticItem1), new DevExpress.XtraBars.LinkPersistInfo(beiNumberObject), new DevExpress.XtraBars.LinkPersistInfo(bbiExportCSV), new DevExpress.XtraBars.LinkPersistInfo(bbiExportXML), new DevExpress.XtraBars.LinkPersistInfo(bbiExportPDF) });
            bar1.Text = "Tools";
            // 
            // bbiGenerateInvoices
            // 
            bbiGenerateInvoices.Caption = "Generuj Faktury";
            bbiGenerateInvoices.Id = 0;
            bbiGenerateInvoices.Name = "bbiGenerateInvoices";
            bbiGenerateInvoices.ItemClick += bbiGenerateInvoices_ItemClick;
            // 
            // bbiGeneateCustomers
            // 
            bbiGeneateCustomers.Caption = "Generuj klientów";
            bbiGeneateCustomers.Id = 1;
            bbiGeneateCustomers.Name = "bbiGeneateCustomers";
            bbiGeneateCustomers.ItemClick += bbiGeneateCustomers_ItemClick;
            // 
            // barStaticItem1
            // 
            barStaticItem1.Caption = "Podaj liczbę obiektów do wygenerowania:";
            barStaticItem1.Id = 4;
            barStaticItem1.Name = "barStaticItem1";
            // 
            // beiNumberObject
            // 
            beiNumberObject.Caption = "barEditItem1";
            beiNumberObject.Edit = repositoryItemTextEdit1;
            beiNumberObject.EditValue = "1";
            beiNumberObject.Id = 3;
            beiNumberObject.Name = "beiNumberObject";
            // 
            // repositoryItemTextEdit1
            // 
            repositoryItemTextEdit1.AutoHeight = false;
            repositoryItemTextEdit1.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // bbiExportCSV
            // 
            bbiExportCSV.Caption = "Eksport CSV";
            bbiExportCSV.Id = 5;
            bbiExportCSV.Name = "bbiExportCSV";
            bbiExportCSV.ItemClick += bbiExportCSV_ItemClick;
            // 
            // bbiExportXML
            // 
            bbiExportXML.Caption = "Eksport XML";
            bbiExportXML.Id = 6;
            bbiExportXML.Name = "bbiExportXML";
            bbiExportXML.ItemClick += bbiExportXML_ItemClick;
            // 
            // bar3
            // 
            bar3.BarName = "Status bar";
            bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            bar3.DockCol = 0;
            bar3.DockRow = 0;
            bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            bar3.OptionsBar.AllowQuickCustomization = false;
            bar3.OptionsBar.DrawDragBorder = false;
            bar3.OptionsBar.UseWholeRow = true;
            bar3.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            barDockControlTop.CausesValidation = false;
            barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            barDockControlTop.Location = new System.Drawing.Point(0, 0);
            barDockControlTop.Manager = barManager1;
            barDockControlTop.Margin = new System.Windows.Forms.Padding(4);
            barDockControlTop.Size = new System.Drawing.Size(1346, 25);
            // 
            // barDockControlBottom
            // 
            barDockControlBottom.CausesValidation = false;
            barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            barDockControlBottom.Location = new System.Drawing.Point(0, 642);
            barDockControlBottom.Manager = barManager1;
            barDockControlBottom.Margin = new System.Windows.Forms.Padding(4);
            barDockControlBottom.Size = new System.Drawing.Size(1346, 20);
            // 
            // barDockControlLeft
            // 
            barDockControlLeft.CausesValidation = false;
            barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            barDockControlLeft.Location = new System.Drawing.Point(0, 25);
            barDockControlLeft.Manager = barManager1;
            barDockControlLeft.Margin = new System.Windows.Forms.Padding(4);
            barDockControlLeft.Size = new System.Drawing.Size(0, 617);
            // 
            // barDockControlRight
            // 
            barDockControlRight.CausesValidation = false;
            barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            barDockControlRight.Location = new System.Drawing.Point(1346, 25);
            barDockControlRight.Manager = barManager1;
            barDockControlRight.Margin = new System.Windows.Forms.Padding(4);
            barDockControlRight.Size = new System.Drawing.Size(0, 617);
            // 
            // repositoryItemRadioGroup1
            // 
            repositoryItemRadioGroup1.Name = "repositoryItemRadioGroup1";
            // 
            // layoutControl1
            // 
            layoutControl1.Controls.Add(xtcData);
            layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            layoutControl1.Location = new System.Drawing.Point(0, 25);
            layoutControl1.Name = "layoutControl1";
            layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(1108, 350, 812, 500);
            layoutControl1.Root = Root;
            layoutControl1.Size = new System.Drawing.Size(1346, 617);
            layoutControl1.TabIndex = 4;
            layoutControl1.Text = "layoutControl1";
            // 
            // xtcData
            // 
            xtcData.Location = new System.Drawing.Point(12, 12);
            xtcData.Name = "xtcData";
            xtcData.SelectedTabPage = xtpInvoice;
            xtcData.Size = new System.Drawing.Size(1322, 593);
            xtcData.TabIndex = 4;
            xtcData.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] { xtpInvoice, xtpCustomers });
            // 
            // xtpInvoice
            // 
            xtpInvoice.Controls.Add(layoutControl2);
            xtpInvoice.Name = "xtpInvoice";
            xtpInvoice.Size = new System.Drawing.Size(1320, 563);
            xtpInvoice.Text = "Faktury";
            // 
            // layoutControl2
            // 
            layoutControl2.Controls.Add(layoutControl3);
            layoutControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            layoutControl2.Location = new System.Drawing.Point(0, 0);
            layoutControl2.Name = "layoutControl2";
            layoutControl2.Root = layoutControlGroup1;
            layoutControl2.Size = new System.Drawing.Size(1320, 563);
            layoutControl2.TabIndex = 0;
            layoutControl2.Text = "layoutControl2";
            // 
            // layoutControl3
            // 
            layoutControl3.Controls.Add(gcInvoice);
            layoutControl3.Location = new System.Drawing.Point(12, 12);
            layoutControl3.Name = "layoutControl3";
            layoutControl3.Root = layoutControlGroup2;
            layoutControl3.Size = new System.Drawing.Size(1296, 539);
            layoutControl3.TabIndex = 4;
            layoutControl3.Text = "layoutControl3";
            // 
            // gcInvoice
            // 
            gcInvoice.Location = new System.Drawing.Point(12, 12);
            gcInvoice.MainView = gvInvoice;
            gcInvoice.MenuManager = barManager1;
            gcInvoice.Name = "gcInvoice";
            gcInvoice.Size = new System.Drawing.Size(1272, 515);
            gcInvoice.TabIndex = 4;
            gcInvoice.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gvInvoice });
            gcInvoice.KeyDown += gcInvoice_KeyDown;
            // 
            // gvInvoice
            // 
            gvInvoice.GridControl = gcInvoice;
            gvInvoice.Name = "gvInvoice";
            gvInvoice.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            gvInvoice.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.True;
            gvInvoice.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            gvInvoice.RowUpdated += gvInvoice_RowUpdated;
            // 
            // layoutControlGroup2
            // 
            layoutControlGroup2.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            layoutControlGroup2.GroupBordersVisible = false;
            layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { layoutControlItem3 });
            layoutControlGroup2.Name = "layoutControlGroup2";
            layoutControlGroup2.Size = new System.Drawing.Size(1296, 539);
            layoutControlGroup2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            layoutControlItem3.Control = gcInvoice;
            layoutControlItem3.Location = new System.Drawing.Point(0, 0);
            layoutControlItem3.Name = "layoutControlItem3";
            layoutControlItem3.Size = new System.Drawing.Size(1276, 519);
            layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            layoutControlItem3.TextVisible = false;
            // 
            // layoutControlGroup1
            // 
            layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            layoutControlGroup1.GroupBordersVisible = false;
            layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { layoutControlItem2 });
            layoutControlGroup1.Name = "layoutControlGroup1";
            layoutControlGroup1.Size = new System.Drawing.Size(1320, 563);
            layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            layoutControlItem2.Control = layoutControl3;
            layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            layoutControlItem2.Name = "layoutControlItem2";
            layoutControlItem2.Size = new System.Drawing.Size(1300, 543);
            layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            layoutControlItem2.TextVisible = false;
            // 
            // xtpCustomers
            // 
            xtpCustomers.Controls.Add(layoutControl4);
            xtpCustomers.Name = "xtpCustomers";
            xtpCustomers.Size = new System.Drawing.Size(1320, 563);
            xtpCustomers.Text = "Klienci";
            // 
            // layoutControl4
            // 
            layoutControl4.Controls.Add(gcCustomers);
            layoutControl4.Dock = System.Windows.Forms.DockStyle.Fill;
            layoutControl4.Location = new System.Drawing.Point(0, 0);
            layoutControl4.Name = "layoutControl4";
            layoutControl4.Root = layoutControlGroup3;
            layoutControl4.Size = new System.Drawing.Size(1320, 563);
            layoutControl4.TabIndex = 0;
            layoutControl4.Text = "layoutControl4";
            // 
            // gcCustomers
            // 
            gcCustomers.Location = new System.Drawing.Point(12, 12);
            gcCustomers.MainView = gvCustomers;
            gcCustomers.MenuManager = barManager1;
            gcCustomers.Name = "gcCustomers";
            gcCustomers.Size = new System.Drawing.Size(1296, 539);
            gcCustomers.TabIndex = 4;
            gcCustomers.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gvCustomers });
            // 
            // gvCustomers
            // 
            gvCustomers.GridControl = gcCustomers;
            gvCustomers.Name = "gvCustomers";
            gvCustomers.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            gvCustomers.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click;
            gvCustomers.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            gvCustomers.RowUpdated += gvCustomers_RowUpdated;
            gvCustomers.KeyDown += gvCustomers_KeyDown;
            // 
            // layoutControlGroup3
            // 
            layoutControlGroup3.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            layoutControlGroup3.GroupBordersVisible = false;
            layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { layoutControlItem4 });
            layoutControlGroup3.Name = "layoutControlGroup3";
            layoutControlGroup3.Size = new System.Drawing.Size(1320, 563);
            layoutControlGroup3.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            layoutControlItem4.Control = gcCustomers;
            layoutControlItem4.Location = new System.Drawing.Point(0, 0);
            layoutControlItem4.Name = "layoutControlItem4";
            layoutControlItem4.Size = new System.Drawing.Size(1300, 543);
            layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            layoutControlItem4.TextVisible = false;
            // 
            // Root
            // 
            Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            Root.GroupBordersVisible = false;
            Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { layoutControlItem1 });
            Root.Name = "Root";
            Root.Size = new System.Drawing.Size(1346, 617);
            Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            layoutControlItem1.Control = xtcData;
            layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            layoutControlItem1.Name = "layoutControlItem1";
            layoutControlItem1.Size = new System.Drawing.Size(1326, 597);
            layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            layoutControlItem1.TextVisible = false;
            // 
            // layoutControl5
            // 
            layoutControl5.Dock = System.Windows.Forms.DockStyle.Fill;
            layoutControl5.Location = new System.Drawing.Point(1, 29);
            layoutControl5.Name = "layoutControl5";
            layoutControl5.Root = layoutControlGroup4;
            layoutControl5.Size = new System.Drawing.Size(1320, 563);
            layoutControl5.TabIndex = 3;
            layoutControl5.Text = "layoutControl5";
            // 
            // layoutControlGroup4
            // 
            layoutControlGroup4.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            layoutControlGroup4.GroupBordersVisible = false;
            layoutControlGroup4.Name = "layoutControlGroup4";
            layoutControlGroup4.Size = new System.Drawing.Size(1320, 563);
            layoutControlGroup4.TextVisible = false;
            // 
            // bbiExportPDF
            // 
            bbiExportPDF.Caption = "Eksport do PDF";
            bbiExportPDF.Id = 7;
            bbiExportPDF.Name = "bbiExportPDF";
            bbiExportPDF.ItemClick += bbiExportPDF_ItemClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1346, 662);
            Controls.Add(layoutControl1);
            Controls.Add(barDockControlLeft);
            Controls.Add(barDockControlRight);
            Controls.Add(barDockControlBottom);
            Controls.Add(barDockControlTop);
            Margin = new System.Windows.Forms.Padding(4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)barManager1).EndInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemTextEdit1).EndInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemRadioGroup1).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControl1).EndInit();
            layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)xtcData).EndInit();
            xtcData.ResumeLayout(false);
            xtpInvoice.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)layoutControl2).EndInit();
            layoutControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)layoutControl3).EndInit();
            layoutControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gcInvoice).EndInit();
            ((System.ComponentModel.ISupportInitialize)gvInvoice).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlGroup2).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem3).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlGroup1).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem2).EndInit();
            xtpCustomers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)layoutControl4).EndInit();
            layoutControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gcCustomers).EndInit();
            ((System.ComponentModel.ISupportInitialize)gvCustomers).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlGroup3).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem4).EndInit();
            ((System.ComponentModel.ISupportInitialize)Root).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem1).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControl5).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlGroup4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraTab.XtraTabControl xtcData;
        private DevExpress.XtraTab.XtraTabPage xtpInvoice;
        private DevExpress.XtraLayout.LayoutControl layoutControl2;
        private DevExpress.XtraLayout.LayoutControl layoutControl3;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraTab.XtraTabPage xtpCustomers;
        private DevExpress.XtraLayout.LayoutControl layoutControl4;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraGrid.GridControl gcInvoice;
        private DevExpress.XtraGrid.Views.Grid.GridView gvInvoice;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraGrid.GridControl gcCustomers;
        private DevExpress.XtraGrid.Views.Grid.GridView gvCustomers;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraBars.BarButtonItem bbiGenerateInvoices;
        private DevExpress.XtraBars.BarButtonItem bbiGeneateCustomers;
        private DevExpress.XtraBars.BarEditItem beiNumberObject;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemRadioGroup repositoryItemRadioGroup1;
        private DevExpress.XtraBars.BarStaticItem barStaticItem1;
        private DevExpress.XtraBars.BarButtonItem bbiExportCSV;
        private DevExpress.XtraBars.BarButtonItem bbiExportXML;
        private DevExpress.XtraLayout.LayoutControl layoutControl5;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup4;
        private DevExpress.XtraReports.ReportGeneration.ReportGenerator reportGenerator1;
        private DevExpress.XtraBars.BarButtonItem bbiExportPDF;
    }
}

