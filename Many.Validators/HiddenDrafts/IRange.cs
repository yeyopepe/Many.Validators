namespace Many.Validators.HiddenDrafts
{
    //TODO: Unfinished
    internal enum RangeCondition
    {
        Inclusive,
        Exclusive
    }
    internal interface IRange<V>
    {
        (RangeCondition,V) Min { get; }
        (RangeCondition, V) Max { get; }
        
        bool Validate(V value);
    }
}
