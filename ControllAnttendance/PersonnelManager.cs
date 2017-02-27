using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ControllAnttendance.ModelTwo;
namespace ControllAnttendance
{
    public partial class PersonnelManager : Form
    {
        public PersonnelManager()
        {
            InitializeComponent();
        }
        AddPersonnelss AddPersonne = new AddPersonnelss();
        private void button1_Click(object sender, EventArgs e)
        {
            AddPersonne.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (var Db = new ModelTwoContext())
            {
                int id = int.Parse(textBox1.Text);
                var Person = Db.Personnels.Where(x => x.Id == id).ToList();

                foreach(var a in Person)
                {
                    LastName.Text = a.LastName;
                    Names.Text = a.Name;
                    MiddleName.Text = a.LastName;
                    pictureBox1.Image = Helper.byteArrayToImage(a.Photo);
                }
            }
            
        }
    }
}
