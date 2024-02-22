using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Cannon : MonoBehaviour
{
    Camera cam;
    Rigidbody2D rb;

    [SerializeField] HingeJoint2D[] wheels;
    JointMotor2D motor;

    [SerializeField] float CannonSpeed;
      bool isMoving = false;

    Vector2 pos;
    float screenBounds;
    float velocityX;


    private void OnEnable()
    {
        Meteor.OnGameOver += DisableCanonMovement;
    }

    private void OnDisable()
    {
        Meteor.OnGameOver -= DisableCanonMovement;
    }

    void Start()
    {

       // EnableCanonMovement();
        cam = Camera.main;

        rb = GetComponent<Rigidbody2D>();
        pos = rb.position;

        motor = wheels[0].motor;

        screenBounds = Game.Instance.screenWidth - 0.56f;
    }

    void Update()
    {
        //Check player input ( hand or mouse drag)
        isMoving = Input.GetMouseButton(0);

        if (isMoving)
        {
            pos.x = cam.ScreenToWorldPoint(Input.mousePosition).x;
        }
    }

    void FixedUpdate()
    {
        //Move the cannon
        if (isMoving)
        {
            rb.MovePosition(Vector2.Lerp(rb.position, pos, CannonSpeed * Time.fixedDeltaTime));
            velocityX = pos.x - rb.position.x;
        }
        else
        {
            rb.velocity = Vector2.zero;
            velocityX = 0f;
        }

        //Rotate wheels
        //velocityX = rb.GetPointVelocity(rb.position).x;
        if (Mathf.Abs(velocityX) > 0.0f && Mathf.Abs(rb.position.x) < screenBounds)
        {
            motor.motorSpeed = velocityX * 1000f;
            MotorActivate(true);
        }
        else
        {
            motor.motorSpeed = 0f;
            MotorActivate(false);
        }
    }

    void MotorActivate(bool isActive)
    {
        wheels[0].useMotor = isActive;
        wheels[1].useMotor = isActive;

        wheels[0].motor = motor;
        wheels[1].motor = motor;
    }


    public void DisableCanonMovement() {

        //MotorActivate(true);
        rb.bodyType = RigidbodyType2D.Static;
        gameObject.SetActive(false);
    }
    
    public void EnableCanonMovement() {

        /*MotorActivate(false);*/
        rb.bodyType = RigidbodyType2D.Dynamic;
        gameObject.SetActive(false);

    }
}
