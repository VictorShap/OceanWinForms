
namespace OceanWinForms
{
    public static class ControlExtensions
    {
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool LockWindowUpdate(IntPtr hWndLock);

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
    }
}
