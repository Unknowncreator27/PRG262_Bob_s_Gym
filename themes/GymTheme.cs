using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRG262_Bob_s_Gym.Themes
{
    public static class GymTheme
    {

        public static readonly Color BackgroundDark = Color.FromArgb(18, 18, 42); //12122A - Form bg
        public static readonly Color BackgroundPanel = Color.FromArgb(26, 26, 46);
        public static readonly Color AccentRed = Color.FromArgb(200, 16, 46);
        public static readonly Color AccentRedHover = Color.FromArgb(165, 13, 38);
        public static readonly Color InputBg = Color.FromArgb(13, 13, 34);
        public static readonly Color InputBorder = Color.FromArgb(42, 42, 74);
        public static readonly Color TextPrimary = Color.FromArgb(224, 224, 224);
        public static readonly Color TextMuted = Color.FromArgb(136, 136, 170);
        public static readonly Color White = Color.White;

        public static void StyleTextBox(TextBox tb)
        {
            tb.BackColor = InputBg;
            tb.ForeColor = TextPrimary;
            tb.BorderStyle = BorderStyle.FixedSingle;
            tb.Font = new Font("Segoe UI", 10f);
        }

        public static void StyleButton(Button btn)
        {
            btn.BackColor = AccentRed;
            btn.ForeColor = White;
            btn.FlatStyle = FlatStyle.Flat;
            btn.Font = new Font("Segoe UI Semibold", 10f);
            btn.Cursor = Cursors.Hand;
            btn.FlatAppearance.BorderSize = 0;
            btn.FlatAppearance.MouseOverBackColor = AccentRedHover;
            btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(140, 10, 30);
        }

        public static void styleCheckBox(CheckBox cb)
        {
            cb.ForeColor = TextMuted;
            cb.Font = new Font("Segoe UI", 9f);
            cb.BackColor = Color.Transparent;
        }

        public static void StyleLabel(Label label, bool isMuted = false)
        {
            label.ForeColor = isMuted ? TextMuted : TextPrimary;
            label.Font = new Font("Segoe UI", 9f, isMuted ? FontStyle.Regular : FontStyle.Bold);
            label.BackColor = Color.Transparent;
        }


    }
}
