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

        private void btnNumber_Click(object sender, EventArgs e)
        {
            // 클릭된 버튼이 어떤 숫자인지 가져오기
            Button btn = (Button)sender;

            // 상단 수식 텍스트박스에 숫자 추가
            txtExpression.Text += btn.Text;
        }

        // 2. 더하기(+) 버튼 클릭 시 수식에 기호 추가
        private void btnPlus_Click(object sender, EventArgs e)
        {
            // 연산자 앞뒤로 공백을 주면 나중에 계산하기 편합니다
            txtExpression.Text += " + ";
        }

        // 3. 결과(=) 버튼 클릭 시 계산 수행
        private void btnEqual_Click(object sender, EventArgs e)
        {
            try
            {
                // 과제 1의 핵심: 수식을 계산하여 결과창에 출력
                // DataTable을 활용해 문자열 수식을 실제 숫자로 계산합니다 int보다 더 강력.
                System.Data.DataTable table = new System.Data.DataTable();
                var result = table.Compute(txtExpression.Text, "");

                // 하단 결과창에 출력
                txtResult.Text = result.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("수식을 확인해주세요.");
            }
        }
    }
}