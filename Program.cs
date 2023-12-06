using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace ConsoleApp2
{

    
    

    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                using (TeamsContext db = new TeamsContext())
                {
                    List<Teams> teams = db.Teams.ToList();

                    foreach (var item in teams)
                    {
                        item.Print();
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
           
        }
    }
}
