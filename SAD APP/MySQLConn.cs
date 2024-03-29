﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace SAD_APP
{
    internal class MySQLConn
    {
        // The connections string for the database connection

        static readonly string connstring = "Data Source=DAGMAWI\\SQLEXPRESS01;" +
                                            "Integrated Security=True;" +
                                            "Connect Timeout=30;" +
                                            "Encrypt=False;";


        // Login page authentication
        //
        public static (string, int) loginPage(string username, string password)
        {
            try
            {
                string conQuery = "USE FinalHospital; SELECT Role, UserID FROM Users WHERE username = @Username AND password = @Password";

                using (SqlConnection conn = new SqlConnection(connstring))
                {
                    using (SqlCommand cmd = new SqlCommand(conQuery, conn))
                    {
                        conn.Open();

                        cmd.Parameters.AddWithValue("@Username", username);
                        cmd.Parameters.AddWithValue("@Password", password);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    string role = reader.GetString(0);
                                    int userid = reader.GetInt32(1);
                                    return (role, userid) ;
                                }
                            }
                        }
                    }
                }

                return (null, 0);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
                return (null, 0);
            }

        }


        // Fetch all the users for Admin
        public static DataTable listOfUsers() {
            try
            {
                string conQuery = "USE FinalHospital; SELECT Name, Username, Role FROM Users";

                using (SqlConnection conn = new SqlConnection(connstring))
                {
                    using (SqlCommand cmd = new SqlCommand(conQuery, conn))
                    {
                        conn.Open();

                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);
                            conn.Close();
                            return dt;
                        }

                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("An error occurred here : " + ex.Message);
                return null;
            }

        }


        // Create a user for Admin
        public static void createUser(string fullname, int phonenumber, string email, string specialization, string username, string role, string newpass)
        {
            try
            {
                string conQuery = "USE FinalHospital; INSERT INTO Users (Name, ContactNumber, Email, Username, Password, Role) VALUES(@Name, @ContactNumber, @Email, @Username, @Password, @Role)";

                using (SqlConnection conn = new SqlConnection(connstring))
                {
                    using (SqlCommand cmd = new SqlCommand(conQuery, conn))
                    {
                        conn.Open();

                        cmd.Parameters.AddWithValue("@Name", fullname);
                        cmd.Parameters.AddWithValue("@ContactNumber", phonenumber);
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@Username", username);
                        cmd.Parameters.AddWithValue("@Password", newpass);
                        cmd.Parameters.AddWithValue("@Role", role);

                        cmd.ExecuteNonQuery();
                        conn.Close();
                    }
                }

                if (role == "doctor")
                {
                    string fetchIDQuery = "USE FinalHospital; SELECT UserID FROM Users WHERE Name = @name";
                    string insertDoctorQuery = "USE FinalHospital; SET IDENTITY_INSERT Doctor ON; INSERT INTO Doctor(DoctorID, Specialization) VALUES(@UserID, @Specialization)";

                    using (SqlConnection conn = new SqlConnection(connstring))
                    {
                        using (SqlCommand cmd = new SqlCommand(fetchIDQuery, conn))
                        {
                            conn.Open();

                            cmd.Parameters.AddWithValue("@name", fullname);

                            SqlDataReader reader = cmd.ExecuteReader();
                            if (reader.Read())
                            {
                                int userID = reader.GetInt32(0);
                                conn.Close();

                                using (SqlCommand cmd2 = new SqlCommand(insertDoctorQuery, conn))
                                {
                                    conn.Open();
                                    cmd2.Parameters.AddWithValue("@UserID", userID);
                                    cmd2.Parameters.AddWithValue("@Specialization", specialization);

                                    cmd2.ExecuteNonQuery();
                                    conn.Close();
                                }
                            }
                        }
                    }
                }

                else if (role == "technician")
                {
                    string insertTechnicianQuery = "USE FinalHospital; INSERT INTO LabTechnician(Name, ContactNumber, Email) VALUES(@Name, @ContactNumber, @Email)";

                    using (SqlConnection conn = new SqlConnection(connstring))
                    {
                        using (SqlCommand cmd = new SqlCommand(insertTechnicianQuery, conn))
                        {
                            conn.Open();

                            cmd.Parameters.AddWithValue("@Name", fullname);
                            cmd.Parameters.AddWithValue("@ContactNumber", phonenumber);
                            cmd.Parameters.AddWithValue("@Email", email);

                            cmd.ExecuteNonQuery();
                            conn.Close();
                        }
                    }
                }

                MessageBox.Show("Account created successfully");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }


        // Delete a User
        public static bool deleteUser(string username)
        {
            try
            {
                string conQuery = "USE FinalHospital; DELETE FROM Users WHERE username = @Username";

                using (SqlConnection conn = new SqlConnection(connstring))
                {
                    using (SqlCommand cmd = new SqlCommand(conQuery, conn))
                    {
                        conn.Open();

                        cmd.Parameters.AddWithValue("@Username", username);

                        cmd.ExecuteNonQuery();
                        return true;
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
                return false;
            }
        }


        // To register Patients 
        public static void registerPatient(string fullName, int age, string gender, string city, int phoneNumber, string email)
        {
            using (SqlConnection connection = new SqlConnection(connstring))
            {
                connection.Open();
                string query = "USE FinalHospital; INSERT INTO Patient(Name, Age, Gender, City, ContactNumber, Email, Reviewed) VALUES(@fullName, @age, @gender, @city, @phoneNumber, @email, 0)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@fullName", fullName);
                    command.Parameters.AddWithValue("@age", age);
                    command.Parameters.AddWithValue("@gender", gender);
                    command.Parameters.AddWithValue("@city", city);
                    command.Parameters.AddWithValue("@phoneNumber", phoneNumber);
                    command.Parameters.AddWithValue("@email", email);
                    command.ExecuteNonQuery();
                }
            }
            MessageBox.Show("Record created successfully!");
        }


        // The list of unreviewed Patients
        public static DataTable listOfPatient()
        {
            DataTable dt = new DataTable();

            using (SqlConnection conn = new SqlConnection(connstring))
            {
                conn.Open();

                string query = "use FinalHospital; select PatientID, Name, Age, Gender from Patient Where Reviewed = 0 order by PatientID desc;";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        dt.Load(dr);
                    }
                }
            }

            return dt;
        }


        // To get the list of Doctors
        public static List<string> GetDoctorNames()
        {

            string query = "use FinalHospital; SELECT Name FROM Users WHERE Role = 'doctor' AND Available = 1";

            List<string> doctorNames = new List<string>();

            using (SqlConnection connection = new SqlConnection(connstring))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        doctorNames.Add(reader["Name"].ToString());
                    }

                    reader.Close();
                }
            }

            return doctorNames;
        }

        //Getting patient information for medical certificate
        public static (string name, int age, string contactNumber, string gender) getPatientInfo (int patientId)
        {
            string query = "USE FinalHospital; SELECT Name, Age, Gender, ContactNumber FROM Patient WHERE PatientID = @patientId";
            string name = "";
            int age = 0;
            string contactNumber = "";
            string gender = "";

            using (SqlConnection conn = new SqlConnection (connstring))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    conn.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            name = reader["Name"].ToString();
                            age = Convert.ToInt32(reader["Age"]);
                            contactNumber = reader["ContactNumber"].ToString();
                            gender = reader["Gender"].ToString();
                        }
                    }
                }
            }
            return (name, age, contactNumber, gender);
        }

        // To get the list of Vacant Rooms
        public static List<string> GetVacantRooms()
        {
            string query = "use FinalHospital; SELECT RoomNumber FROM Room WHERE RoomStatus = 'vacant'";

            List<string> vacantRooms = new List<string>();

            using (SqlConnection connection = new SqlConnection(connstring))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        vacantRooms.Add(reader["RoomNumber"].ToString());
                    }

                    reader.Close();
                }
            }

            return vacantRooms;
        }


        // To register patient's Clinical Diagnosis
        public static bool registerClinical(int ID, string clinical, string history, string symptom, string assignedDoc, int assignedRoom)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connstring))
                {
                    conn.Open();

                    string selectDoctorQuery = "use FinalHospital; SELECT UserID FROM Users WHERE Role = 'doctor' AND Name = @AssignedDoc;";
                    string insertQuery = "use FinalHospital; INSERT INTO Diagnosis(PatientID, ClinicalDiagnosis, History, Symptoms) VALUES (@ID, @Clinical, @History, @Symptom);";
                    string updateQuery = "use FinalHospital; UPDATE Patient SET Reviewed = 'true' WHERE PatientID = @ID;";
                    string insertAppointmentQuery = "use FinalHospital; INSERT INTO Appointment(PatientID, DoctorID) VALUES (@ID, @DoctorID);";
                    string insertAdmissionQuery = "use FinalHospital; INSERT INTO Admission(PatientID, RoomNumber) VALUES (@ID, @AssignedRoom);";

                    using (SqlCommand selectDoctorCmd = new SqlCommand(selectDoctorQuery, conn))
                    {
                        selectDoctorCmd.Parameters.AddWithValue("@AssignedDoc", assignedDoc);

                        using (SqlDataReader reader = selectDoctorCmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                int doctorID = reader.GetInt32(reader.GetOrdinal("UserID"));
                                reader.Close();
                                //MessageBox.Show("this is the iD: " + doctorID);
                                using (SqlCommand cmd = new SqlCommand(insertQuery, conn))
                                {
                                    cmd.Parameters.AddWithValue("@ID", ID);
                                    cmd.Parameters.AddWithValue("@Clinical", clinical);
                                    cmd.Parameters.AddWithValue("@History", history);
                                    cmd.Parameters.AddWithValue("@Symptom", symptom);

                                    int rowsAffected = cmd.ExecuteNonQuery();

                                    if (rowsAffected > 0)
                                    {
                                        using (SqlCommand updateCmd = new SqlCommand(updateQuery, conn))
                                        {
                                            updateCmd.Parameters.AddWithValue("@ID", ID);
                                            rowsAffected = updateCmd.ExecuteNonQuery();
                                        }

                                        using (SqlCommand insertAppointmentCmd = new SqlCommand(insertAppointmentQuery, conn))
                                        {
                                            insertAppointmentCmd.Parameters.AddWithValue("@ID", ID);
                                            insertAppointmentCmd.Parameters.AddWithValue("@DoctorID", doctorID);
                                            rowsAffected = insertAppointmentCmd.ExecuteNonQuery();
                                        }

                                        using (SqlCommand insertAdmissionCmd = new SqlCommand(insertAdmissionQuery, conn))
                                        {
                                            insertAdmissionCmd.Parameters.AddWithValue("@ID", ID);
                                            insertAdmissionCmd.Parameters.AddWithValue("@AssignedRoom", assignedRoom);
                                            rowsAffected = insertAdmissionCmd.ExecuteNonQuery();
                                        }
                                    }

                                    return rowsAffected > 0;
                                }
                            }
                            else
                            {
                                return false;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
              //  Log the exception details for debugging purposes

               Console.WriteLine(ex.ToString());

                return false;
            }
        }


        //BG ADDED HERE
        //Getting the diagnosis information
        public static (string, string, string) RetrieveDiagnosisAndSymptoms(int patientID)
        {
            string clinicalDiagnosis = "";
            string symptoms = "";
            string history = "";

            using (SqlConnection conn = new SqlConnection(connstring))
            {
                conn.Open();

                string selectQuery = "use FinalHospital; SELECT ClinicalDiagnosis, History, Symptoms FROM Diagnosis WHERE PatientID = @ID;";

                using (SqlCommand cmd = new SqlCommand(selectQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@ID", patientID);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            clinicalDiagnosis = reader.GetString(reader.GetOrdinal("ClinicalDiagnosis"));
                            symptoms = reader.GetString(reader.GetOrdinal("Symptoms"));
                            history = reader.GetString(reader.GetOrdinal("History"));
                        }
                    }
                }
            }

            return (clinicalDiagnosis, symptoms, history);
        }


        //Adding the prescription form details
        public static bool addPrescription(int patientId, int doctorId, string medication, string dosage, string frequency)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connstring))
                {
                    connection.Open();
                    string query = "USE FinalHospital; INSERT INTO Prescription (DoctorID, PatientID, Medication, Dosage, Frequency, PrescriptionDate) " +
                        "VALUES(@doctorId, @patientId, @medication, @dosage, @frequency, @currentDate)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@patientId", patientId);
                        command.Parameters.AddWithValue("@doctorId", doctorId);
                        command.Parameters.AddWithValue("@medication", medication);
                        command.Parameters.AddWithValue("@dosage", dosage);
                        command.Parameters.AddWithValue("@frequency", frequency);
                        command.Parameters.AddWithValue("@currentDate", DateTime.Now.ToString("MM/dd/yyyy"));
                        command.ExecuteNonQuery();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
                return false;
            }
        }


        //BG ADDED

        //Recording test results entered by lab technician
        //First retrieving patientId for use in labtechresult and labtech (enter test results function

        public static int retrievePatientId (int requestId)
        {
            int patientid = 0;
            using (SqlConnection conn = new SqlConnection(connstring))
            {
                conn.Open();
                string query = "USE FinalHospital; SELECT PatientId FROM TestRequest WHERE RequestId = @requestid";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@requestid", requestId);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                patientid = reader.GetInt32(0);
                            }
                        }
                    }
                }
            }
            return patientid;
        }


        //Then actually insert the test results into the database
        public static bool enterTestResults(int patientId, int requestId, int labtechId, string testresult)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connstring))
                {
                    conn.Open();
                    string query = "USE FinalHospital; INSERT INTO TestResult (PatientID, RequestID, LabTechId, TestResult) VALUES (@patientid, @requestid, @labtechid, @testresult)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@patientid", patientId);
                        cmd.Parameters.AddWithValue("@requestid", requestId);
                        cmd.Parameters.AddWithValue("@labtechid", labtechId);
                        cmd.Parameters.AddWithValue("@testresult", testresult);
                        cmd.ExecuteNonQuery();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
                return false;
            }
        }



        //Adding the definitive diagnosis
        public static bool addDefinitive(int patientId, string definitive)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connstring))
                {
                    connection.Open();
                    string updateQuery = "USE FinalHospital UPDATE Diagnosis SET DefinitiveDiagnosis = @definitiveDiagnosis WHERE PatientId = @patientId;";

                    using (SqlCommand command = new SqlCommand(updateQuery, connection))
                    {
                        command.Parameters.AddWithValue("@definitiveDiagnosis", definitive);
                        command.Parameters.AddWithValue("@patientId", patientId);

                        command.ExecuteNonQuery();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
                return false;
            }
        }


        //BG ADDED END


        //BG ADDED AGAIN
        //Getting the data for the list of requested tests
        public static DataTable listOfRequestedTests()
        {
            DataTable requestedTests = new DataTable();
            using (SqlConnection conn = new SqlConnection(connstring))
            {
                conn.Open();

                string query = "USE FinalHospital; SELECT t.requestid, p.name, p.gender, u.name AS doctor_name, l.testname FROM testRequest t JOIN users u ON t.doctorid = u.userid JOIN patient p ON t.patientid = p.patientid JOIN labtest l ON t.labtestid = l.testid";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd.CommandText, conn))
                    {
                        da.Fill(requestedTests);

                    }
                }
            }
            return requestedTests;
        }

        //Sish added
        public static string retrieveTestResult(int patientID)
        {
            string testResult = "";
            using (SqlConnection conn = new SqlConnection (connstring))
            {
                conn.Open();

                string query = "USE FinalHospital; SELECT TestResult FROM TestResult WHERE PatientID = @patientID";
                using (SqlCommand cmd = new SqlCommand (query, conn))
                {
                    cmd.Parameters.AddWithValue("@patientID", patientID);

                    testResult = cmd.ExecuteReader().ToString();
                }
            }
            return testResult;
        }

        // The list of Reviewed Patients
        public static DataTable listOfReviewedPatient()
    {
        DataTable dt = new DataTable();

        using (SqlConnection conn = new SqlConnection(connstring))
        {
            conn.Open();

            string query = "use FinalHospital; select PatientID, Name, Age, Gender from Patient Where Reviewed = 1 AND (IsTreated = 0 OR IsTreated IS NULL) order by PatientID desc;";

            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    dt.Load(dr);
                }
            }
                
            conn.Close();
        }

        return dt;
    }


        // To get the ID of the lab technician
        public static int GetLabTechID(int userID)
        {
            string fetchNameQuery = "USE FinalHospital; SELECT Name FROM Users WHERE UserID = @userID";
            string fetchIDQuery = "USE FinalHospital; SELECT LabTechID FROM LabTechnician WHERE Name = @name";
            int labTechID = 0;
            string name = "";

            using (SqlConnection conn = new SqlConnection(connstring))
            {
                using (SqlCommand cmd = new SqlCommand(fetchNameQuery, conn))
                {
                    conn.Open();

                    cmd.Parameters.AddWithValue("@userID", userID);

                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        name = reader.GetString(0);
                    }

                    conn.Close();
                }

                using (SqlCommand cmd = new SqlCommand(fetchIDQuery, conn))
                {
                    conn.Open();

                    cmd.Parameters.AddWithValue("@name", name);

                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        labTechID = reader.GetInt32(0);
                    }

                    conn.Close();
                }
            }

            return labTechID;
        }


        // Entering the lab request from the doctor
        public static void EnterLabRequest(int doctorId, int labTestId, int patientId)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connstring))
                {
                    connection.Open();

                    string insertQuery = "USE FinalHospital; INSERT INTO TestRequest(DoctorID, LabTestID, PatientID) VALUES (@DoctorID, @LabTestID, @PatientID)";
                    using (SqlCommand insertCommand = new SqlCommand(insertQuery, connection))
                    {
                        insertCommand.Parameters.AddWithValue("@DoctorID", doctorId);
                        insertCommand.Parameters.AddWithValue("@LabTestID", labTestId);
                        insertCommand.Parameters.AddWithValue("@PatientID", patientId);

                        insertCommand.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        //Retrieving financial information
        public static (int labRevenue, int admissionRevenue) getFinancialInfo()
        {
            int labRevenue = 0;
            int admissionRevenue = 0;

            string query = "SELECT (SELECT SUM(lt.TestCost) FROM TestRequest tr JOIN LabTest lt ON tr.[Lab TestID] = lt.TestID) AS TotalLabTestRevenue, (SELECT COUNT(*) * 500 FROM Admission) AS TotalAdmissionRevenue";

            try
            {
                using (SqlConnection conn = new SqlConnection(connstring))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                labRevenue = reader.GetInt32(0);
                                admissionRevenue = reader.GetInt32(1);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("Apologies, the financial information for today is not available");
            }

            return (labRevenue, admissionRevenue);
        }


        // Retrieving the prescription for the Pharmacist
        public static DataTable GetPrescriptionData()
        {
            string query = "USE FinalHospital; SELECT pa.Name, p.Medication, p.Dosage, p.Frequency FROM Prescription p INNER JOIN Patient pa ON p.PatientID = pa.PatientID;";

            try
            {
                using (SqlConnection connection = new SqlConnection(connstring))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);
                            return dataTable;
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error: " + ex.Message);
                return null;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return null;
            }
        }

    }
}

