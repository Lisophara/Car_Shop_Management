using System;
using System.Diagnostics;
using MySql.Data.MySqlClient;

namespace CarSellerShop.Data
{
    class DbSeeder : Data_IO
    {
        MySqlConnection conn = new MySqlConnection();
        MySqlCommand cmd = new MySqlCommand();
        public DbSeeder()
        {
            try
            {
                conn.ConnectionString = connectionStr();
                conn.Open();

                /**
                 *  Query for create Table 
                 *      Staff State
                 *      
                 *    - Not stuff
                 */
                cmd = new MySqlCommand(
                    "CREATE TABLE `stuff_state` (" +
                    "`stuff_state_id` tinyint NOT NULL AUTO_INCREMENT," +
                    "`stuff_state_name` enum('Admin','Editor','Cashier') NOT NULL," +
                    "PRIMARY KEY(`stuff_state_id`)," +
                    "UNIQUE KEY `stuff_state_name` (`stuff_state_name`)" +
                    ") ENGINE=InnoDB AUTO_INCREMENT = 5 DEFAULT CHARSET = utf8mb4 COLLATE=utf8mb4_0900_ai_ci;", conn);
                cmd.ExecuteNonQuery();

                /**
                 *  Query for create Table 
                 *      Staff Info
                 *      
                 *    - Not stuff
                 */
                cmd = new MySqlCommand(
                    "CREATE TABLE `stuff_info` (" +
                    "`stuff_id` int NOT NULL AUTO_INCREMENT," +
                    "`national_id` varchar(14) NOT NULL," +
                    "`stuff_first_name` varchar(30) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL," +
                    "`stuff_last_name` varchar(30) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL," +
                    "`stuff_gender` varchar(1) NOT NULL," +
                    "`dob` date NOT NULL," +
                    "`stuff_phone_num` varchar(10) NOT NULL," +
                    "`stuff_addr` varchar(255) DEFAULT NULL," +
                    "`stuff_image_path` varchar(255) NOT NULL," +
                    "`stuff_state_id` tinyint NOT NULL," +
                    "`is_deleted` tinyint(1) NOT NULL DEFAULT '0'," +
                    "PRIMARY KEY(`stuff_id`)," +
                    "UNIQUE KEY `national_id` (`national_id`)," +
                    "KEY `fk_stuff_state_id` (`stuff_state_id`)," +
                    "CONSTRAINT `fk_stuff_state_id` FOREIGN KEY(`stuff_state_id`) REFERENCES `stuff_state` (`stuff_state_id`)" +
                    ") ENGINE = InnoDB AUTO_INCREMENT = 13 DEFAULT CHARSET = utf8mb4 COLLATE = utf8mb4_0900_ai_ci;", conn);
                cmd.ExecuteNonQuery();

                /**
                 *  Query for create Table 
                 *      Customer
                 */
                cmd = new MySqlCommand(
                    "CREATE TABLE `customer` ("+
                    "`national_id` varchar(12) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,"+
                    "`first_name` varchar(30) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,"+
                    "`last_name` varchar(30) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,"+
                    "`gender` varchar(1) NOT NULL,"+
                    "`dob` date NOT NULL,"+
                    "`phone` varchar(10) NOT NULL,"+
                    "`phone2` varchar(10) DEFAULT NULL,"+
                    "`addr` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci DEFAULT '',"+
                    "`image_path` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci DEFAULT '',"+
                    "`is_deleted` tinyint(1) NOT NULL DEFAULT '0',"+
                    "PRIMARY KEY(`national_id`)"+
                    ") ENGINE = InnoDB DEFAULT CHARSET = utf8mb4 COLLATE = utf8mb4_0900_ai_ci; ", conn);
                cmd.ExecuteNonQuery();

                /**
                 *  Query for create Table 
                 *      Account
                 */
                cmd = new MySqlCommand(
                    "CREATE TABLE `account` (" +
                    "`id` int NOT NULL AUTO_INCREMENT," +
                    "`user_name` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL," +
                    "`password` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL," +
                    "`forget_tip` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL," +
                    "`stuff_id` int NOT NULL," +
                    "`created_date` date NOT NULL," +
                    "`account_disable` tinyint(1) NOT NULL DEFAULT '0'," +
                    "PRIMARY KEY(`id`)," +
                    "UNIQUE KEY `user_name` (`user_name`)," +
                    "UNIQUE KEY `stuff_id` (`stuff_id`)," +
                    "CONSTRAINT `fk_stuff_account` FOREIGN KEY(`stuff_id`) REFERENCES `stuff_info` (`stuff_id`)" +
                    ") ENGINE = InnoDB AUTO_INCREMENT = 7 DEFAULT CHARSET = utf8mb4 COLLATE = utf8mb4_0900_ai_ci;", conn);
                cmd.ExecuteNonQuery();

                /**
                 *  Query for create Table 
                 *      Car
                 */
                cmd = new MySqlCommand(
                    "CREATE TABLE `car` (" +
                    "`identifier` varchar(17) NOT NULL," +
                    "`model_name` varchar(50) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL," +
                    "`color` varchar(20) CHARACTER SET utf8 COLLATE utf8_general_ci DEFAULT NULL," +
                    "`create_year` year DEFAULT NULL," +
                    "`image` varchar(255) NOT NULL," +
                    "`car_status` enum('Original','Second hand') NOT NULL," +
                    "`car_type` enum('Truck','Bus','Family') DEFAULT NULL," +
                    "`price` decimal (16,2) NOT NULL," +
                    "`is_sold` tinyint(1) NOT NULL DEFAULT '0'," +
                    "PRIMARY KEY(`identifier`)" +
                    ") ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE = utf8mb4_0900_ai_ci;", conn);
                cmd.ExecuteNonQuery();

                /**
                 *  Query for create Table 
                 *      Sell Record
                 */
                cmd = new MySqlCommand(
                    "CREATE TABLE `sell_record` ("+
                    "`sell_id` int NOT NULL AUTO_INCREMENT," +
                    "`sell_date` date NOT NULL," +
                    "`sell_time` time NOT NULL," +
                    "`stuff_id` int NOT NULL," +
                    "`customer_national_id` varchar(12) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL," +
                    "`car_identifier` varchar(17) NOT NULL," +
                    "`discount` decimal(2, 2) DEFAULT NULL," +
                    "`is_deleted` tinyint(1) NOT NULL DEFAULT '0'," +
                    "`decription` varchar(512) CHARACTER SET utf8 COLLATE utf8_general_ci DEFAULT ''," +
                    "PRIMARY KEY(`sell_id`)," +
                    "KEY `fk_stuff_id` (`stuff_id`)," +
                    "KEY `fk_customer_national_id` (`customer_national_id`)," +
                    "KEY `fk_car_identifier` (`car_identifier`)," +
                    "CONSTRAINT `fk_car_identifier` FOREIGN KEY(`car_identifier`) REFERENCES `car` (`identifier`)," +
                    "CONSTRAINT `fk_customer_national_id` FOREIGN KEY(`customer_national_id`) REFERENCES `customer` (`national_id`)," +
                    "CONSTRAINT `fk_stuff_id` FOREIGN KEY(`stuff_id`) REFERENCES `stuff_info` (`stuff_id`)" +
                    ") ENGINE = InnoDB AUTO_INCREMENT = 21 DEFAULT CHARSET = utf8mb4 COLLATE = utf8mb4_0900_ai_ci;", conn);
                cmd.ExecuteNonQuery();
                conn.Close();

                /**
                 * Seed data to database
                 */
                seeder();
                
            }
            catch (MySqlException mysqlEx)
            {
                Debug.WriteLine(mysqlEx.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        private void seeder()
        {
            /**
             *  First seed role as admin
             *  
             *  Email: admin@gmail.com
             *  Password: admin
             */
            Data_IO data = new Data_IO();
            if (data.Read_Data("*", "`account`", conditionStatement: "WHERE `id` = 1").Rows.Count <= 0)
            {
                data.Write_Data("stuff_state", "1, 'Admin'");
                data.Write_Data("stuff_state", "2, 'Editor'");
                data.Write_Data("stuff_state", "3, 'Cashier'");
                data.Write_Data(table: "`stuff_info`",
                            dataToInsert: $"1, " +
                            $"'0000000000', " +
                            $"'Super', " +
                            $"'Admin', " +
                            $"'M', " +
                            $"DATE('2000-5-20'), " +
                            $"'0962031234', " +
                            $"'PP Kork tul sleng', " +
                            $"'', " +
                            $"1, " +
                            $"DEFAULT");
                data.Write_Data(table: "`account`",
                dataToInsert: $"1," +
                $"'admin@gmail.com'," +
                $"'admin'," +
                $"'admin'," +
                $"1," +
                $"DATE('{DateTime.Now.Year}-{DateTime.Now.Month}-{DateTime.Now.Day}')," +
                $"FALSE");
            }
        }
    }
}
