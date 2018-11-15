using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace IdeaWoodTeste
{
    public partial class DashBoard : Form
    {

        public DashBoard()
        {
            InitializeComponent();
        }

        private void bGerarMapa_Click(object sender, EventArgs e)
        {
           //VALIDAR QUANDO A PESSOA NAO SELECIONAR NENHUM MAPA TRY CATC?
           ///////////////////////////////////////////////////////////////////////////
            ReportDocument cryRpt = new ReportDocument();
            cryRpt.Load("C:\\Users\\JSemedo\\documents\\visual studio 2015\\Projects\\IdeaWoodTeste\\IdeaWoodTeste\\" + FuncaoGerarMapa() + ".rpt");
            cryRpt.DataSourceConnections.Clear();
            cryRpt.DataSourceConnections[0].IntegratedSecurity = true;

            ParameterValues crParameterValues = new ParameterValues();


            ParameterDiscreteValue crParameterDiscreteValue = new ParameterDiscreteValue();

            //Parametro Datadesde
            ParameterFieldDefinitions crParameterFieldDefinitions;
            ParameterFieldDefinition crParameterFieldDefinition;
            crParameterDiscreteValue.Value = monthCalendar1.SelectionRange.Start.ToString();
            crParameterFieldDefinitions = cryRpt.DataDefinition.ParameterFields;
            crParameterFieldDefinition = crParameterFieldDefinitions["Datadesde"];
            crParameterValues = crParameterFieldDefinition.CurrentValues;
            crParameterValues.Clear();
            crParameterValues.Add(crParameterDiscreteValue);
            crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);

            //Parametro DataAté
            crParameterDiscreteValue.Value = monthCalendar2.SelectionRange.Start.ToString();
            crParameterFieldDefinitions = cryRpt.DataDefinition.ParameterFields;
            crParameterFieldDefinition = crParameterFieldDefinitions["DataAte"];
            crParameterValues = crParameterFieldDefinition.CurrentValues;
            crParameterValues.Clear();
            crParameterValues.Add(crParameterDiscreteValue);
            crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);


            crystalReportViewer1.ReportSource = cryRpt;
            crystalReportViewer1.Refresh();
        }

        public string FuncaoGerarMapa()
        {
          
            string nomemapa = null;

            if (checkIndividualMensal.Checked == true)
            {
                nomemapa = "Colaborador_Dias";
            }
            if (CheckIndividualPorObra.Checked == true)
            {
                nomemapa = "Colaborador_Obra";
            }
            if (checkIndividualPorTipo.Checked == true)
            {
                nomemapa = "Individual_por_tipo(E,D,V)";
            }
            if (checkObraPorTipo.Checked == true)
            {
                nomemapa = "Obra_Tarefa";
            }
            if (checkobraportotaldehoras.Checked == true)
            {
                nomemapa = "Obra_por_total_Horas";
            }
            //else
            //{
            //    MessageBox.Show("Selecione o mapa pretendido");
            //}

            return nomemapa;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FuncaoGerarMapa();
            
        }
    }

}

