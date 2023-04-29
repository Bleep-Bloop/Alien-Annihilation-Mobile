using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BaseCharacter))]
public class CharacterController : MonoBehaviour
{
    [Header("Components")]
    [SerializeField] private FloatingJoystick variableJoystick; // ToDo: Maybe grab from scene
    private Rigidbody2D rb2D; 
    private BaseCharacter parentCharacter;

    [Header("Runtime")]
    private Vector3 MovementVector = new();

    private void Awake()
    {
        parentCharacter = GetComponent<BaseCharacter>();
        rb2D = GetComponent<Rigidbody2D>();
    }

    // Start is called before the first frame update
    void Start()
    {
    }


    void Update()
    {
        Move();
    }

    void Move()
    {
        MovementVector.x = variableJoystick.Horizontal * parentCharacter.GetMovementSpeed();
        MovementVector.y = variableJoystick.Vertical * parentCharacter.GetMovementSpeed();
        rb2D.velocity = MovementVector;
    }

}
