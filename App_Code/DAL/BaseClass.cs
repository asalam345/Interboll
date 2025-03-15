using System;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Data.SqlClient;
using System.Collections;


namespace DAL
{
    public class BaseClass
    {

        private SqlDataAdapter _sqldaAdapter;
       // string strConnectionString = ConfigurationManager.ConnectionStrings["cnStr"].ConnectionString;
        string strConnectionString = (WebsiteConfig.ConnectionString);
        //new SqlConnection(WebsiteConfig.ConnectionString),
        //(WebsiteConfig.ConnectionString)
        public BaseClass(string strConnectionString)
        {
         //  strConnectionString = ConfigurationManager.ConnectionStrings["cnStr"].ConnectionString;
            strConnectionString = (WebsiteConfig.ConnectionString);
 
            _sqldaAdapter = new SqlDataAdapter();
            _sqldaAdapter.SelectCommand = new SqlCommand();
            _sqldaAdapter.SelectCommand.Connection = new SqlConnection(strConnectionString);
            _sqldaAdapter.SelectCommand.Connection.Open();
        } // end constructor



        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(true); // as a service to those who might inherit from us
        } // end Dispose


        protected virtual void Dispose(bool disposing)
        {
            if (!disposing)
                return; // we're being collected, so let the GC take care of this object
            if (_sqldaAdapter != null)
            {
                if (_sqldaAdapter.SelectCommand != null)
                {
                    if (_sqldaAdapter.SelectCommand.Connection != null)
                    {
                        _sqldaAdapter.SelectCommand.Connection.Dispose();
                    } // end nested-nested if

                    _sqldaAdapter.SelectCommand.Dispose();
                } // end nested if

                _sqldaAdapter.Dispose();
                _sqldaAdapter = null;
            } // end if
        } // end Dispose

        private void Initialize()
        {
            _sqldaAdapter.SelectCommand.Parameters.Clear();
        } // end Initialize


        protected DataTable ExecuteStoredProcedureDataTable(string strProcedureName, ArrayList arlParams)
        {
            if (_sqldaAdapter == null)
            {
                throw new System.ObjectDisposedException(GetType().FullName);
            } // end if

            Initialize();

            SqlCommand dbCommand = _sqldaAdapter.SelectCommand;
            dbCommand.CommandText = strProcedureName;
            dbCommand.CommandType = CommandType.StoredProcedure;

            if (arlParams != null)
            {
                for (int i = 0; i < arlParams.Count; i++)
                {
                    dbCommand.Parameters.Add(arlParams[i]);
                } // end for
            } // end if


            DataTable dtResult = new DataTable();
            _sqldaAdapter.Fill(dtResult);
            return dtResult;
        } // end ExecuteStoredProcedureDataTable

        protected int ExecuteNonQueryStoredProcedure(string strProcedureName, ArrayList arlParams)
        {
            try
            {
                if (_sqldaAdapter == null)
                {
                    throw new System.ObjectDisposedException(GetType().FullName);
                } // end if

                Initialize();

                int intResult = 0;

                SqlCommand dbCommand = _sqldaAdapter.SelectCommand;
                dbCommand.CommandText = strProcedureName;
                dbCommand.CommandType = CommandType.StoredProcedure;

                if (arlParams != null)
                {
                    for (int i = 0; i < arlParams.Count; i++)
                    {
                        dbCommand.Parameters.Add(arlParams[i]);
                    } // end for
                } // end if

                intResult = dbCommand.ExecuteNonQuery();

                return intResult;
            }
            catch (SqlException ex)
            {
                return ex.Number;
            }
        } // end ExecuteNonQueryStoredProcedure

        protected object ExecuteStoredProcedureScalar(string strProcedureName, ArrayList arlParams)
        {
            if (_sqldaAdapter == null)
            {
                throw new System.ObjectDisposedException(GetType().FullName);
            } // end if

            Initialize();

            object objResult = null;

            SqlCommand dbCommand = _sqldaAdapter.SelectCommand;
            dbCommand.CommandText = strProcedureName;
            dbCommand.CommandType = CommandType.StoredProcedure;

            if (arlParams != null)
            {
                for (int i = 0; i < arlParams.Count; i++)
                {
                    dbCommand.Parameters.Add(arlParams[i]);
                } // end for
            } // end if

            objResult = dbCommand.ExecuteScalar();


            return objResult;
        } // end ExecuteStoredProcedureScalar

        protected object ExecuteSQLStringScalar(string strSQL)
        {
            if (_sqldaAdapter == null)
            {
                throw new System.ObjectDisposedException(GetType().FullName);
            } // end if

            Initialize();

            object objResult = null;

            SqlCommand dbCommand = _sqldaAdapter.SelectCommand;
            dbCommand.CommandText = strSQL;
            dbCommand.CommandType = CommandType.Text;

            objResult = dbCommand.ExecuteScalar();

            return objResult;
        } // end ExecuteSQLStringScalar

        protected DataTable ExecuteSQLStringDataTable(string strSQL)
        {
            if (_sqldaAdapter == null)
            {
                throw new System.ObjectDisposedException(GetType().FullName);
            } // end if

            Initialize();

            SqlCommand dbCommand = _sqldaAdapter.SelectCommand;
            dbCommand.CommandText = strSQL;
            dbCommand.CommandType = CommandType.Text;

            DataTable dtResult = new DataTable();

            _sqldaAdapter.Fill(dtResult);

            return dtResult;
        } // end ExecuteSQLStringDataTable

        protected SqlDataReader ExecuteSQLStringDataReader(string strSQL)
        {
            if (_sqldaAdapter == null)
            {
                throw new System.ObjectDisposedException(GetType().FullName);
            } // end if

            Initialize();

            SqlCommand dbCommand = _sqldaAdapter.SelectCommand;
            dbCommand.CommandText = strSQL;
            dbCommand.CommandType = CommandType.Text;

            SqlDataReader drResult;
            drResult = dbCommand.ExecuteReader();


            return drResult;
        } // end ExecuteSQLStringDataTable

        protected DataSet ExecuteSQLStringDataSet(string strSQL)
        {
            if (_sqldaAdapter == null)
            {
                throw new System.ObjectDisposedException(GetType().FullName);
            } // end if

            Initialize();

            SqlCommand dbCommand = _sqldaAdapter.SelectCommand;
            dbCommand.CommandText = strSQL;
            dbCommand.CommandType = CommandType.Text;

            DataSet dsResult = new DataSet();
            _sqldaAdapter.Fill(dsResult);

            return dsResult;
        } // end ExecuteSQLStringDataTable

        protected DataSet ExecuteSPDataSet(string strProcedureName, ArrayList arlParams)
        {
            if (_sqldaAdapter == null)
            {
                throw new System.ObjectDisposedException(GetType().FullName);
            } // end if
            Initialize();



            SqlCommand dbCommand = _sqldaAdapter.SelectCommand;
            dbCommand.CommandText = strProcedureName;
            dbCommand.CommandType = CommandType.StoredProcedure;

            if (arlParams != null)
            {
                for (int i = 0; i < arlParams.Count; i++)
                {
                    dbCommand.Parameters.Add(arlParams[i]);
                } // end for
            } // end if


            DataSet dsResult = new DataSet();
            _sqldaAdapter.Fill(dsResult);

            return dsResult;
        } // end ExecuteSPDataSet

    }
}
