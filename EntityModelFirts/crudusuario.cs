using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityModelFirts
{
    public partial class crudusuario : UserControl
    {
        public crudusuario()
        {
            InitializeComponent();
            cbmTipo.DropDownStyle = ComboBoxStyle.DropDownList;
            cbmestado.DropDownStyle = ComboBoxStyle.DropDownList;
            cbmModificar.DropDownStyle = ComboBoxStyle.DropDownList;
            cbmuser.DropDownStyle = ComboBoxStyle.DropDownList;

            using (Model2 model = new Model2())
            {
                listusuarios.DataSource = model.usuarios.ToList();

            }
            using (Model2 model = new Model2())
            {
                cbmuser.DataSource = model.usuarios.ToList();
                cbmuser.DisplayMember = "usuario";
                cbmuser.ValueMember = "id";
                cbmModificar.DataSource = model.usuarios.ToList();
                cbmModificar.DisplayMember = "usuario";
                cbmModificar.ValueMember = "id";


            }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (Model2 model = new Model2())
            {
                usuarios usuario1 = new usuarios();
                usuario1.usuario = nombre.Text;
                usuario1.passwd = password.Text;
                usuario1.estado = cbmestado.SelectedItem.ToString();
                usuario1.tipo_usuario = cbmTipo.SelectedItem.ToString();
                model.usuarios.Add(usuario1);
                model.SaveChanges();
                MessageBox.Show("Usuario agregado");
                nombre.Text = "";
                password.Text = "";
                cbmestado.Text = "";
                cbmTipo.Text= "";
                listusuarios.DataSource = model.usuarios.ToList();
                cbmuser.DataSource = model.usuarios.ToList();
                cbmModificar.DataSource = model.usuarios.ToList();



            }

        }

        private void tabPage4_Click(object sender, EventArgs e)
        {
            
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void usuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using(Model2 model = new Model2()){
               usuarios usuario1 = model.usuarios.Where(x => x.id == (int)cbmuser.SelectedValue).FirstOrDefault();
                model.usuarios.Remove(usuario1);
                model.SaveChanges();
                MessageBox.Show("Usuario eliminado");
                nombre.Text = "";
                password.Text = "";
                cbmestado.Text = "";
                cbmTipo.Text= "";

                cbmuser.DataSource = model.usuarios.ToList();
                listusuarios.DataSource = model.usuarios.ToList();
                cbmModificar.DataSource = model.usuarios.ToList();

            }
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (Model2 model = new Model2())
            {
                usuarios usuario1 = model.usuarios.Where(x => x.id == (int)cbmModificar.SelectedValue).FirstOrDefault();
                nombrem.Text = usuario1.usuario;
                passwordm.Text = usuario1.passwd;
                cbmEstadom.Text = usuario1.estado;
                cbmTipom.Text = usuario1.tipo_usuario;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (Model2 model = new Model2())
            {
                usuarios usuario1 = model.usuarios.Where(x => x.id == (int)cbmModificar.SelectedValue).FirstOrDefault();
                usuario1.usuario = nombrem.Text;
                usuario1.passwd = passwordm.Text;
                usuario1.estado = cbmEstadom.SelectedItem.ToString();
                usuario1.tipo_usuario = cbmTipom.SelectedItem.ToString();
                model.SaveChanges();
                MessageBox.Show("Usuario modificado");
                nombrem.Text = "";
                passwordm.Text = "";
                cbmEstadom.Text = "";
                cbmTipom.Text = "";
                cbmModificar.DataSource = model.usuarios.ToList();
                listusuarios.DataSource = model.usuarios.ToList();
                cbmuser.DataSource = model.usuarios.ToList();

            }
        }
    }
 }

