using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba1Sharp1
{
    public partial class Form1 : Form
    {
        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        public static extern int MessageBox(IntPtr hWnd, String text, String caption, uint type);
        Library selectedLibrary = null;
        public Form1()
        {
            InitializeComponent();
            withoutArgumentRB.Checked = true;
            updateCounterLabel();
            showMessageBox("Лабораторная работа 1. Градсков, Живов. 1 бригада", "Приветствие");
        }

        private void updateCounterLabel()
        {
            objectCounterLabel.Text =$"Количество объектов: {Library.ObjectCounter}" ;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void withoutArgumentRB_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton withoutArgumentRB = (RadioButton)sender;
            if (withoutArgumentRB.Checked)
            {
                showFields(0);
            }
        }

        private void showFields(int numberArguments)
        {
            switch (numberArguments)
            {
                case 0:
                    nameInputTB.Visible = false;
                    quantityOfBooksTB.Visible = false;
                    phoneInputTB.Visible = false;
                    addressInputTB.Visible = false;
                    squareInputTB.Visible = false;
                    avgNumberInputTB.Visible = false;
                    rateInputTB.Visible = false;
                    label1.Visible = false;
                    label2.Visible = false;
                    label3.Visible = false;
                    label4.Visible = false;
                    label5.Visible = false;
                    label6.Visible = false;
                    label7.Visible = false;
                    break;
                case 1:
                    nameInputTB.Visible = true;
                    quantityOfBooksTB.Visible = false;
                    phoneInputTB.Visible = false;
                    addressInputTB.Visible = false;
                    squareInputTB.Visible = false;
                    avgNumberInputTB.Visible = false;
                    rateInputTB.Visible = false;
                    label1.Visible = true;
                    label2.Visible = false;
                    label3.Visible = false;
                    label4.Visible = false;
                    label5.Visible = false;
                    label6.Visible = false;
                    label7.Visible = false;
                    break;
                case 2:
                    nameInputTB.Visible = true;
                    quantityOfBooksTB.Visible = true;
                    phoneInputTB.Visible = false;
                    addressInputTB.Visible = false;
                    squareInputTB.Visible = false;
                    avgNumberInputTB.Visible = false;
                    rateInputTB.Visible = false;
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = false;
                    label4.Visible = false;
                    label5.Visible = false;
                    label6.Visible = false;
                    label7.Visible = false;
                    break;
                case 7:
                    nameInputTB.Visible = true;
                    quantityOfBooksTB.Visible = true;
                    phoneInputTB.Visible = true;
                    addressInputTB.Visible = true;
                    squareInputTB.Visible = true;
                    avgNumberInputTB.Visible = true;
                    rateInputTB.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label4.Visible = true;
                    label5.Visible = true;
                    label6.Visible = true;
                    label7.Visible = true;
                    break;
            }
        }

        private void oneArgumentRB_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton oneArgumentRB = (RadioButton)sender;
            if (oneArgumentRB.Checked)
            {
                showFields(1);
            }
        }

        private void twoArgumentRB_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton twoArgumentRB = (RadioButton)sender;
            if (twoArgumentRB.Checked)
            {
                showFields(2);
            }
        }

        private void allArgumentRB_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton allArgumentRB = (RadioButton)sender;
            if (allArgumentRB.Checked)
            {
                showFields(7);
            }
        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Library library = null;
                if (withoutArgumentRB.Checked)
                {
                    library = new Library();
                }
                else if (oneArgumentRB.Checked)
                {
                    library = new Library(nameInputTB.Text);
                }
                else if (twoArgumentRB.Checked)
                {

                    validData(name: nameInputTB.Text, quantityOfBooks: quantityOfBooksTB.Text);
                    library = new Library(nameInputTB.Text, int.Parse(quantityOfBooksTB.Text));
                }
                else
                {
                    validData(nameInputTB.Text, 
                        quantityOfBooksTB.Text, 
                        phoneInputTB.Text,
                        addressInputTB.Text, 
                        squareInputTB.Text,
                        avgNumberInputTB.Text,
                        rateInputTB.Text);
                    library = new Library(nameInputTB.Text,
                        int.Parse(quantityOfBooksTB.Text),
                        phoneInputTB.Text, addressInputTB.Text,
                        float.Parse(squareInputTB.Text),
                        int.Parse(avgNumberInputTB.Text),
                        float.Parse(rateInputTB.Text));
                }
                Library.AddInList(library);
                updateList();
                updateCounterLabel();
            }
            catch (CustInvalidArgumentException exc) { showMessageBox($"Ошибка: {exc.Message}\nПоле: {exc.Place}","Авария") ; }
        }
        private void updateList()
        {
            listOfLibrariesCB.Items.Clear();
            foreach (var library in Library.Libraries)
            {
                listOfLibrariesCB.Items.Add(library.Name);
            }
        }

        private static void showMessageBox(string text, string title)
        {
            MessageBox(IntPtr.Zero, text, title, 0) ;
        }

        private void showData()
        {
            textBox9.Text = selectedLibrary.Name;
            textBox8.Text = selectedLibrary.QuantityOfBooks.ToString();
            textBox7.Text = selectedLibrary.Phone;
            textBox6.Text = selectedLibrary.Address;
            textBox5.Text = selectedLibrary.Square.ToString();
            textBox4.Text = selectedLibrary.AvgNumberOfVisitors.ToString();
            textBox3.Text = selectedLibrary.Rate.ToString();

        }

        private void listOfLibrariesCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listOfLibrariesCB.SelectedIndex != -1)
            {
                Library library = Library.Libraries[listOfLibrariesCB.SelectedIndex];
                selectedLibrary = library;
                showData();
            }
        }

        private void validData(string name,
            string quantityOfBooks = "0",
            string phone = "880008000800",
            string address = "ул.Пушкина,д.12",
            string square = "0",
            string numberOfVisitors = "0",
            string rate = "0")
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new CustInvalidArgumentException("Значение не может быть пустым", "Название");
            }
            if (!int.TryParse(quantityOfBooks, out int quantityParsed)||quantityParsed<0)
            {

                throw new CustInvalidArgumentException("Неверное значение. Значение должно быть положительным числом", "Библиотечный фонд");
            }
            if (!Regex.IsMatch(phone, "^(\\+7|8)\\d{10}$", RegexOptions.IgnoreCase))
            {
                throw new CustInvalidArgumentException("Значение номера телефона должно соответствовать шаблону: (+7/8)1111111111",
                    "Номер телефона");
            }
            if (!float.TryParse(square, out float squareParsed) || squareParsed < 0)
            {
                throw new CustInvalidArgumentException("Значение не может быть отрицательным", "Площадь");
            }
            if (!Regex.IsMatch(address, "^ул.\\w+,д.\\d{1,3}$", RegexOptions.IgnoreCase))
            {
                throw new CustInvalidArgumentException("Адрес должен соответствовать формату: ул.(Название улицы),д.(номер дома)", "Адрес");
            }
            if(!int.TryParse(numberOfVisitors, out int numberParsed) || numberParsed < 0)
            {
                throw new CustInvalidArgumentException("Неверное значение.Значение должно быть положительным числом", "Среднее число посетителей");
            }
            if(!float.TryParse(rate, out float rateParsed)||rateParsed <0||rateParsed>5)

            {
                throw new CustInvalidArgumentException("Неверное значение."+
                    "Значение - вещественное число должно находится в диапазоне от 0 до 5 включительно", "Рейтинг");
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                validData(textBox9.Text, textBox8.Text, textBox7.Text, textBox6.Text, textBox5.Text, textBox4.Text, textBox3.Text);
                Library.Libraries[listOfLibrariesCB.SelectedIndex].Name = textBox9.Text;
                Library.Libraries[listOfLibrariesCB.SelectedIndex].QuantityOfBooks = int.Parse(textBox8.Text);
                Library.Libraries[listOfLibrariesCB.SelectedIndex].Phone = textBox7.Text;
                Library.Libraries[listOfLibrariesCB.SelectedIndex].Address = textBox6.Text;
                Library.Libraries[listOfLibrariesCB.SelectedIndex].Square = float.Parse(textBox5.Text);
                Library.Libraries[listOfLibrariesCB.SelectedIndex].AvgNumberOfVisitors = int.Parse(textBox4.Text);
                Library.Libraries[listOfLibrariesCB.SelectedIndex].Rate = float.Parse(textBox3.Text);
                showMessageBox("Сохранено", "Успех");
            }
            catch(CustInvalidArgumentException exc)
            {
                showMessageBox(exc.Message, "Авария");
            }
        }

        private void printBtn_Click(object sender, EventArgs e)
        {
            String result = fetchData();
            showMessageBox(result.ToString(), "Вывод");
        }

        private string fetchData()
        {
            StringBuilder result = new StringBuilder("");
            if (nameOutCB.Checked)
            {
                result.AppendLine($"Название: {selectedLibrary.Name}");
            }
            if (quantityOutCB.Checked)
            {
                result.AppendLine($"Библиотечный фонд: {selectedLibrary.QuantityOfBooks.ToString()}");
                result.AppendLine($"Библиотечный фонд (16 hex): {selectedLibrary.Hex(selectedLibrary.QuantityOfBooks).ToString()}");
            }
            if (phoneOutCB.Checked)
            {
                result.AppendLine($"Номер телефона: {selectedLibrary.Phone}");
            }
            if (addressOutCB.Checked)
            {
                result.AppendLine($"Адрес: {selectedLibrary.Address}");
            }
            if (squareOutCB.Checked)
            {
                result.AppendLine($"Площадь: {selectedLibrary.Square.ToString()}");
            }
            if (avgNumberOutCB.Checked)
            {
                result.AppendLine($"Среднее число посетителей: {selectedLibrary.AvgNumberOfVisitors.ToString()}");
            }
            if (rateOutCB.Checked)
            {
                result.AppendLine($"Рейтинг: {selectedLibrary.Rate.ToString()}");
            }
            return result.ToString();
            
        }
    }
}
