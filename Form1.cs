using System;
using System.Data;
using System.Text.RegularExpressions; // 정규식 사용을 위해 추가
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

        // 2. 괄호 버튼 클릭 (토글 기능)
        private void btnParenthesis_Click(object sender, EventArgs e)
        {
            if (txtExpression.Text.Contains("=")) txtExpression.Clear();

            string text = txtExpression.Text;
            if (string.IsNullOrEmpty(text))
            {
                txtExpression.Text = "(";
                return;
            }

            int openCount = text.Split('(').Length - 1;
            int closeCount = text.Split(')').Length - 1;
            char lastChar = text[text.Length - 1];

            // ')'를 넣는 조건: 열린 괄호가 더 많고, 마지막이 숫자거나 ')'일 때
            if (openCount > closeCount && (System.Char.IsDigit(lastChar) || lastChar == ')'))
            {
                txtExpression.Text += ")";
            }
            else
            {
                // '('를 넣을 때 앞이 숫자나 ')'라면 가독성을 위해 공백 없이 붙임 (내부에서 처리)
                txtExpression.Text += "(";
            }
        }

        // 3. 연산자 버튼 (중복 시 교체)
        private void btnOperator_Click(object sender, EventArgs e)
        {
            if (txtExpression.Text.Contains("=")) txtExpression.Text = txtResult.Text;
            if (string.IsNullOrWhiteSpace(txtExpression.Text)) return;

            if (sender is Button btn)
            {
                if (txtExpression.Text.EndsWith("(")) return;
                if (txtExpression.Text.EndsWith(" "))
                {
                    txtExpression.Text = txtExpression.Text.Substring(0, txtExpression.Text.Length - 3);
                }
                txtExpression.Text += " " + btn.Text + " ";
            }
        }

        // 4. 소수점, 부호 전환, 편집 기능 (기존 로직 유지)
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
            if (string.IsNullOrEmpty(text) || text.EndsWith(" ")) return; // 연산자 보호

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

        // 5. [수정] 결과 계산 로직 (정규식을 이용한 암시적 곱셈 보정)
        private void btnEqual_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtExpression.Text) || txtExpression.Text.Contains("=")) return;

            int openCount = txtExpression.Text.Split('(').Length - 1;
            int closeCount = txtExpression.Text.Split(')').Length - 1;
            if (openCount != closeCount || txtExpression.Text.EndsWith(" "))
            {
                MessageBox.Show("수식이 완성되지 않았습니다.");
                return;
            }

            try
            {
                string original = txtExpression.Text;

                // 내부 계산용 변환 시작
                string solve = original.Replace("×", "*").Replace("÷", "/");

                // 정규식을 사용하여 암시적 곱셈 처리 (숫자( -> 숫자*( / )숫자 -> )*숫자 / )( -> )*( )
                // 1. 숫자 뒤에 바로 '('가 오는 경우: 2( -> 2*(
                solve = Regex.Replace(solve, @"(\d)\(", "$1*(");
                // 2. ')' 뒤에 바로 숫자가 오는 경우: )2 -> )*2
                solve = Regex.Replace(solve, @"\)(\d)", ")*$1");
                // 3. ')' 뒤에 바로 '('가 오는 경우: )( -> )*(
                solve = Regex.Replace(solve, @"\)\(", ")*(");

                DataTable table = new DataTable();
                object? calcResult = table.Compute(solve, "");

                if (calcResult == null) return;

                string resultStr = calcResult.ToString() ?? "";

                if (resultStr.Contains("∞") || resultStr.ToLower().Contains("infinity") || resultStr.Contains("NaN"))
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