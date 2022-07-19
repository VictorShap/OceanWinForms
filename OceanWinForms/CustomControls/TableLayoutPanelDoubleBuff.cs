﻿
namespace OceanWinForms.CustomControls
{
    internal class TableLayoutPanelDoubleBuff : TableLayoutPanel
    {
        #region Properties
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }
        #endregion

        #region Ctor
        public TableLayoutPanelDoubleBuff() : base()
        {

        }
        #endregion

        #region Methods
        public static void SetDoubleBuffered(System.Windows.Forms.Control c)
        {
            if (System.Windows.Forms.SystemInformation.TerminalServerSession)
                return;
            System.Reflection.PropertyInfo aProp = typeof(System.Windows.Forms.Control).GetProperty("DoubleBuffered",
            System.Reflection.BindingFlags.NonPublic |
            System.Reflection.BindingFlags.Instance);
            aProp.SetValue(c, true, null);
        }

        #endregion
    }
}
