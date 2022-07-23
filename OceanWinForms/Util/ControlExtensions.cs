namespace OceanWinForms.Util
{
    public static class ControlExtensions
    {
        #region Fields
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool LockWindowUpdate(IntPtr hWndLock);

        private static readonly Dictionary<Control, bool> Draggables = new Dictionary<Control, bool>();
        private static Size _mouseOffset;
        #endregion

        #region Methods

        #region Private
        private static void control_MouseDown(object sender, MouseEventArgs e)
        {
            _mouseOffset = new Size(e.Location);
            Draggables[(Control)sender] = true;
        }

        private static void control_MouseUp(object sender, MouseEventArgs e)
        {
            Draggables[(Control)sender] = false;
        }

        private static void control_MouseMove(object sender, MouseEventArgs e)
        {
            if (!Draggables[(Control)sender])
                return;

            var newLocationOffset = e.Location - _mouseOffset;
            ((Control)sender).Left += newLocationOffset.X;
            ((Control)sender).Top += newLocationOffset.Y;
        }
        #endregion

        #region Extension methods
        public static void Suspend(this Control control)
        {
            if (!control.IsDisposed)
            {
                LockWindowUpdate(control.Handle);
            }
        }

        public static void Resume(this Control control)
        {
            if (!control.IsDisposed)
            {
                LockWindowUpdate(IntPtr.Zero);
            }
        }

        public static void Draggable(this Control control, bool enable)
        {
            if (enable)
            {
                if (Draggables.ContainsKey(control))
                {
                    return;
                }
                Draggables.Add(control, false);

                control.MouseDown += control_MouseDown;
                control.MouseUp += control_MouseUp;
                control.MouseMove += control_MouseMove;
            }
            else
            {
                if (!Draggables.ContainsKey(control))
                {
                    return;
                }

                control.MouseDown -= control_MouseDown;
                control.MouseUp -= control_MouseUp;
                control.MouseMove -= control_MouseMove;
                Draggables.Remove(control);
            }
        }
        #endregion

        #endregion
    }
}
