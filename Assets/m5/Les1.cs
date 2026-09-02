using UnityEngine;

public class Les1 : MonoBehaviour
{
    Matrix2x2 M;

    Vector3 v = new Vector3(1, 0, 0);
    Vector3 u = new Vector3(0, 1, 0);

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        M = new Matrix2x2(
             1, 2,
             3, 4
            );

        Debug.Log(M.Matrix[0, 0]);
        Debug.Log(M.Matrix[0, 1]);
        Debug.Log(M.Matrix[1, 0]);
        Debug.Log(M.Matrix[1, 1]);

        Debug.Log(M.Determinant().ToString());

        v= M.Multiply(v);
        u= M.Multiply(u);   

        Debug.Log(v.ToString());
        Debug.Log(u.ToString());
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
