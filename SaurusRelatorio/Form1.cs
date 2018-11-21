using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


// Exportar PDF
using System.IO;
using System.Reflection;
using iTextSharp.text.pdf;
using iTextSharp.text;

namespace SaurusRelatorio
{
    public partial class frmPrincipal : Form
    {
        string connectionString = @"Data Source=(localdb)\mssqllocaldb; Initial Catalog = dbsaurus_pdvfit; Integrated Security=True;";
        string var_query;
        string var_btn;

        public void statusBtn()
        {
            btnTeste.BackColor = System.Drawing.Color.DarkBlue;
            btnVendaCupomTrib.BackColor = System.Drawing.Color.DarkBlue;

            switch (var_btn)
            {
                case "teste":
                    btnTeste.BackColor = System.Drawing.Color.Green;
                    break;
                case "vendacupomtrib":
                    btnVendaCupomTrib.BackColor = System.Drawing.Color.Green;
                    break;
            }
        }

        public void chamarBtnClick()
        {
            switch (var_btn)
            {
                case "vendacupomtrib":
                    btnVendaCupomTrib.PerformClick();
                    break;              
            }

        }

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnVendaCupomTrib_Click(object sender, EventArgs e)
        {
            var_btn = "vendacupomtrib";
            statusBtn();

            using (SqlConnection sqlCon = new SqlConnection(connectionString)) {
                sqlCon.Open();

                var_query = "SELECT COUNT(DISTINCT tbProd.prod_idMov) AS qtdVendas, " +
                     "SUM(IIF(indImposto = 'TT', vFinal, 0))  AS Icms_vBc,  " +
                     "SUM(prod_icms_vIcms) AS Icms_vIcms, " +
                     "SUM(IIF(indImposto = 'FF', vFinal, 0))  AS Icms_vlSubst,  " +
                     "SUM(IIF(indImposto = 'II', vFinal, 0))  AS Icms_vlIsento, " +
                     "SUM(IIF(indImposto = 'NN', vFinal, 0))  AS  Icms_vlNaoTrib " +
                     "FROM tbMovDados d " +
                     "INNER JOIN(SELECT " +
                     " p.prod_idMov, " +
                     "p.vFinal, " +
                     "i.prod_icms_cst, " +
                     "i.prod_icms_vBc, " +
                     "i.prod_icms_vIcms, " +
                     "CASE " +
                     "WHEN i.prod_icms_cst IN('10', '60', '70', '201', '202', '203', '500') THEN 'FF' " +
                     "WHEN i.prod_icms_cst IN('40', '41', '400') THEN 'II' " +
                     "WHEN i.prod_icms_cst IN('50', '51', '300') THEN 'NN' " +
                     "ELSE 'TT' " +
                     "END AS indImposto " +
                     "FROM tbMovProdImpostos i " +
                     "INNER JOIN vwMovProd p " +
                     "ON i.prod_idProd = p.prod_idProd " +
                     "  WHERE   p.prod_indStatus = 0 " +
                     ")   AS tbProd " +
                     "ON tbProd.prod_idMov = d.mov_idMov " +
                     "INNER JOIN tbMovSessoes ms " +
                     "ON d.mov_idSessao = ms.mov_idSessao " +
                     "INNER JOIN tbCaixaDados c " +
                     "ON ms.mov_idCaixa = c.cai_idCaixa " +
                     "OUTER APPLY dbo.fn_retMovStatusTable(d.mov_idMov) s " +
                     "WHERE s.mov_indStatus = 2 " +
                     "AND mov_tpAmb = 1 ";                    

                if (dtpInicial.Text.Length > 0) {var_query += "AND d.mov_dhEmi >= '" + dtpInicial.Value.Date.ToString("yyyy-MM-dd") + "' ";}
                if (dtpFinal.Text.Length > 0){var_query += "AND d.mov_dhEmi <= '" + dtpFinal.Value.Date.ToString("yyyy-MM-dd") + "' ";}
                if (tbCaixa.Text.Length > 0) { var_query += "AND c.cai_numCaixa =  '" + tbCaixa.Text + "' "; }

                tbQuery.Text = var_query;
                SqlDataAdapter sqlDa = new SqlDataAdapter(var_query, sqlCon);
                DataTable dtb1 = new DataTable();
                sqlDa.Fill(dtb1);
                dataGridView1.DataSource = dtb1;
            }
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            PdfPTable pdfTable = new PdfPTable(dataGridView1.ColumnCount);
            pdfTable.DefaultCell.Padding = 3;
            pdfTable.WidthPercentage = 30;
            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;
            pdfTable.DefaultCell.BorderWidth = 1;

            //Adding Header row
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                cell.BackgroundColor = new iTextSharp.text.Color(240, 240, 240);
                pdfTable.AddCell(cell);
            }

            //Adding DataRow
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if(cell.Value != null)
                    {
                        pdfTable.AddCell(cell.Value.ToString());
                    }
                    
                }
            }

            //Exporting to PDF
            string folderPath = "C:\\saurus\\";
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }
            using (FileStream stream = new FileStream(folderPath + "DataGridViewExport.pdf", FileMode.Create))
            {
                Document pdfDoc = new Document(PageSize.A2, 10f, 10f, 10f, 0f);
                PdfWriter.GetInstance(pdfDoc, stream);
                pdfDoc.Open();
                pdfDoc.Add(pdfTable);
                pdfDoc.Close();
                stream.Close();
            }

            //Abrindo PDF
            System.Diagnostics.Process.Start("C:\\saurus\\DataGridViewExport.pdf");
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void btnTeste_Click(object sender, EventArgs e)
        {
            var_btn = "teste";
            statusBtn();
            
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                var_query = "SELECT * FROM tbCaixaDados";
                tbQuery.Text = var_query;
                SqlDataAdapter sqlDa = new SqlDataAdapter(var_query, sqlCon);
                DataTable dtb1 = new DataTable();
                sqlDa.Fill(dtb1);
                dataGridView1.DataSource = dtb1;
            }
        }

        private void dtpInicial_ValueChanged(object sender, EventArgs e)
        {
            chamarBtnClick();
        }

        private void dtpFinal_ValueChanged(object sender, EventArgs e)
        {
            chamarBtnClick();
        }

        private void tbCaixa_TextChanged(object sender, EventArgs e)
        {
            chamarBtnClick();
        }
    }
}
