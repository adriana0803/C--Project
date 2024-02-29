using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Drawing.Printing;

namespace proiectVanzari
{
    public partial class Form2 : Form
    {
        
        public Form2()
        {
            InitializeComponent();
        }

        private void PrintListView()
        {
            PrintDocument printDocument = new PrintDocument();
            printDocument.DefaultPageSettings.Landscape = true; //am setat modul landscape

            int currentPage = 0;

            printDocument.PrintPage += (sender, e) =>
            {
                //defineste pozitia de start a printului
                int x = e.MarginBounds.Left;
                int y = e.MarginBounds.Top;

                //printeaza denumirile coloanelor
                if (currentPage == 0)
                {
                    foreach (ColumnHeader column in lv1.Columns)
                    {
                        e.Graphics.DrawString(column.Text, lv1.Font, Brushes.Black, x, y);
                        x += column.Width;
                    }
                    y += lv1.Font.Height;
                }

                //printeaza itemele din listview
                while (currentPage < lv1.Items.Count)
                {
                    x = e.MarginBounds.Left;

                    ListViewItem item = lv1.Items[currentPage];
                    foreach (ListViewItem.ListViewSubItem subItem in item.SubItems)
                    {
                        e.Graphics.DrawString(subItem.Text, lv1.Font, Brushes.Black, x, y);
                        x += lv1.Columns[item.SubItems.IndexOf(subItem)].Width;
                    }
                    y += lv1.Font.Height;

                    currentPage++;

                    //verifica daca sunt mai multe iteme de printat
                    if (y + lv1.Font.Height > e.MarginBounds.Bottom)
                        break;
                }

                //verifica daca sunt mai multe pagini de printat
                if (currentPage < lv1.Items.Count)
                    e.HasMorePages = true;
                else
                    e.HasMorePages = false;
            };

            PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog();
            printPreviewDialog.Document = printDocument;
            printPreviewDialog.ShowDialog();
        }



        private void btDelete_Click(object sender, EventArgs e)
        {
            if(lv1.SelectedItems.Count == 0) 
            {
                MessageBox.Show("Selecteaza o tranzactie.");
                return;
            }

            ListViewItem selectedItem = lv1.SelectedItems[0];

            lv1.Items.Remove(selectedItem);
        }

        private void fisiertsm_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text Files|*.txt";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName))
                {
                    foreach (ColumnHeader column in lv1.Columns)
                    {
                        writer.Write(column.Text);
                        writer.Write("\t"); //folosesc o distanta de un tab intre coloane
                    }
                    writer.WriteLine();

                    foreach (ListViewItem item in lv1.Items)
                    {
                        writer.WriteLine(string.Join("\t", item.SubItems.Cast<ListViewItem.ListViewSubItem>().Select(subItem => subItem.Text)));
                    }
                }
            }
        }

        private void printtsm_Click(object sender, EventArgs e)
        {
            this.PrintListView();
        }
    }
}
