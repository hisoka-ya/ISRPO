using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;


namespace ClassLibrary
{
    [Serializable]
    public class Ship { 

            public string Name { get; set; }
            public int Year { get; set; }
            public decimal Capacity { get; set; }
            public string Port { get; set; }

            public Ship(string name, int year, decimal capacity, string port)
            {
                Name = name;
                Year = year;
                Capacity = capacity;
                Port = port;
            }
        public class DataManager
        {
            private string filePath = "data.bin";
            public DataManager(string path)
            {
                filePath = path;
            }
            public void AddRecord(Ship record)
            {
                List<Ship> records = LoadShips();
                records.Add(record);
                SaveRecords(records);
            }
            public void SaveRecords(List<Ship> records)
            {
                using (FileStream fs = new FileStream(filePath, FileMode.Create))
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    formatter.Serialize(fs, records);
                }
            }
                public List<Ship> LoadShips()
                {
                    if (!File.Exists(filePath))
                        return new List<Ship>();

                    using (FileStream fs = new FileStream(filePath, FileMode.Open))
                    {
                        BinaryFormatter formatter = new BinaryFormatter();
                        return (List<Ship>)formatter.Deserialize(fs);
                    }
                }
            public Ship FindRecordsByName(string name)
            {
                var ships = LoadShips();
                return ships.Find(s => s.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
            }
            public void EditShip(Ship updatedShip)
            {
                var ships = LoadShips();
                var index = ships.FindIndex(s => s.Name.Equals(updatedShip.Name, StringComparison.OrdinalIgnoreCase));

                if (index != -1)
                {
                    ships[index] = updatedShip;
                    SaveRecords(ships);
                }
                else
                {
                    throw new Exception("Корабль не найден.");
                }
            }
        }
    }
}
    


