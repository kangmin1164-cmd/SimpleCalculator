using System;
using System.Data; // DataTable 사용을 위해 필수
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

        // [과제 1 & 2 공통] 숫자 버튼(0~9) 클릭 시 호출
        private void btnNumber_Click(object sender, EventArgs e)
        {
            // 과제1 코딩과 테스트 완료
            Button btn = (Button)sender;

            // 사용자가 누른 숫자(String)를 수식창에 누적 (Step 1: Input)
            txtExpression.Text += btn.Text;
        }

        // [과제 2] 연산자 버튼(+, -, ×, ÷) 클릭 시 호출
        private void btnOperator_Click(object sender, EventArgs e)
        {
            // 과제2 코딩과 테스트 완료
            Button btn = (Button)sender;

            // 기호 앞뒤로 공백을 넣어 수식 구분 (Step 1: Input)
            txtExpression.Text += " " + btn.Text + " ";
        }

        // [과제 1 & 2 통합] 결과 계산 버튼(=) 클릭 시 호출
        private void btnEqual_Click(object sender, EventArgs e)
        {
            // 과제1, 2 코딩과 테스트 완료
            try
            {
                // 1. 수식 가져오기 (String)
                string expression = txtExpression.Text;

                // 2. 기호 치환 (표시용 ×, ÷를 계산용 *, /로 변경)
                expression = expression.Replace("×", "*").Replace("÷", "/");

                // 3. 변환 및 계산 (Step 2 & 3: Parsing & Process)
                // DataTable.Compute가 내부적으로 문자열 내 숫자를 계산 가능한 수치로 변환합니다.
                DataTable table = new DataTable();
                var calcResult = table.Compute(expression, "");

                // 4. 결과 출력 (Step 4: ToString 변환 준수)
                // 계산된 숫자 결과를 다시 문자열(String)로 변환하여 텍스트박스에 표시
                txtResult.Text = calcResult.ToString();
            }
            catch (Exception)
            {
                // 잘못된 수식(예: 1++2) 입력 시 에러 처리
                MessageBox.Show("수식을 확인해주세요.");
            }
        }
    }
}