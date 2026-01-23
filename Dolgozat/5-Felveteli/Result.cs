namespace EntranceExam
{
    internal class Result
    {
        public int StudentID { get; }
        public int TaskID { get; }
        public int Point { get; }

        public Result(int studentID, int taskID, int point)
        {
            StudentID = studentID;
            TaskID = taskID;
            Point = point;
        }

        public override string ToString()
        {
            return $"StudentID: {StudentID}, TaskID: {TaskID}, Pont: {Point}";
        }
    }
}
