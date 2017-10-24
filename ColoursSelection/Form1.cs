using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft;
using System.IO;
using Newtonsoft.Json;
using System.IO.Pipes;
using JsonHandler;
using MyColors;
using System.Threading;

namespace ColorsSelection
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// Binding list of colors
        /// Binded to datagridview
        /// </summary>
        BindingList<MyColor> _colors = new BindingList<MyColor>();

        /// <summary>
        /// Current color selected
        /// </summary>
        Color _currentColor;

        /// <summary>
        /// Wait for server pipe async to end,
        /// Disable button if true,
        /// Enable if false
        /// </summary>
        bool _serverThreadWait = false;

        public Form1()
        {
            InitializeComponent();
            this.colorsDataGridView.DataSource = _colors;
        }

        /// <summary>
        /// Opens up color dialog to select color from, 
        /// and updates form fields when selected
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void colorSelectorButton_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog1 = new ColorDialog();

            // Show the color dialog
            DialogResult result = colorDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                _currentColor = colorDialog1.Color;

                // Set picture box background to the selected color
                this.colorPictureBox.BackColor = colorDialog1.Color;

                // Fill in RGBA text boxes to selected color
                this.redTextBox.Text = colorDialog1.Color.R.ToString();
                this.greenTextBox.Text = colorDialog1.Color.G.ToString();
                this.blueTextBox.Text = colorDialog1.Color.B.ToString();
                this.alphaTextBox.Text = colorDialog1.Color.A.ToString();

                // Create hex code of color
                String code = (colorDialog1.Color.ToArgb()).ToString("X6");

                if (colorDialog1.Color.IsNamedColor)
                    this.colorNameTextBox.Text = colorDialog1.Color.Name;
                else
                    this.colorNameTextBox.Clear();
                this.htmlHexCodeTextBox.Text = code;
            }

            checkControls();
        }

        /// <summary>
        /// Exports colors to json file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exportJsonButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "json files (*.json)|*.json|All files (*.*)|*.*";
            saveFileDialog.FileName = "Colors";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
                if ((saveFileDialog.CheckPathExists))
                    JsonHandler.JsonHandler.WriteJsonToFile(saveFileDialog.FileName, _colors.ToArray());

            checkControls();
        }

        /// <summary>
        /// Exports colors array to client pipes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void exportExternButton_Click(object sender, EventArgs e)
        {
            this._serverThreadWait = true;
            this.exportExternButton.Enabled = false;
            var task = ServerThread(_colors.ToArray());
            _serverThreadWait = (await task) ? false : false;
            checkControls();
        }

        /// <summary>
        /// Adds color selected to datagridview
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addButton_Click(object sender, EventArgs e)
        {
            if (_currentColor.IsEmpty)
                return;

            _colors.Add(new MyColor(_currentColor));
            this.colorsDataGridView.Update();
            this.colorsDataGridView.Refresh();

            checkControls();
        }

        /// <summary>
        /// Removes color selected inside datagridview
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void removeButton_Click(object sender, EventArgs e)
        {
            // Sanity checking
            if (this.colorsDataGridView.CurrentRow == null || this.colorsDataGridView.CurrentRow.Index < 0)
                return;
            if (this.colorsDataGridView.Rows.Count < 1)
                return;
            if (this.colorsDataGridView.CurrentRow.IsNewRow)
                return;

            // Remove color at row selected index,
            // Removes color from binded list also
            this.colorsDataGridView.Rows.RemoveAt(this.colorsDataGridView.CurrentRow.Index);

            checkControls();
        }

        /// <summary>
        /// Exits applciation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Enable and disable form controls
        /// </summary>
        public void checkControls()
        {
            this.removeButton.Enabled = (this.colorsDataGridView.Rows.Count > 0) ? true : false;
            this.addButton.Enabled = (!_currentColor.IsEmpty) ? true : false;

            this.exportJsonButton.Enabled = (this._colors.Count > 0) ? true : false;
            this.exportExternButton.Enabled = (this._colors.Count > 0) ? 
                (this._serverThreadWait) ? false : true : false;
        }

        /// <summary>
        /// Send serialized json object to client pipe streams
        /// </summary>
        /// <param name="data"></param>
        public static async Task<bool> ServerThread(object data)
        {
            using (NamedPipeServerStream pipeServer =
                new NamedPipeServerStream("testpipe", PipeDirection.Out))
            {
                await pipeServer.WaitForConnectionAsync();
                try
                {
                    using (StreamWriter sw = new StreamWriter(pipeServer))
                    {
                        sw.AutoFlush = true;
                        sw.WriteLine(JsonConvert.SerializeObject(data, Formatting.Indented));
                    }
                }
                catch (IOException e)
                {
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// Keydown event only triggers when keypressed on focused form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control)
            {
                switch (e.KeyCode)
                {
                    case Keys.E: // Ctrl + E, close form and exits application
                        Close();
                        break;
                }
            }
        }
    }
}
