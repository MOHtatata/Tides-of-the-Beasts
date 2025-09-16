//using Newtonsoft.Json.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Ship : IntEventInvoker
{
    public float acceleration = 0.4f;  // Speed up rate
    public float maxSpeed = 2f;      // Max forward speed
    public float rotationSpeed = 10f; // Turning speed
    public float drag = 0.98f;       // Slowdown factor when no input

    private float _currentSpeed = 0f; // Track current movement speed

    public GameObject prefabCannonball;
    public Transform leftCannon;  // Assign in Inspector
    public Transform rightCannon; // Assign in Inspector
    public float cannonForce = 15f;
    public float recoilForce = 1f;
    public float fireCooldown = 0.5f;
    private float lastFireTime;
    public Timer timerLeft;
    public Timer timerRight;

    private bool _controlsEnabled = true;

    private Animator _anim;

    public int health = 100;
    private int _endGame = 0;

    public Joystick joystick;

    public void Start()
    {
        timerLeft = gameObject.AddComponent<Timer>();
        timerLeft.Duration = fireCooldown;
        timerLeft.Run();
        timerRight = gameObject.AddComponent<Timer>();
        timerRight.Duration = fireCooldown;
        timerRight.Run();

        GameObject obj = GameObject.FindGameObjectWithTag("Joystick");
        joystick = obj.GetComponent<Joystick>();
        _anim= GetComponent<Animator>();

        EventManager.AddListener(EventName.MobileInputEvent, CannonFireMobileInput);

        unityEvents.Add(EventName.HealthChangedEvent, new HealthChangedEvent());
        EventManager.AddInvoker(EventName.HealthChangedEvent, this);

        unityEvents.Add(EventName.EndGameEvent, new EndGameEvent());
        EventManager.AddInvoker(EventName.EndGameEvent, this);

        unityEvents[EventName.HealthChangedEvent].Invoke(health);
    }

    public void Update()
    {
        if(!_controlsEnabled) return;

        //Mobile Input
        HandleMobileMovement();

        //PC Input For Cannons
        //HandleMovement();
        //CannonFire();
    }
    public void SetControl(bool state)
    {
        _controlsEnabled = state;
    }
    public void CannonFire()
    {
        if (timerLeft.Finished)
        {
            if (Input.GetKeyDown(KeyCode.Q))
            {
                FireCannon(leftCannon, -transform.right);
            }
        }
        if (timerRight.Finished)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                FireCannonRight(rightCannon, transform.right);
            }
        }
    }
    //Mobile Input For Cannons
    public void CannonFireMobileInput(int value)
    {
        if(value == 0)
        {
            if (timerLeft.Finished)
            {
                FireCannon(leftCannon, -transform.right);
            }
        }
        else
        {
            if (timerRight.Finished)
            {
                FireCannonRight(rightCannon, transform.right);
            }
        }
    }
    public void FireCannon(Transform cannon, Vector3 direction)
    {
        AudioManager.Play(AudioClipName.CannonFire);
        GameObject cannonball = Instantiate(prefabCannonball,cannon.position,Quaternion.identity);

        Vector2 combinedForce = (transform.up * _currentSpeed * 0.5f) + (direction * cannonForce);
        cannonball.GetComponent<Rigidbody2D>().AddForce(combinedForce, ForceMode2D.Impulse);

        timerLeft.Run();
    }
    public void FireCannonRight(Transform cannon, Vector3 direction)
    {
        AudioManager.Play(AudioClipName.CannonFire);
        GameObject cannonball = Instantiate(prefabCannonball, cannon.position, Quaternion.identity);

        Vector2 combinedForce = (transform.up * _currentSpeed * 0.5f) + (direction * cannonForce);
        cannonball.GetComponent<Rigidbody2D>().AddForce(combinedForce, ForceMode2D.Impulse);

        timerRight.Run();
    }
    public void HandleMovement()
    {
        Vector3 _currentVelocity = transform.position;

        float moveInput = Input.GetAxis("Vertical");
        float turnInput = Input.GetAxis("Horizontal");

        // Acceleration/deceleration
        if (Mathf.Abs(moveInput) > 0.1f)
        {
            _currentSpeed += moveInput * acceleration * Time.deltaTime;
            _currentSpeed = Mathf.Clamp(_currentSpeed, -maxSpeed * 0.5f, maxSpeed); // Allow reverse
        }
        else
        {
            // Apply drag (gradual slowdown)
            _currentSpeed = Mathf.Lerp(_currentSpeed, 0f, drag * Time.deltaTime);
        }

        // Rotation (works even when not moving)
        if (Mathf.Abs(turnInput) > 0.1f)
        {
            float turnDirection = Mathf.Sign(_currentSpeed) * turnInput; // Reverse turn when moving backward
            transform.Rotate(Vector3.forward * -turnDirection * rotationSpeed * Time.deltaTime);
        }
        _currentVelocity = transform.up * _currentSpeed;

        transform.position += _currentVelocity * Time.deltaTime;
    }
    public void HandleMobileMovement()
    {
        Vector3 _currentVelocity = transform.position;

        float moveInput = joystick.Vertical;
        float turnInput = joystick.Horizontal;

        // Acceleration/deceleration
        if (Mathf.Abs(moveInput) > 0.1f)
        {
            _currentSpeed += moveInput * acceleration * Time.deltaTime;
            _currentSpeed = Mathf.Clamp(_currentSpeed, -maxSpeed * 0.5f, maxSpeed); // Allow reverse
        }
        else
        {
            // Apply drag (gradual slowdown)
            _currentSpeed = Mathf.Lerp(_currentSpeed, 0f, drag * Time.deltaTime);
        }

        // Rotation (works even when not moving)
        if (Mathf.Abs(turnInput) > 0.1f)
        {
            float turnDirection = Mathf.Sign(_currentSpeed) * turnInput; // Reverse turn when moving backward
            transform.Rotate(Vector3.forward * -turnDirection * rotationSpeed * Time.deltaTime);
        }
        _currentVelocity = transform.up * _currentSpeed;

        transform.position += _currentVelocity * Time.deltaTime;
    }
    public void TakeDamage(int damage)
    {
        AudioManager.Play(AudioClipName.ShipDamagedSound);
        _anim.SetTrigger("isDamage");
        health = Mathf.Max(0, health - damage);
        unityEvents[EventName.HealthChangedEvent].Invoke(health);

        if (health <= 0)
        {
            Die();
        }
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("EnemyCannonball"))
        {
            TakeDamage(10);
            Destroy(collision.gameObject);
        }
        if(collision.gameObject.CompareTag("Enemy"))
        {
            TakeDamage(10);
        }
    }
    void Die()
    {
        Debug.Log("Player destroyed!");
        unityEvents[EventName.EndGameEvent].Invoke(_endGame);
    }
}
