using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1Var5
{
    class MultiLevelParking
    {
        List<Parking<ITransport>> parkingStages;
        
        private const int countPlaces = 20;
        
        private int pictureWidth;
        
        private int pictureHeight;
        
        public MultiLevelParking(int countStages, int pictureWidth, int pictureHeight)
        {
            parkingStages = new List<Parking<ITransport>>();
            this.pictureWidth = pictureWidth;
            this.pictureHeight = pictureHeight;
            for (int i = 0; i < countStages; ++i)
            {
                parkingStages.Add(new Parking<ITransport>(countPlaces, pictureWidth,
               pictureHeight));
            }
        }
        
        public Parking<ITransport> this[int ind]
        {
            get
            {
                if (ind > -1 && ind < parkingStages.Count)
                {
                    return parkingStages[ind];
                }
                return null;
            }
        }

        public bool SaveData(string filename)
        {
            if (File.Exists(filename))
            {
                File.Delete(filename);
            }
            using (FileStream fs = new FileStream(filename, FileMode.Create))
            {
                using (BufferedStream bs = new BufferedStream(fs))
                {
        
                    WriteToFile("CountLeveles:" + parkingStages.Count +
                   Environment.NewLine, fs);
                    foreach (var level in parkingStages)
                    {
                        

                        WriteToFile("Level" + Environment.NewLine, fs);
                        for (int i = 0; i < countPlaces; i++)
                        {
                            try
                            {
                                var ship = level[i];
                                
                                    if (ship.GetType().Name == "Ship")
                                    {
                                        WriteToFile(i + ":Ship:", fs);
                                    }
                                    if (ship.GetType().Name == "WaterCar")
                                    {
                                        WriteToFile(i + ":WaterCar:", fs);
                                    }


                                    WriteToFile(ship + Environment.NewLine, fs);
                            }
                            finally { }
                        }
                    }
                }
            }
            return true;
        }

        private void WriteToFile(string text, FileStream stream)
        {
            byte[] info = new UTF8Encoding(true).GetBytes(text);
            stream.Write(info, 0, info.Length);
        }
        
        public bool LoadData(string filename)
        {
            if (!File.Exists(filename))
            {
                throw new FileNotFoundException();
            }
            string bufferTextFromFile = "";
            using (FileStream fs = new FileStream(filename, FileMode.Open))
            {
                using (BufferedStream bs = new BufferedStream(fs))
                {
                    byte[] b = new byte[fs.Length];
                    UTF8Encoding temp = new UTF8Encoding(true);
                    while (bs.Read(b, 0, b.Length) > 0)
                    {
                        bufferTextFromFile += temp.GetString(b);
                    }
                }
            }
            bufferTextFromFile = bufferTextFromFile.Replace("\r", "");
            var strs = bufferTextFromFile.Split('\n');
            if (strs[0].Contains("CountLeveles"))
            {
                int count = Convert.ToInt32(strs[0].Split(':')[1]);
                if (parkingStages != null)
                {
                    parkingStages.Clear();
                }

                parkingStages = new List<Parking<ITransport>>(count);
            }
            else
            {
                throw new Exception("Неверный формат файла");
            }

            int counter = -1;

            ITransport ship = null;

            for (int i = 1; i < strs.Length; ++i)
            {
                if (strs[i] == "Level")
                {
                    counter++;
                    parkingStages.Add(new Parking<ITransport>(countPlaces, pictureWidth,
                    pictureHeight));
                    continue;
                }

                if (string.IsNullOrEmpty(strs[i]))
                {
                    continue;
                }

                if (strs[i].Split(':')[1] == "Ship")
                {
                    ship = new Ship(strs[i].Split(':')[2]);
                }
                else if (strs[i].Split(':')[1] == "WaterCar")
                {
                    ship = new WaterCar(strs[i].Split(':')[2]);
                }

                parkingStages[counter][Convert.ToInt32(strs[i].Split(':')[0])] = ship;
            }
            return true;
        }
    }
}