using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace MacroBuilder
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            var rhk = new RegisterHotKeyWrapper(Handle);
            rhk.RegisterKey(Keys.Oem8, KeyModifiers.NoRepeat);
            rhk.RegisterKey(Keys.D, KeyModifiers.NoRepeat);
            rhk.HotKeyPressed += HotKeyPressed;
        }

        private void HotKeyPressed(Keys key)
        {
            Debug.WriteLine(key.ToString());
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
