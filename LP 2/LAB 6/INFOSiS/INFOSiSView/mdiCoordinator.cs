using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace INFOSiSView
{
    public partial class mdiCoordinator : Form
    {
        private frmCourseHistoryManager frmcoursehistory;
        private frmCoursesManager frmcourse;
        private frmProfessorManager frmprofessor;
        private frmStudentConsult frmstudentconsult;
        private frmStudentManager frmstudent;
        private frmInterestedMailing frminterestedmail;
        private frmCourseReport frmreportecurso;
        private frmInternReport frmreportepracticante;
        private frmProfessorReport frmreporteprofesor;
        public mdiCoordinator()
        {
            InitializeComponent();
            cambiarEstado(State.New);
        }

        public void fManage_Closingfrm(object sender, FormClosingEventArgs e)
        {
            frmcourse = null;
            frmcoursehistory = null;
            frmprofessor = null;
            frmstudentconsult = null;
            frmstudent = null;
            cambiarEstado(State.New);
        }

        private void gestiónDeCursosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmcourse == null)
            {
                frmcourse = new frmCoursesManager();
                frmcourse.FormClosing += fManage_Closingfrm;
                frmcourse.MdiParent=this;
                cambiarEstado(State.Modify);
            }
            frmcourse.Visible = true;
        }

        private void cambiarEstado(State estado)
        {
            switch (estado)
            {
                case State.New:
                    coursesToolStripMenuItem.Enabled = true;
                    alumnosToolStripMenuItem.Enabled = true;
                    interesadosToolStripMenuItem.Enabled = true;
                    profesoresToolStripMenuItem.Enabled = true;
                    practicantesToolStripMenuItem.Enabled = true;
                    opcionesToolStripMenuItem.Enabled = true;
                    reportesToolStripMenuItem.Enabled = true;
                    break;
                case State.Modify:
                    coursesToolStripMenuItem.Enabled = false;
                    alumnosToolStripMenuItem.Enabled = false;
                    interesadosToolStripMenuItem.Enabled = false;
                    profesoresToolStripMenuItem.Enabled = false;
                    practicantesToolStripMenuItem.Enabled = false;
                    opcionesToolStripMenuItem.Enabled = false;
                    reportesToolStripMenuItem.Enabled = false;
                    break;
            }

        }

        private void gestiónDeCursosDictadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmcoursehistory == null)
            {
                frmcoursehistory = new frmCourseHistoryManager();
                frmcoursehistory.FormClosing += fManage_Closingfrm;
                frmcoursehistory.MdiParent = this;
                cambiarEstado(State.Modify);
            }
            frmcoursehistory.Visible = true;
        }

        private void consultaDeAlumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmstudentconsult == null)
            {
                frmstudentconsult = new frmStudentConsult();
                frmstudentconsult.FormClosing += fManage_Closingfrm;
                frmstudentconsult.MdiParent = this;
                cambiarEstado(State.Modify);
            }
            frmstudentconsult.Visible = true;
        }

        private void gestiónDeAlumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmstudent == null)
            {
                frmstudent = new frmStudentManager();
                frmstudent.FormClosing += fManage_Closingfrm;
                frmstudent.MdiParent=this;
                cambiarEstado(State.Modify);
            }
            frmstudent.Visible = true;
        }

        private void mandarPublicidadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frminterestedmail == null)
            {
                frminterestedmail = new frmInterestedMailing();
                frminterestedmail.FormClosing += fManage_Closingfrm;
                frminterestedmail.MdiParent = this;
                cambiarEstado(State.Modify);
            }
            frminterestedmail.Visible = true;
        }

        private void gestiónDeInteresadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void gestiónDeProfesoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmprofessor == null)
            {
                frmprofessor = new frmProfessorManager();
                frmprofessor.FormClosing += fManage_Closingfrm;
                frmprofessor.MdiParent = this;
                cambiarEstado(State.Modify);
            }
            frmprofessor.Visible = true;
        }

        private void disponibilidadSemanalToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cambiarContraseñaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void gestiónDePracticantesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void reporteDePracticantesToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (frmreportepracticante == null)
            {
                frmreportepracticante = new frmInternReport();
                frmreportepracticante.FormClosing += fManage_Closingfrm;
                frmreportepracticante.MdiParent = this;
                cambiarEstado(State.Modify);
            }
            frmreportepracticante.Visible = true;

        }

        private void reporteDeProfesoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if (frmreporteprofesor == null)
            {
                frmreporteprofesor = new frmProfessorReport();
                frmreporteprofesor.FormClosing += fManage_Closingfrm;
                frmreporteprofesor.MdiParent = this;
                cambiarEstado(State.Modify);
            }
            frmreporteprofesor.Visible = true;
            
        }

        private void reporteDeCursosToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (frmreportecurso == null)
            {
                frmreportecurso = new frmCourseReport();
                frmreportecurso.FormClosing += fManage_Closingfrm;
                frmreportecurso.MdiParent = this;
                cambiarEstado(State.Modify);
            }
            frmreportecurso.Visible = true;

        }
    }
}
