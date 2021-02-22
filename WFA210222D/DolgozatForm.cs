using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA210222D
{
  public partial class DolgozatForm : Form
  {
      private readonly RadioButton[] _colorRadioButtons;
      private readonly Button[] _colorButtons;
      private static readonly Regex PunctuationMarkRegex = new Regex("^[.?!]$");
      private static readonly Regex NumberRegex = new Regex("^\\d+(\\.\\d)*$");
        
        public DolgozatForm()
        {
            InitializeComponent();
            
            _colorRadioButtons = new RadioButton[]
            {
                rbRed, rbYellow, rbGreen, rbBlue
            };
            _colorButtons = new Button[]
            {
                btnFirst, btnSecond, btnThird, btnFourth
            };

            rbGreen.Checked = true;
            textRecordBtn.Enabled = false;
        }

        private void colorBtn_Click(object sender, EventArgs e)
        {
            var selectedRadioBtn = _colorRadioButtons.First(rb => rb.Checked);
            ((Button) sender).BackColor = Color.FromName(selectedRadioBtn.Name.Substring(2));
            foreach (var button 
                in _colorButtons.Where(button => button != (Button) sender))
                button.BackColor = Color.White;
        }

        private void cbUppercase_CheckedChanged(object sender, EventArgs e)
        {
            foreach (var button in _colorButtons)
                button.Text = cbUppercase.Checked
                    ? button.Text.ToUpper()
                    : button.Text.ToLower();
        }

        private void textRecordTextBox_TextChanged(object sender, EventArgs e)
        {
            var textRecordTextEnd = textRecordTextBox.Text[textRecordTextBox.Text.Length - 1];
            var endsWithPunctuationMark = PunctuationMarkRegex.IsMatch(textRecordTextEnd.ToString());
            
            textAppropriateLabel.ForeColor = endsWithPunctuationMark ? Color.LawnGreen : Color.Red;
            textAppropriateLabel.Text = endsWithPunctuationMark ? "Oké!" : "nem jó!";

            textRecordBtn.Enabled = endsWithPunctuationMark;
        }

        private void textRecordBtn_Click(object sender, EventArgs e)
        {
            var previousLines = recordedLines.Lines.ToList();
            
            var newLines = new List<string>();
            newLines.AddRange(previousLines);
            newLines.Add(textRecordTextBox.Text);
            
            recordedLines.Lines = newLines.ToArray();
        }

        private void calculateTriangleBtn_Click(object sender, EventArgs e)
        {
            if (!NumberRegex.IsMatch(befogo1.Text) || !NumberRegex.IsMatch(befogo2.Text)) return;
            
            var befogo1Value = double.Parse(befogo1.Text);
            var befogo2Value = double.Parse(befogo2.Text);

            var atfogoValue = Math.Sqrt(Math.Pow(befogo1Value, 2) + Math.Pow(befogo2Value, 2));
            var keruletValue = befogo1Value + befogo2Value + atfogoValue;
            var teruletValue = (befogo1Value * befogo2Value) / 2;

            atfogo.Text = Math.Round(atfogoValue, 2).ToString();
            kerulet.Text = Math.Round(keruletValue, 2).ToString();
            terulet.Text = Math.Round(teruletValue, 2).ToString();
        }
  }
}