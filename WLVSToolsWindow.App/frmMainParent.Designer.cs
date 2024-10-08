namespace WLVSToolsWindow.App
{
    partial class frmMainParent
    {
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;

        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainParent));
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            splitContainer1 = new SplitContainer();
            toolStrip1 = new ToolStrip();
            toolStripButton1 = new ToolStripDropDownButton();
            tsmiGenerateFakePersonalInfo = new ToolStripMenuItem();
            tabControl1 = new TabControl();
            statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.ImeMode = ImeMode.NoControl;
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1 });
            statusStrip1.Location = new Point(0, 502);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Padding = new Padding(1, 0, 19, 0);
            statusStrip1.Size = new Size(960, 26);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(151, 20);
            toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(toolStrip1);
            splitContainer1.Panel1MinSize = 5;
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(tabControl1);
            splitContainer1.Size = new Size(960, 502);
            splitContainer1.SplitterDistance = 320;
            splitContainer1.TabIndex = 2;
            // 
            // toolStrip1
            // 
            toolStrip1.Dock = DockStyle.Fill;
            toolStrip1.GripStyle = ToolStripGripStyle.Hidden;
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton1 });
            toolStrip1.LayoutStyle = ToolStripLayoutStyle.VerticalStackWithOverflow;
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.RenderMode = ToolStripRenderMode.Professional;
            toolStrip1.Size = new Size(320, 502);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            toolStripButton1.DropDownItems.AddRange(new ToolStripItem[] { tsmiGenerateFakePersonalInfo });
            toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageAlign = ContentAlignment.MiddleLeft;
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(318, 24);
            toolStripButton1.Text = "Common Tools";
            // 
            // tsmiGenerateFakePersonalInfo
            // 
            tsmiGenerateFakePersonalInfo.Name = "tsmiGenerateFakePersonalInfo";
            tsmiGenerateFakePersonalInfo.Size = new Size(274, 26);
            tsmiGenerateFakePersonalInfo.Text = "Generate Fake Personal Info";
            tsmiGenerateFakePersonalInfo.Click += toolStripMenuItem_Click;
            // 
            // tabControl1
            // 
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.DrawMode = TabDrawMode.OwnerDrawFixed;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(636, 502);
            tabControl1.TabIndex = 0;
            // 
            // frmMainParent
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(960, 528);
            Controls.Add(splitContainer1);
            Controls.Add(statusStrip1);
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            Name = "frmMainParent";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "WLVS Tools by Tonton";
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private SplitContainer splitContainer1;
        private ToolStrip toolStrip1;
        private ToolStripDropDownButton toolStripButton1;
        private ToolStripMenuItem tsmiGenerateFakePersonalInfo;
        private TabControl tabControl1;
    }
}
