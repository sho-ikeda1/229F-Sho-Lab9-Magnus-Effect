using UnityEngine;

public class Magnus_Effect : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField] Vector3 velocity, spin;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.K))
        {
            //kick
            Kick();
        }
        //appply magnus eff.
        ApplyMagnusEffect();
    }
    void Kick()
    {
        //แรงตรง
        rb.linearVelocity = velocity;
        //แรงหมุน
        rb.angularVelocity = spin;
    }
    void ApplyMagnusEffect() 
    {
        Vector3 magnusForce = Vector3.Cross(rb.linearVelocity,rb.angularVelocity);

        rb.AddForce(magnusForce);
    }

}
