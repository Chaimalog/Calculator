using System;
using System.Windows.Forms;
using Button = System.Windows.Forms.Button;

namespace clac
{
    public partial class Form1 : Form
    {
        string operation = "";// نحفظ بداخله العملبة الحسابية 
        float result = 0;// نحفظ بداخله القيمة المسجلة على الشاشة  قبل اختيار العملية 
        bool ClickOperation = false;// متغير عند حدوث  عملية حسابية 
        public Form1()
        {
            InitializeComponent();
        }

        private void button16_Click(object sender, EventArgs e)
        {

            // حدث لجميع ازرار الارقام و الفاصلة
            Button but = (Button)sender;
            if (textBox1.Text == "0" || ClickOperation == true)
            {
                // تمسح القيمة السابقة لكتابة القيمة الجديدة
                textBox1.Clear();
                // لحذف الصفر الظاهر على شاشة الالة
            }
            if (but.Text == ".")
            {

                if (!textBox1.Text.Contains("."))
                {
                    textBox1.Text = textBox1.Text + but.Text;
                }

            }
            else { textBox1.Text = textBox1.Text + but.Text; }
            ClickOperation = false;  //عدم اختيار عملية حسابية بعد
            //كتابة الفاصلة مرة واحدة و تفادي كتابة الفاصلة بدون رقم قبلها
        }

       

        private void button10_Click(object sender, EventArgs e)
        {
            Button but = (Button)sender;
            operation = but.Text;
            result = float.Parse(textBox1.Text);
            ClickOperation = true;
        }
        private void button13_Click(object sender, EventArgs e)
        {
            switch (operation)
            {
                case "+":
                    textBox1.Text = (result + float.Parse(textBox1.Text)).ToString();
                    break;

                case "-":
                    textBox1.Text = (result - float.Parse(textBox1.Text)).ToString();
                    break;

                case "x":

                    textBox1.Text = (result * float.Parse(textBox1.Text)).ToString();
                    break;

                case "/":

                    textBox1.Text = (result / float.Parse(textBox1.Text)).ToString();
                    break;

            }
        }
        private void button17_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);
                // للتراجع delete 
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            //لمسح الشاشة و افراغها  CLEAN 
            textBox1.Clear();
            result = 0;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
