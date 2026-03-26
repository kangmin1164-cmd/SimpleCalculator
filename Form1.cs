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

        // 1. 숫자 버튼 클릭
        private void btnNumber_Click(object sender, EventArgs e)
        {
            if (txtExpression.Text.Contains("=")) txtExpression.Clear();
            if (sender is Button btn)
            {
                if (txtExpression.Text == "0" || txtExpression.Text.EndsWith(" 0"))
                {
                    txtExpression.Text = txtExpression.Text.Substring(0, txtExpression.Text.Length - 1);
                }
                txtExpression.Text += btn.Text;
            }
        }

        // 2. 연산자 버튼 (중복 시 교체 로직 포함)
        private void btnOperator_Click(object sender, EventArgs e)
        {
            if (txtExpression.Text.Contains("=")) txtExpression.Text = txtResult.Text;
            if (string.IsNullOrWhiteSpace(txtExpression.Text)) return;

            if (sender is Button btn)
            {
                if (txtExpression.Text.EndsWith(" "))
                {
                    txtExpression.Text = txtExpression.Text.Substring(0, txtExpression.Text.Length - 3);
                }
                txtExpression.Text += " " + btn.Text + " ";
            }
        }

        // 3. 소수점, 부호 전환, 삭제 등은 기존과 동일
        private void btnDot_Click(object sender, EventArgs e)
        {
            if (txtExpression.Text.Contains("=")) txtExpression.Clear();
            string[] parts = txtExpression.Text.Split(' ');
            string lastPart = parts[parts.Length - 1];
            if (!lastPart.Contains("."))
            {
                if (string.IsNullOrEmpty(lastPart)) txtExpression.Text += "0.";
                else txtExpression.Text += ".";
            }
        }

        private void btnSign_Click(object sender, EventArgs e)
        {
            if (txtExpression.Text.Contains("=")) return;
            string text = txtExpression.Text.TrimEnd();
            int lastSpaceIndex = text.LastIndexOf(' ');
            string prefix = lastSpaceIndex == -1 ? "" : text.Substring(0, lastSpaceIndex + 1);
            string lastNumber = lastSpaceIndex == -1 ? text : text.Substring(lastSpaceIndex + 1);
            if (string.IsNullOrEmpty(lastNumber) || lastNumber == "0") return;

            if (lastNumber.StartsWith("-")) txtExpression.Text = prefix + lastNumber.Substring(1);
            else txtExpression.Text = prefix + "-" + lastNumber;
        }

        private void btnClear_Click(object sender, EventArgs e) { txtExpression.Clear(); txtResult.Clear(); }

        private void btnCE_Click(object sender, EventArgs e)
        {
            if (txtExpression.Text.Contains("=")) { btnClear_Click(sender, e); return; }
            string text = txtExpression.Text;
            int lastSpaceIndex = text.TrimEnd().LastIndexOf(' ');
            if (lastSpaceIndex == -1) txtExpression.Text = "0";
            else txtExpression.Text = text.Substring(0, lastSpaceIndex + 1) + "0";
            txtResult.Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtExpression.Text.Contains("=") || txtExpression.Text.Length == 0) return;
            txtExpression.Text = txtExpression.Text.Substring(0, txtExpression.Text.Length - 1);
        }

        // ★ [핵심 수정] 결과 계산 및 무한대(∞) 처리 ★
        private void btnEqual_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtExpression.Text) || txtExpression.Text.Contains("=")) return;
            if (txtExpression.Text.EndsWith(" ")) return;

            try
            {
                string original = txtExpression.Text;
                string solve = original.Replace("×", "*").Replace("÷", "/");

                DataTable table = new DataTable();
                object? calcResult = table.Compute(solve, "");

                if (calcResult == null) return;

                string resultStr = calcResult.ToString() ?? "";

                // ∞ 기호나 Infinity 텍스트가 포함되어 있는지 검사
                if (resultStr.Contains("∞") || resultStr.ToLower().Contains("infinity") || resultStr.Contains("nan"))
                {
                    txtResult.Text = "0으로 나눌 수 없습니다.";
                }
                else
                {
                    txtResult.Text = resultStr;
                    txtExpression.Text = original + " = " + resultStr;
                }
            }
            catch (Exception)
            {
                txtResult.Text = "수식 오류";
            }
        }
    }
}