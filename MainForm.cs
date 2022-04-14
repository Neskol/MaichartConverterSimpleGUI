using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MaichartConverter;
using System.Windows.Forms;

namespace MaichartConverterSimpleGUI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            try
            {
                Ma2Parser parser = new Ma2Parser();
                Ma2Tokenizer tokenizer = new Ma2Tokenizer();
                MaidataCompiler compiler = new MaidataCompiler();
                Chart converting = new Ma2(parser.ChartOfToken(tokenizer.TokensFromText(ma2TextBox.Text)));
                simaiTextBox.Text = compiler.Compose(converting);
                Console.WriteLine(compiler.Compose(converting));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
