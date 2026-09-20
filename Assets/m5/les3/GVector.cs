using Unity.VisualScripting;
using UnityEngine;

public class GVector : MonoBehaviour
{
    public Vector3 vector = new Vector3(3,2,0) ;
    [SerializeField] Transform Head;
    [SerializeField] LineRenderer lr;
    void Start()
    {
        
    }

    void Update()
    {
        Head.transform.localPosition = new Vector3(vector.magnitude, 0, 0);
        lr.SetPosition(1, new Vector3(vector.magnitude, 0, 0));

        transform.rotation = Quaternion.Euler(0,0,Mathf.Atan2(vector.y, vector.x) * Mathf.Rad2Deg);
    }
}
