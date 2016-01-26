using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DannyRydstromBrowser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            Browser1.Navigate(txtUrl.Text);
        }

        private void encryptBtn_Click(object sender, EventArgs e)
        {
            EncryptionService.ServiceClient encoder = new EncryptionService.ServiceClient();
            String message = messBox.Text;
            newMess.Text = encoder.Encrypt(message);
        }

        private void decryptBtn_Click(object sender, EventArgs e)
        {
            EncryptionService.ServiceClient decoder = new EncryptionService.ServiceClient();
            String encryptedMess = newMess.Text;
            messBox.Text = decoder.Decrypt(encryptedMess);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void stockBtn_Click(object sender, EventArgs e)
        {
            StockQuotesServ.ServiceClient stocks = new StockQuotesServ.ServiceClient();
            String symbol = stockSym.Text;
            stockPrice.Text = stocks.getStockquote(symbol);
        }
    }
}
