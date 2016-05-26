using System;
using System.Windows.Forms;

namespace AntiCE_Driver
{
    public partial class frmMain : Form
    {
        public int playerHp = 100;
        AntiCEDriver.ObfuscInt oi = new AntiCEDriver.ObfuscInt(200);

        public frmMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtPlayerHp.Text = playerHp.ToString();
            txtSafe.Text = oi._sf.val1.ToString();
        }

        private void btnReduce_Click(object sender, EventArgs e)
        {
            txtPlayerHp.Text = (playerHp - 10).ToString();
            playerHp -= 10;
        }

        private void btnIncrement_Click(object sender, EventArgs e)
        {
            txtPlayerHp.Text = (playerHp + 10).ToString();
            playerHp += 10;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtSafePlus_Click(object sender, EventArgs e)
        {
            oi += 10;
            txtSafe.Text = oi._sf.val1.ToString();
        }
    }
}