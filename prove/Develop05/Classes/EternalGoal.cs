namespace Develop05.Classes
{
    public class EternalGoal : Goal
    {
        // Constructor
        public EternalGoal(string name, string desc, int points)
            : base(name, desc, points) { }

        // Getters
        public override int GetPoints()
        {
            int result = 0;
            if (IsComplete())
            {
                result = _points;
            }
            return result;
        }

        // Methods
        public override void RecordProgress()
        {
            _earned += GetPoints();
            _complete = false;
        }

        public override string ToString()
        {
            return $"The simple goal is complete: {_complete}";
        }
    }
}
