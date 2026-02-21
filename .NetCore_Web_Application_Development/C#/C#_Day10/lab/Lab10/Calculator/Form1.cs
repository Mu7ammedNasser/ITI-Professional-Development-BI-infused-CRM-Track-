using System.Data;

namespace Calculator
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }

        private void btnNumber_Clicked(object sender, EventArgs e)
        {
            var btn = sender as Button;
            screen.AppendText(btn.Text);
        }

        private void btnEquals_click(object sender, EventArgs e)
        {

            try
            {
                var res = new DataTable().Compute(screen.Text, null);
                double value = Convert.ToDouble(res);
                if (double.IsInfinity(value))
                {
                    screen.Text = "Math Error";
                    return;

                }
                screen.Text = res.ToString();
            }
            catch
            {
                screen.Text = "Error";
            }
        }

        private void btnClear_click(object sender, EventArgs e)
        {
            screen.Clear();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (screen.Text.Length > 0)
            {
                screen.Text = screen.Text.Substring(0, screen.Text.Length - 1);
            }
        }
    }
}
