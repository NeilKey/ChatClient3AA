using System;
using System.Drawing;
using System.Windows.Forms;

namespace ChatClient3AA
{
    public partial class SettingsForm : Form
    {
        ColorDialog cDialog = new ColorDialog();
        FontDialog fDialog = new FontDialog();

        public SettingsForm()
        {
            InitializeComponent();
        }

        private void onSettingFormLoad(object sender, EventArgs e)
        {
            //Loading saved settings
            /* --> uncomment this section once all the following settins will be created
            convInColor_lbl.ForeColor = Settings.Default.ConvInColor;
            convOutColor_lbl.ForeColor = Settings.Default.ConvOutColor;
            outTextColor_lbl.ForeColor = Settings.Default.OutTextColor;
            convInColor_lbl.Font = Settings.Default.ConvInFont;
            convOutColor_lbl.Font = Settings.Default.ConvOutFont;
            outTextColor_lbl.Font = Settings.Default.OutTextFont;

            langComboBox.Text = Settings.Default.Language;
            hostnameTextBox.Text = Settings.Default.Hostname;
            portTextBox.Text = Settings.Default.Port;
             */

        }

        private void onInColorButton(object sender, EventArgs e)
        {
            // Show the ColorPicker dialog
            cDialog.ShowDialog();
            // Set selected color to the label
            convInColor_lbl.ForeColor = cDialog.Color;
        }

        private void onCancel(object sender, EventArgs e)
        {
            this.Close();
        }

        private void onOutColorButton(object sender, EventArgs e)
        {
            // Show the ColorPicker dialog
            cDialog.ShowDialog();
            // Set selected color to the label
            convOutColor_lbl.ForeColor = cDialog.Color;
        }

        private void onTextColorButton(object sender, EventArgs e)
        {
            // Show the ColorPicker dialog
            cDialog.ShowDialog();
            // Set selected color to the label
            outTextColor_lbl.ForeColor = cDialog.Color;
        }

        private void onInFontButton(object sender, EventArgs e)
        {
            DialogResult result = fDialog.ShowDialog();
            // See if OK was pressed.
            if (result == DialogResult.OK)
            {
                // Get Font.
                Font font = fDialog.Font;
                // Set TextBox properties.
                convInColor_lbl.Font = font;
            }
        }

        private void onOutFontButton(object sender, EventArgs e)
        {
            DialogResult result = fDialog.ShowDialog();
            // See if OK was pressed.
            if (result == DialogResult.OK)
            {
                // Get Font.
                Font font = fDialog.Font;
                // Set TextBox properties.
                convOutColor_lbl.Font = font;
            }
        }

        private void onTextFontButton(object sender, EventArgs e)
        {
            DialogResult result = fDialog.ShowDialog();
            // See if OK was pressed.
            if (result == DialogResult.OK)
            {
                // Get Font.
                Font font = fDialog.Font;
                // Set TextBox properties.
                outTextColor_lbl.Font = font;
            }
        }

        private void onSaveButton(object sender, EventArgs e)
        {
            //saving current settings to real settings
            /* --> uncomment this section once all the following settins will be created
            Settings.Default.ConvInColor = convInColor_lbl.ForeColor;
            Settings.Default.ConvOutColor = convOutColor_lbl.ForeColor;
            Settings.Default.OutTextColor = outTextColor_lbl.ForeColor;
            Settings.Default.ConvInFont = convInColor_lbl.Font;
            Settings.Default.ConvOutFont = convOutColor_lbl.Font;
            Settings.Default.OutTextFont = outTextColor_lbl.Font;

            Settings.Default.Language = langComboBox.Text;
            Settings.Default.Hostname = hostnameTextBox.Text;
            Settings.Default.Port = portTextBox.Text;
            
            Setting.Default.Save();
              
             */
        }
    }
}
