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
    public partial class AddPersonnelss : Form
    {
        public AddPersonnelss()
        {
            InitializeComponent();
        }

        private void LoadPhoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();

            dlg.Title = "Open Image";
            dlg.Filter = "Image Files (*.bmp;*.jpg;*.jpeg,*.png)|*.BMP;*.JPG;*.JPEG;*.PNG";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(dlg.FileName);
                textBox1.Text = dlg.FileName;

            }
            dlg.Dispose();
        }

        private void Send_Click(object sender, EventArgs e)
        {
            using (var Db = new ModelTwoContext())
            {
                

                Db.Personnels.Add(
                    new Personnel()
                    {
                        Name = Names.Text,
                        LastName = LastName.Text,
                        MiddleName = MiddleName.Text,
                        Photo = Helper.imageToByteArray(pictureBox1.Image)
                    }
                    );
                Db.SaveChanges();
                MessageBox.Show("All is Cool");
            }
        }
    }
}
