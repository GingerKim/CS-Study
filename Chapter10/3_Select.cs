using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter10
{
    internal class _3_select
    {
        static void Main3(string[] args)
        {
            // 데이터베이스 접속 정보
            string server = "127.0.0.1";
            string port = "3306";
            string username = "root";
            string password = "1234";
            string database = "testdb";

            //데이터베이스 커넥션 생성
            string strConn = $"server={server}; port={port}; username={username}; password={password};database={database}";
            MySqlConnection conn = new MySqlConnection(strConn);

            try
            {
                // 데이터베이스 접속
                conn.Open();
                Console.WriteLine("성공 ...");

                // SQL 실행
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT * FROM `USER1`";

                MySqlDataReader reader = cmd.ExecuteReader();


                //결과 출력
                while (reader.Read())
                {
                    Console.WriteLine("{0},{1},{2},{3}", reader[0], reader[1], reader[2], reader[3]);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("실패 : " + e.Message);
            }
            finally
            {
                conn.Close();
                Console.WriteLine("종료...");

            }

        }
    }
}
