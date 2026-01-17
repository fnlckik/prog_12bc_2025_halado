namespace SportsCompetition
{
    class Result
    {
        public int ID { get; }
        public int StudentID { get; }
        public int EventID { get; }
        public int Score { get; }

        public Result(int id, int studentID, int eventID, int score)
        {
            ID = id;
            StudentID = studentID;
            EventID = eventID;
            Score = score;
        }

        public override string ToString() => $"StudentId: {StudentID}, EventId: {EventID}, Score: {Score}";
    }
}
