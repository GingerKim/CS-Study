namespace Chapter11
{
    public partial class form : Form
    {
        public form()
        {
            InitializeComponent();
        }

        private void IDBOX_TextChanged(object sender, EventArgs e)
        {
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void form_Load(object sender, EventArgs e)
        {

        }

        private void btnfruit_Click(object sender, EventArgs e)
        {
            CheckBox[] chbFruits = { chbfruit1, chbfruit2, chbfruit3, chbfruit4, chbfruit5 };

            List<string> fruits = new List<string>();

            foreach (CheckBox chb in chbFruits)
            {
                if(chb.Checked)
                {
                    fruits.Add(chb.Text);
                }
            }
            btnfruit.Text = "������ ���� : " + String.Join(",", fruits);
        }

        private void lbResultFruit_Click(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void PASSWORD_SHOW_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdresultgender_Click(object sender, EventArgs e)
        {
            if(rdmale.Checked)
            {
                rbgenderresultbox.Text = " ��� : ����";
            }
            else
            {

                rbgenderresultbox.Text = " ��� : ����";
            }
        }

        private void rdresultyear_Click(object sender, EventArgs e)
        {
            if(rdyear1.Checked)
            {
                rbgenderresultbox.Text = "��� : 1�г�";
            }
            else if(rdyear2.Checked)
            {
                rbgenderresultbox.Text = "��� : 2�г�";
            }
            else if (rdyear3.Checked)
            {
                rbgenderresultbox.Text = "��� : 3�г�";
            }
            else if (rdyear4.Checked)
            {
                rbgenderresultbox.Text = "��� : 4�г�";
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();

           
        }

        private void btnForm2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }

        private void OK1_Click(object sender, EventArgs e)
        {
            string uid = IDBOX.Text;
            ID_SHOW.Text = "��� : " + uid;
        }

        private void OK2_Click(object sender, EventArgs e)
        {
            NAME_SHOW.Text = "��� : " + NAMEBOX.Text;
        }

        private void OK3_Click(object sender, EventArgs e)
        {
            PASSWORD_SHOW.Text = "��� : " + PASSWORD_BOX.Text;
        }

        private void btnForm3_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.ShowDialog();
        }

        private void btnform4_Click(object sender, EventArgs e)
        {
            new Form4().ShowDialog();
        }
    }
}