using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Computer_Laboratory_Equipment
{
    public partial class Form1 : Form
    {
        // The size the login layout was designed for
        private const int DesignWidth = 759;
        private const int DesignHeight = 498;

        // Each control's original position, so the layout can be re-centered on resize
        private readonly Dictionary<Control, Point> originalPositions = new Dictionary<Control, Point>();

        public Form1()
        {
            InitializeComponent();

            foreach (Control c in Controls)
                originalPositions[c] = c.Location;

            Resize += (s, e) => CenterControls();
            CenterControls();
        }

        // Keeps the login controls centered in the window at any size
        private void CenterControls()
        {
            int dx = (ClientSize.Width - DesignWidth) / 2;
            int dy = (ClientSize.Height - DesignHeight) / 2;

            foreach (var pair in originalPositions)
                pair.Key.Location = new Point(pair.Value.X + dx, pair.Value.Y + dy);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}