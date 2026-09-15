using UnityEngine;

public class Triangle : MonoBehaviour
{
    [SerializeField] Transform pointA;
    [SerializeField] Transform pointB;
    [SerializeField] Transform pointC;

    [SerializeField] LineRenderer lr;

    void Start()
    {
        
    }

    void Update()
    {
        lr.SetPosition(0, pointA.localPosition);
        lr.SetPosition(1, pointB.localPosition);
        lr.SetPosition(2, pointC.localPosition);

    }
}
