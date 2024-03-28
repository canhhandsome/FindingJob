using System.Drawing.Drawing2D;

public static class PanelUtils
{
    public static void MakeRounded( Panel panel, int radius)
    {
        panel.Paint += (sender, e) =>
        {
            using (GraphicsPath path = GetRoundRectangle(panel.ClientRectangle, radius))
            using (Region region = new Region(path))
            {
                panel.Region = region;
                using (Pen pen = new Pen(panel.BackColor, 1))
                {
                    e.Graphics.DrawPath(pen, path);
                }
            }
        };
    }
    private static GraphicsPath GetRoundRectangle(Rectangle bounds, int radius)
    {
        float r = radius;
        GraphicsPath path = new GraphicsPath();
        path.StartFigure();

        // Top-left corner
        path.AddArc(bounds.Left, bounds.Top, 2 * r, 2 * r, 180, 90);

        // Top edge
        path.AddLine(bounds.Left + r, bounds.Top, bounds.Right - r, bounds.Top);

        // Top-right corner
        path.AddArc(bounds.Right - 2 * r, bounds.Top, 2 * r, 2 * r, 270, 90);

        // Right edge
        path.AddLine(bounds.Right, bounds.Top + r, bounds.Right, bounds.Bottom - r);

        // Bottom-right corner
        path.AddArc(bounds.Right - 2 * r, bounds.Bottom - 2 * r, 2 * r, 2 * r, 0, 90);

        // Bottom edge
        path.AddLine(bounds.Right - r, bounds.Bottom, bounds.Left + r, bounds.Bottom);

        // Bottom-left corner
        path.AddArc(bounds.Left, bounds.Bottom - 2 * r, 2 * r, 2 * r, 90, 90);

        path.CloseFigure();
        return path;
    }


}
