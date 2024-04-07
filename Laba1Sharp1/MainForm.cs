using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Xml.Linq;

namespace Laba1Sharp1
{

    public partial class MainForm : Form
    {
        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        public static extern int MessageBox(IntPtr hWnd, String text, String caption, uint type);
        Library selectedLibrary = null;
        int typeOfLibrary = 0;
        int managementType = 0;

        public MainForm()
        {

            InitializeComponent();
            withoutArgumentRB.Checked = true;
            updateCounterLabel();
            Library.Libraries.CollectionChanged += CollectionChangedHandler;
            showMessageBox("Лабораторная работа 3. Градсков, Живов. 1 бригада", "Приветствие");
            GeneralLbRB.Checked = true;
            CultManagementRB.Checked = true;
        }

        private void updateCounterLabel()
        {
            objectCounterLabel.Text =$"Количество объектов: {Library.ObjectCounter}" ;
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
            clearAllFields();
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
                    labelNameInput.Visible = false;
                    labelQuantityInput.Visible = false;
                    labelPhoneInput.Visible = false;
                    labelAddressInput.Visible = false;
                    labelSquareInput.Visible = false;
                    labelAvgNumberOfVisitorsUnput.Visible = false;
                    labelRateInput.Visible = false;
                    break;
                case 1:
                    nameInputTB.Visible = true;
                    quantityOfBooksTB.Visible = false;
                    phoneInputTB.Visible = false;
                    addressInputTB.Visible = false;
                    squareInputTB.Visible = false;
                    avgNumberInputTB.Visible = false;
                    rateInputTB.Visible = false;
                    labelNameInput.Visible = true;
                    labelQuantityInput.Visible = false;
                    labelPhoneInput.Visible = false;
                    labelAddressInput.Visible = false;
                    labelSquareInput.Visible = false;
                    labelAvgNumberOfVisitorsUnput.Visible = false;
                    labelRateInput.Visible = false;
                    break;
                case 2:
                    nameInputTB.Visible = true;
                    quantityOfBooksTB.Visible = true;
                    phoneInputTB.Visible = false;
                    addressInputTB.Visible = false;
                    squareInputTB.Visible = false;
                    avgNumberInputTB.Visible = false;
                    rateInputTB.Visible = false;
                    labelNameInput.Visible = true;
                    labelQuantityInput.Visible = true;
                    labelPhoneInput.Visible = false;
                    labelAddressInput.Visible = false;
                    labelSquareInput.Visible = false;
                    labelAvgNumberOfVisitorsUnput.Visible = false;
                    labelRateInput.Visible = false;
                    break;
                case 7:
                    nameInputTB.Visible = true;
                    quantityOfBooksTB.Visible = true;
                    phoneInputTB.Visible = true;
                    addressInputTB.Visible = true;
                    squareInputTB.Visible = true;
                    avgNumberInputTB.Visible = true;
                    rateInputTB.Visible = true;
                    labelNameInput.Visible = true;
                    labelQuantityInput.Visible = true;
                    labelPhoneInput.Visible = true;
                    labelAddressInput.Visible = true;
                    labelSquareInput.Visible = true;
                    labelAvgNumberOfVisitorsUnput.Visible = true;
                    labelRateInput.Visible = true;
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
                Management management = null;
                switch (managementType)
                {
                    case 1:
                        management = new CultureManagement();
                        break;
                    case 2:
                        management = new LibraryDepartment();
                        break;
                    default: management = new CultureManagement(); break;
                }
                LibraryFactory factory = null;
                switch (typeOfLibrary)
                {
                    case 1:
                        factory = new GeneralLibrary();
                        break;
                    case 2:
                        factory = new NationalLibrary();
                        break;
                    default:factory = new GeneralLibrary(); break;
                }
                Library library = null;
                if (withoutArgumentRB.Checked)
                {
                    library = new Library(factory, management);
                }
                else if (oneArgumentRB.Checked)
                {
                    validData(name:nameInputTB.Text);
                    library = new Library(factory,management,nameInputTB.Text);
                }
                else if (twoArgumentRB.Checked)
                {

                    validData(name: nameInputTB.Text, quantityOfBooks: quantityOfBooksTB.Text);
                    library = new Library(factory,management,  nameInputTB.Text, int.Parse(quantityOfBooksTB.Text));
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
                    library = new Library(factory,management, nameInputTB.Text,
                        int.Parse(quantityOfBooksTB.Text),
                        phoneInputTB.Text, addressInputTB.Text,
                        float.Parse(squareInputTB.Text),
                        int.Parse(avgNumberInputTB.Text),
                        float.Parse(rateInputTB.Text));
                }
                Library.AddInList(library.Name, library);
                updateList();
                updateCounterLabel();
            }
            catch (CustInvalidArgumentException exc) { 
                Enabled = false; 
                showMessageBox($"Ошибка: {exc.Message}\nПоле: {exc.Place}","Авария") ; 
                Enabled = true; 
                this.Activate();
            }
        }
        private void updateList()
        {
            listOfLibrariesCB.Items.Clear();
            foreach (var library in Library.Libraries.getAll())
            {
                listOfLibrariesCB.Items.Add(library.Value.Name);
            }
        }

        private static void showMessageBox(string text, string title)
        {
            MessageBox(IntPtr.Zero, text, title, 0) ;
        }

        private void showData()
        {
            nameChangeTB.Text = selectedLibrary.Name;
            quantityChangeTB.Text = selectedLibrary.QuantityOfBooks.ToString();
            phoneChangeTB.Text = selectedLibrary.Phone;
            addressChangeTB.Text = selectedLibrary.Address;
            squareChangeTB.Text = selectedLibrary.Square.ToString();
            avgNumberChangeTB.Text = selectedLibrary.AvgNumberOfVisitors.ToString();
            rateChangeTB.Text = selectedLibrary.Rate.ToString();

        }

        private void listOfLibrariesCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listOfLibrariesCB.SelectedIndex != -1)
            {
                Library library = Library.Libraries.getEl(listOfLibrariesCB.SelectedItem.ToString());
                
                selectedLibrary = library;
                showData();
            }
        }

        private void validData(string name,
            string quantityOfBooks = "0",
            string phone = "+79012310002",
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
                validData(nameChangeTB.Text, quantityChangeTB.Text, phoneChangeTB.Text, addressChangeTB.Text, squareChangeTB.Text, avgNumberChangeTB.Text, rateChangeTB.Text);
               
               Library library = new Library(new GeneralLibrary(), selectedLibrary.Management,  nameChangeTB.Text, int.Parse(quantityChangeTB.Text), phoneChangeTB.Text, addressChangeTB.Text,
                    float.Parse(squareChangeTB.Text), int.Parse(avgNumberChangeTB.Text), float.Parse(rateChangeTB.Text));
                Library.AddInList(library.Name, library);
                Library.RemoveInList(listOfLibrariesCB.SelectedItem.ToString()); 
                listOfLibrariesCB.SelectedItem= library.Name;
                selectedLibrary = library;
                
                Enabled = false;
                updateList();
                showMessageBox("Сохранено", "Успех");
                Enabled = true;
                this.Activate();

            }
            catch(CustInvalidArgumentException exc)
            {
                Enabled = false;
                showMessageBox(exc.Message, "Авария");
                Enabled = true;
                this.Activate();
            }
           
        }

        private void printBtn_Click(object sender, EventArgs e)
        {
            if(selectedLibrary!=null)
            {
                String result = fetchData();
                Enabled = false;
                showMessageBox(result.ToString(), "Вывод");
                Enabled=true;
                this.Activate();
            }
            else
            {
                Enabled = false;
                showMessageBox("Объект не выбран", "Ошибка");
                Enabled = true;
                this.Activate();
            }
           
        }

        private string fetchData()
        {
            StringBuilder result = new StringBuilder("");
            result.AppendLine(selectedLibrary.Use());
            result.AppendLine(selectedLibrary.Work());
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

        private void clearAllFields()
        {
            nameInputTB.Clear();
            quantityOfBooksTB.Clear();
            phoneInputTB.Clear();
            addressInputTB.Clear();
               squareInputTB.Clear();
            avgNumberInputTB.Clear();
            rateInputTB.Clear();
        }
         void CollectionChangedHandler(string action, string key)
        {
            this.Enabled = false;
            showMessageBox(action, key);
            this.Enabled = true;
            this.Activate();
        }

        private void btnShowListOfObjects_Click(object sender, EventArgs e)
        {
            Enabled = false;
            RepositoryShow repositoryShow = new RepositoryShow();
            repositoryShow.ShowDialog();
            Enabled = true;
            this.Activate();

        }

        private void btnDetermineSpeedOfLists_Click(object sender, EventArgs e)
        {
            Enabled = false;
            Test test = new Test();
            test.ShowDialog();
            Enabled = true;
            this.Activate();

        }

        private void GeneralLbRB_CheckedChanged(object sender, EventArgs e)
        {
            typeOfLibrary = 1;
        }

        private void EducateLbRB_CheckedChanged(object sender, EventArgs e)
        {
            typeOfLibrary = 2;
        }

        private void CultManagementRB_CheckedChanged(object sender, EventArgs e)
        {
            managementType = 1;
        }

        private void LibDepartmentRB_CheckedChanged(object sender, EventArgs e)
        {
            managementType=2;
        }

        private void setRequestExtensions_Click(object sender, EventArgs e)
        {
            selectedLibrary.setRequestExt();
        }

        private void setIncreaseRequest_Click(object sender, EventArgs e)
        {
            selectedLibrary.setRequestIncrease();
        }
    }
}
