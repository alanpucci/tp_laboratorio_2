using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using Exceptions;

namespace SQL
{
    public static class SqlHandler
    {
        static string connectionStr;
        static SqlConnection connection;
        static SqlCommand command;

        /// <summary>
        /// Initiate connection and command
        /// </summary>
        static SqlHandler()
        {
            connectionStr = @"Data Source=.; Initial Catalog = Alan.Pucci.TPFinal; Integrated Security = True";
            connection = new SqlConnection(connectionStr);
            command = new SqlCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.Connection = connection;
        }

        /// <summary>
        /// Saves a new computer into DB
        /// </summary>
        /// <param name="computer">Computer to save</param>
        public static void CreateComputer(Computer computer)
        {
            try
            {
                command.Parameters.Clear();
                connection.Open();

                command.CommandText = "INSERT INTO dbo.computers VALUES(@operative_system, @type, @ram, @processor, @hard_disk, @graphic_card, @description, @creation_date, @client_name, @state, @extra_accesory, @accesory1, @accesory2)";

                command.Parameters.AddWithValue("@operative_system", computer.OperativeSystem.ToString());
                command.Parameters.AddWithValue("@type", computer.ComputerType.ToString());
                command.Parameters.AddWithValue("@ram", computer.ComputerRAM.ToString());
                command.Parameters.AddWithValue("@processor", computer.ComputerProcessor.ToString());
                command.Parameters.AddWithValue("@hard_disk", computer.ComputerHardDisk.ToString());
                command.Parameters.AddWithValue("@graphic_card", computer.ComputerGraphicCard.ToString());
                command.Parameters.AddWithValue("@description", computer.Desc);
                command.Parameters.AddWithValue("@creation_date", computer.Date);
                command.Parameters.AddWithValue("@client_name", computer.ClientName);
                command.Parameters.AddWithValue("@state", computer.ComputerState.ToString());
                if(computer.ComputerType == ComType.Notebook)
                {
                    command.Parameters.AddWithValue("@extra_accesory", ((Notebook)computer).Brand.ToString());
                    command.Parameters.AddWithValue("@accesory1", ((Notebook)computer).Charger );
                    command.Parameters.AddWithValue("@accesory2", ((Notebook)computer).TouchScreen );
                }
                else
                {
                    command.Parameters.AddWithValue("@extra_accesory", ((Desktop)computer).Cooler);
                    command.Parameters.AddWithValue("@accesory1", ((Desktop)computer).DvdBurner);
                    command.Parameters.AddWithValue("@accesory2", ((Desktop)computer).ExtraAccesory);
                }

                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw new Exception("No se pudo guardar la computadora en la base de datos");
            }
            finally
            {
                connection.Close();
            }
        }

        /// <summary>
        /// Returns all computers from a DB
        /// </summary>
        public static List<Computer> GetComputers()
        {
            List<Computer> computerList = new List<Computer>();
            Computer aux = null;
            try
            {
                command.Parameters.Clear();
                connection.Open();

                command.CommandText = "SELECT * FROM dbo.computers";

                SqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read() != false)
                {
                    if (dataReader["type"].ToString() == ComType.Notebook.ToString())
                    {
                        aux = new Notebook(Convert.ToInt32(dataReader["id"]), dataReader["client_name"].ToString(), (Brand)Enum.Parse(typeof(Brand),dataReader["extra_accesory"].ToString()), Convert.ToBoolean(dataReader["accesory1"]), Convert.ToBoolean(dataReader["accesory2"]), (OS)Enum.Parse(typeof(OS),dataReader["operative_system"].ToString()), (ComType)Enum.Parse(typeof(ComType),dataReader["type"].ToString()), (Processor)Enum.Parse(typeof(Processor),dataReader["processor"].ToString()), (HardDisk)Enum.Parse(typeof(HardDisk),dataReader["hard_disk"].ToString()), (RAM)Enum.Parse(typeof(RAM),dataReader["ram"].ToString()), dataReader["description"].ToString(), (GraphicCard)Enum.Parse(typeof(GraphicCard),dataReader["graphic_card"].ToString()), (State)Enum.Parse(typeof(State), dataReader["state"].ToString()), Convert.ToDateTime(dataReader["creation_date"]));
                    }
                    else
                    {
                        aux = new Desktop(Convert.ToInt32(dataReader["id"]), dataReader["client_name"].ToString(), (Cooler)Enum.Parse(typeof(Cooler), dataReader["extra_accesory"].ToString()), Convert.ToBoolean(dataReader["accesory1"]), Convert.ToBoolean(dataReader["accesory2"]), (OS)Enum.Parse(typeof(OS), dataReader["operative_system"].ToString()), (ComType)Enum.Parse(typeof(ComType), dataReader["type"].ToString()), (Processor)Enum.Parse(typeof(Processor), dataReader["processor"].ToString()), (HardDisk)Enum.Parse(typeof(HardDisk), dataReader["hard_disk"].ToString()), (RAM)Enum.Parse(typeof(RAM), dataReader["ram"].ToString()), dataReader["description"].ToString(), (GraphicCard)Enum.Parse(typeof(GraphicCard), dataReader["graphic_card"].ToString()),(State)Enum.Parse(typeof(State), dataReader["state"].ToString()), Convert.ToDateTime(dataReader["creation_date"]));
                    }
                    computerList.Add(aux);
                }
                dataReader.Close();
                return computerList;
            }
            catch (Exception)
            {
                throw new Exception("No se recuperaron los datos");
            }
            finally
            {
                connection.Close();
            }
        }

        /// <summary>
        /// Delete a computer by id
        /// </summary>
        public static void DeleteComputer(int id)
        {
            try
            {
                command.Parameters.Clear();
                connection.Open();
                command.CommandText = $"DELETE FROM dbo.computers WHERE id={id}";

                if (command.ExecuteNonQuery() != 1)
                {
                    throw new ComputerException("No se pudo eliminar la computadora con ese id");
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
        }

        /// <summary>
        /// Get a computer by id from a DB
        /// </summary>
        /// <param name="id">ID to search</param>
        public static Computer GetById(int id)
        {
            Computer aux = null;
            try
            {
                command.Parameters.Clear();
                connection.Open();

                command.CommandText = $"SELECT * FROM dbo.computers WHERE id={id}";

                using (SqlDataReader dataReader = command.ExecuteReader())
                {
                    if (dataReader.Read() != false)
                    {
                        if (dataReader["type"].ToString() == ComType.Notebook.ToString())
                        {
                            aux = new Notebook(Convert.ToInt32(dataReader["id"]), dataReader["client_name"].ToString(), (Brand)Enum.Parse(typeof(Brand), dataReader["extra_accesory"].ToString()), Convert.ToBoolean(dataReader["accesory1"]), Convert.ToBoolean(dataReader["accesory2"]), (OS)Enum.Parse(typeof(OS), dataReader["operative_system"].ToString()), (ComType)Enum.Parse(typeof(ComType), dataReader["type"].ToString()), (Processor)Enum.Parse(typeof(Processor), dataReader["processor"].ToString()), (HardDisk)Enum.Parse(typeof(HardDisk), dataReader["hard_disk"].ToString()), (RAM)Enum.Parse(typeof(RAM), dataReader["ram"].ToString()), dataReader["description"].ToString(), (GraphicCard)Enum.Parse(typeof(GraphicCard), dataReader["graphic_card"].ToString()), (State)Enum.Parse(typeof(State), dataReader["state"].ToString()), Convert.ToDateTime(dataReader["creation_date"]));
                        }
                        else
                        {
                            aux = new Desktop(Convert.ToInt32(dataReader["id"]), dataReader["client_name"].ToString(), (Cooler)Enum.Parse(typeof(Cooler), dataReader["extra_accesory"].ToString()), Convert.ToBoolean(dataReader["accesory1"]), Convert.ToBoolean(dataReader["accesory2"]), (OS)Enum.Parse(typeof(OS), dataReader["operative_system"].ToString()), (ComType)Enum.Parse(typeof(ComType), dataReader["type"].ToString()), (Processor)Enum.Parse(typeof(Processor), dataReader["processor"].ToString()), (HardDisk)Enum.Parse(typeof(HardDisk), dataReader["hard_disk"].ToString()), (RAM)Enum.Parse(typeof(RAM), dataReader["ram"].ToString()), dataReader["description"].ToString(), (GraphicCard)Enum.Parse(typeof(GraphicCard), dataReader["graphic_card"].ToString()), (State)Enum.Parse(typeof(State), dataReader["state"].ToString()), Convert.ToDateTime(dataReader["creation_date"]));
                        }
                        return aux;
                    }
                }
                throw new Exception("No se encontro la computadora con ese id");
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
        }

        /// <summary>
        /// Update a computer into DB by id
        /// </summary>
        /// <param name="computer">Computer to update</param>
        public static void UpdateComputer(Computer computer)
        {
            try
            {
                command.Parameters.Clear();
                connection.Open();

                command.CommandText = $"UPDATE dbo.computers SET operative_system=@operative_system, type=@type, ram=@ram, processor=@processor, hard_disk=@hard_disk, graphic_card=@graphic_card, description=@description, client_name=@client_name, state=@state, extra_accesory=@extra_accesory, accesory1=@accesory1, accesory2=@accesory2  WHERE id={computer.ID}";

                command.Parameters.AddWithValue("@operative_system", computer.OperativeSystem.ToString());
                command.Parameters.AddWithValue("@type", computer.ComputerType.ToString());
                command.Parameters.AddWithValue("@ram", computer.ComputerRAM.ToString());
                command.Parameters.AddWithValue("@processor", computer.ComputerProcessor.ToString());
                command.Parameters.AddWithValue("@hard_disk", computer.ComputerHardDisk.ToString());
                command.Parameters.AddWithValue("@graphic_card", computer.ComputerGraphicCard.ToString());
                command.Parameters.AddWithValue("@description", computer.Desc);
                command.Parameters.AddWithValue("@client_name", computer.ClientName);
                command.Parameters.AddWithValue("@state", computer.ComputerState.ToString());
                if (computer.ComputerType == ComType.Notebook)
                {
                    command.Parameters.AddWithValue("@extra_accesory", ((Notebook)computer).Brand.ToString());
                    command.Parameters.AddWithValue("@accesory1", ((Notebook)computer).Charger);
                    command.Parameters.AddWithValue("@accesory2", ((Notebook)computer).TouchScreen);
                }
                else
                {
                    command.Parameters.AddWithValue("@extra_accesory", ((Desktop)computer).Cooler);
                    command.Parameters.AddWithValue("@accesory1", ((Desktop)computer).DvdBurner);
                    command.Parameters.AddWithValue("@accesory2", ((Desktop)computer).ExtraAccesory);
                }

                if (command.ExecuteNonQuery() != 1)
                {
                    throw new Exception("No se pudo modificar la computadora con ese id");
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
