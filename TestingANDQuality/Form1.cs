using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace TestingANDQuality
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int[] initialArray;
        int sizeArray;
        string fileName;
        bool handWriting = false;

        private int[] Function(int [] array)
        {
            int[] resultArray = new int[array.Length];
            Array.Copy(array, resultArray, array.Length);
            int addNumber = 0;
            bool firstEven = true;
            for (int i = 0; i < resultArray.Length; i++)
            {
                if (resultArray[i] % 2 == 0)
                {
                    if (firstEven)
                    {
                        addNumber = resultArray[i];
                        firstEven = false;
                    }
                    else
                    {
                        resultArray[i] = resultArray[i] + addNumber;
                    }

                }
            }
            if (firstEven)
            {
                sizeArray = resultArray.Length;
                return null;
            }
            else
                return resultArray;
        }

        private void buttonRandGenerate_Click(object sender, EventArgs e)
        {
            fileName = null;
            textBoxInitialArray.ReadOnly = true;
            handWriting = false;
            textBoxInitialArray.Clear();
            textBoxResultArray.Clear();

            Form2 newForm2 = new Form2();
            newForm2.ShowDialog();

            if (newForm2.Confirm)
            {
                Random random = new Random();
                int sizeArray = newForm2.SizeArray;
                initialArray = new int[sizeArray];
                progressBar.Value = 0;
                progressBar.Minimum = 0;
                progressBar.Maximum = sizeArray;
                for (int i = 0; i < sizeArray; i++)
                {
                    progressBar.Value++;
                    initialArray[i] = random.Next(-100, 100);
                    textBoxInitialArray.Text += initialArray[i].ToString() + " ";
                }
                btnTransform.Enabled = true;
                groupBox.Text = "Исходный массив(Сгенерирован случайно)";
            }
            else
            {
                initialArray = null;
                btnTransform.Enabled = false;
                groupBox.Text = "Исходный массив(Источник не выбран)";
            }
            progressBar.Value = 0;
        }

        private void btnTransform_Click(object sender, EventArgs e)
        {
            textBoxResultArray.Clear();
            if (handWriting)
            {
                string strArray = textBoxInitialArray.Text;
                if (strArray.Length > 1000)
                {
                    var messageWrongFileFormat = MessageBox.Show("Количество символов не должно превышать 1000", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    initialArray = null;
                }
                else
                {
                    try
                    {
                        strArray = DeleteSpaceString(strArray);

                        bool changeArray = false;
                        ///////Новый вариант///////
                        string [] numbers = strArray.Split(' ');
                        initialArray = new int[numbers.Length];
                        for (int i = 0; i < numbers.Length; i++)
                        {
                            char[] charArrayNumbers = numbers[i].ToCharArray();
                            if ((charArrayNumbers.Length >= 2 && charArrayNumbers[0] == '0') || (charArrayNumbers.Length >= 3 && charArrayNumbers[0] == '-') && charArrayNumbers[1]=='0')
                            {
                                var messageWrongFileFormat = MessageBox.Show("Массив содержит числа с незначимыми нулями. Нажмите OK если вы хотите преобразовать массив", "Внимание", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                                if (messageWrongFileFormat != DialogResult.OK)
                                {
                                    initialArray = null;
                                    textBoxInitialArray.Clear();  //Не значащие нули
                                    break;
                                }
                                else
                                    changeArray = true;
                            }
                            initialArray[i] = int.Parse(numbers[i]);
                            
                        }

                        if (changeArray)
                        {
                            progressBar.Value = 0;
                            progressBar.Minimum = 0;
                            progressBar.Maximum = initialArray.Length;
                            textBoxInitialArray.Clear();
                            for (int i = 0; i < initialArray.Length; i++)
                            {
                                progressBar.Value++;
                                textBoxInitialArray.Text += initialArray[i] + " ";
                            }
                            progressBar.Value = 0;
                        }
                        ///////Новый вариант///////
                        
                        //initialArray = strArray.Split(' ').Select(x => int.Parse(x)).ToArray(); // Старый вариант
                    }
                    catch (Exception ex)
                    {
                        if (textBoxInitialArray.Text == "")
                        {
                            var messageWrongFileFormat = MessageBox.Show("Вы не ввели исходный массив", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            var messageWrongFileFormat = MessageBox.Show("Неправильные данные. Массив должен содержать целые числа, положительные или отрицательные, отделенные друг от друга пробелом в диапазоне от -1073741823 до 1073741823 включительно.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        initialArray = null;
                        textBoxInitialArray.Clear();
                    }
                }
            }
            textBoxResultArray.Clear();
            if (initialArray != null)
            {
                if (Inrange(initialArray))
                {
                    sizeArray = initialArray.Length;
                    int[] resultArray = Function(initialArray);

                    if (radioButtonOnTheScreen.Checked) // на экран
                    {

                        if (resultArray != null)
                        {
                            progressBar.Value = 0;
                            progressBar.Minimum = 0;
                            progressBar.Maximum = resultArray.Length;

                            for (int i = 0; i < resultArray.Length; i++)
                            {
                                progressBar.Value++;
                                textBoxResultArray.Text += resultArray[i].ToString() + " ";
                            }
                        }
                        else
                        {
                            for (int i = 0; i < sizeArray; i++)
                            {
                                progressBar.Value++;
                                textBoxResultArray.Text += "$ ";
                            }
                        }
                    }
                    else
                    {
                        WriteFile(resultArray); // в файл
                    }
                }
                else
                {
                    var messageWrongFileFormat = MessageBox.Show("Числа в массиве должны быть в диапазоне от -1073741823 до 1073741823 включительно.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    initialArray = null;
                    textBoxInitialArray.Clear();
                }
            }
            progressBar.Value = 0;
        }

        private void buttonLoadArray_Click(object sender, EventArgs e)
        {
            fileName = null;
            textBoxInitialArray.Clear();
            textBoxResultArray.Clear();
            initialArray = null;
            handWriting = false;
            textBoxInitialArray.ReadOnly = true;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = " |*.txt";

            //List<string> numbers = new List<string>();

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                fileName = openFileDialog.FileName;

                if (CheckfileName(fileName))
                {
                    StreamReader streamReader = new StreamReader(openFileDialog.OpenFile());
                    string strArray = streamReader.ReadLine();
                    if (strArray != null)
                    {
                        if (strArray.Length <= 1000)
                        {
                            try
                            {
                                strArray = DeleteSpaceString(strArray);

                                //initialArray = strArray.Split(' ').Select(x => int.Parse(x)).ToArray();

                                string[] numbers = strArray.Split(' ');
                                initialArray = new int[numbers.Length];
                                for (int i = 0; i < numbers.Length; i++)
                                {
                                    char[] charArrayNumbers = numbers[i].ToCharArray();
                                    if ((charArrayNumbers.Length >= 2 && charArrayNumbers[0] == '0') || (charArrayNumbers.Length >= 3 && charArrayNumbers[0] == '-') && charArrayNumbers[1] == '0')
                                    {
                                        var messageWrongFileFormat = MessageBox.Show("Массив в файле содержит числа с незначимыми нулями. Нажмите OK если вы хотите загрузить такой массив", "Внимание", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                                        if (messageWrongFileFormat != DialogResult.OK)
                                        {
                                            initialArray = null;
                                            textBoxInitialArray.Clear();
                                            buttonLoadArray_Click(sender, e);
                                            return;
                                        }
                                    }
                                    initialArray[i] = int.Parse(numbers[i]);

                                }
                                //////////////


                                if (Inrange(initialArray))
                                {
                                    progressBar.Value = 0;
                                    progressBar.Minimum = 0;
                                    progressBar.Maximum = initialArray.Length;

                                    for (int i = 0; i < initialArray.Length; i++)
                                    {
                                        progressBar.Value++;
                                        textBoxInitialArray.Text += initialArray[i].ToString() + " ";
                                    }
                                    btnTransform.Enabled = true;
                                }
                                else
                                {
                                    var messageWrongFileFormat = MessageBox.Show("Неправильные данные в файле. Числа в массиве должны быть в диапазоне от -1073741823 до 1073741823 включительно.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    buttonLoadArray_Click(sender, e);
                                }
                            }
                            catch (Exception ex)
                            {
                                var messageWrongFileFormat = MessageBox.Show("Неправильные данные в файле. Файл должен содержать целые числа, положительные или отрицательные, отделенные друг от друга пробелом в диапазоне от -1073741823 до 1073741823 включительно.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                buttonLoadArray_Click(sender, e);
                            }
                        }
                        else
                        {
                            string message = "Файл очень большой. Количество символов в файле не должно превышать 1000";
                            string caption = "Ошибка!";
                            var messageWrongFileFormat = MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            buttonLoadArray_Click(sender, e);
                        }
                    }
                    else
                    {
                        var messageWrongFileFormat = MessageBox.Show("Файл пуст!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        buttonLoadArray_Click(sender, e);
                    }
                    progressBar.Value = 0;
                    streamReader.Dispose();
                    streamReader.Close();
                }
                else
                {
                    var messageWrongFileFormat = MessageBox.Show("Файл c неправильным расширением. Расширение файла должно быть txt", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    buttonLoadArray_Click(sender, e);
                }
            }
            else
            {
                groupBox.Text = "Исходный массив(Источник не выбран)";
                btnTransform.Enabled = false;
                initialArray = null;
                textBoxInitialArray.Clear();
            }
            if (initialArray != null)
            {
                groupBox.Text = "Исходный массив(Из файла: " + fileName + " )";
            }
        }

        private void buttonHandwritingArray_Click(object sender, EventArgs e)
        {
            fileName = null;
            textBoxInitialArray.Clear();
            textBoxResultArray.Clear();
            textBoxInitialArray.ReadOnly = false;
            handWriting = true;
            btnTransform.Enabled = true;
            groupBox.Text = "Исходный массив(Ручной ввод)";
        }

        private void WriteFile(int [] resultArray)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Сохранить массив";
            saveFileDialog.CheckPathExists = true;
            saveFileDialog.Filter = " |*.txt";
            saveFileDialog.ShowHelp = true;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string nameSaveFile = saveFileDialog.FileName;

                if (CheckfileName(nameSaveFile))
                {
                    if (fileName == null || fileName != nameSaveFile) // сравниваем не является ли сохраненный файл, файлом из которого мы загрузили массив
                    {
                        StreamWriter writer = new StreamWriter(saveFileDialog.OpenFile());
                        progressBar.Value = 0;
                        progressBar.Minimum = 0;
                        progressBar.Maximum = sizeArray;

                        for (int i = 0; i < sizeArray; i++)
                        {
                            progressBar.Value++;
                            if (resultArray != null)
                            {
                                if (i != sizeArray - 1)
                                {
                                    writer.Write(resultArray[i].ToString() + ' ');
                                }
                                else
                                    writer.Write(resultArray[i].ToString());
                            }
                            else
                                writer.Write("$ ");
                        }
                        writer.Dispose();
                        writer.Close();
                        var messageWrongFileFormat = MessageBox.Show("Файл " + nameSaveFile + " сохранен!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        var messageWrongFileFormat = MessageBox.Show("Файл не сохранен! Нельзя сохранить массив в файле, из которого он был считан! ", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        WriteFile(resultArray);
                    }

                }
                else
                {
                    var messageWrongFileFormat = MessageBox.Show("Вы указали неверный формат файла. Необходимо указать файл с расширением txt", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    WriteFile(resultArray);
                }
            }
        }

        bool CheckfileName(string name)
        {
            char[] nameFileCharArray = name.ToCharArray();
            Array.Reverse(nameFileCharArray);
            int i = 0;
            if (nameFileCharArray.Length>=4 && nameFileCharArray[i] == 't' && nameFileCharArray[i + 1] == 'x' && nameFileCharArray[i + 2] == 't' && nameFileCharArray[i + 3] == '.')
            {
                return true;
            }
            else
                return false;
        }

        bool Inrange(int [] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if(array[i]<-1073741823 || array[i] > 1073741823)
                    return false;
            }
            return true;
        }

        string  DeleteSpaceString(string strNumbers)
        {
            char[] charArray = strNumbers.ToCharArray();
            Array.Reverse(charArray);
            if (charArray[0] == ' ')
            {
                char[] result = new char[strNumbers.Length - 1];
                string temp = new string(charArray);
                for (int i = 1; i < temp.Length; i++)
                {
                    result[i - 1] = temp[i];
                }
                Array.Reverse(result);
                string strResult = new string(result);
                return strResult;
            }
            return strNumbers;
        }
    }
}
