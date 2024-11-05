using System.Windows.Forms;

namespace WinFormsApp3_перемещать
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            checkedListBox1.Items.Add("Apple");
            checkedListBox1.Items.Add("Banana");
            checkedListBox1.Items.Add("Cherry");
            checkedListBox1.Items.Add("Date");
            listBox1.Items.Clear();
        }

        

        private void btnMoveItems_Click_1(object sender, EventArgs e)
        {
            var selectedItems = new List<string>();

            foreach (var item in checkedListBox1.CheckedItems)
            {
                listBox1.Items.Add(item);

                selectedItems.Add(item.ToString());
            }

            foreach (var selectedItem in selectedItems)
            {
                checkedListBox1.Items.Remove(selectedItem);
            }

            foreach (int index in checkedListBox1.CheckedIndices)
            {
                checkedListBox1.SetItemChecked(index, false);
            }
        }
    }
}
