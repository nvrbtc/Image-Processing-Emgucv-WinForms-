using APO_Tsarehradskiy.InputArguments;
using APO_Tsarehradskiy.InputTypes;
using Emgu.CV.CvEnum;
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

namespace APO_Tsarehradskiy.customUI
{
    public partial class UniversalFilterWindow : Form
    {
        private List<MatrixRow> matrixRows = new List<MatrixRow>()
        {
            new MatrixRow(0,0,0),
            new MatrixRow(0,0,0),
            new MatrixRow(0,0,0)
        };
        private Filter2dInput input = new Filter2dInput();
        public UniversalFilterWindow()
        {
            InitializeComponent();
            Bind();
        }
        private void Bind()
        {
            if (gridMatrix != null)
            {
                foreach (var row in matrixRows)
                {
                    gridMatrix.Rows.Add(row.X1, row.X2, row.X3);
                }
            }
            if (cbBorder != null)
            {
                cbBorder.DataSource = new[]
                {
                    new ComboBoxInput<BorderType>{Text = "Reflect", Value = BorderType.Reflect },
                    new ComboBoxInput<BorderType>{Text = "Replicate", Value = BorderType.Replicate },
                    new ComboBoxInput<BorderType>{Text = "Isolated", Value = BorderType.Isolated }
                };
                cbBorder.DisplayMember = "Text";
                cbBorder.ValueMember = "Value";
                cbBorder.DataBindings.Add(nameof(cbBorder.SelectedValue), input, nameof(input.border), false, DataSourceUpdateMode.OnValidation);
            }
        }

        private void gridMatrix_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (e.Control is TextBox box)
            {
                box.KeyPress -= ValidateUserInput;
                box.KeyPress += ValidateUserInput;
            }
        }

        private void ValidateUserInput(object? sender, KeyPressEventArgs e)
        {
            TextBox tb = sender as TextBox;

            if (char.IsControl(e.KeyChar))
            {
                return;
            }

            if (e.KeyChar == '-')
            {
                if (tb.SelectionStart != 0 || tb.Text.Contains('-'))
                {
                    e.Handled = true;
                }
                return;
            }

            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                return;
            }

        }

        private void gridMatrix_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            var input = e.FormattedValue.ToString();

            if (!Regex.IsMatch(input, @"^-?[1-9]\d*$|^0$"))
            {
                e.Cancel = true;
                gridMatrix.Rows[e.RowIndex].ErrorText = "No leading zeros idiot";
            }
            else
            {
                gridMatrix.Rows[e.RowIndex].ErrorText = "";
            }
        }
    }
}
