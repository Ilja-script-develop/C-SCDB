using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Управление_БД
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataBaseDataSet.Состав_семьи". При необходимости она может быть перемещена или удалена.
            this.состав_семьиTableAdapter1.Fill(this.dataBaseDataSet.Состав_семьи);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataBaseDataSet1.Штатное_расписание". При необходимости она может быть перемещена или удалена.
            this.штатное_расписаниеTableAdapter.Fill(this.dataBaseDataSet1.Штатное_расписание);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataBaseDataSet1.Сотрудник". При необходимости она может быть перемещена или удалена.
            this.сотрудникTableAdapter.Fill(this.dataBaseDataSet1.Сотрудник);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.состав_семьиTableAdapter1.Update(this.dataBaseDataSet.Состав_семьи);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.штатное_расписаниеTableAdapter.Update(this.dataBaseDataSet1.Штатное_расписание);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.сотрудникTableAdapter.Update(this.dataBaseDataSet1.Сотрудник);

        }


     

       
       


       

       
    }
}
