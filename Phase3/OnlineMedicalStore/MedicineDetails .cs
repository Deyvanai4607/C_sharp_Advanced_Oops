using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineMedicalStore
{
    public class MedicineDetails 
    {
        /*Properties:
        a.	MedicineID (MD100)
        b.	MedicineName
        c.	AvailableCount
        d.	Price
        e.	DateOfExpiry
        */
        //static feild
        private static int s_medicineID=100;
        //properties
        public string MedicineID { get; set; }
        public string MedicineName { get; set; }
        public int AvailableCount { get; set; }
        public int Price { get; set; }
        public DateTime DateOfExpiry { get; set; }
        //constructor
        public MedicineDetails(string medicineName,int availableCount,int price,DateTime dateOfExpiry){
            s_medicineID++;
            MedicineID="MD"+s_medicineID;
            MedicineName=medicineName;
            AvailableCount=availableCount;
            Price=price;
            DateOfExpiry=dateOfExpiry;
        }

        public MedicineDetails(string med){
            string[] medicin=med.Split(",");
            
            MedicineID=medicin[0];
            s_medicineID=int.Parse(medicin[0].Remove(0,2));
            MedicineName=medicin[1];
            AvailableCount=int.Parse(medicin[2]);
            Price=int.Parse(medicin[3]);
            DateOfExpiry=DateTime.ParseExact(medicin[4],"dd/MM/yyyy",null);
        }
        
        
        
        
    }
}