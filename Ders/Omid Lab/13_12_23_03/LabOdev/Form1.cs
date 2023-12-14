using System.Windows.Forms;
using System.Xml.Linq;

namespace LabTask
{
    public partial class Form1 : Form
    {
        private string[,] studentData = new string[10, 7];

        public Form1()
        {
            InitializeComponent();
        }

        public void calculateAvg(int rowIndex)
        {
            int not1, not2, not3, resultAvg;

            not1 = Convert.ToInt32(txtCalculusGrade.Text);
            not2 = Convert.ToInt32(txtOOPgrade.Text);
            not3 = Convert.ToInt32(txtDataStructureGrade.Text);

            resultAvg = (not1 + not2 + not3) / 3;

            studentData[rowIndex, 6] = resultAvg.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string id = txtIdNum.Text;
            string name = txtName.Text;
            string surname = txtSurname.Text;
            string oopGrade = txtOOPgrade.Text;
            string calculusGrade = txtCalculusGrade.Text;
            string dataStructureGrade = txtDataStructureGrade.Text;
            

            // Dizideki boþ hücreyi bulalým
            int rowIndex = -1;
            for (int i = 0; i < studentData.GetLength(0); i++)
            {
                if (studentData[i, 0] == null)
                {
                    rowIndex = i;
                    break;
                }
            }
            rowIndex = FindEmptyRow();
            if (rowIndex == -1)
            {
                MessageBox.Show("Dizi dolu, daha fazla öðrenci eklenemez.");
                return;
            }

            studentData[rowIndex, 0] = id;
            studentData[rowIndex, 1] = name;
            studentData[rowIndex, 2] = surname;
            studentData[rowIndex, 3] = oopGrade;
            studentData[rowIndex, 4] = calculusGrade;
            studentData[rowIndex, 5] = dataStructureGrade;

            calculateAvg(rowIndex);



            ClearTextBoxes();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            rchTxtBox.Clear(); // Önce mevcut içeriði temizleyelim

            for (int i = 0; i < studentData.GetLength(0); i++)
            {
                if (studentData[i, 0] != null)
                {
                    string studentInfo = $"{studentData[i, 0]} , {studentData[i, 1]} , " +
                    $"{studentData[i, 2]} , {studentData[i, 3]} , {studentData[i, 4]} , {studentData[i, 5]} , " +
                    $"{studentData[i, 6]}"; // resultAvg'yi de ekleyelim
                    rchTxtBox.AppendText($"{studentInfo}\n");
                }
            }

        }

        private void ClearTextBoxes()
        {
            txtIdNum.Clear();
            txtName.Clear();
            txtSurname.Clear();
            txtOOPgrade.Clear();
            txtCalculusGrade.Clear();
            txtDataStructureGrade.Clear();
        }
        private int FindEmptyRow()
        {
            for (int i = 0; i < studentData.GetLength(0); i++)
            {
                if (studentData[i, 0] == null)
                {
                    return i;
                }
            }

            return -1; // Boþ satýr bulunamazsa -1 döndür
        }
    }
}