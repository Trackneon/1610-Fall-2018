using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu]
public class AddValue : ScriptableObject {

    public FloatData ValueObj;

    public FloatData MinValue;
    public FloatData MaxValue;

    public UnityEvent EventMin;
    public UnityEvent EventMax;

    public void AddValueToObj (FloatData data)
    {
        ValueObj.Value += data.Value;

        if(ValueObj.Value <= MinValue.Value)
        {
            EventMin.Invoke();
        }
        if(ValueObj.Value >= MaxValue.Value)
        {
            EventMax.Invoke();
        }
    }

}
