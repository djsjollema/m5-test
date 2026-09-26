using UnityEngine;

public class Les4 : MonoBehaviour
{
    [SerializeField] Transform Ball;
    [SerializeField] GVector VelocityVector;
    Matrix2x2 M, N;
    Matrix2x2 demoMatrix;

    Vector3 Velocity = new Vector3(1, 2, 0);
    Vector2 minPos, maxPos;

    Vector3 v = new Vector3(1, 0, 0);
    Vector3 u = new Vector3(0, 1, 0);

    void Start()
    {
        minPos = Camera.main.ScreenToWorldPoint(new Vector3(0, 0, 0));
        maxPos = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, 0));

        M = new Matrix2x2(
             1, 0,
             0, -1
            );
        N = new Matrix2x2(
             -1, 0,
             0, 1
            );

        demoMatrix = new Matrix2x2(
             1, 2,
             3, 4
            );

        Debug.Log(demoMatrix.Matrix[0, 0]);
        Debug.Log(demoMatrix.Matrix[0, 1]);
        Debug.Log(demoMatrix.Matrix[1, 0]);
        Debug.Log(demoMatrix.Matrix[1, 1]);

        Debug.Log(demoMatrix.Determinant().ToString());

        v = demoMatrix.Multiply(v);
        u = demoMatrix.Multiply(u);

        Debug.Log(v.ToString());
        Debug.Log(u.ToString());
    }

    void Update()
    {
        VelocityVector.vector = Velocity;
        VelocityVector.transform.position = Ball.position;
        Ball.position += Velocity * Time.deltaTime;

        if (Ball.position.y < minPos.y + 0.5f || Ball.position.y > maxPos.y - 0.5f)
        {
            Velocity = M.Multiply(Velocity);
        }

        if (Ball.position.x < minPos.x + 0.5f || Ball.position.x > maxPos.x - 0.5f)
        {
            Velocity = N.Multiply(Velocity);
        }
    }
}
