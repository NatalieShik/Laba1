using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace FirstVersion
{
    public partial class MainForm : Form
    {
        List<FrequencyAnalysis> frequencyList = new List<FrequencyAnalysis>();  //лист, предназначенный для хранения символов и информации о них
        public MainForm()
        {
            InitializeComponent();
        }

        private void InformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InformationForm form = new InformationForm();   //при нажатии на кнопку справки создается новый объект формы справки и демонстрируется пользователю
            form.ShowDialog();
        }

        private void buttonCount_Click(object sender, EventArgs e)
        {
            frequencyList.Clear();  //стирание записей прошлого анализа
            Dictionary<char, int> frequency = new Dictionary<char, int>();  //словарь для подсчета ключей и их значений
            int symbolAmount = 0;   //переменная для подсчета общего числа анализируемых символов
            foreach (char symbol in richTextBoxForUserInput.Text)   //цикл для посимвольного анализа данных в поле ввода
            {
                char tempSymbol = symbol;   //записывается текущий символ
                int tempNum = (int)tempSymbol;  //и его номер в Юникоде
                if (Char.IsControl(tempSymbol)) //если символ относится к управляющим, цикл пропускает его
                    continue;

                if (tempNum >= 8234 && tempNum <= 8238 //если это символы переворота
                    || tempNum == 8206 || tempNum == 8207 
                    || tempNum == 173)  //или мягкий дефис (т.е. символ, указывающий, где можно переносить слово)
                    continue;   //цикл пропускает и эти символы

                if (Char.IsWhiteSpace(tempSymbol) || tempNum == 8203)   //если текущий символ пробел (в том числе пробел нулевой ширины)
                    tempSymbol = ' ';   //то указываем, что это просто пробел

                if ((int)tempSymbol == 8209)    //если символ - это неразрывный дефис, записываем его как обычный дефис
                    tempSymbol = '-';

                if (!frequency.ContainsKey(tempSymbol)) //если в словаре еще нет текущего символа, добавляем его с ключом (абсолютной встречаемостью) равной 1
                    frequency.Add(tempSymbol, 1);
                else
                    frequency[tempSymbol]++;    //иначе увеличиваем значение у уже существующего в словаре символа на 1
                symbolAmount++; //увеличиваем количество проанализированных символов на 1
            }

            if (frequency.Count == 0)   //если в словаре нет записей, выводим ошибку, очищаем данные из таблицы, данные о количестве символов и завершаем анализ
            {
                MessageBox.Show("Нельзя проанализировать отсутствующий текст.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dataGridViewForResults.RowCount = 0;
                labelForNumber.Text = "не рассчитано";
                return;
            }

            foreach (var item in frequency.OrderByDescending(x => x.Value)) //в упорядоченном по убыванию ключа (абсолютной частоты) словаре перебирается каждый элемент
            {
                string symbol;  //переменная для хранения строкового значения/определения символа
                string toolTip = $"Десятичный код в Юникоде: {(int)item.Key}";  //переменная, записывающая информацию о символе для подсказки
                if (item.Key == ' ')    //если встретился пробел, то вместо пустого графического отображения, будет слово, подсказка будет из этого же слова, так как пробелы могут быть разными, как и коды
                {
                    symbol = "Пробел";
                    toolTip = symbol;
                }
                else
                    symbol = item.Key.ToString();   //в ином случае символ будет преобразован к типу string
                if (item.Key == '-')    //пробел может быть как обычным, так и неразрывным, поэтому подсказка не отображает код
                    toolTip = "Дефис";
                FrequencyAnalysis temp = new FrequencyAnalysis(symbol, item.Value, Math.Round(((double)item.Value) / symbolAmount, 4) * 100, toolTip); //создание нового объекта с информацией о символе
                frequencyList.Add(temp);    //добавление объекта в лист
            }

            int i = 0;  //переменная для перебора строк в таблице
            dataGridViewForResults.RowCount = frequencyList.Count;  //указываем, что в таблице столько же колонок, сколько записей в листе
            foreach (FrequencyAnalysis symbolInfo in frequencyList) //для каждой записи в листе
            {
                dataGridViewForResults.Rows[i].Cells[0].Value = symbolInfo.Symbol;  //записываем в первую колонку сам символ
                dataGridViewForResults.Rows[i].Cells[0].ToolTipText = symbolInfo.ToolTipText;   //устанавливаем для этой колонки подсказку при наведении
                dataGridViewForResults.Rows[i].Cells[1].Value = symbolInfo.Absolutefrequency;   //записываем абсюлутную встречаемость во вторую колонку
                dataGridViewForResults.Rows[i].Cells[2].Value = symbolInfo.Relativefrequency + "%"; //и относительную в третьей
                i++;
            }
            labelForNumber.Text = symbolAmount.ToString();  //записываем над таблицей общее количество символов
        }
    }
}
