using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineMedicalStore
{
    public static class FileHandling
    {
        public static void Create(){
            if(!Directory.Exists("OnlineMedicalStore")){
                Directory.CreateDirectory("OnlineMedicalStore");
            }
            if(!File.Exists("OnlineMedicalStore/userInfo.csv")){
                File.Create("OnlineMedicalStore/userInfo.csv").Close();
            }
            if(!File.Exists("OnlineMedicalStore/medicalInfo.csv")){
                File.Create("OnlineMedicalStore/medicalInfo.csv").Close();
            }
            if(!File.Exists("OnlineMedicalStore/orderInfo.csv")){
                File.Create("OnlineMedicalStore/orderInfo.csv").Close();
            }
        }   

        public static void WriteCsv(){
            String[] users=new string[Operation.userDetailsList.Count];
            for(int i=0;i<Operation.userDetailsList.Count;i++){
                //string name,int age,string city,string phoneNumber,int balance):base( name, age, city, phoneNumber
                users[i]=Operation.userDetailsList[i].UserID+","+Operation.userDetailsList[i].Name+","+Operation.userDetailsList[i].Age+","+Operation.userDetailsList[i].City+","+Operation.userDetailsList[i].PhoneNumber+","+Operation.userDetailsList[i].WalletBalance;             
            }
            File.WriteAllLines("OnlineMedicalStore/userInfo.csv",users);

            String[] medical=new string[Operation.medicineDetailsList.Count];
            for(int i=0;i<Operation.medicineDetailsList.Count;i++){
                //string medicineName,int availableCount,int price,DateTime dateOfExpiry
                medical[i]=Operation.medicineDetailsList[i].MedicineID+","+Operation.medicineDetailsList[i].MedicineName+","+Operation.medicineDetailsList[i].AvailableCount+","+Operation.medicineDetailsList[i].Price+","+Operation.medicineDetailsList[i].DateOfExpiry.ToString("dd/MM/yyyy");             
            }
            File.WriteAllLines("OnlineMedicalStore/medicalInfo.csv",medical);

            String[] orders=new string[Operation.orderDetailsList.Count];
            for(int i=0;i<Operation.orderDetailsList.Count;i++){
                //string userID,string medicineID,int medicineCount,int totalPrice,DateTime orderDate,OrderStatus orderStatus
                orders[i]=Operation.orderDetailsList[i].OrderID+","+Operation.orderDetailsList[i].UserID+","+Operation.orderDetailsList[i].MedicineID+","+Operation.orderDetailsList[i].MedicineCount+","+Operation.orderDetailsList[i].TotalPrice+","+Operation.orderDetailsList[i].OrderDate.ToString("dd/MM/yyyy")+","+Operation.orderDetailsList[i].OrderStatus;             
            }
            File.WriteAllLines("OnlineMedicalStore/orderInfo.csv",orders);
        }   

        public static void ReadFromCsv(){
            String[] users=File.ReadAllLines("OnlineMedicalStore/userInfo.csv");
            foreach(string user in users){
                string[] user1=user.Split(",");
                UserDetails user2=new UserDetails(user1[0],user1[1],int.Parse(user1[2]),user1[3],user1[4],int.Parse(user1[5]));
                Operation.userDetailsList.Add(user2);
            }

            String[] medical=File.ReadAllLines("OnlineMedicalStore/medicalInfo.csv");
            foreach(string med in medical){
                MedicineDetails medicen=new MedicineDetails(med);
                Operation.medicineDetailsList.Add(medicen);
            }

            String[] orders=File.ReadAllLines("OnlineMedicalStore/orderInfo.csv");
            foreach(string order in orders){
                OrderDetails order1=new OrderDetails(order);
                Operation.orderDetailsList.Add(order1);
            }
        }  
    }
}