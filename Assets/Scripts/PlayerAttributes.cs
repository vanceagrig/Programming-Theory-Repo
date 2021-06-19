using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerAttributes : MonoBehaviour
{
    public float lifePoints = 200;
    public Text lifePointsText;
    
    public float damage;
    public Text damagePointsText;

    public float mana;
    public Text manaPointsText;

    public Text generalInfoText;

    public float jumpForce;
    protected bool isGrounded;
    protected Rigidbody rb;
    protected Vector3 jump;

    private void Update()
    {
        PlayerJump();
    }


    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        jump = new Vector3(0.0f, 2.0f, 0.0f);
        manaPointsText.text = mana.ToString();
        lifePointsText.text = lifePoints.ToString();
        damagePointsText.text = damage.ToString();
    }


    public void PlayerJump()
    {
        if (Input.GetKeyDown(KeyCode.Mouse1)&& isGrounded==true)
        {
            rb.AddForce(jump * jumpForce, ForceMode.Impulse);
            isGrounded = false;
        }
    }
    void OnCollisionStay()
    {
        isGrounded = true;
    }
}
