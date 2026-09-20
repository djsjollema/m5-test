using Unity.VisualScripting;
using UnityEngine;

public class Les3 : MonoBehaviour
{
    [SerializeField] GVector SupportVector;
    [SerializeField] GVector DirectionVector;
    [SerializeField] DraggablePoint A;
    [SerializeField] DraggablePoint B;

    [SerializeField] LineRenderer lr;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        SupportVector.transform.position = Vector3.zero;
        SupportVector.vector = new Vector3(A.transform.localPosition.x, A.transform.localPosition.y, 0 );

        DirectionVector.transform.position = new Vector3(A.transform.localPosition.x, A.transform.localPosition.y, 0);
        DirectionVector.vector = B.transform.localPosition - A.transform.localPosition;
        DirectionVector.vector = DirectionVector.vector.normalized;

        lr.SetPosition(0, SupportVector.vector  + DirectionVector.vector * 20);
        lr.SetPosition(1, SupportVector.vector + DirectionVector.vector * -20);
    }
}
