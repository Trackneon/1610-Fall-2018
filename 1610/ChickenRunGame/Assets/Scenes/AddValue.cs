using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu]
public class AddValue : ScriptableObject {

    public FloatData ValueObj;

    public void AddValueToObj (FloatData data)
    {
        ValueObj.Value += data.Value;

    }

}
