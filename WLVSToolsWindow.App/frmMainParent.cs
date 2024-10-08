using WLVSToolsWindow.App.Core.General;

namespace WLVSToolsWindow.App
{
    public partial class frmMainParent : Form
    {
        public frmMainParent()
        {
            InitializeComponent();
            tabControl1.DrawItem += TabControl1_DrawItem;
            tabControl1.MouseDown += TabControl1_MouseDown;
        }

        private void TabControl1_MouseDown(object? sender, MouseEventArgs e)
        {
            for (int i = 0; i < this.tabControl1.TabPages.Count; i++)
            {
                Rectangle r = tabControl1.GetTabRect(i);
                //Getting the position of the "x" mark.
                Rectangle closeButton = new Rectangle(r.Right - 19, r.Top + 5, 9, 7);
                if (closeButton.Contains(e.Location))
                {
                    var tabToClose = this.tabControl1.TabPages[i];
                    if (MessageBox.Show($"Would you like to Close this Tab({tabToClose.Text.Trim()})?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        this.tabControl1.TabPages.RemoveAt(i);
                        break;
                    }
                }
            }
        }

        private void TabControl1_DrawItem(object? sender, DrawItemEventArgs e)
        {
            var tabText = this.tabControl1.TabPages[e.Index].Text;

            //This code will render a "x" mark at the end of the Tab caption. 
            e.Graphics.DrawString("X", e.Font, Brushes.Black, e.Bounds.Right - 20, e.Bounds.Top + 4);
            e.Graphics.DrawString(tabText, e.Font, Brushes.Black, e.Bounds.Left, e.Bounds.Top + 4);
            e.DrawFocusRectangle();
        }

        private void toolStripMenuItem_Click(object sender, EventArgs e)
        {
            var toolStripMenuItem = (ToolStripMenuItem)sender;
            var itemText = toolStripMenuItem.Text + "    ";
            var form = Helper.TryGetFormByName(toolStripMenuItem.Name.Replace("tsmi", "frm"));
            var tabPage = new TabPage(itemText);
            var sameTabExists = (from TabPage tab in tabControl1.TabPages
                                 where tab.Text == itemText
                                 select tab).Any();

            if (!sameTabExists)
            {
                //tabPage
                form.TopLevel = false;
                form.FormBorderStyle = FormBorderStyle.None;
                form.Show();
                tabPage.Controls.Add(form);
                tabControl1.TabPages.Add(tabPage);
            }
        }
    }
}
