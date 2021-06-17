using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animals : MonoBehaviour
{
    public PlayerAttributes playerStats;
    public float lifePoints=200;
    public int speed;
    public Vector3 jump;
    public float jumpForce = 2.0f;
    public bool isGrounded;
    public Rigidbody rb;


    void Start()
    {
        rb = GetComponent<Rigidbody>();
        jump = new Vector3(0.0f, 2.0f, 0.0f);
    }
    void OnCollisionStay()
    {
        isGrounded = true;
    }
    public virtual void SetLifePoints()
    {
        lifePoints = 200;
    }
    public virtual void TakeDamage()
    {
        lifePoints -=10;
    }
    public virtual void InflictDamage()
    {
        playerStats.lifePoints -= 10;
    }
    public virtual void Jump()
    {
        rb.AddForce(jump * jumpForce, ForceMode.Impulse);
        isGrounded = false;
    }
}
