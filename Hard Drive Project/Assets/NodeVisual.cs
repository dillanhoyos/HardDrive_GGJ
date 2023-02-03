using UnityEngine;

public class NodeVisual : MonoBehaviour
{
    public int value;

    public void SetValue(int value)
    {
        this.value = value;
        GetComponentInChildren<TextMesh>().text = value.ToString();
    }
}
