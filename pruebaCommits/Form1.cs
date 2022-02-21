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
        String movies;
        String peliculas;
        String comer;
        String jugar;
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
            if (checkBox1.Checked)
            {
                movies = checkBox1.Text;
            }
            if (checkBox2.Checked)
            {
                peliculas = checkBox2.Text;
            }
            if (checkBox3.Checked)
            {
                jugar = checkBox3.Text;
            }
            if (checkBox4.Checked)
            {
                comer= checkBox4.Text;
            }

            label6.Text = "Nombre: "+nombre+"\n"+
                          "Curso: "+ curso+"\n"+
                           "Apellido: " + apellido+"\n"
                           +"Sexo: "+ sexo
                           +"\n me Gusta"+movies
                           +"\n" + peliculas
                           +"\n" + jugar
                           + "\n" + comer; 
        }
    }
}
