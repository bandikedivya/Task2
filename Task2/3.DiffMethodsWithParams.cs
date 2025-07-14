using System;

namespace DiffMethodsWithParams
{

    public class Hospital
    {
        public string HospitalName(string name)
        {
            return $"Welcome to {name} Hopital";
        }

        public string HopitalPatientDetails(string name, int age)
        {
            return $"Patient Name: {name}, Age: {age}";
        }


        //  Returns a string - takes customer name and shop name
        public string BookAppointment(string patientname, string consultationType)
        {
            return $"Appointment booked for {patientname},Consultation Type: {consultationType}";
        }

        public double ConsultationBill(double price)
        {
            double billprice = 1500.25;
            return billprice;
        }
        public string AdmitPatient(string name, int age, string ailment)
        {
            return $"Patient Name: {name}, Age :{age}, admitted with ailment: {ailment}.";
        }
        public string AssignRoom(string patientName, int roomNumber)
        {
            return $"Patient Name: {patientName} assigned to Room: {roomNumber}.";
        }
        public string ScheduleSurgery(string patientName, string surgeryType, DateTime surgeryDate)
        {
            return $"Surgery: '{surgeryType}' scheduled for {patientName} on {surgeryDate:yyyy-MM-dd}.";
        }
        public string DischargePatient(string name, DateTime dischargeDate)
        {
            return $"Patient Name: {name} discharged on {dischargeDate:yyyy-MM-dd}.";
        }

        public string GenerateDetailedBill(string patientName, double roomCharges, double doctorFees, double medicationCharges)
        {
            double total = roomCharges + doctorFees + medicationCharges;
            return $"Bill for {patientName}:\n" +
                   $"Room Charges: {roomCharges:C}\n" +
                   $"Doctor Fees: {doctorFees:C}\n" +
                   $"Medication Charges: {medicationCharges:C}\n" +
                   $"Total: {total:C}";
        }

        public string UpdateMedicalRecord(string patientName, string diagnosis, string treatment)
        {
            return $"Medical record updated for {patientName}:\nDiagnosis: {diagnosis}\nTreatment: {treatment}";
        }

        static void Main()
        {
           Hospital hospital = new Hospital();
            Console.WriteLine(hospital.HospitalName("CityCare"));
            Console.WriteLine(hospital.HopitalPatientDetails("Ruth",32));
            Console.WriteLine(hospital.BookAppointment("Luck","ENT"));
            Console.WriteLine($"Consultation Bill: Rupees: {hospital.ConsultationBill(0):F2}");

            Console.WriteLine(hospital.AdmitPatient("David", 25, "Apendix"));
            Console.WriteLine(hospital.AssignRoom("David", 305));
            Console.WriteLine(hospital.ScheduleSurgery("David", "Apendix", new DateTime(2025, 8, 1)));
            Console.WriteLine(hospital.GenerateDetailedBill("David", 5000, 12000, 1500));

            Console.WriteLine(hospital.UpdateMedicalRecord("David", "Apendicites Disease", "Medication & Surgery"));
            

            Console.WriteLine(hospital.DischargePatient("David", DateTime.Today.AddDays(5)));
        }
    }
}

 