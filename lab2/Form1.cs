using System.Diagnostics;
using System.Xml;
using System.Xml.Xsl;

namespace lab2
{   /*
      17. "Кадри науковців (Пенсія)"
Таблиці містять таку інформацію: П.І.П., факультет
(департамент, відділення), кафедра, дата народження, стать та ін.
     */
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadData();
        }
        public void LoadData()
        {
            var staff = DataLoader.GetData();
            cmb_name.Items.Add(String.Empty);
            cmb_department.Items.Add(String.Empty);
            cmb_gender.Items.Add(String.Empty);
            cmb_age.Items.Add(String.Empty);
            for (int i = 0; i < staff.Count; i++)
            {
                XmlNode teacher = staff.Item(i);
                modifyForm(teacher);
            }

            cmb_age.Items.Add("<30");
            cmb_age.Items.Add("30-50");
            cmb_age.Items.Add("51-65");
            cmb_age.Items.Add(">65");
        }
        public void modifyForm(XmlNode teacher)
        {

            if (!cmb_name.Items.Contains(teacher.Attributes["NAME"].Value))
            {
                cmb_name.Items.Add(teacher.Attributes["NAME"].Value);
            }
            if (!cmb_department.Items.Contains(teacher.Attributes["DEPARTMENT"].Value))
            {
                cmb_department.Items.Add(teacher.Attributes["DEPARTMENT"].Value);
            }
            if (!cmb_gender.Items.Contains(teacher.Attributes["GENDER"].Value))
            {
                cmb_gender.Items.Add(teacher.Attributes["GENDER"].Value);
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
        
        private bool validate_fields()
        {

            return true;
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            if (validate_fields())
            {
                TeacherQuery query = new TeacherQuery();

                if (cmb_name.SelectedItem != null)
                    query.name = cmb_name.SelectedItem.ToString();
                if (cmb_department.SelectedItem != null)
                    query.department = cmb_department.SelectedItem.ToString();
                if (cmb_age.SelectedItem != null)
                    query.age_range = cmb_age.SelectedItem.ToString();
                if (cmb_gender.SelectedItem != null)
                    query.gender = cmb_gender.SelectedItem.ToString();
                ISearchEngine searchEngine;
                searchEngine = new LinqtoXMLSearchEngine();
                if (btn_linq.Checked)
                    searchEngine = new LinqtoXMLSearchEngine();
                else if (btn_dom.Checked)
                    searchEngine = new DomSearchEngine();
                else if (btn_sax.Checked)
                    searchEngine = new SaxSearchEngine();
                else
                {
                    MessageBox.Show("Оберіть спосіб");
                    return;
                }
                List<Teacher> res = searchEngine.search(query);
                box_result.Text = "";
                foreach(Teacher item in res)
                    box_result.Text += item.ToString();
            }

        }

        private void box_result_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataLoader.SaveHTML();
            MessageBox.Show("Успішно Перетворено");
        }

        private void cmb_name_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
        }
    }
}