using System.Data.SqlClient;
using System.Windows.Forms;

namespace AdoNet_HW_1
{
    public static class DB_Model
    {
        public static bool Write_DB(Food food)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(@"Data Source=SQL5103.site4now.net;Initial Catalog=DB_A7168B_kuvaevsql;Integrated Security=False"))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(@"INSERT INTO [dbo].[Fruits_&_Vegetables]([Name], [Type], [Color], [Calory]) VALUES(@f_name, @f_type, @f_color, @f_calory);", connection))
                    {
                        SqlParameter nameParameter = new SqlParameter("@f_name", food.name);
                        SqlParameter typeParameter = new SqlParameter("@f_type", food.type);
                        SqlParameter colorParameter = new SqlParameter("@f_color", food.color);
                        SqlParameter caloryParameter = new SqlParameter("@f_calory", food.calory);
                        
                        command.Parameters.AddRange(new SqlParameter[] { nameParameter, typeParameter, colorParameter, caloryParameter });

                        int count = command.ExecuteNonQuery();
                        command.Dispose();
                        connection.Close();
                        if (count > 0)
                            return true;

                        return false;
                    }
                }
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message.ToString());
                return false;
            }
        }
    }
}
