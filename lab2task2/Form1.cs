namespace lab2task2
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            inputtextBox.Text = Properties.Settings.Default.vvod.ToString();//выгрузка сохранённого значения в поле inputtextBox
        }   
        private void checkButton_Click_1(object sender, EventArgs e)
        {
            string ans=Logic.splitstring(this.inputtextBox.Text);
            //если функция вернула ответ,а не вернула сообщение об ошибке, то тогда выводим ответ на задачу
            if (ans != "формат введённых данных некоректен, попробуйте ещё раз")
                anslabel.Text = ans;
            else
            {//если функция вернула ошибку, то выводим окно с ошибкой
                MessageBox.Show("формат введённых данных некоректен, попробуйте ещё раз", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                anslabel.Text = null;
            }
            inputtextBox.Clear();//очистка поля после подсчёта
        }
        private void inputtextBox_KeyDown_1(object sender, KeyEventArgs e)
        {
            //при нажатии на клавишу Enter смещаем фокукс на кнопку для решения задачи
            if (e.KeyCode == Keys.Enter)
            {
                this.AcceptButton = checkButton;
            }
        }

        private void MainForm_Deactivate_1(object sender, EventArgs e)
        {
            //перед закрытием программы сохраняем введённое в поле ввода значение
            Properties.Settings.Default.vvod = this.inputtextBox.Text;
            Properties.Settings.Default.Save();
        }
    }
}
public class Logic
{
    //логика программы в которой происходит поиск ответа на поставленную задачу с текущими данными
    public static string splitstring(String vvod)
    {
        //создаём следующие переменные:
        var num = new List<double>();//массив для хранения чисел в ведённой последовательности
        double save = 0; //вспомогательная переменная для хранения числа, при его переводе из текста
        int j = 0;//счётчик разрядности, предназначенный для корректного перевода числа
        try
        { //обработка ошибки, при неверно введённом формате данных
            for (int i = vvod.Length; i > 0; i--) //цикл для прохода строки с конца
            {

                if (vvod[i - 1] == ',') { num.Add(save); j = 0; save = 0; }//при символе "," записываем зранящееся в переменной save число в массив
                else if (vvod[i - 1] == ' ');
                else
                {
                    save += Math.Pow(10, j) * int.Parse(vvod[i - 1].ToString());//переводимтекущий символ в число помножая его на разрядность и сохраняем в переменной save
                    j++;
                }
            }
            if (num.Count < 1) { return "формат введённых данных некоректен, попробуйте ещё раз"; } //обработка малого числа введённых данных
        }
        catch (FormatException) { return "формат введённых данных некоректен, попробуйте ещё раз"; }
        return giveans(num);
    }
    private static string giveans(List<double> num)
    {
        //проходим по полученному выше массиву проверяя порядок
        for (int i = 1; i < num.Count; i++)
        {
            if (num[i - 1] <= num[i])
            {

                return "Последовательность, не возрастающая";
            }
        }
        return "Последовательность, возрастающая";
    }
}
