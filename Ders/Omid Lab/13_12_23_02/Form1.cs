using System;
using System.Windows.Forms;
using System.Xml.Linq;

namespace _13_12_23_02
{
    public partial class Form1 : Form
    {
        private string[,] studentData = new string[10, 6];

        public Form1()
        {
            InitializeComponent();
        }

        public void calculateAvg(object sender, EventArgs e)
        {
            int not1, not2, not3, resultAvg;

            not1 = Convert.ToInt32(txtCalculusGrade.Text);
            not2 = Convert.ToInt32(txtOOPgrade.Text);
            not3 = Convert.ToInt32(txtDataStructureGrade.Text);

            resultAvg = (not1 + not2 + not3) / 3;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string id = txtIdNum.Text;
            string name = txtName.Text;
            string surname = txtSurname.Text;
            string oopGrade = txtOOPgrade.Text;
            string calculusGrade = txtCalculusGrade.Text;
            string dataStructureGrade = txtDataStructureGrade.Text;


            // Dizideki boş hücreyi bulalım
            int rowIndex = -1;
            for (int i = 0; i < studentData.GetLength(0); i++)
            {
                if (studentData[i, 0] == null)
                {
                    rowIndex = i;
                    break;
                }
            }

            if (rowIndex == -1)
            {
                MessageBox.Show("Dizi dolu, daha fazla öğrenci eklenemez.");
                return;
            }

            studentData[rowIndex, 0] = id;
            studentData[rowIndex, 1] = name;
            studentData[rowIndex, 2] = surname;
            studentData[rowIndex, 3] = oopGrade;
            studentData[rowIndex, 4] = calculusGrade;
            studentData[rowIndex, 5] = dataStructureGrade;



            ClearTextBoxes();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            rchTxtBox.Clear(); // Önce mevcut içeriği temizleyelim

            for (int i = 0; i < studentData.GetLength(0); i++)
            {
                if (studentData[i, 0] != null)
                {
                    string studentInfo = $"{studentData[i, 0]} , {studentData[i, 1]} , " +
                        $"{studentData[i, 2]} , {studentData[i, 3]} , {studentData[i, 4]} , {studentData[i, 5]} , ";
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
    }
}