using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pruebaCommits
{
    public partial class Form1 : Form
    {
        String nombre;
        String curso;
        String apellido;
        String sexo;
        public Form1()
        {
            InitializeComponent();
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            nombre = textBox1.Text;
            curso = textBox2.Text;
            apellido = textBox3.Text;
            sexo = comboBox1.Text;
            label6.Text = "Nombre: "+nombre+"\n"+
                          "Curso: "+ curso+"\n"+
                           "Apellido: " + apellido+"\n"
                           +"Sexo: "+ sexo;
        }
    }
}
