using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Reflection;

namespace El_Merendero_Massimo_Pavoni
{
    static class DataManager
    {
        private static SqlConnection _connection;
        private static SqlCommand _command;
        private static SqlDataAdapter _dataAdapter;
        private static string[] _dbTablesNames = { "Utenti", "Classi", "Merende", "Ordini" };
        private static DataSet _dbData;

        public static List<Utente> Utenti { get; private set; }
        public static List<Classe> Classi { get; private set; }
        public static List<Merenda> Merende { get; private set; }
        public static List<Ordine> Ordini { get; private set; }

        #region Methods

        /// <summary>
        /// Verify if the connection to the database is opened or closed.
        /// </summary>
        /// <returns>True if connection is opened, otherwise false.</returns>
        internal static bool IsConnected()
        {
            if (_connection != null)
                return _connection.State == ConnectionState.Open ? true : false;
            return false;
        }

        /// <summary>
        /// Opens the connection to the database and initializes needed objects.
        /// </summary>
        /// <param name="output">The output message.</param>
        /// <returns>True if connection is opened with success, otherwise false.</returns>
        internal static bool Connect(out string output)
        {
            try
            {
                string path = Directory.GetParent(Directory.GetParent(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)).FullName).FullName;
                string _connectionString = "Data Source = (LocalDB)\\MSSQLLocalDB;" +
                    "AttachDbFilename = " + path + "\\MerendeDb.mdf;" +
                    "Integrated Security = True";
                _connection = new SqlConnection(_connectionString);
                _connection.Open();
                _command = new SqlCommand();
                _command.Connection = _connection;
                _dbData = new DataSet();
                Utenti = new List<Utente>();
                Classi = new List<Classe>();
                Merende = new List<Merenda>();
                Ordini = new List<Ordine>();
                if (!RefreshData(out output))
                    return false;
                output = "OK";
                return true;
            }
            catch (Exception ex)
            {
                output = String.Format("Catched Exception: {0}\nMethod: {1}\nClass: {2}\nDll: {3}",
                    ex.Message, ex.TargetSite.Name, ex.TargetSite.DeclaringType.FullName, ex.TargetSite.Module.Name);
                return false;
            }
        }

        /// <summary>
        /// Closes the connection to the database.
        /// </summary>
        /// <param name="output">The output message.</param>
        /// <returns>True if connection is closed with success, otherwise false.</returns>
        internal static bool Disconnect(out string output)
        {
            try
            {
                _connection.Close();
                output = "OK";
                return true;
            }
            catch (Exception ex)
            {
                output = String.Format("Catched Exception: {0}\nMethod: {1}\nClass: {2}\nDll: {3}",
                    ex.Message, ex.TargetSite.Name, ex.TargetSite.DeclaringType.FullName, ex.TargetSite.Module.Name);
                return false;
            }
        }

        #region CRUD

        /// <summary>
        /// Updates the dataset tables' rows.
        /// </summary>
        /// <param name="output">The output message.</param>
        /// <returns>True if local dataset was updated, otherwise false.</returns>
        internal static bool RefreshData(out string output)
        {
            try
            {
                _dbData.Tables.Clear();

                //////////////////////////////////////////////////////////////////////// Utenti
                
                _dataAdapter = new SqlDataAdapter("SELECT * FROM " + _dbTablesNames[0] + " ORDER BY Username", _connection);
                _dataAdapter.Fill(_dbData, _dbTablesNames[0]);
                _dbData.Tables[_dbTablesNames[0]].PrimaryKey = new DataColumn[] { _dbData.Tables[_dbTablesNames[0]].Columns["IdUtente"] };

                Utenti.Clear();
                foreach (DataRow utente in _dbData.Tables[_dbTablesNames[0]].Rows)
                    Utenti.Add(new Utente(
                        Convert.ToInt64(utente["IdUtente"]),
                        utente["Username"].ToString(),
                        utente["PasswordHash"] as byte[],
                        Convert.ToBoolean(utente["ElMerendero"]),
                        utente["ClasseDiAppartenenza"] is DBNull ? -1 : Convert.ToInt64(utente["ClasseDiAppartenenza"]),
                        utente["ClasseRappresentata"] is DBNull ? -1 : Convert.ToInt64(utente["ClasseRappresentata"])
                        ));

                //////////////////////////////////////////////////////////////////////// Classi

                _dataAdapter = new SqlDataAdapter("SELECT * FROM " + _dbTablesNames[1] + " ORDER BY Indirizzo, Anno, Sezione", _connection);
                _dataAdapter.Fill(_dbData, _dbTablesNames[1]);
                _dbData.Tables[_dbTablesNames[1]].PrimaryKey = new DataColumn[] { _dbData.Tables[_dbTablesNames[1]].Columns["IdClasse"] };

                Classi.Clear();
                foreach (DataRow classe in _dbData.Tables[_dbTablesNames[1]].Rows)
                    Classi.Add(new Classe(
                        Convert.ToInt64(classe["IdClasse"]),
                        Convert.ToByte(classe["Anno"]),
                        Convert.ToChar(classe["Sezione"]),
                        classe["Indirizzo"].ToString()
                        ));

                //////////////////////////////////////////////////////////////////////// Merende

                _dataAdapter = new SqlDataAdapter("SELECT * FROM " + _dbTablesNames[2] + " ORDER BY Nome, Variante, Tipo, Disponibilita", _connection);
                _dataAdapter.Fill(_dbData, _dbTablesNames[2]);
                _dbData.Tables[_dbTablesNames[2]].PrimaryKey = new DataColumn[] { _dbData.Tables[_dbTablesNames[2]].Columns["IdMerenda"] };

                Merende.Clear();
                foreach (DataRow merenda in _dbData.Tables[_dbTablesNames[2]].Rows)
                    Merende.Add(new Merenda(
                        merenda["Nome"].ToString(),
                        merenda["Variante"].ToString(),
                        (TipoMerenda)Convert.ToByte(merenda["Tipo"]),
                        Convert.ToDecimal(merenda["CostoUnitario"]),
                        Convert.ToInt16(merenda["Disponibilita"]),
                        Convert.ToInt64(merenda["IdMerenda"])
                        ));

                //////////////////////////////////////////////////////////////////////// Ordini

                _dataAdapter = new SqlDataAdapter("SELECT * FROM " + _dbTablesNames[3] + " ORDER BY DataRichiesta, Quantita", _connection);
                _dataAdapter.Fill(_dbData, _dbTablesNames[3]);
                _dbData.Tables[_dbTablesNames[3]].PrimaryKey = new DataColumn[] { _dbData.Tables[_dbTablesNames[3]].Columns["IdOrdine"] };

                Ordini.Clear();
                foreach (DataRow ordine in _dbData.Tables[_dbTablesNames[3]].Rows)
                    Ordini.Add(new Ordine(
                        Convert.ToInt64(ordine["IdUtente"]),
                        Convert.ToInt64(ordine["IdMerenda"]),
                        Convert.ToInt16(ordine["Quantita"]),
                        Convert.ToDateTime(ordine["DataRichiesta"]),
                        ordine["DataPagamento"] is DBNull ? (DateTime?)null : Convert.ToDateTime(ordine["DataPagamento"]),
                        Convert.ToInt64(ordine["IdOrdine"])
                        ));

                output = "OK";
                return true;
            }
            catch (Exception ex)
            {
                output = String.Format("Catched Exception: {0}\nMethod: {1}\nClass: {2}\nDll: {3}",
                    ex.Message, ex.TargetSite.Name, ex.TargetSite.DeclaringType.FullName, ex.TargetSite.Module.Name);
                return false;
            }
        }

        /// <summary>
        /// Insert new ordine and reduce available quantity of interested product.
        /// </summary>
        /// <param name="ordine">The ordine to insert.</param>
        /// <param name="output">The output message.</param>
        /// <returns>True if new ordine was created on database and available quantity was reduced, otherwise false.</returns>
        internal static bool InsertOrdine(Ordine ordine, out string output)
        {
            try
            {
                if (new TimeSpan(DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second) >= Properties.Settings.Default.EndInsertOrdine)
                {
                    output = "Ci dispiace, ma è stato superato l'orario entro il quale è possibile effettuare ordinazioni (" + Properties.Settings.Default.EndInsertOrdine.ToString() + ")";
                    return false;
                }
                _command.CommandText = String.Format("INSERT INTO Ordini (IdUtente, IdMerenda, Quantita, DataRichiesta) VALUES({0}, {1}, {2}, CONVERT(DATETIME, '{3}'))",
                    ordine.IdUtente, ordine.IdMerenda, ordine.Quantita, DateTime.Now.ToString());
                _command.ExecuteNonQuery();
                _command.CommandText = String.Format("UPDATE Merende SET Disponibilita = {0} WHERE IdMerenda = {1}",
                    Merende.Find(m => m.IdMerenda == ordine.IdMerenda).Disponibilita - ordine.Quantita, ordine.IdMerenda);
                _command.ExecuteNonQuery();
                output = "OK";
                return true;
            }
            catch (Exception ex)
            {
                output = String.Format("Catched Exception: {0}\nMethod: {1}\nClass: {2}\nDll: {3}",
                    ex.Message, ex.TargetSite.Name, ex.TargetSite.DeclaringType.FullName, ex.TargetSite.Module.Name);
                return false;
            }
        }

        /// <summary>
        /// Update ordini with DataPagamento as now.
        /// </summary>
        /// <param name="ordini">The ordini to update.</param>
        /// <param name="output">The output message.</param>
        /// <returns>True if all ordini were updated on database, otherwise false.</returns>
        internal static bool ConfirmOrdini(IEnumerable<Ordine> ordini, out string output)
        {
            try
            {
                if (new TimeSpan(DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second) >= Properties.Settings.Default.EndConfirmOrdini)
                {
                    output = "Ci dispiace, ma è stato superato l'orario entro il quale è possibile confermare le ordinazioni (" + Properties.Settings.Default.EndConfirmOrdini.ToString() + ")";
                    return false;
                }
                foreach (Ordine ordine in ordini)
                {
                    _command.CommandText = String.Format("UPDATE Ordini SET DataPagamento = CONVERT(DATETIME, '{0}') WHERE IdOrdine = {1}",
                        DateTime.Now.ToString(), ordine.IdOrdine);
                    _command.ExecuteNonQuery();
                }
                output = "OK";
                return true;
            }
            catch (Exception ex)
            {
                output = String.Format("Catched Exception: {0}\nMethod: {1}\nClass: {2}\nDll: {3}",
                    ex.Message, ex.TargetSite.Name, ex.TargetSite.DeclaringType.FullName, ex.TargetSite.Module.Name);
                return false;
            }
        }

        /// <summary>
        /// Insert new merenda.
        /// </summary>
        /// <param name="merenda">The merenda to insert.</param>
        /// <param name="output">The output message.</param>
        /// <returns>True if new merenda was created on database, otherwise false.</returns>
        internal static bool InsertMerenda(Merenda merenda, out string output)
        {
            try
            {
                _command.CommandText = String.Format("INSERT INTO Merende (Nome, Variante, Tipo, CostoUnitario, Disponibilita) VALUES('{0}', '{1}', {2}, {3}, {4})",
                    merenda.Nome, merenda.Variante, (byte)merenda.Tipo, merenda.CostoUnitario, merenda.Disponibilita);
                _command.ExecuteNonQuery();
                output = "OK";
                return true;
            }
            catch (Exception ex)
            {
                output = String.Format("Catched Exception: {0}\nMethod: {1}\nClass: {2}\nDll: {3}",
                    ex.Message, ex.TargetSite.Name, ex.TargetSite.DeclaringType.FullName, ex.TargetSite.Module.Name);
                return false;
            }
        }

        /// <summary>
        /// Update existing merenda.
        /// </summary>
        /// <param name="merenda">The new merenda to use during replacement.</param>
        /// <param name="output">The output message.</param>
        /// <returns>True if merenda was updated on database, otherwise false.</returns>
        internal static bool UpdateMerenda(Merenda merenda, out string output)
        {
            try
            {
                _command.CommandText = String.Format("UPDATE Merende SET Nome = '{0}', Variante = '{1}', Tipo = {2}, CostoUnitario = {3}, Disponibilita = {4} WHERE IdMerenda = {5}",
                    merenda.Nome, merenda.Variante, (byte)merenda.Tipo, merenda.CostoUnitario, merenda.Disponibilita, merenda.IdMerenda);
                _command.ExecuteNonQuery();
                output = "OK";
                return true;
            }
            catch (Exception ex)
            {
                output = String.Format("Catched Exception: {0}\nMethod: {1}\nClass: {2}\nDll: {3}",
                    ex.Message, ex.TargetSite.Name, ex.TargetSite.DeclaringType.FullName, ex.TargetSite.Module.Name);
                return false;
            }
        }

        /// <summary>
        /// Delete existing merenda.
        /// </summary>
        /// <param name="idMerenda">The id of the merenda to delete.</param>
        /// <param name="output">The output message.</param>
        /// <returns>True if merenda was deleted from database, otherwise false.</returns>
        internal static bool DeleteMerenda(long idMerenda, out string output)
        {
            try
            {
                _command.CommandText = String.Format("DELETE FROM Merende WHERE IdMerenda = {0}", idMerenda);
                _command.ExecuteNonQuery();
                output = "OK";
                return true;
            }
            catch (Exception ex)
            {
                output = String.Format("Catched Exception: {0}\nMethod: {1}\nClass: {2}\nDll: {3}",
                    ex.Message, ex.TargetSite.Name, ex.TargetSite.DeclaringType.FullName, ex.TargetSite.Module.Name);
                return false;
            }
        }

        #endregion

        #endregion
    }
}
