namespace HIMS.Visitor
{
    internal class PatientSelectedEventArgs
    {
        private int patientID;
        private string firstName;
        private string lastName;

        public PatientSelectedEventArgs(int patientID, string firstName, string lastName)
        {
            this.patientID = patientID;
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public object FirstName { get; internal set; }
        public object LastName { get; internal set; }
        public object PatientID { get; internal set; }
    }
}