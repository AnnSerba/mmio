using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace mmio2
{
    public partial class Hello : Form
    {
        public List<Дробь> FuncCeli = new List<Дробь>();
        public List<СтрокаОграничения> Ogranichenia = new List<СтрокаОграничения>();
        public Opt opt = Opt.Max;
        public Hello()
        {
            InitializeComponent();
            DataGridViewTextBoxColumn newColumnFC1 = new DataGridViewTextBoxColumn();
            newColumnFC1.HeaderText = "X[" + (dataGridViewФункцияЦели.Columns.Count - 1) + "]";
            newColumnFC1.Name = "X" + (dataGridViewФункцияЦели.Columns.Count - 1);
            dataGridViewФункцияЦели.Columns.Insert(dataGridViewФункцияЦели.Columns.Count - 2, newColumnFC1);

            DataGridViewTextBoxColumn newColumnFC2 = new DataGridViewTextBoxColumn();
            newColumnFC2.HeaderText = "X[" + (dataGridViewФункцияЦели.Columns.Count - 1) + "]";
            newColumnFC2.Name = "X" + (dataGridViewФункцияЦели.Columns.Count - 1);
            dataGridViewФункцияЦели.Columns.Insert(dataGridViewФункцияЦели.Columns.Count - 2, newColumnFC2);
            
            dataGridViewФункцияЦели.Rows.Add();
            dataGridViewФункцияЦели.Rows[0].Cells[0].Value = 1;
            dataGridViewФункцияЦели.Rows[0].Cells[1].Value = 1;
            DataGridViewComboBoxCell dgvOpt = new DataGridViewComboBoxCell();
            dgvOpt.Items.Add(Opt.Max.ToString());
            dgvOpt.Items.Add(Opt.Min.ToString());
            dataGridViewФункцияЦели.Rows[0].Cells[3] = dgvOpt;
            dataGridViewФункцияЦели.Rows[0].Cells[3].Value = dgvOpt.Items[0];


            DataGridViewTextBoxColumn newColumnOg1 = new DataGridViewTextBoxColumn();
            newColumnOg1.HeaderText = "X[" + (dataGridViewОграничения.Columns.Count - 1) + "]";
            newColumnOg1.Name = "X" + (dataGridViewОграничения.Columns.Count - 1);
            dataGridViewОграничения.Columns.Insert(dataGridViewОграничения.Columns.Count - 2, newColumnOg1);

            DataGridViewTextBoxColumn newColumnOg2 = new DataGridViewTextBoxColumn();
            newColumnOg2.HeaderText = "X[" + (dataGridViewОграничения.Columns.Count - 1) + "]";
            newColumnOg2.Name = "X" + (dataGridViewОграничения.Columns.Count - 1);
            dataGridViewОграничения.Columns.Insert(dataGridViewОграничения.Columns.Count - 2, newColumnOg2);

            dataGridViewОграничения.Rows.Add();
            dataGridViewОграничения.Rows[0].Cells[0].Value = 1;
            dataGridViewОграничения.Rows[0].Cells[1].Value = 1;
            DataGridViewComboBoxCell dgvЗнак0 = new DataGridViewComboBoxCell();
            dgvЗнак0.Items.Add(">=");
            dgvЗнак0.Items.Add("<=");
            dgvЗнак0.Items.Add("=");
            dataGridViewОграничения.Rows[0].Cells[2] = dgvЗнак0;
            dataGridViewОграничения.Rows[0].Cells[2].Value = dgvЗнак0.Items[1];
            dataGridViewОграничения.Rows[0].Cells[3].Value = 4;

            dataGridViewОграничения.Rows.Add();
            dataGridViewОграничения.Rows[1].Cells[0].Value = 3;
            dataGridViewОграничения.Rows[1].Cells[1].Value = 1;
            DataGridViewComboBoxCell dgvЗнак1 = new DataGridViewComboBoxCell();
            dgvЗнак1.Items.Add(">=");
            dgvЗнак1.Items.Add("<=");
            dgvЗнак1.Items.Add("=");
            dataGridViewОграничения.Rows[1].Cells[2] = dgvЗнак1;
            dataGridViewОграничения.Rows[1].Cells[2].Value = dgvЗнак1.Items[1];
            dataGridViewОграничения.Rows[1].Cells[3].Value = 4;

            dataGridViewОграничения.Rows.Add();
            dataGridViewОграничения.Rows[2].Cells[0].Value = 1;
            dataGridViewОграничения.Rows[2].Cells[1].Value = 5;
            DataGridViewComboBoxCell dgvЗнак2 = new DataGridViewComboBoxCell();
            dgvЗнак2.Items.Add(">=");
            dgvЗнак2.Items.Add("<=");
            dgvЗнак2.Items.Add("=");
            dataGridViewОграничения.Rows[2].Cells[2] = dgvЗнак2;
            dataGridViewОграничения.Rows[2].Cells[2].Value = dgvЗнак2.Items[1];
            dataGridViewОграничения.Rows[2].Cells[3].Value = 4;
        }

        private void buttonДобавитьСистему_Click(object sender, EventArgs e)
        {
            dataGridViewОграничения.Rows.Add();
            DataGridViewComboBoxCell dgvЗнак = new DataGridViewComboBoxCell();
            dgvЗнак.Items.Add(">=");
            dgvЗнак.Items.Add("<=");
            dgvЗнак.Items.Add("=");
            dataGridViewОграничения.Rows[dataGridViewОграничения.Rows.Count - 1].Cells[dataGridViewОграничения.Columns.Count - 2] = dgvЗнак;
            dataGridViewОграничения.Rows[dataGridViewОграничения.Rows.Count - 1].Cells[dataGridViewОграничения.Columns.Count - 2].Value = dgvЗнак.Items[0];
      
        }

        private void buttonДобавитьПеременную_Click(object sender, EventArgs e)
        {
            DataGridViewTextBoxColumn newColumnFC = new DataGridViewTextBoxColumn();
            newColumnFC.HeaderText = "X[" + (dataGridViewФункцияЦели.Columns.Count - 1) + "]";
            newColumnFC.Name = "X" + (dataGridViewФункцияЦели.Columns.Count - 1);
            dataGridViewФункцияЦели.Columns.Insert(dataGridViewФункцияЦели.Columns.Count - 2, newColumnFC);

            DataGridViewTextBoxColumn newColumnOg = new DataGridViewTextBoxColumn();
            newColumnOg.HeaderText = "X[" + (dataGridViewОграничения.Columns.Count - 1) + "]";
            newColumnOg.Name = "X" + (dataGridViewОграничения.Columns.Count - 1);
            dataGridViewОграничения.Columns.Insert(dataGridViewОграничения.Columns.Count - 2, newColumnOg);
        }

        private void buttonУдалитьСистему_Click(object sender, EventArgs e)
        {
            if (dataGridViewОграничения.Rows.Count > 1)
            {
                dataGridViewОграничения.Rows.RemoveAt(dataGridViewОграничения.Rows.Count - 1); ;
            }
        }

        private void buttonУдалитьПеременную_Click(object sender, EventArgs e)
        {

            if (dataGridViewФункцияЦели.Columns.Count > 4)
            {
                dataGridViewФункцияЦели.Columns.RemoveAt(dataGridViewФункцияЦели.Columns.Count - 3);
                dataGridViewОграничения.Columns.RemoveAt(dataGridViewОграничения.Columns.Count - 3);
            }
        }

        public bool ПроверкаПравельностиВведённойСтроки(string st)
        {
            bool flag = false;
            int знаменатель = 0;
            for (int k = 0; k < st.Length; k++)
            {
                if (k == 0 && st[k] == '-')
                {
                }
                else
                {
                    int res = 0;
                    if (st[k] != '/' && int.TryParse(st[k].ToString(), out res) == false)
                    {
                        return false;
                    }
                    if (k == st.Length - 1 && st[k] == '/')
                    {
                        return false;
                    }
                    if (k == 0 && st[k] == '/')
                    {
                        return false;
                    }
                    if (st[k] == '/')
                    {
                        flag = true;
                    }
                    if (flag == true)
                    {
                        знаменатель += res;
                    }
                }
            }
            if (знаменатель == 0)
            {
                return false;
            }
                
            return true;
        }
        public Дробь ИзStringВДробь(string st)
        {
            int числитель = 0, знаменатель = 0, знак = 1;
            bool flag = false;
            for (int k = 0; k < st.Length; k++)
            {
                if (flag == false)
                {
                    if (k == 0 && st[k] == '-')
                    {
                        знак = -1;
                    }
                    else
                    {
                        int res = 0;
                        if (int.TryParse(st[k].ToString(), out res) == true)
                        {
                            числитель += res;
                        }
                        else
                        {
                            flag = true;
                        }
                    }
                }
                else
                {
                    int res = 0;
                    int.TryParse(st[k].ToString(), out res);
                    
                        знаменатель += res;
                    
                }
            }
            return new Дробь(знак*числитель,знаменатель);
        }
        private void buttonРешить_Click(object sender, EventArgs e)
        {
            FuncCeli.Clear();
            Ogranichenia.Clear();
            bool flag = true;
            for (int i = 0; i < dataGridViewФункцияЦели.Rows[0].Cells.Count - 2; i++)
            {
                int res = 0;
                if (int.TryParse(dataGridViewФункцияЦели.Rows[0].Cells[i].Value + "", out res) == true)
                {
                    FuncCeli.Add(new Дробь(res));
                }
                else
                {
                    if (ПроверкаПравельностиВведённойСтроки(dataGridViewФункцияЦели.Rows[0].Cells[i].Value.ToString()) == true)
                    {
                        FuncCeli.Add(ИзStringВДробь(dataGridViewФункцияЦели.Rows[0].Cells[i].Value.ToString()));
                    }
                    else
                    {
                        MessageBox.Show("Ошибка ввода функции цели. Элемент" + (i+1));
                        flag = false;
                    }

                }
            }
            if (dataGridViewФункцияЦели.Rows[0].Cells[dataGridViewФункцияЦели.Rows[0].Cells.Count - 1].Value.ToString() == Opt.Max+"")
            {
                opt = Opt.Max;
            }
            else
            {
                opt = Opt.Min;
            }
            for (int i = 0; i < dataGridViewОграничения.Rows.Count; i++)
            {
                Ogranichenia.Add(new СтрокаОграничения());
                for (int j = 0; j < dataGridViewОграничения.Rows[i].Cells.Count; j++)
                {
                    if (j == dataGridViewОграничения.Rows[i].Cells.Count - 2)
                    {
                        Ogranichenia[i].Знак = dataGridViewОграничения.Rows[i].Cells[j].Value.ToString();
                    }
                    else
                    {
                        int res = 0;
                        if (int.TryParse(dataGridViewОграничения.Rows[i].Cells[j].Value + "", out res) == true)
                        {
                            if (j == dataGridViewОграничения.Rows[i].Cells.Count - 1)
                            {
                                Ogranichenia[i].СвободныйЧлен = new Дробь(res); ;
                            }
                            else
                            {
                                Ogranichenia[i].Строка.Add(new Дробь(res));
                            }
                        }
                        else
                        {
                            if (ПроверкаПравельностиВведённойСтроки(dataGridViewОграничения.Rows[0].Cells[i].Value.ToString()) == true)
                            {
                                if (j == dataGridViewОграничения.Rows[i].Cells.Count - 1)
                                {
                                    Ogranichenia[i].СвободныйЧлен = ИзStringВДробь(dataGridViewОграничения.Rows[0].Cells[i].Value.ToString());
                                }
                                else
                                {
                                    Ogranichenia[i].Строка.Add(ИзStringВДробь(dataGridViewОграничения.Rows[0].Cells[i].Value.ToString()));
                                }
                                
                            }
                            else
                            {
                                MessageBox.Show("Ошибка ввода ограничения. Элемент в " + (i + 1) + "-й стоке " + (j + 1) + "-й");
                                flag = false;
                            }
                        }
                    }
                }
            }
            if (flag == true)
            {
                Solve solve = new Solve(FuncCeli, Ogranichenia, opt);
            }
        }

        private void buttonВыход_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
