using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba1Sharp1
{
    public partial class RepositoryShow : Form
    {
        public RepositoryShow()
        {
            InitializeComponent();
            setData();
        }

        private void setData()
        {

            if (Library.ObjectCounter > 0)
            {
                ListView listOfObjectsLib = new ListView();
                
                listOfObjectsLib.Bounds = new Rectangle(new Point(10, 10), new Size(500, 200));
                ListViewItem listItem = new ListViewItem();
                foreach (var item in Library.Libraries.getAll())
                {
                      
                    listItem.Text = $"Наименование: {item.Value.Name}, " +
                        $"библ. фонд: {item.Value.QuantityOfBooks}, " +
                        $"адрес: {item.Value.Address}, рейтинг: {item.Value.Rate}";
                    listOfObjectsLib.Items.Add(listItem);
                    
                }
                this.Controls.Add(listOfObjectsLib);
            }
            else
            {
                Label emptyListLabel = new Label();
                emptyListLabel.Bounds= new Rectangle(new Point(10,10), new Size(300,200));
                emptyListLabel.Text = "Список пуст";
                this.Controls.Add(emptyListLabel);
            }
        }
    }
}
