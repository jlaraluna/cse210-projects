class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus, int amountCompleted = 0)
        : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = amountCompleted;
    }

    public override int RecordEvent()
    {
        if (_amountCompleted < _target)
        {
            _amountCompleted++;
            if (_amountCompleted == _target)
            {
                return _points + _bonus;
            }
            return _points;
        }
        return 0;
    }

    public override bool IsComplete() => _amountCompleted >= _target;

    public override string GetDetailsString() =>
        $"{base.GetDetailsString()} -- Completed {_amountCompleted}/{_target} times";

    public override string GetStringRepresentation() =>
        $"ChecklistGoal:{_shortName},{_description},{_points},{_amountCompleted},{_target},{_bonus}";
}
