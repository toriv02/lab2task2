namespace lab2task2
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            inputtextBox.Text = Properties.Settings.Default.vvod.ToString();//�������� ����������� �������� � ���� inputtextBox
        }   
        private void checkButton_Click_1(object sender, EventArgs e)
        {
            string ans=Logic.splitstring(this.inputtextBox.Text);
            //���� ������� ������� �����,� �� ������� ��������� �� ������, �� ����� ������� ����� �� ������
            if (ans != "������ �������� ������ ����������, ���������� ��� ���")
                anslabel.Text = ans;
            else
            {//���� ������� ������� ������, �� ������� ���� � �������
                MessageBox.Show("������ �������� ������ ����������, ���������� ��� ���", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
                anslabel.Text = null;
            }
            inputtextBox.Clear();//������� ���� ����� ��������
        }
        private void inputtextBox_KeyDown_1(object sender, KeyEventArgs e)
        {
            //��� ������� �� ������� Enter ������� ������ �� ������ ��� ������� ������
            if (e.KeyCode == Keys.Enter)
            {
                this.AcceptButton = checkButton;
            }
        }

        private void MainForm_Deactivate_1(object sender, EventArgs e)
        {
            //����� ��������� ��������� ��������� �������� � ���� ����� ��������
            Properties.Settings.Default.vvod = this.inputtextBox.Text;
            Properties.Settings.Default.Save();
        }
    }
}
public class Logic
{
    //������ ��������� � ������� ���������� ����� ������ �� ������������ ������ � �������� �������
    public static string splitstring(String vvod)
    {
        //������ ��������� ����������:
        var num = new List<double>();//������ ��� �������� ����� � ������� ������������������
        double save = 0; //��������������� ���������� ��� �������� �����, ��� ��� �������� �� ������
        int j = 0;//������� �����������, ��������������� ��� ����������� �������� �����
        try
        { //��������� ������, ��� ������� �������� ������� ������
            for (int i = vvod.Length; i > 0; i--) //���� ��� ������� ������ � �����
            {

                if (vvod[i - 1] == ',') { num.Add(save); j = 0; save = 0; }//��� ������� "," ���������� ���������� � ���������� save ����� � ������
                else if (vvod[i - 1] == ' ');
                else
                {
                    save += Math.Pow(10, j) * int.Parse(vvod[i - 1].ToString());//���������������� ������ � ����� �������� ��� �� ����������� � ��������� � ���������� save
                    j++;
                }
            }
            if (num.Count < 1) { return "������ �������� ������ ����������, ���������� ��� ���"; } //��������� ������ ����� �������� ������
        }
        catch (FormatException) { return "������ �������� ������ ����������, ���������� ��� ���"; }
        return giveans(num);
    }
    private static string giveans(List<double> num)
    {
        //�������� �� ����������� ���� ������� �������� �������
        for (int i = 1; i < num.Count; i++)
        {
            if (num[i - 1] <= num[i])
            {

                return "������������������, �� ������������";
            }
        }
        return "������������������, ������������";
    }
}
