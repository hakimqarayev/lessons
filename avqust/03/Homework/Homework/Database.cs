using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class Database
    {
        private static ArrayList _database = new ArrayList(); 

        public static bool CheckBarcode(string barcode, int? exceptId= null)
        {
            if (_database != null && _database.Count > 0)
            {
                for (int i = 0; i < _database.Count; i++)
                {
                    Device device = (Device)_database[i];
                    if (device.Barcode == barcode && !device.IsDeleted && device.ID != exceptId)
                        return true;
                }
            }
             return false;
        }

        public static void NewItem(Device device)
        {
            if (device != null && !string.IsNullOrEmpty(device.Barcode))
            {
                device.CreateDate = DateTime.Now;
                device.CreateUser = 100;
                _database.Add(device);
            }
        }

        public static void NewItems(params Device[] devices)
        {
            if (devices != null)
            {
                foreach (var item in devices)
                {
                    if (!string.IsNullOrEmpty(item.Barcode))
                    {
                        if (CheckBarcode(item.Barcode))
                            Console.WriteLine("Bu barkod daha once basqa mehsul ucun sisteme elave olunub!");
                        else
                        {
                            item.CreateDate = DateTime.Now;
                            item.CreateUser = 100;
                            _database.Add(item);
                        }
                    }
                }
            }
        }

        public static void UpdateItem(Device updatedevice)
        {
            if (updatedevice != null && !string.IsNullOrEmpty(updatedevice.Barcode))
            {
                if (_database != null && _database.Count > 0)
                {
                    for (int i = 0; i < _database.Count; i++)
                    {
                        Base device = (Base)_database[i];

                        if (device.ID == updatedevice.ID)
                        {
                            if (!CheckBarcode(updatedevice.Barcode, updatedevice.ID))
                            {
                                updatedevice.EditDate = DateTime.Now;
                                updatedevice.EditUser = 101;
                            }
                        }
                    }
                }
            }
        }

        public static void DeleteDevice(Device deleteDevice)
        {
            if (deleteDevice != null)
            {
                if (_database != null && _database.Count > 0)
                {
                    for (int i = 0; i < _database.Count; i++)
                    {
                        Base item = (Base)_database[i];

                        if (item.ID == deleteDevice.ID)
                        {
                            deleteDevice.IsDeleted = true;
                            deleteDevice.DeleteDate = DateTime.Now;
                            deleteDevice.DeleteUser = 102;
                        }
                    }
                }
            }
        }


    }
}
