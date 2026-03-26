using System;
using System.Data;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // [과제 1 & 2] 숫자 버튼 클릭
        private void btnNumber_Click(object sender, EventArgs e)
        {
            // 계산이 끝난 후(=이 포함된 상태) 숫자를 누르면 새로 시작하도록 초기화
            if (txtExpression.Text.Contains("=")) txtExpression.Clear();

            Button btn = (Button)sender;
            txtExpression.Text += btn.Text;
        }

        // [과제 2] 연산자 버튼 클릭
        private void btnOperator_Click(object sender, EventArgs e)
        {
            // 계산 결과 뒤에 바로 연산자를 붙여서 이어서 계산 가능하게 처리
            if (txtExpression.Text.Contains("="))
            {
                txtExpression.Text = txtResult.Text;
            }

            Button btn = (Button)sender;
            txtExpression.Text += " " + btn.Text + " ";
        }

        // [과제 3] CE: 마지막 숫자 뭉치 삭제
        private void btnCE_Click(object sender, EventArgs e)
        {
            if (txtExpression.Text.Contains("=")) { btnClear_Click(null, null); return; }

            string text = txtExpression.Text.TrimEnd();
            if (string.IsNullOrEmpty(text)) return;
            int lastSpaceIndex = text.LastIndexOf(' ');
            if (lastSpaceIndex == -1) txtExpression.Clear();
            else txtExpression.Text = text.Substring(0, lastSpaceIndex + 1);
        }

        // [과제 3] C: 초기화
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtExpression.Clear();
            txtResult.Clear();
        }

        // [과제 3] Del: 한 글자 삭제
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtExpression.Text.Contains("=")) return; // 결과 도출 후엔 삭제 불가
            if (txtExpression.Text.Length > 0)
                txtExpression.Text = txtExpression.Text.Substring(0, txtExpression.Text.Length - 1);
        }

        // ★ 수정된 부분: 결과창과 수식창에 동시에 값 표시 ★
        private void btnEqual_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtExpression.Text) || txtExpression.Text.Contains("=")) return;

            try
            {
                string originalExpression = txtExpression.Text; // 원래 수식 보관
                string solveExpression = originalExpression.Replace("×", "*").Replace("÷", "/");

                DataTable table = new DataTable();
                var calcResult = table.Compute(solveExpression, "");
                string resultStr = calcResult.ToString();

                // 1. 하단 결과창에는 숫자만 표시
                txtResult.Text = resultStr;

                // 2. 상단 수식창에는 "기존 수식 = 결과" 형태로 표시
                txtExpression.Text = originalExpression + " = " + resultStr;
            }
            catch (Exception)
            {
                MessageBox.Show("수식을 확인해주세요.");
            }
        }
    }
}