using RestSharp;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace WebapiSunat
{
    public partial class frmValidarDocumentoSunat : Form
    {
        string sToken { get; set; }
        string sResultado { get; set; }
        string sQuery { get; set; }
        string sCia = "02";       
        
        public frmValidarDocumentoSunat()
        {
            InitializeComponent();                  
        }

        private DataTable sqlConexion()
        {
            clsConexion cnn = new clsConexion();
            DataTable lista = new DataTable();
            SqlCommand cmd = new SqlCommand("SP_WBAPI_DOCUMETO_CC", cnn.conexion);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@sCia", "02");
            if (cboTipoDoc.SelectedValue == null)
            cmd.Parameters.AddWithValue("@tipodoc","");
            else
            cmd.Parameters.AddWithValue("@tipodoc", cboTipoDoc.SelectedValue);
            cmd.Parameters.AddWithValue("@FechaInicio", dtFechaInicio.Value.ToString("yyyy/MM/dd"));
            cmd.Parameters.AddWithValue("@FechaFin", dtFechaFin.Value.ToString("yyyy/MM/dd"));
            SqlDataReader dr = cmd.ExecuteReader();
            lista.Load(dr);
            cnn.Cerrar();
            return lista;           
        }

        private DataTable sqlComboxTipoDoc()
        {
            clsConexion cnn = new clsConexion();
            DataTable lista = new DataTable();
            SqlCommand cmd = new SqlCommand("SP_WBAPI_TIPO_DOCUMENTO", cnn.conexion);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@sCia","02");
            SqlDataReader dr = cmd.ExecuteReader();
            lista.Load(dr);
            cnn.Cerrar();
            return lista;
        }

        private void sqlUpdate_DocumentoCC()
        {
            clsConexion cnn = new clsConexion();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sQuery, cnn.conexion);
            da.Fill(dt);
        }
        private void comboxTipoDoc()
        {
            cboTipoDoc.DisplayMember = "descripcion";
            cboTipoDoc.ValueMember = "id_tipo_doc";
            cboTipoDoc.DataSource = sqlComboxTipoDoc();     
        }
  
        private void apiToken()
        {
            var client = new RestClient("https://api-seguridad.sunat.gob.pe/v1/clientesextranet/d20518d7-4b32-4ea9-bb02-10d0a8784231/oauth2/token/");
            var request = new RestRequest(Method.POST);
            request.AddHeader("cache-control", "no-cache");
            request.AddHeader("Connection", "keep-alive");
            request.AddHeader("Cookie", "TS010973df=014dc399cbc46f7f5db35c706f2c5774ad37c5497a84aa13ef26fc47115e10a2196b45eb2c02a523b5dbe3ce0eadc575024b7cc41a");
            request.AddHeader("Content-Length", "196");
            request.AddHeader("Accept-Encoding", "gzip, deflate");
            request.AddHeader("Host", "api-seguridad.sunat.gob.pe");
            request.AddHeader("Postman-Token", "3c7de252-88c7-4866-8ba0-44b800fe0c74,14df5969-1c3b-4d42-9584-58c9dd554e64");
            request.AddHeader("Cache-Control", "no-cache");
            request.AddHeader("Accept", "*/*");
            request.AddHeader("User-Agent", "PostmanRuntime/7.19.0");
            request.AddHeader("Content-Type", "application/x-www-form-urlencoded");
            request.AddParameter("undefined", "grant_type=client_credentials&scope=https%3A%2F%2Fapi.sunat.gob.pe%2Fv1%2Fcontribuyente%2Fcontribuyentes&client_id=d20518d7-4b32-4ea9-bb02-10d0a8784231&client_secret=KZkya6crYOm9ZeeHg0%2BE3g%3D%3D", ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);
            sToken = response.Content.Substring(17,3221);
            txtToken.Text = "Bearer" +" "+ sToken;
           
        }

        private void ApiSunat()
        {
            DataTable dt = new DataTable();
            dt = sqlConexion();
            try
            {
                GridViewListado.Rows.Clear();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    GridViewListado.Rows.Add(dt.Rows[i][0]);
                    GridViewListado.Rows[i].Cells[0].Value = dt.Rows[i][0].ToString();
                    GridViewListado.Rows[i].Cells[1].Value = dt.Rows[i][1].ToString();
                    GridViewListado.Rows[i].Cells[2].Value = dt.Rows[i][2].ToString();
                    GridViewListado.Rows[i].Cells[3].Value = dt.Rows[i][3].ToString();
                    GridViewListado.Rows[i].Cells[4].Value = dt.Rows[i][4].ToString();
                    GridViewListado.Rows[i].Cells[5].Value = dt.Rows[i][5].ToString();
                    GridViewListado.Rows[i].Cells[6].Value = dt.Rows[i][6].ToString();
                    GridViewListado.Rows[i].Cells[7].Value = dt.Rows[i][7].ToString();

                    var client = new RestClient("https://api.sunat.gob.pe/v1/contribuyente/contribuyentes/20543323862/validarcomprobante");
                    var request = new RestRequest(Method.POST);
                    request.AddHeader("cache-control", "no-cache");
                    request.AddHeader("Connection", "keep-alive");
                    request.AddHeader("Content-Length", "143");
                    request.AddHeader("Accept-Encoding", "gzip, deflate");
                    request.AddHeader("Host", "api.sunat.gob.pe");
                    request.AddHeader("Postman-Token", "60421583-7b53-4ffa-9c3e-294f56f492a8,ba3de686-a6dc-4410-b465-214fdba8e3e2");
                    request.AddHeader("Cache-Control", "no-cache");
                    request.AddHeader("Accept", "*/*");
                    request.AddHeader("User-Agent", "PostmanRuntime/7.19.0");
                    request.AddHeader("Authorization", txtToken.Text);
                    request.AddHeader("Content-Type", "application/json");
                    request.AddParameter("undefined", "{" +
                        "\n\"numRuc\":" + '"' + GridViewListado.Rows[i].Cells[1].Value + '"' + "," +
                        "\n\"codComp\": " + '"' + GridViewListado.Rows[i].Cells[3].Value + '"' + "," +
                        "\n\"numeroSerie\":" + '"' + GridViewListado.Rows[i].Cells[4].Value + '"' + "," +
                        "\n\"numero\":" + '"' + GridViewListado.Rows[i].Cells[5].Value + '"' + "," +
                        "\n\"fechaEmision\":" + '"' + GridViewListado.Rows[i].Cells[6].Value + '"' + "," +
                        "\n\"monto\":" + '"' + GridViewListado.Rows[i].Cells[7].Value +
                        "\"\n}" +
                        "\n\n" +
                        "\n",
                        ParameterType.RequestBody);
                    IRestResponse response = client.Execute(request);
                    sResultado = response.Content.Substring(68,1);


                    if (sResultado == "0")
                    {
                        sResultado = "No existe";
                    }
                    if (sResultado == "1")
                    {
                        sResultado = "Aceptado";
                    }
                    if (sResultado == "2")
                    {
                        sResultado = "Anulado";
                    }
                    if (sResultado == "3")
                    {
                        sResultado = "Autorizado";
                    }
                    if (sResultado == "4")
                    {
                        sResultado = "No autorizado";
                    }
                    GridViewListado.Rows[i].Cells[8].Value = sResultado;

                }

                    GridViewListado.ClearSelection();
            }
            catch (Exception ex)
            {
                 MessageBox.Show(ex.Message);//throw;
            }
            MessageBox.Show("Proceso Terminado", "Aviso");
        }

        //Update al SQL columna set validacion_cpe_sunat
        private void btnCargar_Click(object sender, EventArgs e)
        {
            clsConexion cnn = new clsConexion();
            //cnn.conexion.
            SqlCommand sqlCmd;

            sQuery = "UPDATE documento_cc " + " " +
                     "SET validacion_cpe_sunat=@sRpta " +
                     "WHERE cia=@sCia and sede=@sSede and id_tipo_doc=@sTipoDoc and serie_doc=@sSerieDoc and nro_doc=@sNroDoc ";

            sqlCmd = new SqlCommand(null, cnn.conexion);

            try
            {
                for (int i = 0; i < (GridViewListado.Rows.Count - 1); i++)
                {
                    
                    if (i==0)
                    {
                        sqlCmd.CommandText = "UPDATE documento_cc SET validacion_cpe_sunat=@sRpta " +
                        "WHERE cia=@sCia and sede=@sSede and id_tipo_doc=@sTipoDoc and serie_doc=@sSerieDoc and nro_doc=@sNroDoc ";

                        sqlCmd.Parameters.Add("@sCia", SqlDbType.VarChar, 2);
                        sqlCmd.Parameters["@sCia"].Value = "02";

                        sqlCmd.Parameters.Add("@sSede", SqlDbType.VarChar, 2);
                        sqlCmd.Parameters["@sSede"].Value = GridViewListado.Rows[i].Cells[0].Value;

                        sqlCmd.Parameters.Add("@sTipoDoc", SqlDbType.VarChar, 2);
                        sqlCmd.Parameters["@sTipoDoc"].Value = GridViewListado.Rows[i].Cells[2].Value;

                        sqlCmd.Parameters.Add("@sSerieDoc", SqlDbType.VarChar, 4);
                        sqlCmd.Parameters["@sSerieDoc"].Value = GridViewListado.Rows[i].Cells[4].Value;

                        sqlCmd.Parameters.Add("@sNroDoc", SqlDbType.VarChar, 20);
                        sqlCmd.Parameters["@sNroDoc"].Value = GridViewListado.Rows[i].Cells[5].Value;

                        sqlCmd.Parameters.Add("@sRpta", SqlDbType.VarChar, 100);
                        sqlCmd.Parameters["@sRpta"].Value = GridViewListado.Rows[i].Cells[8].Value;

                        sqlCmd.Prepare();
                        sqlCmd.ExecuteNonQuery();
                    }
                    else
                    {

                        sqlCmd.Parameters["@sCia"].Value = "02";
                        sqlCmd.Parameters["@sSede"].Value = GridViewListado.Rows[i].Cells[0].Value;
                        sqlCmd.Parameters["@sTipoDoc"].Value = GridViewListado.Rows[i].Cells[2].Value;
                        sqlCmd.Parameters["@sSerieDoc"].Value = GridViewListado.Rows[i].Cells[4].Value;
                        sqlCmd.Parameters["@sNroDoc"].Value = GridViewListado.Rows[i].Cells[5].Value;
                        sqlCmd.Parameters["@sRpta"].Value = GridViewListado.Rows[i].Cells[8].Value;
                        sqlCmd.ExecuteNonQuery();

                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally {
                cnn.Cerrar();
            }

            MessageBox.Show("se cargo los datos","Aviso");
        }

        private void expotarExcel()
        {
            try
            {
                ProcessStartInfo startInfo = new ProcessStartInfo();
                DateTime dtfecha = DateTime.Now;
                startInfo.FileName = Path.Combine(@"D:\ExpotarExcel\ValidacionSunat" + Convert.ToString(dtfecha.ToString("dd-MM-yyy")) + ".xls");
                DataTable dt = new DataTable();
                foreach (DataGridViewColumn col in GridViewListado.Columns)
                {
                    dt.Columns.Add(col.HeaderText);
                }

                foreach (DataGridViewRow row in GridViewListado.Rows)
                {
                    DataRow dRow = dt.NewRow();
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if (cell.Value != null)
                        {
                            dRow[cell.ColumnIndex] = cell.Value.ToString();
                        }
                        else
                        {
                            dRow[cell.ColumnIndex] = "";
                        }
                    }
                    dt.Rows.Add(dRow);
                }

                DataSet ds1 = new DataSet();
                ds1.Tables.Add(dt);
                ds1.Locale = System.Threading.Thread.CurrentThread.CurrentCulture;
                //Se crea la hoja excel a partir de la coleccion de datos
                ExcelLibrary.DataSetHelper.CreateWorkbook(startInfo.FileName, ds1);
                Process.Start(startInfo);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmValidarDocumentoSunat_Load(object sender, EventArgs e)
        {
            comboxTipoDoc();
            cboTipoDoc.SelectedIndex = -1;
        }
        private void btnListar_Click(object sender, EventArgs e)
        {
            apiToken();
            ApiSunat();
        }

        private void Exportar_Click(object sender, EventArgs e)
        {
            expotarExcel();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            GridViewListado.Rows.Clear();
        }

    }
}
