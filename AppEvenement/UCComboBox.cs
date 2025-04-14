using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace AppEvenement
{
    public partial class UCComboBox : UserControl
    {
        public UCComboBox()
        {
            InitializeComponent();
        }
        /*
         * Ensemble des propriétés de la ComboBox
         */
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public ComboBox.ObjectCollection Items
        {
            get { return comboBox.Items; }
        }

        [Browsable(true)]
        public object DataSource
        {
            get { return comboBox.DataSource; }
            set { comboBox.DataSource = value; }
        }

        [Browsable(true)]
        public string DisplayMember
        {
            get { return comboBox.DisplayMember; }
            set { comboBox.DisplayMember = value; }
        }

        [Browsable(true)]
        public string ValueMember
        {
            get { return comboBox.ValueMember; }
            set { comboBox.ValueMember = value; }
        }

        [Browsable(true)]
        public object SelectedItem
        {
            get { return comboBox.SelectedItem; }
            set { comboBox.SelectedItem = value; }
        }

        [Browsable(true)]
        public object SelectedValue
        {
            get { return comboBox.SelectedValue; }
            set { comboBox.SelectedValue = value; }
        }

        [Browsable(true)]
        public int SelectedIndex
        {
            get { return comboBox.SelectedIndex; }
            set { comboBox.SelectedIndex = value; }
        }

        [Browsable(true)]
        public override string Text
        {
            get { return comboBox.Text; }
            set { comboBox.Text = value; }
        }

        [Browsable(true)]
        public ComboBoxStyle DropDownStyle
        {
            get { return comboBox.DropDownStyle; }
            set { comboBox.DropDownStyle = value; }
        }
        [Browsable(true)]
        public event EventHandler SelectedIndexChanged
        {
            add { comboBox.SelectedIndexChanged += value; }
            remove { comboBox.SelectedIndexChanged -= value; }
        }



        [Browsable(true)]
        public event EventHandler SelectedValueChanged
        {
            add { comboBox.SelectedValueChanged += value; }
            remove { comboBox.SelectedValueChanged -= value; }
        }

        [Browsable(true)]
        public event EventHandler SelectionChangeCommitted
        {
            add { comboBox.SelectionChangeCommitted += value; }
            remove { comboBox.SelectionChangeCommitted -= value; }
        }

        private void ComboBoxUserControl_Load(object sender, EventArgs e)
        {
        }

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
