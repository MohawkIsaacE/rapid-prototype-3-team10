using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public Camera Cam;
    public Rigidbody CueBallrb;
    public float HitForceKPH = 1;
    public bool DoCueBallHit;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            DoCueBallHit = true;
        }
    }

    private void FixedUpdate()
    {
        if (!DoCueBallHit)
            return;
        DoCueBallHit = false;

        //Vector3 hitDirection = CueBallrb.transform.forward;
        Vector3 hitDirection = Cam.transform.forward;
        Vector3 force = HitForceKPH * CueBallrb.mass * hitDirection;
        CueBallrb.AddForce(force, ForceMode.Impulse);

        //Vector3 kickSpinDirection = CueBallrb.transform.up;
        //Vector3 torque = kickSpinDirection * KickSpinForce;
        //CueBallrb.AddTorque(torque, ForceMode.Impulse);
    }
}
