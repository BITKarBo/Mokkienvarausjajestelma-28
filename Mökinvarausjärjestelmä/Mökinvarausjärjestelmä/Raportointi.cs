using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mökinvarausjärjestelmä
{
    public partial class Raportointi : Form
    {
        public Raportointi()
        {
            InitializeComponent();
        }
        SQLdataset gds = new SQLdataset();



        private void Raportointi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'vNDataset.toimintaalue' table. You can move, or remove it, as needed.
            this.toimintaalueTableAdapter.Fill(this.vNDataset.toimintaalue);
            // TODO: This line of code loads data into the 'vNDataset.varaus' table. You can move, or remove it, as needed.
            this.varausTableAdapter.Fill(this.vNDataset.varaus);

            cbToimintaalue.SelectedValue = 1; // default 1

            chartMajoitukset.Series["Majoitukset"].XValueMember = "pvm";
            chartMajoitukset.Series[0].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Date;
            chartMajoitukset.Series["Majoitukset"].YValueMembers = "maara";
            chartMajoitukset.Series[0].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;

            chartPalvelut.Series["Palvelut"].XValueMember = "palvelut";
            chartPalvelut.Series[0].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            chartPalvelut.Series["Palvelut"].YValueMembers = "lkm";
            chartPalvelut.Series[0].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;

            //default data
            string sqlcommand = string.Format("SELECT COUNT(varaus.varaus_id) AS `maara`, varaus.varattu_pvm AS `pvm` FROM varaus WHERE varaus.mokki_mokki_id IN(SELECT mokki.mokki_id FROM mokki WHERE mokki.toimintaalue_id = 1) AND varaus.varattu_pvm BETWEEN '2000-1-1' AND '2100-01-1' GROUP BY varaus.varattu_pvm;");

            chartMajoitukset.DataSource = gds.Getdataset(sqlcommand).Tables[0];
            chartMajoitukset.DataBind();

            string sqlcommand1 = string.Format("SELECT varauksen_palvelut.lkm AS `lkm`, palvelu.nimi AS `palvelut` FROM varauksen_palvelut, palvelu WHERE varauksen_palvelut.varaus_id IN(SELECT varaus.varaus_id FROM varaus WHERE varaus.varattu_pvm BETWEEN '2000-1-1' AND '2100-01-1' GROUP BY varaus_id) AND palvelu.nimi IN(SELECT palvelu.nimi FROM palvelu, varauksen_palvelut WHERE palvelu.palvelu_id = varauksen_palvelut.varaus_id AND palvelu.toimintaalue_id = 1)");

            chartPalvelut.DataSource = gds.Getdataset(sqlcommand1).Tables[0];
            chartPalvelut.DataBind();


            string sqlcommandvaraukset = string.Format("SELECT COUNT(varaus.varaus_id) AS `maarat` FROM varaus WHERE varaus.mokki_mokki_id IN(SELECT mokki.mokki_id FROM mokki WHERE mokki.toimintaalue_id = 1) AND varaus.varattu_pvm BETWEEN '2000-1-1' AND '2100-01-1' GROUP BY varaus.varattu_pvm;");
            string varauksetlbl = "Varausten Määrä: " + gds.Getdataset(sqlcommandvaraukset).Tables[0].Rows[1]["maarat"].ToString();
            lblvaraukset.Text = varauksetlbl;

            string sqlcommandpalvelut = string.Format("SELECT SUM(varauksen_palvelut.lkm) AS `lkm` FROM varaus, varauksen_palvelut WHERE varaus.mokki_mokki_id IN(SELECT mokki.mokki_id FROM mokki WHERE mokki.toimintaalue_id = {0}) AND varaus.varattu_pvm BETWEEN '{1:yyyy/MM/dd}' AND '{2:yyyy/MM/dd}' GROUP BY varaus.varattu_pvm;", cbToimintaalue.SelectedValue, dateTimePickerAloitus.Value, dateTimePickerLopetus.Value);
            string palvelutlbl = "Palveluiden Määrä: " + gds.Getdataset(sqlcommandpalvelut).Tables[0].Rows[0]["lkm"].ToString();
            lblPalveluidenmaara.Text = palvelutlbl;
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            
            if (tcontrolRaportit.SelectedTab == PageMajoitukset)
            {

                // Query jolla saadaan varaukset joissa mökki toimialue tietty. määrä eroteltuna päivämäärillä.
                string sqlcommand = string.Format("SELECT COUNT(varaus.varaus_id) AS `maara`, varaus.varattu_pvm AS `pvm` FROM varaus WHERE varaus.mokki_mokki_id IN(SELECT mokki.mokki_id FROM mokki WHERE mokki.toimintaalue_id = {0}) AND varaus.varattu_pvm BETWEEN '{1:yyyy/MM/dd}' AND '{2:yyyy/MM/dd}' GROUP BY varaus.varattu_pvm;", cbToimintaalue.SelectedValue, dateTimePickerAloitus.Value, dateTimePickerLopetus.Value);

                chartMajoitukset.DataSource = gds.Getdataset(sqlcommand).Tables[0];
                chartMajoitukset.DataBind();
                try
                {

                    string sqlcommandvaraukset = string.Format("SELECT COUNT(varaus.varaus_id) AS `maarat` FROM varaus WHERE varaus.mokki_mokki_id IN(SELECT mokki.mokki_id FROM mokki WHERE mokki.toimintaalue_id = {0}) AND varaus.varattu_pvm BETWEEN '{1:yyyy/MM/dd}' AND '{2:yyyy/MM/dd}' GROUP BY varaus.varattu_pvm;", cbToimintaalue.SelectedValue, dateTimePickerAloitus.Value, dateTimePickerLopetus.Value);
                    string varauksetlbl = "Varausten Määrä: " + gds.Getdataset(sqlcommandvaraukset).Tables[0].Rows[1]["maarat"].ToString();
                    lblvaraukset.Text = varauksetlbl;
                }
                catch (Exception ex)
                {
                    lblvaraukset.Text = "Varausten Määrä: 0";
                    Console.Write(ex.Message);
                }

            }
            else
            {

                // Toinen Query palveluille. Query jossa varauksen_palvelut kaikki menneet palvelut ja lkm eroteltuna varaus ID:llä

                string sqlcommand1 = string.Format("SELECT varauksen_palvelut.lkm AS `lkm`, palvelu.nimi AS `palvelut` FROM varauksen_palvelut, palvelu WHERE varauksen_palvelut.varaus_id IN(SELECT varaus.varaus_id FROM varaus WHERE varaus.varattu_pvm BETWEEN '{0:yyyy/MM/dd}' AND '{1:yyyy/MM/dd}' GROUP BY varaus_id) AND palvelu.nimi IN(SELECT palvelu.nimi FROM palvelu, varauksen_palvelut WHERE palvelu.palvelu_id = varauksen_palvelut.varaus_id AND palvelu.toimintaalue_id = {2})", dateTimePickerAloitus.Value, dateTimePickerLopetus.Value, cbToimintaalue.SelectedValue);

                chartPalvelut.DataSource = gds.Getdataset(sqlcommand1).Tables[0];
                chartPalvelut.DataBind();
                try
                {

                    string sqlcommandpalvelut = string.Format("SELECT SUM(varauksen_palvelut.lkm) AS `lkm` FROM varaus, varauksen_palvelut WHERE varaus.mokki_mokki_id IN(SELECT mokki.mokki_id FROM mokki WHERE mokki.toimintaalue_id = {0}) AND varaus.varattu_pvm BETWEEN '{1:yyyy/MM/dd}' AND '{2:yyyy/MM/dd}' GROUP BY varaus.varattu_pvm;", cbToimintaalue.SelectedValue, dateTimePickerAloitus.Value, dateTimePickerLopetus.Value);
                    string palvelutlbl = "Palveluiden Määrä: " + gds.Getdataset(sqlcommandpalvelut).Tables[0].Rows[0]["lkm"].ToString();
                    lblPalveluidenmaara.Text = palvelutlbl;
                }
                catch (Exception ex)
                {
                    lblPalveluidenmaara.Text = "Palveluiden Määrä: 0";
                    Console.Write(ex.Message);
                }
            }
        }

        private void btnPiirakka_Click(object sender, EventArgs e)
        {
            if (tcontrolRaportit.SelectedTab == PageMajoitukset)
            {
                chartMajoitukset.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            }
            else
            {
                chartPalvelut.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            }
        }

        private void btn3D_Click(object sender, EventArgs e)
        {
            if (tcontrolRaportit.SelectedTab == PageMajoitukset)
            {
                chartMajoitukset.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pyramid;
            }
            else
            {
                chartPalvelut.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pyramid;
            }
        }

        private void btnPylväs_Click(object sender, EventArgs e)
        {
            if (tcontrolRaportit.SelectedTab == PageMajoitukset)
            {
                chartMajoitukset.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            }
            else
            {
                chartPalvelut.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            }
        }
    }
}
