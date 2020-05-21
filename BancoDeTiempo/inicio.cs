using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BancoDeTiempo
{
    public partial class Form1 : Form
    {
        btEntities bet = new btEntities();
        public Form1()
        {
            InitializeComponent();

            //Usuario u = new Usuario();
            //u.nombre_usuario = "Marc Sánchez";
            //u.id_usuario = "56324645X";
            //u.pass = "56643";
            //u.alias = "marcss";
            //u.descripcion = "Profesor de programación";
            //u.email = "marcss@uoc.edu";
            //u.telefono = 645587344;
            //u.fecha_nacimiento = new DateTime(1990, 3, 4);
            //u.balance = 7;

            //Usuario u2 = new Usuario();
            //u2.id_usuario = "50424556D";
            //u2.nombre_usuario = "Enrique Molina";
            //u2.pass = "5w345";
            //u2.alias = "quiquem";
            //u2.descripcion = "Profesor de dibujo";
            //u2.email = "enriquemf@uoc.edu";
            //u2.telefono = 677888446;
            //u2.fecha_nacimiento = new DateTime(1988, 11, 21);
            //u2.balance = 10;

            //GestorBBDD.agregarUsuario(u);
            //GestorBBDD.agregarUsuario(u2);

            //Usuario u = new Usuario();
            //u = GestorBBDD.buscarUsuario("50424556D");
            //Console.WriteLine(u.nombre_usuario);

            //GestorBBDD.eliminarUsuario("50424556D");

            /*Usuario u = new Usuario();
            u = GestorBBDD.buscarUsuario("45352455Y");
            Console.WriteLine(u.nombre_usuario);

            u.nombre_usuario = "Yaiza Santos Fernández";
            GestorBBDD.actualizarUsuario(u);
            u = GestorBBDD.buscarUsuario("45352455Y");
            Console.WriteLine(u.nombre_usuario);*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Servicio s = new Servicio();
            //s.id_servicio = "test";
            //s.titulo = textBox1.Text;
            //s.descripcion = textBox2.Text;
            //s.id_usuario = "56324645X";
            //s.id_categoria = "test";
            //s.tipo_servicio = "1";

            //GestorBBDD.agregarServicio(s);
        }
    }
}
