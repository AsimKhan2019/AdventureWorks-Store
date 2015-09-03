using System;

namespace AdvWrks.DataModel
{
    public class EmployeeDepartmentData
    {
        public int Id { get; set; }
        public short DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public byte ShiftId { get; set; }
        public string ShiftName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
    }
}
