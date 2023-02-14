using System;
using System.Drawing;
using System.Windows.Forms;
using HtmlAgilityPack;
using System.Media;

namespace NapalmBitcoin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            this.FormBorderStyle = FormBorderStyle.None;
            InitializeComponent();
        }

        #region WholeFormDragable   
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void Form1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        #endregion

        
        SoundPlayer typewriter = new SoundPlayer();
        HtmlWeb web = new HtmlWeb();
        HtmlAgilityPack.HtmlDocument doc;
        string TotalPagesElement = "//h6[@class='typography__StyledTypography-owin6q-0 hZxwDe']";


        private void Form1_Load(object sender, EventArgs e)
        {
            string path = Application.StartupPath + "/muzika.wav";
            typewriter.SoundLocation = path;

            timer1.Start();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Minimise_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            doc = web.Load("https://www.coindesk.com/price/bitcoin/");
            var HeaderNames = doc.DocumentNode.SelectSingleNode(TotalPagesElement);
            string PriceString = HeaderNames.InnerText.Replace("%", "");

            LedDiode.BackColor = Color.Gray;
            RealTimeTextBox.Text = "Currently at 0%.";

            if (float.Parse(PriceString) > 0)
            {
                LedDiode.BackColor = Color.Green;
                RealTimeTextBox.Text = "Currently is rising. ^-^ ";
            }
            else if (float.Parse(PriceString) < 0)
            {
                LedDiode.BackColor = Color.Red;
                RealTimeTextBox.Text = "Currently is falling.";
                typewriter.Play();
            }
            textBox1.Text = string.Concat(Environment.NewLine, Environment.NewLine, PriceString, "%");

            timer1.Interval = 60000;
        }
    }
}
